import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ColMember } from '../_models/colMember';
import { ColMembersService } from '../_services/col-members.service';

@Component({
  selector: 'app-college-detail',
  templateUrl: './college-detail.component.html',
  styleUrls: ['./college-detail.component.css'],
})
export class CollegeDetailComponent implements OnInit {
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
