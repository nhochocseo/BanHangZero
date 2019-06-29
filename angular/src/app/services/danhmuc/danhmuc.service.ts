import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { ApiPublicService } from '../api-public.service';


@Injectable({
  providedIn: 'root'
})
export class DanhMucService {
    private saveDanhMucCode = '002';
  constructor(
    private apiPublic: ApiPublicService
    ) {}

    saveDanhMuc(): Observable<any> {
    return this.apiPublic.getValuePublic(this.saveDanhMucCode, {});
  }
}
