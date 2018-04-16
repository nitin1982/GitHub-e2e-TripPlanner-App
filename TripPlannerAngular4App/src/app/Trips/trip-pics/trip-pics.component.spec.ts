import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TripPicsComponent } from './trip-pics.component';

describe('TripPicsComponent', () => {
  let component: TripPicsComponent;
  let fixture: ComponentFixture<TripPicsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TripPicsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TripPicsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
