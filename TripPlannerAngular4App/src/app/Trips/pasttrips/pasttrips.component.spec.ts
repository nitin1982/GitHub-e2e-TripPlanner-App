import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PasttripsComponent } from './pasttrips.component';

describe('PasttripsComponent', () => {
  let component: PasttripsComponent;
  let fixture: ComponentFixture<PasttripsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PasttripsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PasttripsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
