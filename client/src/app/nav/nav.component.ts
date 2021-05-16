import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { ColUser } from '../_models/colUser';
import { ColAccountService } from '../_services/col-account.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css'],
})
export class NavComponent implements OnInit {
  model: any = {};

  constructor(public colAccountService: ColAccountService) {}

  ngOnInit(): void {}

  login() {
    this.colAccountService.colLogin(this.model).subscribe(
      (response) => {
        console.log(response);
      },
      (error) => {
        console.log(error);
      }
    );
  }

  logout() {
    this.colAccountService.logout();
  }
}
