import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class DropdownServiceService {
  readonly rootURL = 'https://localhost:44359/api/Cascading';
  constructor(private http: HttpClient) { }

  getAllCountry() {
    return this.http.get('https://localhost:44359/api/Cascading/GetAllCountry');
  }

  getStateByCountry(CountryId: number) {
    return this.http.get('https://localhost:44359/api/Cascading/GetStateById/'+CountryId);
  }

  getCityByState(StateId: number) {
    return this.http.get('https://localhost:44359/api/Cascading/GetCityById/'+StateId);
  }
}
