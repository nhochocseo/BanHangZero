import { Pipe, PipeTransform } from '@angular/core';

@Pipe({name: 'trangThaiTinTucPipe'})
export class TrangThaiTinTucPipe implements PipeTransform {
  constructor(
  ) {}

  transform(value: any) {
      switch (value) {
        case 0:
            value = 'Thêm mới';
            break;
        case 1:
            value = 'Xóa tạm';
            break;
        default:
            value = 'Chưa rõ';
            break;
      }
    return value;
  }
}
