import { Component, OnInit } from '@angular/core';
import { Trip } from '../../model/trip';

@Component({
  selector: 'app-itineary',
  templateUrl: './itineary.component.html',
  styleUrls: ['./itineary.component.css']
})
export class ItinearyComponent implements OnInit {
  trip: Trip;
  constructor() { }

  ngOnInit() {
    this.trip = new Trip();
  }

}
