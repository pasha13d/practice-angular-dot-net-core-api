import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { CompanyServiceService } from './company-service.service';

@Component({
  selector: 'app-company',
  templateUrl: './company.component.html',
  styleUrls: ['./company.component.css']
})
export class CompanyComponent implements OnInit {

  constructor(public service: CompanyServiceService) { }

  resetForm(form?: NgForm) {
    if(form != null)
     form.resetForm();
    this.service.formData = {
      Id: 0,
      CompanyName: ''
    }
  }
  
  ngOnInit(): void {
   this.resetForm();
  }

  onSubmit(form: NgForm) {
    console.log(form.value);
    if(this.service.formData.Id == 0)
    {
      this.insertRecord(form);
    }
  }

  insertRecord(form: NgForm) {
    this.service.postCompany().subscribe(
      res => {
        this.resetForm(form);
        console.log("Company Saved Succesfully");
      },
      err => {
        console.log(err);
      }
    )
   }

}
