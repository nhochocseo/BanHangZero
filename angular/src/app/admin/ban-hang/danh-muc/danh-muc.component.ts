import { Component, OnInit, ViewChild } from '@angular/core';
import { accountModuleAnimation } from '@shared/animations/routerTransition';
import { PermissionTreeComponent } from '@app/admin/shared/permission-tree.component';
import { RoleServiceProxy } from '@shared/service-proxies/service-proxies';

@Component({
  selector: 'app-danh-muc',
  templateUrl: './danh-muc.component.html',
  styleUrls: ['./danh-muc.component.css'],
  animations: [accountModuleAnimation()]
})
export class DanhMucComponent implements OnInit {
  @ViewChild('permissionTree') permissionTree: PermissionTreeComponent;
  constructor(
    private _roleService: RoleServiceProxy
  ) { }

  ngOnInit() {
    this.show();
  }
  show(roleId?: number): void {

    this._roleService.getRoleForEdit(roleId).subscribe(result => {
        let data = result.role;
        this.permissionTree.editData = result;
    });
}
}
