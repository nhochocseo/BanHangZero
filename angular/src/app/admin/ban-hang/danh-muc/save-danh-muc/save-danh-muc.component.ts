import { Component, OnInit, Inject } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';
import { FormsModule } from '@angular/forms';
import { DanhMucServiceProxy } from '@shared/service-proxies/service-proxies';

@Component({
  selector: 'app-save-danh-muc',
  templateUrl: './save-danh-muc.component.html',
  styleUrls: ['./save-danh-muc.component.css']
})
export class SaveDanhMucComponent implements OnInit {
  DanhMucForm: FormGroup;
  DanhSachDanhMuc: any;
  constructor(
    public dialogRef: MatDialogRef<SaveDanhMucComponent>,
    private fb: FormBuilder,
    private danhMucService: DanhMucServiceProxy,
  ) { }

  ngOnInit() {
    this.DanhMucForm = this.fb.group({
      id: [''],
      name: ['', Validators.required],
      url: ['', Validators.required],
      parentId: ['', Validators.required],
      created: ['']
    });
    this.getDanhSachDanhMuc();
  }
  getDanhSachDanhMuc() {
    this.danhMucService.getDanhMuc('', '', 0, 100).pipe().subscribe(result => {
      if(result && result.items) {
        this.DanhSachDanhMuc = result.items;
        console.log(this.DanhSachDanhMuc);
      }
    });
  }
  onSubmit() {
    console.log(this.DanhMucForm);
  }
}
