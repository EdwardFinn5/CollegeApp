import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { Router } from '@angular/router';
import { ColAccountService } from '../_services/col-account.service';

@Component({
  selector: 'app-col-user-login',
  templateUrl: './col-user-login.component.html',
  styleUrls: ['./col-user-login.component.css'],
})
export class ColUserLoginComponent implements OnInit {
  model: any = {};
  loggedIn: boolean;
  @Output() cancelLogin = new EventEmitter();

  constructor(
    private colAccountService: ColAccountService,
    private router: Router
  ) {}

  ngOnInit(): void {}

  login() {
    this.colAccountService.colLogin(this.model).subscribe(
      (response) => {
        console.log(response);
        this.loggedIn = true;
        this.router.navigateByUrl('/collegelist');
      },
      (error) => {
        console.log(error);
      }
    );
  }

  logout() {
    this.loggedIn = false;
  }

  cancel() {
    console.log('cancelled');
    this.cancelLogin.emit(false);
    this.router.navigateByUrl('/');
  }
}
