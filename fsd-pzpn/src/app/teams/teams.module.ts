import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TeamsListComponent } from './teams-list/teams-list.component';

@NgModule({
  imports: [
    CommonModule
  ],
  declarations: [
    TeamsListComponent
  ],
  exports: [
    TeamsListComponent
  ]
})
export class TeamsModule { }
