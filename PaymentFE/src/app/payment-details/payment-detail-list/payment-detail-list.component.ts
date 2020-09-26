import { Component, OnInit } from '@angular/core';
import { PaymentDetail } from 'src/app/shared/payment-detail.model';
import { PaymentDetailService } from 'src/app/shared/payment-detail.service';

@Component({
  selector: 'app-payment-detail-list',
  templateUrl: './payment-detail-list.component.html',
  styles: []
})
export class PaymentDetailListComponent implements OnInit {

  // private value;
  // public total=0;

  constructor(public service: PaymentDetailService) { }
  
 

  ngOnInit(): void {
    this.service.refreshList();
    // console.log("Total",this.Total);
  }
  populateForm(pd: PaymentDetail) {
    this.service.formData = Object.assign({}, pd);
  }


  
  get Total() {
    let total: number = 0;
    // if(!this.service.list==null){
     for(let p of this.service.list) 
     {
        total+= parseInt(p.CardNumber);
     }
    // }
     return total;
  }

 
  onDelete(PMId) {
    this.service.deletePaymentDetail(PMId)
    .subscribe(res =>{
      this.service.refreshList();
    },
      err=>{
        console.log(err);
      })
  }
}
