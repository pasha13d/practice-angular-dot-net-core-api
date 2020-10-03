import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { FloorDetail } from './floor.model';

@Injectable({
  providedIn: 'root'
})
export class FloorServiceService {
  formData:FloorDetail = new FloorDetail();

  readonly rootURL = 'https://localhost:44359/api';
  constructor(private http: HttpClient) { }

  postFloor() {
    return this.http.post('https://localhost:44359/api/Floor', this.formData)
  }
  getAllCompany() {
    return this.http.get('https://localhost:44359/api/Company/GetAllCompany');
  }
}
