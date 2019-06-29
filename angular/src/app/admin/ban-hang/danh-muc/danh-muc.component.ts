import { Component, OnInit, ViewChild } from '@angular/core';
import { accountModuleAnimation } from '@shared/animations/routerTransition';
import { PermissionTreeComponent } from '@app/admin/shared/permission-tree.component';
import { RoleServiceProxy } from '@shared/service-proxies/service-proxies';
import { DanhMucService } from '@app/services/danhmuc/danhmuc.service';

@Component({
  selector: 'app-danh-muc',
  templateUrl: './danh-muc.component.html',
  styleUrls: ['./danh-muc.component.css'],
  animations: [accountModuleAnimation()]
})
export class DanhMucComponent implements OnInit {
  @ViewChild('permissionTree') permissionTree: PermissionTreeComponent;
  constructor(
    private _roleService: RoleServiceProxy,
    private danhMucService: DanhMucService
  ) { }

  ngOnInit() {
    this.show();
    this.getDanhSach();
  }
  show(roleId?: number): void {

    this._roleService.getRoleForEdit(roleId).subscribe(result => {
        let data = result.role;
        this.permissionTree.editData = result;
    });
  }
  getDanhSach() {
    this.danhMucService.getListDanhMuc().subscribe(res => {
      console.log(res);
    });
  }
}
