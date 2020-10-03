import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { CompanyDetail } from './company.model';

@Injectable({
  providedIn: 'root'
})
export class CompanyServiceService {
  formData:CompanyDetail = new CompanyDetail();

  readonly rootURL = 'https://localhost:44359/api';

  constructor(private http: HttpClient) { }

  postCompany() {
    return this.http.post(this.rootURL+'/Company', this.formData)
  }
}
