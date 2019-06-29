import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { PortalConfig } from '../constants/config/app.config';

@Injectable({
 providedIn: 'root'
})
export class ApiPublicService {

  private getValuePublicUrl = PortalConfig.GATEWAY_API + '/api/getValuePublic';

  constructor(
    private httpClient: HttpClient,
  ) {}

  getValuePublic(code: string, data: any): any {
    const body = {
        code: code,
        data: data,
    };
    return this.httpClient.post(this.getValuePublicUrl, body);
  }
}
