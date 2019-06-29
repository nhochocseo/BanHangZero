import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class StateManageService {

  public stateEvent: Subject<any> = new Subject<any>();

  private countWait = 0;

  get isLoading() {
    return this.countWait > 0;
  }

  constructor() { }

  setLoading(loading: boolean) {
    if (loading) {
      // if (this.countWait < 1) {
        ++this.countWait;
      // }
    } else {
      // if (this.countWait > 0) {
        --this.countWait;
      // }
    }
  }
}

export interface IStateEvent<T = any> {
  type: StateType;
  data: T;
}

export enum StateType {
  diaChiOptionSubject = 1,
  notiDiaChiOption
}
