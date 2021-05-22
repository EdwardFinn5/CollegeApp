import { HttpClient } from '@angular/common/http';
import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ColAccountService } from '../_services/col-account.service';

@Component({
  selector: 'app-hs-student',
  templateUrl: './hs-student.component.html',
  styleUrls: ['./hs-student.component.css'],
})
export class HsStudentComponent implements OnInit {
  collegeRegisterMode = false;
  model: any = {};
  loggedIn: boolean;
  // colUsers: any;

  constructor(
    public colAccountService: ColAccountService,
    private router: Router
  ) // private http: HttpClient
  {}

  ngOnInit(): void {
    // this.getColUsers();
  }

  // getColUsers() {
  //   this.http
  //     .get('https://localhost:5001/api/colUsers')
  //     .subscribe((colUsers) => (this.colUsers = colUsers));
  // }

  registerToggle() {
    this.collegeRegisterMode = !this.collegeRegisterMode;
  }

  cancelCollegeRegisterMode(event: boolean) {
    this.collegeRegisterMode = event;
  }

  login() {
    this.colAccountService.colLogin(this.model).subscribe((response) => {
      this.router.navigateByUrl('/hslist');
    });
  }

  logout() {
    this.colAccountService.logout();
    this.router.navigateByUrl('/');
  }

  onLoginBtn() {
    this.router.navigate(['/coluserlogin']);
  }

  onRegisterBtn() {
    this.router.navigate(['/collegeregister']);
  }

  cancel() {
    console.log('cancelled');
    this.router.navigateByUrl('/');
  }
}
