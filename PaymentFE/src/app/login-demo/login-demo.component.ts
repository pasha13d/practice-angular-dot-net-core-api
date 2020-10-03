import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { PaymentDetailService } from '../shared/payment-detail.service';
import { AuthService } from '../auth/auth.service';

@Component({
  selector: 'app-login-demo',
  templateUrl: './login-demo.component.html',
  styleUrls: ['./login-demo.component.css']
})

export class LoginDemoComponent implements OnInit {
  loginForm: FormGroup;

 
  constructor(private fb: FormBuilder, private _auth: AuthService, private router: Router, private service: PaymentDetailService) { }
  
  private formSubmitAttempt: boolean;

  ngOnInit(): void {
    this.loginForm = this.fb.group({
      Email: ['', Validators.required],
      Password: ['', Validators.required]
    });
  }
  
  // onSubmit() {
  //   console.log(this.loginForm);
  //   this.validateLogin();
  // }
  // validateLogin() {
  //   // console.log(this.loginForm.value.Email);
  //   console.log(this.service.loginFormData.Email);
  //   if(this.loginForm.value.Email == this.service.loginFormData.Email && this.loginForm.value.Password == this.service.loginFormData.Password)
  //   {
  //     console.log("t", this.loginForm.value.Email)
  //     this.router.navigateByUrl('/cascadingDDL')
  //   }
  // }


  onSubmit() {
    if(this.loginForm.valid) {
      this._auth.login(this.loginForm.value);
    }
    this.formSubmitAttempt = true;
    console.log("value", this.loginForm.value);
  }



}
