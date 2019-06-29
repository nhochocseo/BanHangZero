import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { ApiPublicService } from '../api-public.service';


@Injectable({
  providedIn: 'root'
})
export class HomeService {
    private getListDanhMucCode = '001';
  constructor(
    private apiPublic: ApiPublicService
    ) {}

  getListDanhMuc(): Observable<any> {
    return this.apiPublic.getValuePublic(this.getListDanhMucCode, {});
  }
}
