import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ReplaySubject } from 'rxjs';
import { map } from 'rxjs/operators';
import { ColUser } from '../_models/colUser';

@Injectable({
  providedIn: 'root',
})
export class ColAccountService {
  baseUrl = 'https://localhost:5001/api/';
  private currentColUserSource = new ReplaySubject<ColUser>(1);
  currentColUser$ = this.currentColUserSource.asObservable();
  colUserType: string;

  constructor(private http: HttpClient) {}

  colLogin(model: any) {
    return this.http.post(this.baseUrl + 'colAccount/colLogin', model).pipe(
      map((response: ColUser) => {
        const colUser = response;
        if (colUser) {
          localStorage.setItem('colUser', JSON.stringify(colUser));
          this.currentColUserSource.next(colUser);
        }
      })
    );
  }

  collegeRegister(model: any) {
    return this.http
      .post(this.baseUrl + 'colaccount/collegeregister', model)
      .pipe(
        map((colUser: ColUser) => {
          if (colUser) {
            localStorage.setItem('colUser', JSON.stringify(colUser));
            this.currentColUserSource.next(colUser);
            this.colUserType = colUser.colUserType;
          }
          // return colUser;
        })
      );
  }

  hsRegister(model: any) {
    return this.http.post(this.baseUrl + 'colaccount/hsregister', model).pipe(
      map((colUser: ColUser) => {
        if (colUser) {
          localStorage.setItem('colUser', JSON.stringify(colUser));
          this.currentColUserSource.next(colUser);
          this.colUserType = colUser.colUserType;
        }
        // return colUser;
      })
    );
  }

  setCurrentColUser(colUser: ColUser) {
    this.currentColUserSource.next(colUser);
    this.colUserType = colUser.colUserType;
  }

  logout() {
    localStorage.removeItem('colUser');
    localStorage.removeItem('loginStatus');
    this.currentColUserSource.next(null);
  }
}
