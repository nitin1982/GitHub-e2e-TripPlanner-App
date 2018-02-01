import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UcomingtripComponent } from './ucomingtrip.component';

describe('UcomingtripComponent', () => {
  let component: UcomingtripComponent;
  let fixture: ComponentFixture<UcomingtripComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UcomingtripComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UcomingtripComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
