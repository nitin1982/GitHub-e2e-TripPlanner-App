import { Observable } from 'rxjs/Observable';
import { Injectable } from '@angular/core';

import 'rxjs/add/observable/of';
import 'rxjs/add/operator/do';
import 'rxjs/add/operator/delay';

@Injectable()
export class AuthService {
  isLoggedIn: boolean;

  constructor() {

  }

  login(): Observable<boolean> {
    return Observable.of(true).delay(2000).do(val => this.isLoggedIn = true);
  }

}
