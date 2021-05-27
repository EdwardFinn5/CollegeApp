import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { ColAccountService } from '../_services/col-account.service';

@Component({
  selector: 'app-hs-register',
  templateUrl: './hs-register.component.html',
  styleUrls: ['./hs-register.component.css'],
})
export class HsRegisterComponent implements OnInit {
  @Output() cancelHsRegister = new EventEmitter();
  model: any = {};

  constructor(
    private colAccountService: ColAccountService,
    private toastr: ToastrService,
    private router: Router
  ) {}

  ngOnInit(): void {}

  hsRegister() {
    this.colAccountService.hsRegister(this.model).subscribe(
      (response) => {
        console.log(response);
        this.cancel();
        this.router.navigateByUrl('/members');
      },
      (error) => {
        console.log(error);
        this.toastr.error(error.error);
      }
    );
  }

  cancel() {
    console.log('cancelled');
    this.cancelHsRegister.emit(false);
    this.router.navigateByUrl('/');
  }
}
