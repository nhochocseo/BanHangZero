import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { Observable, Subject, of } from 'rxjs';
import { map } from 'rxjs/operators';
import { PortalConfig } from '@app/constants/config/app.config';



@Injectable({
  providedIn: 'root'
})
export class AuthService {
  public token: string;
  public publicTokenKey = ':L$@:FKD:KFD:F<';
  public username: string;

  _currentDonVi: any;
  set currentDonVi(dv: any) {
    this._currentDonVi = dv;
    if (this._currentDonVi) {
      localStorage.setItem('currentMaDonVi', JSON.stringify(this._currentDonVi.Ma));
    }
    this.notifyDonViChange();
  }

  get currentDonVi() {
    return this._currentDonVi;
  }

  public eventChange: Subject<any> = new Subject();
  constructor(
    private http: HttpClient,
    private router: Router
  ) {
    const currentUser = JSON.parse(localStorage.getItem('currentUser'));
  }

  notifyDonViChange(): any {
    this.eventChange.next(this.currentDonVi);
  }

  public isAuthenticated(): boolean {
    if (!this.token) {
      return false;
    }
    // Check whether the current time is past the
    // access token's expiry time
    const expire_time = localStorage.getItem('expires_at');
    if (expire_time == null || expire_time === '') {
      return false;
    }
    const expiresAt = new Date(expire_time).getTime();

    return new Date().getTime() < expiresAt;
  }

  logout(): void {
    this.removeAccount();
    this.router.navigate(['/index']);
  }

  public admin() {
    return true;
  }
  removeAccount() {
    this.token = null;
    this.username = null;
    localStorage.clear();
  }

  login(username, password, loaidoituong, text, code): Observable<boolean> {
    const body = 'grant_type=password&username=' + encodeURIComponent(username) + '&password=' +
      encodeURIComponent(password) + '&loaidoituong=' + encodeURIComponent(loaidoituong) +
      '&text=' + encodeURIComponent(text) + '&code=' + encodeURIComponent(code);
    const options = {
      headers: new HttpHeaders({
        'Content-Type': 'application/x-www-form-urlencoded',
        'not_auth_token': 'false'
      })
    };
    return this.http.post(PortalConfig.GATEWAY_API + '/token', body, options)
      .pipe(map((result: any) => {
        const token = result.access_token;
        if (token) {
          this.token = token;
          localStorage.setItem('currentUser', JSON.stringify({ username: username, token: token }));
          this.username = username;
          return true;
        } else {
          return false;
        }
      }));
  }

  setPublicToken(token: any) {
    localStorage.setItem(this.publicTokenKey, token);
  }

  getPublicToken() {
    return localStorage.getItem(this.publicTokenKey);
  }

  getTokenByAuth() {
    if (this.token) {
      return of({
        access_token : this.token
      });
    }

    return this.getApiPublicWithToken().pipe(map((res: any) => {
      res.public = true;
      return res;
    }));
  }

  getApiPublicWithToken() {
    const username = '8Ud9u-_JzdxL34-Z';
    const password = 'J#dNeTvz5?-uxP9x';
    const body = 'grant_type=password&username=' + encodeURIComponent(username) + '&password=' +
      encodeURIComponent(password);
    const options = {
      headers: new HttpHeaders({
        'Content-Type': 'application/x-www-form-urlencoded',
        'is_public': 'true',
        'not_auth_token': 'false'
      })
    };
    return this.http.post(PortalConfig.GATEWAY_API + '/token', body, options);
  }
}
