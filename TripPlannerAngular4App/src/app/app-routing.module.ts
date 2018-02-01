import { AboutComponent } from './About/about.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from '../app/Home/home.component';

const appRoutes: Routes = [{
    path: 'Home',
    component: HomeComponent
}, {
  path: 'About',
  component: AboutComponent
}];

@NgModule({
    declarations: [
        HomeComponent, AboutComponent
    ],
    imports: [ RouterModule.forRoot(appRoutes) ],
    providers: [],
    exports: [ RouterModule ]
})
export class AppRoutingModule {

}
