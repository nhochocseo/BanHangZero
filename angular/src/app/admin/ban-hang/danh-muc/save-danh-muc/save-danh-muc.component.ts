import { Component, OnInit, Inject, EventEmitter } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';
import { FormsModule } from '@angular/forms';
import { DanhMucServiceProxy, DanhMuc, IDanhMucDto } from '@shared/service-proxies/service-proxies';
import { HelperFunction } from '@shared/helpers/helper.function';
import { NotifyService } from 'abp-ng2-module/dist/src/notify/notify.service';

@Component({
  selector: 'app-save-danh-muc',
  templateUrl: './save-danh-muc.component.html',
  styleUrls: ['./save-danh-muc.component.css']
})
export class SaveDanhMucComponent implements OnInit {
  DanhMucForm: FormGroup;
  DanhSachDanhMuc: any;
  data_event = new EventEmitter();
  idData: number;
  constructor(
    public dialogRef: MatDialogRef<SaveDanhMucComponent>,
    private fb: FormBuilder,
    private danhMucService: DanhMucServiceProxy,
    private helperFunction: HelperFunction,
    private notify: NotifyService,
    @Inject(MAT_DIALOG_DATA) public data: any
  ) { }

  ngOnInit() {
    this.DanhMucForm = this.fb.group({
      id: [0],
      name: ['', Validators.required],
      url: ['', Validators.required],
      parentId: [+'', Validators.required],
      created: [null]
    });;
    this.getDanhSachDanhMuc();
    console.log(this.data);
    this.setValueForm(this.data.value);
  }

  getDanhSachDanhMuc() {
    this.danhMucService.getDanhMuc('', '', 0, 100).pipe().subscribe(result => {
      if(result && result.items) {
        this.DanhSachDanhMuc = result.items;
        console.log(this.DanhSachDanhMuc);
      }
    });
  }

  getNameValueChange() {
    this.DanhMucForm.controls.url.setValue(this.helperFunction.change_alias(this.DanhMucForm.controls.name.value));
  }

  onSubmit() {
    this.DanhMucForm.controls.parentId.setValue(+this.DanhMucForm.controls.parentId.value);
    this.danhMucService.saveDanhMuc(this.DanhMucForm.value).subscribe(result => {
      if (result === 0) {
        this.notify.success('Thêm mới thành công', 'Thành công');
        this.data_event.emit();
        this.dialogRef.close();
      } else if (result === null) {
        this.notify.error('Có lỗi', 'Err');
      } else  {
        this.notify.success('Sửa thành công', 'Thành công');
        this.data_event.emit();
        this.dialogRef.close();
      }
    });
  }

  setValueForm(value: any) {
    if (value) {
      this.DanhMucForm.controls.parentId.setValue(+this.DanhMucForm.controls.parentId.value);
      this.DanhMucForm.setValue(value);
    }
  }
}
