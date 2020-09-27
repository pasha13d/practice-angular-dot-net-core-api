import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { AppComponent } from './app.component';
import { PaymentDetailsComponent } from './payment-details/payment-details.component';
import { PaymentDetailComponent } from './payment-details/payment-detail/payment-detail.component';
import { PaymentDetailListComponent } from './payment-details/payment-detail-list/payment-detail-list.component';
import { PaymentDetailService } from './shared/payment-detail.service';
import { HttpClientModule } from '@angular/common/http';

import { ReactiveFormsModule  } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { MatButtonModule } from '@angular/material/button';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatCardModule } from '@angular/material/card'
import {MatTableModule} from '@angular/material/table';
import { LoginComponent } from './login/login.component';
import { RouterModule, Routes }   from '@angular/router';
import { AppRoutingModule } from './app-routing.module';
import { CascadingDropdownComponent } from './dropdown/cascading-dropdown/cascading-dropdown.component';
import { GroupByComponent } from './table/group-by/group-by.component';


const routes: Routes=[
  {
    path: '',
    component: LoginComponent
  },
  { 
    path: 'login',
    component: LoginComponent
  },
  {
    path: 'payment',
    component: PaymentDetailsComponent
  },
  {
    path: 'cascadingDDL',
    component: CascadingDropdownComponent
  },
  {
    path: 'groupByEmployee',
    component: GroupByComponent
  }
]



@NgModule({
  declarations: [
    AppComponent,
    PaymentDetailsComponent,
    PaymentDetailComponent,
    PaymentDetailListComponent,
    LoginComponent,
    CascadingDropdownComponent,
    GroupByComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    ReactiveFormsModule,
    BrowserAnimationsModule,
    MatButtonModule,
    MatFormFieldModule,
    MatInputModule,
    MatTableModule,
    MatCardModule,
    RouterModule.forRoot(routes),
    AppRoutingModule
  ],
  providers: [PaymentDetailService],
  bootstrap: [AppComponent]
})
export class AppModule {
}
