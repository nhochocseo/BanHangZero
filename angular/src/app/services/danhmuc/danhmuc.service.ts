import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { ApiCallService } from '../api-call.service';
import { PortalConfig } from '@app/constants/config/app.config';


@Injectable({
  providedIn: 'root'
})
export class DanhMucService {
  private getDanhMucUrl = PortalConfig.GATEWAY_API + '/DanhMuc/GetList';
  constructor(
    private apiPublic: ApiCallService
    ) {}
    getListDanhMuc(): Observable<any> {
      return this.apiPublic.getValue(this.getDanhMucUrl, {});
    }
}
