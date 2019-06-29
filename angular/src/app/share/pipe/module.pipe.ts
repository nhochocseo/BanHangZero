import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { DefaultThumbnail } from './defaultThumbnail.pipe';
@NgModule({
  imports: [
    CommonModule
  ],
  declarations: [
    DefaultThumbnail
  ],
  exports: [
    DefaultThumbnail
  ]
})
export class PipeModule { }
