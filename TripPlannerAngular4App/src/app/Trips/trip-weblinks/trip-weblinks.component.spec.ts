import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TripWeblinksComponent } from './trip-weblinks.component';

describe('TripWeblinksComponent', () => {
  let component: TripWeblinksComponent;
  let fixture: ComponentFixture<TripWeblinksComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TripWeblinksComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TripWeblinksComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
