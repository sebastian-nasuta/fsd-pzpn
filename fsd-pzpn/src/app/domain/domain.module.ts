import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PlayerService } from './players/player.service';
import { HttpModule } from '@angular/http';

@NgModule({
  imports: [
    CommonModule,
    HttpModule
  ],
  declarations: [],
  providers: [
    PlayerService
  ]
})
export class DomainModule { }
