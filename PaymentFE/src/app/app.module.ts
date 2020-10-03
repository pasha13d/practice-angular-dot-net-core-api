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
import {MatSelectModule} from '@angular/material/select';
import { LoginComponent } from './login/login.component';
import { RouterModule, Routes }   from '@angular/router';
import { AppRoutingModule } from './app-routing.module';
import { CascadingDropdownComponent } from './dropdown/cascading-dropdown/cascading-dropdown.component';
import { GroupByComponent } from './table/group-by/group-by.component';
import { LoginDemoComponent } from './login-demo/login-demo.component';
import { UploadFileComponent } from './upload/upload-file/upload-file.component';
import { AuthGuard } from './auth/auth.guard';
import { AuthService } from './auth/auth.service';
import { CompanyComponent } from './payment-details/company/company.component';
import { FloorComponent } from './payment-details/floor/floor.component'

const routes: Routes=[
  {
    path: '',
    component: LoginComponent
    // component: LoginDemoComponent,
    // canActivate: [AuthGuard]
  },
  { 
    path: 'login',
    component: LoginComponent
    // component: LoginDemoComponent
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
  },
  {
    path: 'file-upload',
    component: UploadFileComponent
  },
  {
    path: 'company',
    component: CompanyComponent
  },
  {
    path: 'floor',
    component: FloorComponent
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
    GroupByComponent,
    LoginDemoComponent,
    UploadFileComponent,
    CompanyComponent,
    FloorComponent
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
    MatSelectModule,
    RouterModule.forRoot(routes),
    AppRoutingModule
  ],
  providers: [PaymentDetailService, AuthService, AuthGuard],
  bootstrap: [AppComponent]
})
export class AppModule {
}
