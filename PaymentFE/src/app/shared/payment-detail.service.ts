import { Injectable } from '@angular/core';
import { PaymentDetail } from './payment-detail.model';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class PaymentDetailService {

  // public formData: any;
  formData:PaymentDetail = new PaymentDetail();
  list: PaymentDetail[];
  readonly rootURL = 'https://localhost:44359/api';

  constructor(private http: HttpClient) { }

  postPaymentDetail() {
    return this.http.post(this.rootURL+'/PaymentDetail', this.formData)
  }

  putPaymentDetail() {
    return this.http.put(this.rootURL+'/PaymentDetail/'+this.formData.PMId, this.formData)
  }

  deletePaymentDetail(id) {
    return this.http.delete(this.rootURL+'/PaymentDetail/'+id)
  }

  refreshList(){
    this.http.get(this.rootURL+'/PaymentDetail').toPromise().then(res => this.list = res as PaymentDetail[]);
  }
}
