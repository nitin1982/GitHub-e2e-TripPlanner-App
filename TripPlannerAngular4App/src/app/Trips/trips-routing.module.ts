import { TripsLandingPageComponent } from './tripslandingpage/trips-landingPage.component';
import { PasttripsComponent } from './pasttrips/pasttrips.component';
import { UcomingtripComponent } from './ucomingtrip/ucomingtrip.component';

import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';

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
  ]
}];

@NgModule({
  declarations: [TripsLandingPageComponent, UcomingtripComponent, PasttripsComponent],
  imports: [ CommonModule, RouterModule.forChild(tripRoutes) ],
  exports: [RouterModule],
  providers: [],
})
export class TripsRoutingModule {}
