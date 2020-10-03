import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, NgForm, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import {} from '../payment-details/payment-detail/payment-detail.component'

import { PaymentDetailService } from '../shared/payment-detail.service';
import { MyErrorStateMatcher } from '../default.error-matcher';
import { Observable } from 'rxjs';
import { LoginDetail } from '../shared/login.model';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  logs;
  matcher = new MyErrorStateMatcher();
  
  constructor(private fb: FormBuilder, private router: Router, public service: PaymentDetailService) { }

  ngOnInit(): void {
    this.service.getLoginCheck();
    // this.service.getLoginCheck().subscribe(logs=>{this.logs = logs});
  }
  resetForm(form?: NgForm) {
    if(form != null)
     form.resetForm();
    this.service.loginFormData = {
      Email: '',
      Password: ''
    }
  }
  onSubmit(form: NgForm) {
    this.validateLogin(form);
  }
  validateLogin(form: NgForm) {  
    if(form.value.Email == this.service.loginFormData.Email && form.value.Password == this.service.loginFormData.Password)
    {
      this.router.navigateByUrl('/payment');
    }
    else
    {
      this.router.navigateByUrl('');
      console.log("Not Found");
    }
   }

}
