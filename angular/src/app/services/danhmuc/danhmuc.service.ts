import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { ApiPublicService } from '../api-public.service';


@Injectable({
  providedIn: 'root'
})
export class DanhMucService {
    private saveDanhMucCode = '/DanhMuc/GetList';
  constructor(
    private apiPublic: ApiPublicService
    ) {}

    getListDanhMuc(): Observable<any> {
    return this.apiPublic.getValuePublic(this.saveDanhMucCode, {});
  }
}
