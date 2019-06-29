import { Injectable } from '@angular/core';

@Injectable({  providedIn: 'root' })
export class SyncDataService {
  listRegister: Map<string, Array<any>> = new Map<string, Array<any>>();

  constructor(
  ) { }

  // Tạo 1 register event mới
  register(callback: any, key: string) {
    if (typeof callback != 'function') {
      return;
    }
    const ltR = [callback];
    if (this.listRegister.has(key)) {
      ltR.push(...this.listRegister.get(key));
    }
    this.listRegister.set(key, ltR);
  }

  // unregister khi onDestroy
  unRegister(key: string) {
    this.listRegister.delete(key);
  }

  // send data
   send(data: any, key: string) {
    this.listRegister.forEach((acallback, k) => {
      if (key !== k) {
        acallback.filter(vcallback => {
          vcallback(data);
        });
      }
    });
  }
}

// export interface RegisterSync {
//   key: string;
//   callback: any;
// }
