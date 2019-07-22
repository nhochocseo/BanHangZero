import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { QuanLyNhuanComponent } from './quan-ly-nhuan.component';

describe('QuanLyNhuanComponent', () => {
  let component: QuanLyNhuanComponent;
  let fixture: ComponentFixture<QuanLyNhuanComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ QuanLyNhuanComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(QuanLyNhuanComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
