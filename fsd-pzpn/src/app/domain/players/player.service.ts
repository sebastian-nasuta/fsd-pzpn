import { Injectable } from '@angular/core';
import { Player } from './player';
import { Http } from '@angular/http';
import 'rxjs/add/operator/map';
import { element } from 'protractor';

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
    this.players.length = 0;
  }

  addNewPlayer(player: Player): void {
    this.http.post('api/players', {}, {
      params: {
        firstName: player.firstName,
        lastName: player.lastName,
        number: player.number
      }
    }).subscribe();
    this.loadPlayers();
  }

  removePlayer(player: Player): void {
    this.http.delete('api/players', {
      params: {
        id: player.id
      }
    }).subscribe();
    this.loadPlayers();
  }
}
