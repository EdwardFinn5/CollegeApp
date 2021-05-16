import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ColAccountService } from '../_services/col-account.service';

@Component({
  selector: 'app-college',
  templateUrl: './college.component.html',
  styleUrls: ['./college.component.css'],
})
export class CollegeComponent implements OnInit {
  hsRegisterMode = false;
  model: any = {};
  loggedIn: boolean;

  constructor(
    public colAccountService: ColAccountService,
    private router: Router
  ) {}

  ngOnInit(): void {}

  registerToggle() {
    this.hsRegisterMode = !this.hsRegisterMode;
  }

  cancelHsRegisterMode(event: boolean) {
    this.hsRegisterMode = event;
  }

  login() {
    this.colAccountService.colLogin(this.model).subscribe((response) => {
      this.router.navigateByUrl('/collegelist');
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
    this.router.navigate(['/hsregister']);
  }
}
