import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { DropdownServiceService } from '../dropdown-service.service';

@Component({
  selector: 'app-cascading-dropdown',
  templateUrl: './cascading-dropdown.component.html',
  styleUrls: ['./cascading-dropdown.component.css']
})
export class CascadingDropdownComponent implements OnInit {
  countryList;
  stateList;
  cityList;

  dropDownForm: FormGroup;

  constructor(private ddlService: DropdownServiceService, private fb: FormBuilder) { }

  ngOnInit(): void {

    this.dropDownForm = this.fb.group({
      country: [''],
      state: [''],
      city: ['']
    });

    this.ddlService.getAllCountry().subscribe(countryList=>{this.countryList = countryList;});
  }
  GetStateById(event) {
    console.log(event);
    if(event.target.value > 0) {
      this.ddlService.getStateByCountry(event.target.value).subscribe(stateList=>{this.stateList = stateList;});
    }
  }

  GetCityById(event) {
    // if(event.terget.value >0) {
      this.ddlService.getCityByState(event.target.value).subscribe(cityList=>{this.cityList = cityList});
    // }
  }

  Save() {
    console.log(this.dropDownForm.value);
  }
}
