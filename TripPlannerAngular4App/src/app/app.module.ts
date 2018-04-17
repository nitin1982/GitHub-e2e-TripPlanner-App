import { TripsModule } from './Trips/trips.module';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { NavigationComponent } from '../app/Navigation/navigation.component';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent, NavigationComponent
  ],
  imports: [
    BrowserModule,
    TripsModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
