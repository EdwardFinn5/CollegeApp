import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ColUser } from './_models/colUser';
import { ColAccountService } from './_services/col-account.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent implements OnInit {
  title = 'College Connect';
  // colUsers: any;

  constructor(
    private colAccountService: ColAccountService
  ) // private http: HttpClient
  {}

  ngOnInit() {
    // this.getColUsers();
    this.setCurrentUser();
  }

  setCurrentUser() {
    const colUser: ColUser = JSON.parse(localStorage.getItem('colUser'));
    this.colAccountService.setCurrentColUser(colUser);
  }

  // getColUsers() {
  //   this.http.get('https://localhost:5001/api/colUsers').subscribe(
  //     (response) => {
  //       this.colUsers = response;
  //     },
  //     (error) => {
  //       console.log(error);
  //     }
  //   );
  // }
}
