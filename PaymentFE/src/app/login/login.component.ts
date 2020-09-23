import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import {} from '../payment-details/payment-detail/payment-detail.component'
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  loginForm: FormGroup;
  constructor(private fb: FormBuilder, private router: Router) { }

  ngOnInit(): void {
    this.loginForm = this.fb.group({
      Email: [null, Validators.required],
      Password: [null, Validators.required]
    });
  }

  submit() {
    if(!this.loginForm.valid) {
      return;
    }
    else {
      console.log(this.loginForm.value);
      this.router.navigateByUrl('/payment');
    }
  }

}
