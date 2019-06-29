import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class DataService {
  private _storage: any;

  private _bar = false;
  get storage(): any {
    return this._storage;
  }
  set storage(data: any) {
    this._storage = data;
  }

  ErrorMsgFailRequest: string;

  public tenThuTucActive: any;

  public danhsachTinhCache: any;

  constructor() { }

  getOldData(inputName: any) {
    if (!this.storage) {
      return null;
    }

    if (this.storage[inputName] == null) {
      return null;
    }

    return this.storage[inputName];
  }
}
