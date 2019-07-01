import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { PortalConfig } from '../constants/config/app.config';

@Injectable({
 providedIn: 'root'
})
export class ApiCallService {

  constructor(
    private httpClient: HttpClient,
  ) {}

  getValue(url: string, data: any): any {
    return this.httpClient.get(url, data);
  }
  postValue(url: string, data: any): any {
    return this.httpClient.post(url, data);
  }
}
