import { Pipe, PipeTransform } from '@angular/core';

@Pipe({name: 'defaultThumbnail'})
export class DefaultThumbnail implements PipeTransform {
  constructor(
    // private helper: HelperService
  ) {}

  transform(value: any) {
    if (!value) {
      value = 'assets/images/post/default.png';
    }
    return value;
  }
}
