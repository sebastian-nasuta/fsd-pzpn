import { Component, OnInit } from '@angular/core';
import { PlayerService } from '../../domain/players/player.service';
import { Player } from '../../domain/players/player';
import { FormGroup, FormControl } from '@angular/forms';

@Component({
  selector: 'fsd-players-list',
  templateUrl: './players-list.component.html',
  styleUrls: ['./players-list.component.css']
})
export class PlayersListComponent implements OnInit {
  players: Player[];
  query: FormGroup;

  constructor(private playerService: PlayerService) { }

  ngOnInit() {
    this.query = new FormGroup({
      firstName: new FormControl('', [], []),
      lastName: new FormControl('', [], []),
    });
    this.players = this.playerService.players;
  }

  remove(player: Player) {
    this.playerService.removePlayer(player);
  }

  search() {
    const query = this.query.value;
    this.playerService.loadPlayers(query.firstName, query.lastName);
  }
}
