import { Component, OnInit, ViewChild } from '@angular/core';
import { accountModuleAnimation } from '@shared/animations/routerTransition';
import { PermissionTreeComponent } from '@app/admin/shared/permission-tree.component';
import { RoleServiceProxy, DanhMucServiceProxy } from '@shared/service-proxies/service-proxies';
import { DanhMucService } from '@app/services/danhmuc/danhmuc.service';
import { DanhmucTreeComponent } from '@app/admin/shared/ban-hang/danh-muc/danh-muc-tree.component';
import { Table } from 'primeng/table';
import { LazyLoadEvent } from 'primeng/api';
import { PrimengTableHelper } from '@shared/helpers/PrimengTableHelper';
import { Paginator } from 'primeng/primeng';
import { finalize } from 'rxjs/operators';

@Component({
  selector: 'app-danh-muc',
  templateUrl: './danh-muc.component.html',
  styleUrls: ['./danh-muc.component.css'],
  animations: [accountModuleAnimation()]
})
export class DanhMucComponent implements OnInit {
  // @ViewChild('danhMucTree') danhMucTree: DanhmucTreeComponent;
  // @ViewChild('permissionTree') permissionTree: PermissionTreeComponent;
  @ViewChild('dataTable') dataTable: Table;
  @ViewChild('paginator') paginator: Paginator;
  primengTableHelper: PrimengTableHelper;

  //Filters
  advancedFiltersAreShown = false;
  filterText = '';
  selectedPermission = '';
  role = '';
  onlyLockedUsers = false;
  //
  listDanhMuc: any;
  constructor(
    private _danhMucService: DanhMucServiceProxy,
    private danhMucService: DanhMucService
  ) { }

  ngOnInit() {
    // this.show();
    // this.getDanhSach();
  }
  // getDanhSach() {
  //   this.danhMucService.getListDanhMuc().subscribe(res => {
  //     console.log(res);
  //     this.listDanhMuc = res.result;
  //     // this.danhMucTree.editData = res;
  //     console.log(this.listDanhMuc);
  //   });
  // }
  getUsers(event?: LazyLoadEvent) {
    if (this.primengTableHelper.shouldResetPaging(event)) {
        this.paginator.changePage(0);

        return;
    }

    this.primengTableHelper.showLoadingIndicator();

    this._danhMucService.getList().pipe(finalize(() => this.primengTableHelper.hideLoadingIndicator())).subscribe(result => {
        // this.primengTableHelper.totalRecordsCount = result.totalCount;
        this.primengTableHelper.records = result;
        console.log(result);
    });
    console.log(this.primengTableHelper);
}
}
