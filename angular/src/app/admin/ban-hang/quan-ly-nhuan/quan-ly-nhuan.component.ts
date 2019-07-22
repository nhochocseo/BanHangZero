import { Component, OnInit, Injector } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/common/app-component-base';

@Component({
  selector: 'app-quan-ly-nhuan',
  templateUrl: './quan-ly-nhuan.component.html',
  styleUrls: ['./quan-ly-nhuan.component.css'],
  animations: [appModuleAnimation()]
})
export class QuanLyNhuanComponent  extends AppComponentBase {
  filterText = '';
  //Filters
  advancedFiltersAreShown = false;
  constructor(
    injector: Injector,
  ) {
    super(injector);
  }


}
