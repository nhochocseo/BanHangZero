import { Component, OnInit, ViewChild, Injector } from '@angular/core';
import { PrimengTableHelper } from '@shared/helpers/PrimengTableHelper';
import { DanhMucServiceProxy } from '@shared/service-proxies/service-proxies';
import { LazyLoadEvent } from 'primeng/api';
import { Paginator } from 'primeng/primeng';
import { Table } from 'primeng/table';
import { finalize } from 'rxjs/operators';
import { AppComponentBase } from '@shared/common/app-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';

@Component({
  selector: 'app-danh-muc',
  templateUrl: './danh-muc.component.html',
  styleUrls: ['./danh-muc.component.css'],
  animations: [appModuleAnimation()]
})
export class DanhMucComponent extends AppComponentBase {
  @ViewChild('paginator') paginator: Paginator;
  @ViewChild('dataTable') dataTable: Table;
  filterText = '';
  editField: string;
  constructor(
    private _danhMucService: DanhMucServiceProxy,
    injector: Injector,
  ) {
    super(injector);
  }

  getDanhMuc(event?: LazyLoadEvent) {
    if (this.primengTableHelper.shouldResetPaging(event)) {
        this.paginator.changePage(0);

        return;
    }

    this.primengTableHelper.showLoadingIndicator();
    this._danhMucService.getDanhMuc(
        this.filterText,
        this.primengTableHelper.getSorting(this.dataTable),
        this.primengTableHelper.getSkipCount(this.paginator, event),
        this.primengTableHelper.getMaxResultCount(this.paginator, event),
    ).pipe(finalize(() => this.primengTableHelper.hideLoadingIndicator())).subscribe(result => {
        this.primengTableHelper.totalRecordsCount = result.totalCount;
        this.primengTableHelper.records = result.items;
        this.primengTableHelper.hideLoadingIndicator();
    });
  }
  changeValue(id: number, property: string, event: any) {
    console.log(id);
    this.editField = event.target.textContent;
    console.log(this.editField);
  }
  SaveTab(event: any) {
    console.log(event.target.textContent);
  }
  onKeydown(event: any){
    event.preventDefault();
  }

}
