import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, NgForm, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import {} from '../payment-details/payment-detail/payment-detail.component'

import { PaymentDetailService } from '../shared/payment-detail.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  // loginForm: FormGroup;
  constructor(private fb: FormBuilder, private router: Router, public service: PaymentDetailService) { }

  ngOnInit(): void {
    // this.loginForm = this.fb.group({
    //   Email: [null, Validators.required],
    //   Password: [null, Validators.required]
    // });
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
    // console.log(this.service.loginFormData);
    // if(!this.loginForm.valid) {
    //   return;
    // }
    // else {
    //   console.log(this.loginForm.value);
    //   this.router.navigateByUrl('/payment');
    // }
  }
  validateLogin(form: NgForm) {
    // console.log(form.value['Email'])
    if(form.value.Email== this.service.loginFormData.Email && form.value.Password == this.service.loginFormData.Password)
    {
      this.router.navigateByUrl('/payment')
    }
    // if(!this.service.postLoginCheck()==null){
    //   this.router.navigateByUrl('/payment');
    // }
    // else{
    //   return "Not OK";
    // }
   }

}
