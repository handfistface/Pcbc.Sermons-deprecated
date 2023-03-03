import { Component } from '@angular/core';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {

  public baseUrl: string = "https://www.peterscreekbaptist.com";
  public isMinistriesExpanded: boolean = false;
  public isWhoWeAreExpanded: boolean = false;

  toggleIsMinistriesExpanded() {
    this.isMinistriesExpanded = !this.isMinistriesExpanded;
  }

  public toggleMinistries() {
    this.isMinistriesExpanded = !this.isMinistriesExpanded;
  }

  public toggleIsWhoWeAre() {
    this.isWhoWeAreExpanded = !this.isWhoWeAreExpanded;
    console.log(`is who we are ${this.isWhoWeAreExpanded}`);
  }

}
