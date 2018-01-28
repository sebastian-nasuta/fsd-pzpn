import { Injectable } from '@angular/core';
import { Player } from './player';
import { Http } from '@angular/http';
import 'rxjs/add/operator/map';

@Injectable()
export class PlayerService {
  players: Player[];

  constructor(private http: Http) {
    this.players = [];
  }

  loadPlayers(firstName?: string, lastName?: string, number?: number) {
    this.clear();
    this.http.get('api/players', {
      params: {
        firstName: firstName,
        lastName: lastName,
        number: number
      }
    }).map(response => response.json())
      .subscribe(data => {
        data.forEach(element => {
          this.players.push(element);
        });
      });
  }

  private clear() {
    while (this.players.length > 0) {
      this.players.pop();
    }
  }

  addNewPlayer(player: Player): void {
    this.players.push(player);
  }

  removePlayer(player: Player): void {
    const index = this.players.indexOf(player);
    this.players = this.players.splice(index, 1);
  }
}
