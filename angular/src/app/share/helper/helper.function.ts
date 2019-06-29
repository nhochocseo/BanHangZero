import { Injectable } from '@angular/core';
import { Title } from '@angular/platform-browser';
@Injectable({
  providedIn: 'root'
})
export class HelperFunction {

  constructor(
    private titleService: Title
  ) { }
  public setTitle( newTitle: string) {
    this.titleService.setTitle( newTitle );
  }
    change_alias(alias: any) {
        let str = alias;
        str = str.toLowerCase();
        str = str.replace(/à|á|ạ|ả|ã|â|ầ|ấ|ậ|ẩ|ẫ|ă|ằ|ắ|ặ|ẳ|ẵ/g, 'a');
        str = str.replace(/è|é|ẹ|ẻ|ẽ|ê|ề|ế|ệ|ể|ễ/g, 'e');
        str = str.replace(/ì|í|ị|ỉ|ĩ/g, 'i');
        str = str.replace(/ò|ó|ọ|ỏ|õ|ô|ồ|ố|ộ|ổ|ỗ|ơ|ờ|ớ|ợ|ở|ỡ/g, 'o');
        str = str.replace(/ù|ú|ụ|ủ|ũ|ư|ừ|ứ|ự|ử|ữ/g, 'u');
        str = str.replace(/ỳ|ý|ỵ|ỷ|ỹ/g, 'y');
        str = str.replace(/đ/g, 'd');
        str = str.replace(/!|@|%|\^|\*|\(|\)|\+|\=|\<|\>|\?|\/|,|\.|\:|\;|\'|\"|\&|\#|\[|\]|~|\$|_|`|-|{|}|\||\\/g, ' ');
        str = str.replace(/ + /g, ' ');
        str = str.replace(/-+-/g, '-');
        str = str.replace(/^\-+|\-+$/g, '');
        str = str.replace(/ /g, '-');
        str = str.trim();
        return str;
    }
  getIdUrl(url: any) {
      let str = url;
      str = str.match('_+[0-9]*$');
      if (str) {
        str = str[0].replace(/_/g, '');
      }
      return str;
  }
  ActiveMenu(url: any) {
    let str = url;
    str = str.split('/');
    return str;
}
}
