import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class TableServiceService {

  constructor(private http: HttpClient) { }

  GetGroupByEmployee() {
    return this.http.get('https://localhost:44359/api/Employee/GetGroupByEmployee')
  }
}
