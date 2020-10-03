// import { Injectable } from '@angular/core';

// @Injectable({
//   providedIn: 'root'
// })
// export class AuthService {

//   constructor() { }
// }


import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { BehaviorSubject } from 'rxjs';
import { LoginDetail } from '../shared/login.model';
import { PaymentDetailService } from '../shared/payment-detail.service';
import { LoginDemo } from './login-demo';

@Injectable()
export class AuthService {
  private loggedIn: BehaviorSubject<boolean> = new BehaviorSubject<boolean>(false);

  get isLoggedIn() {
    return this.loggedIn.asObservable();
  }

  constructor(private router: Router, private service: PaymentDetailService) {}

  login(user: LoginDetail) {
    if (user.Email == this.service.loginFormData.Email && user.Password == this.service.loginFormData.Password ) {
      // this.loggedIn.next(true);
      this.router.navigateByUrl('/payment');
    }
    console.log("user", user);
    console.log("service", this.service.loginFormData.Email);
  }

  logout() {
    this.loggedIn.next(false);
    this.router.navigate(['/login']);
  }
}