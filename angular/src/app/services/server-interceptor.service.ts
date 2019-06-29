import { HttpErrorResponse, HttpEvent, HttpHandler, HttpInterceptor, HttpRequest, HttpResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { LoadingBarService } from '@ngx-loading-bar/core';
import { ToastrService } from 'ngx-toastr';
import { finalize, tap, mergeMap, switchMap } from 'rxjs/operators';
import { Observable } from 'rxjs';
import { StateManageService } from '../share/data/state-manage.service';
import { DataService } from '../share/data/data.service';
import { AuthService } from '../share/auth/auth.service';

@Injectable({
  providedIn: 'root'
})
export class ServerInterceptorService implements HttpInterceptor {

  constructor(
    private loader: LoadingBarService,
    private router: Router,
    private dataService: DataService,
    private authService: AuthService,
    private toastr: ToastrService,
    private state: StateManageService
  ) { }

  intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    console.log(req);
    if (req.headers.has('not_auth_token')) {
      const newReq = req.clone({ headers: req.headers.delete('not_auth_token') });
      const handleRequest = next.handle(newReq);
      return this.handleCommonRequest(handleRequest, newReq);
    }

    return this.authService.getTokenByAuth()
      .pipe(switchMap((res: any) => {
        console.log(res);
        let newReq = req;
        if (req.headers.has('ignoreLoadingBar')) {
          newReq = req.clone({ headers: req.headers.delete('ignoreLoadingBar') });
        }
        const handleRequest = next.handle(newReq.clone({
          setHeaders: {
            Authorization: `Bearer ${res.access_token}`,
            // is_public: res.public ? res.public : false
          }
        }));

        return this.handleCommonRequest(handleRequest, req);
      }));
  }

  private handleCommonRequest(handleRequest: Observable<HttpEvent<any>>, req: HttpRequest<any>) {
    console.log("test");
    const responseSubscribe = handleRequest.subscribe.bind(handleRequest);
    handleRequest.subscribe = (...args) => {
      if (!req.headers.has('ignoreLoadingBar')) {
        this.state.setLoading(true);
        this.loader.start();
      }
      return responseSubscribe(...args);
    };
    return handleRequest.pipe(tap(evt => {
      if (evt instanceof HttpResponse) {
        this.handelOkResponses();
      }
    }, err => {
      this.handelFailResponses(err);
    }), finalize(() => {
      if (!req.headers.has('ignoreLoadingBar')) {
        this.state.setLoading(false);
        this.loader.complete();
      }
    }));
  }

  private handelOkResponses() {
    this.dataService.ErrorMsgFailRequest = null;

  }

  private handelFailResponses(response: HttpErrorResponse) {
    let msg = this.dataService.ErrorMsgFailRequest;
    this.dataService.ErrorMsgFailRequest = null;
console.log(response);
    if (response.status == 401) {
      let returnUrl = this.router.url;
      let queryData = '';
      if (returnUrl.indexOf('?') > -1) {
        // url chứa query params
        queryData = returnUrl.substring(returnUrl.length, returnUrl.indexOf('?'));
        returnUrl = returnUrl.substring(0, returnUrl.indexOf('?'));
      }
      // console.log('returnUrl', returnUrl);
      // console.log('queryUrl', queryData);
      this.authService.removeAccount();
      this.router.navigate(['/index'], { queryParams: { login: '1', url: returnUrl, queryUrl: queryData } });
    } else if (response.status == 400 && response.error == 'Mã kiểm tra không chính xác') {
      this.toastr.error(response.error, 'Có lỗi xảy ra');
    } else {
      try {
        if (response.error.error_description) {
          msg = response.error.error_description;
        }
      } catch (ex) {

      } finally {
        this.toastr.error(msg, 'Có lỗi xảy ra .');
      }
    }
  }
}
