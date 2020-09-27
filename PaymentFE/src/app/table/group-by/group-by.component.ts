import { Component, OnInit } from '@angular/core';
import { TableServiceService } from '../table-service.service';

@Component({
  selector: 'app-group-by',
  templateUrl: './group-by.component.html',
  styleUrls: ['./group-by.component.css']
})
export class GroupByComponent implements OnInit {

  groupByEmployeeList;
  constructor(private groupByService: TableServiceService) { }

  ngOnInit(): void {
   this.groupByService.GetGroupByEmployee().subscribe(groupByEmployeeList=>{this.groupByEmployeeList = groupByEmployeeList});
  }
}
