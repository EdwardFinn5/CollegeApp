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

  constructor(private http: HttpClient) {}

  colLogin(model: any) {
    return this.http.post(this.baseUrl + 'colAccount/colLogin', model).pipe(
      map((response: ColUser) => {
        const colUser = response
        if (colUser) {
          localStorage.setItem('colUser', JSON.stringify(colUser));
          this.currentColUserSource.next(colUser);
        }
      })
    );
  }

  setCurrentColUser(colUser: ColUser) {
    this.currentColUserSource.next(colUser);
  }

  logout() {
    localStorage.removeItem('colUser');
    this.currentColUserSource.next(null);
  }
}
