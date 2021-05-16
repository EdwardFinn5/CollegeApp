import { Component, OnInit } from '@angular/core';
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

  constructor(
    public colAccountService: ColAccountService,
    private router: Router // private toastr: ToastrService
  ) {}

  ngOnInit(): void {}

  registerToggle() {
    this.collegeRegisterMode = !this.collegeRegisterMode;
  }

  cancelRegisterMode(event: boolean) {
    this.collegeRegisterMode = event;
  }

  // getUsers() {
  //   this.http.get('https://localhost:5001/api/users')
  //     .subscribe(users => this.users = users);

  // }

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
}
