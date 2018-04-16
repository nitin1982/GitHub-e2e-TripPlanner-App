import { ItinearyComponent } from './itineary/itineary.component';
import { AddEditTripComponent } from './add-edit-trip/add-edit-trip.component';

import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TripsLandingPageComponent } from './tripslandingpage/trips-landingPage.component';
import { PasttripsComponent } from './pasttrips/pasttrips.component';
import { UcomingtripComponent } from './ucomingtrip/ucomingtrip.component';
import { RouterModule, Routes } from '@angular/router';
import { TripDocumentsComponent } from './trip-documents/trip-documents.component';
import { TripPicsComponent } from './trip-pics/trip-pics.component';
import { TripWeblinksComponent } from './trip-weblinks/trip-weblinks.component';
import { TripDescriptionComponent } from './trip-description/trip-description.component';

const tripRoutes: Routes = [{
  path: 'Trips',
  component: TripsLandingPageComponent,
  children: [
    {
      path: 'UpcomingTrips',
      component: UcomingtripComponent
    },
    {
      path: 'PastTrips',
      component: PasttripsComponent
    },
    {
      path: '',
      redirectTo: 'UpcomingTrips',
      pathMatch: 'full'
    },
    {
      path: 'Trips/:TripId/Edit',
      component: AddEditTripComponent,
      children: [
        {
          path: 'Itineary',
          component: ItinearyComponent
        },
        {
          path: 'Docs',
          component: TripDocumentsComponent
        },
        {
          path: 'Pics',
          component: TripPicsComponent
        },
        {
          path: 'WebLinks',
          component: TripWeblinksComponent
        },
        {
          path: 'Desc',
          component: TripDescriptionComponent
        },
        {
          path: '',
          redirectTo: 'Itineary',
          pathMatch: 'full'
        }
      ]
    }
  ]
}];


@NgModule({
  declarations: [
    TripsLandingPageComponent,
    UcomingtripComponent,
    PasttripsComponent,
    AddEditTripComponent,
    TripDocumentsComponent,
    TripPicsComponent,
    TripWeblinksComponent,
    TripDescriptionComponent,
    ItinearyComponent
  ],
  imports: [ CommonModule, RouterModule.forChild(tripRoutes) ],
  exports: [RouterModule],
  providers: [],
})
export class TripsModule {

}
