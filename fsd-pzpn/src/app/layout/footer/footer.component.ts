import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'fsd-footer',
  templateUrl: './footer.component.html',
  styleUrls: ['./footer.component.css']
})
export class FooterComponent implements OnInit {
  year: number;
  author: string;

  ngOnInit() {
    this.year = new Date().getFullYear();
    this.author = "Kamil Wołczyk";
  }

}
