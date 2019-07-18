// tslint:disable-next-line:max-line-length
import { MatButtonModule, MatCheckboxModule, MatTabsModule, MatInputModule, MatSelectModule, MatAutocompleteModule, MatDatepickerModule, MatNativeDateModule, MatDialogModule, MatIconModule } from '@angular/material';
import { NgModule } from '@angular/core';

@NgModule({
    imports: [
        MatButtonModule,
        MatCheckboxModule,
        MatTabsModule,
        MatInputModule,
        MatSelectModule,
        MatAutocompleteModule,
        MatDatepickerModule,
        MatNativeDateModule,
        MatDialogModule,
        MatIconModule
    ],
    exports: [
        MatButtonModule,
        MatCheckboxModule,
        MatTabsModule,
        MatInputModule,
        MatSelectModule,
        MatAutocompleteModule,
        MatDatepickerModule,
        MatDialogModule,
        MatIconModule
    ],
    providers: [
        MatDatepickerModule,
    ],
})
export class CustomMaterialModule {}
