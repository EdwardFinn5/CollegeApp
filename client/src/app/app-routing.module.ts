import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CollegeDetailComponent } from './college-detail/college-detail.component';
import { CollegeComponent } from './college/college.component';
import { NotFoundComponent } from './errors/not-found/not-found.component';
import { ServerErrorComponent } from './errors/server-error/server-error.component';
import { TestErrorsComponent } from './errors/test-errors/test-errors.component';
import { HomeComponent } from './home/home.component';
import { HsEditComponent } from './hs-edit/hs-edit.component';
import { CollegeEditComponent } from './college-edit/college-edit.component';
import { HsListComponent } from './hs-list/hs-list.component';
import { ColUserLoginComponent } from './col-user-login/col-user-login.component';
import { HsStudentComponent } from './hs-student/hs-student.component';
import { HsRegisterComponent } from './hs-register/hs-register.component';
import { CollegeRegisterComponent } from './college-register/college-register.component';
import { ColmemberListComponent } from './colmembers/colmember-list/colmember-list.component';
import { ListsComponent } from './lists/lists.component';
import { AuthGuard } from './_guards/auth.guard';
import { HsDetailComponent } from './hs-detail/hs-detail.component';
import { PreventUnsavedHsChangesGuard } from './_guards/prevent-unsaved-hs-changes.guard';
import { PreventUnsavedCollegeChangesGuard } from './_guards/prevent-unsaved-college-changes.guard';

const routes: Routes = [
  { path: '', component: HomeComponent },
  {
    path: '',
    runGuardsAndResolvers: 'always',
    canActivate: [AuthGuard],
    children: [
      { path: 'colmembers', component: ColmemberListComponent },
      { path: 'hsmemberedit', component: HsEditComponent },
      { path: 'lists', component: ListsComponent },
      { path: 'hsdetail/:colusername', component: HsDetailComponent },
      {
        path: 'hsedit',
        component: HsEditComponent,
        canDeactivate: [PreventUnsavedHsChangesGuard],
      },
      {
        path: 'collegeedit',
        component: CollegeEditComponent,
        canDeactivate: [PreventUnsavedCollegeChangesGuard],
      },
      { path: 'collegedetail/:colusername', component: CollegeDetailComponent },
    ],
  },
  { path: 'hsstudent', component: HsStudentComponent },
  { path: 'college', component: CollegeComponent },
  { path: 'coluserlogin', component: ColUserLoginComponent },
  { path: 'collegeregister', component: CollegeRegisterComponent },
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
