import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ColMember } from '../_models/colMember';
import { ColMembersService } from '../_services/col-members.service';

@Component({
  selector: 'app-hs-detail',
  templateUrl: './hs-detail.component.html',
  styleUrls: ['./hs-detail.component.css'],
})
export class HsDetailComponent implements OnInit {
  colMember: ColMember;

  constructor(
    private colMemberService: ColMembersService,
    private route: ActivatedRoute
  ) {}

  ngOnInit(): void {
    this.loadColMember();
  }

  loadColMember() {
    this.colMemberService
      .getColMember(this.route.snapshot.paramMap.get('colusername'))
      .subscribe((colMember) => {
        this.colMember = colMember;
        console.log(colMember.colUserName);
      });
  }
}
