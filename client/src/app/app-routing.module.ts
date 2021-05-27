import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CollegeDetailComponent } from './college-detail/college-detail.component';
import { CollegeEditComponent } from './college-edit/college-edit.component';
import { CollegeListComponent } from './college-list/college-list.component';
import { CollegeComponent } from './college/college.component';
import { NotFoundComponent } from './errors/not-found/not-found.component';
import { ServerErrorComponent } from './errors/server-error/server-error.component';
import { TestErrorsComponent } from './errors/test-errors/test-errors.component';
import { HomeComponent } from './home/home.component';
import { HsDetailComponent } from './hs-detail/hs-detail.component';
import { HsEditComponent } from './hs-edit/hs-edit.component';
import { HsListComponent } from './hs-list/hs-list.component';
import { ColUserLoginComponent } from './col-user-login/col-user-login.component';
import { HsStudentComponent } from './hs-student/hs-student.component';
import { HsRegisterComponent } from './hs-register/hs-register.component';
import { CollegeRegisterComponent } from './college-register/college-register.component';
import { MemberListComponent } from './members/member-list/member-list.component';
import { MemberDetailComponent } from './members/member-detail/member-detail.component';
import { ListsComponent } from './lists/lists.component';
import { MemberEditComponent } from './members/member-edit/member-edit.component';
import { MessagesComponent } from './messages/messages.component';
import { AuthGuard } from './_guards/auth.guard';

const routes: Routes = [
  { path: '', component: HomeComponent },
  {
    path: '',
    runGuardsAndResolvers: 'always',
    canActivate: [AuthGuard],
    children: [
      { path: 'members', component: MemberListComponent },
      { path: 'hsmemberedit', component: HsEditComponent },
      { path: 'lists', component: ListsComponent },
      { path: 'messages', component: MessagesComponent },
    ],
  },
  { path: 'hsstudent', component: HsStudentComponent },
  { path: 'college', component: CollegeComponent },
  { path: 'coluserlogin', component: ColUserLoginComponent },
  { path: 'collegeregister', component: CollegeRegisterComponent },
  { path: 'collegemember/:id', component: MemberDetailComponent },
  { path: 'hsmember/:id', component: HsDetailComponent },
  { path: 'collegememberedit', component: MemberEditComponent },
  { path: 'hslist', component: HsListComponent },
  { path: 'hsregister', component: HsRegisterComponent },
  { path: 'errors', component: TestErrorsComponent },
  { path: 'not-found', component: NotFoundComponent },
  { path: 'server-error', component: ServerErrorComponent },
  { path: '**', component: NotFoundComponent, pathMatch: 'full' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
