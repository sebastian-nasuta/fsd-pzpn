import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { MainComponent } from './main/main.component';
import { LayoutModule } from './layout/layout.module';
import { PlayersModule } from './players/players.module';
import { TeamsModule } from './teams/teams.module';
import { routes } from './app.router';

@NgModule({
  declarations: [
    MainComponent
  ],
  imports: [
    BrowserModule,
    ReactiveFormsModule,
    RouterModule.forRoot(routes),
    LayoutModule,
    PlayersModule,
    TeamsModule
  ],
  providers: [],
  bootstrap: [MainComponent]
})
export class AppModule { }
