import { Component, OnInit, Injector, ViewChild } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/common/app-component-base';
import { QuanLyNhuanServiceServiceProxy } from '@shared/service-proxies/service-proxies';
import { LazyLoadEvent } from 'primeng/api';
import { finalize } from 'rxjs/operators';
import { Paginator } from 'primeng/primeng';
import { Table } from 'primeng/table';

@Component({
  selector: 'app-quan-ly-nhuan',
  templateUrl: './quan-ly-nhuan.component.html',
  styleUrls: ['./quan-ly-nhuan.component.css'],
  animations: [appModuleAnimation()]
})
export class QuanLyNhuanComponent  extends AppComponentBase  implements OnInit{
  filterText = '';
  //Filters
  advancedFiltersAreShown = false;
  @ViewChild('paginator') paginator: Paginator;
  @ViewChild('dataTable') dataTable: Table;
  constructor(
    injector: Injector,
    private _quanLyNhuanService: QuanLyNhuanServiceServiceProxy
  ) {
    super(injector);
  }

  ngOnInit(): void {
    this.getDanhSach();
  }
  getDanhSach(event?: LazyLoadEvent) {
    this._quanLyNhuanService.getQuanLyNhuan(
        this.filterText,
        null,
        0,
        10,
    ).pipe(finalize(() => this.primengTableHelper.hideLoadingIndicator())).subscribe(result => {
        this.primengTableHelper.totalRecordsCount = result.totalCount;
        this.primengTableHelper.records = result.items;
        this.primengTableHelper.hideLoadingIndicator();
        console.log(this.primengTableHelper.records);
    });
  }
  getDanhSachChangePage(event?: LazyLoadEvent) {
    this.primengTableHelper.showLoadingIndicator();
    this._quanLyNhuanService.getQuanLyNhuan(
        this.filterText,
        null,
        this.primengTableHelper.getSkipCount(this.paginator, event),
        this.primengTableHelper.getMaxResultCount(this.paginator, event),
    ).pipe(finalize(() => this.primengTableHelper.hideLoadingIndicator())).subscribe(result => {
        this.primengTableHelper.totalRecordsCount = result.totalCount;
        this.primengTableHelper.records = result.items;
        this.primengTableHelper.hideLoadingIndicator();
    });
  }

}
