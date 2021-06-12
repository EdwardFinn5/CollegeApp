import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NavComponent } from './nav/nav.component';
import { FormsModule } from '@angular/forms';
import { HomeComponent } from './home/home.component';
import { CollegeComponent } from './college/college.component';
import { HsStudentComponent } from './hs-student/hs-student.component';
import { CollegeEditComponent } from './college-edit/college-edit.component';
import { CollegeRegisterComponent } from './college-register/college-register.component';
import { CollegeListComponent } from './college-list/college-list.component';
import { CollegeDetailComponent } from './college-detail/college-detail.component';
import { ColUserLoginComponent } from './col-user-login/col-user-login.component';
import { HsRegisterComponent } from './hs-register/hs-register.component';
import { HsListComponent } from './hs-list/hs-list.component';
import { HsDetailComponent } from './hs-detail/hs-detail.component';
import { HsEditComponent } from './hs-edit/hs-edit.component';
import { HsCardComponent } from './hs-card/hs-card.component';
import { CollegeCardComponent } from './college-card/college-card.component';
import { TestErrorsComponent } from './errors/test-errors/test-errors.component';
import { NotFoundComponent } from './errors/not-found/not-found.component';
import { ServerErrorComponent } from './errors/server-error/server-error.component';
import { ListsComponent } from './lists/lists.component';
import { SharedModule } from './_modules/shared.module';
import { ErrorInterceptor } from './_interceptors/error.interceptor';
import { ColmemberListComponent } from './colmembers/colmember-list/colmember-list.component';
import { ColmemberCardComponent } from './colmembers/colmember-card/colmember-card.component';
import { JwtInterceptor } from './_interceptors/jwt.interceptor';

@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
    HomeComponent,
    CollegeComponent,
    HsStudentComponent,
    CollegeEditComponent,
    CollegeRegisterComponent,
    CollegeListComponent,
    CollegeDetailComponent,
    ColUserLoginComponent,
    HsRegisterComponent,
    HsListComponent,
    HsDetailComponent,
    HsEditComponent,
    HsCardComponent,
    CollegeCardComponent,
    TestErrorsComponent,
    NotFoundComponent,
    ServerErrorComponent,
    ListsComponent,
    ColmemberListComponent,
    ColmemberCardComponent,
  ],

  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    FormsModule,
    SharedModule,
  ],

  providers: [
    { provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true },
    { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true },
  ],
  bootstrap: [AppComponent],
})
export class AppModule {}
