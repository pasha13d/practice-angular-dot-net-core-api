import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { PaymentDetailService } from 'src/app/shared/payment-detail.service';
import { FloorServiceService } from './floor-service.service';

@Component({
  selector: 'app-floor',
  templateUrl: './floor.component.html',
  styleUrls: ['./floor.component.css']
})
export class FloorComponent implements OnInit {
  companyList;
  constructor(public service: FloorServiceService) { }

  resetForm(form?: NgForm) {
    if(form != null)
     form.resetForm();
    this.service.formData = {
      Id: 0,
      CompanyName: '',
      FloorName: ''
      
    }
  }

  ngOnInit(): void {
    this.resetForm();
    this.service.getAllCompany().subscribe(companyList=>{this.companyList = companyList;});
  }

  onSubmit(form: NgForm) {
    console.log(form.value);
    if(this.service.formData.Id == 0)
    {
      this.insertRecord(form);
    }
  }

  insertRecord(form: NgForm) {
    this.service.postFloor().subscribe(
      res => {
        this.resetForm(form);
        console.log("Floor Saved Succesfully");
      },
      err => {
        console.log(err);
      }
    )
   }

   


}
