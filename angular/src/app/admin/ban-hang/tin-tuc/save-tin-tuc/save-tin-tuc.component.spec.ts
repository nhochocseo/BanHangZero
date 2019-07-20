import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SaveTinTucComponent } from './save-tin-tuc.component';

describe('SaveTinTucComponent', () => {
  let component: SaveTinTucComponent;
  let fixture: ComponentFixture<SaveTinTucComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SaveTinTucComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SaveTinTucComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
