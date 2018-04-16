import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ItinearyComponent } from './itineary.component';

describe('ItinearyComponent', () => {
  let component: ItinearyComponent;
  let fixture: ComponentFixture<ItinearyComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ItinearyComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ItinearyComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
