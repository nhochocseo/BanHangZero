import { Component, ViewChild, Injector } from '@angular/core';
import { Paginator, LazyLoadEvent } from 'primeng/primeng';
import { Table } from 'primeng/table';
import { PrimengTableHelper } from '@shared/helpers/PrimengTableHelper';
import { TinTucServiceProxy } from '@shared/service-proxies/service-proxies';
import { finalize } from 'rxjs/operators';
import { AppComponentBase } from '@shared/common/app-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';

@Component({
  selector: 'app-tin-tuc',
  templateUrl: './tin-tuc.component.html',
  styleUrls: ['./tin-tuc.component.css'],
  animations: [appModuleAnimation()]
})
export class TinTucComponent extends AppComponentBase {
  @ViewChild('paginator') paginator: Paginator;
  @ViewChild('dataTable') dataTable: Table;
  filterText = '';
  editField: string;
  primengTableHelper: PrimengTableHelper;

  constructor(
    private _tinTucService: TinTucServiceProxy,
    injector: Injector,
  ) {
    super(injector);
  }

  openDialog(value?: any): void {
  }

  getTinTuc(event?: LazyLoadEvent) {
    if (this.primengTableHelper.shouldResetPaging(event)) {
      this.paginator.changePage(0);

      return;
    }

    this.primengTableHelper.showLoadingIndicator();
    this._tinTucService.getDanhSach(
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

  delete(id: number) {

  }
}
