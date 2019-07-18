import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SaveDanhMucComponent } from './save-danh-muc.component';

describe('SaveDanhMucComponent', () => {
  let component: SaveDanhMucComponent;
  let fixture: ComponentFixture<SaveDanhMucComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SaveDanhMucComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SaveDanhMucComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
