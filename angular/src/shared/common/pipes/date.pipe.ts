import { Pipe, PipeTransform } from '@angular/core';
import * as moment from 'moment';

@Pipe({name: 'datePipeFormat'})
export class DatePipeFormat implements PipeTransform {
  constructor(
  ) {}

  transform(value: any) {
    if (value) {
        value = moment(value).format('DD/MM/YYYY');
    }
    return value;
  }
}
