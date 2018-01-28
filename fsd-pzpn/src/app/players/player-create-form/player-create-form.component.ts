import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { PlayerService } from '../../domain/players/player.service';
import { Player } from '../../domain/players/player';

@Component({
  selector: 'fsd-player-create-form',
  templateUrl: './player-create-form.component.html',
  styleUrls: ['./player-create-form.component.css']
})
export class PlayerCreateFormComponent implements OnInit {
  playerForm: FormGroup;

  constructor(private playerService: PlayerService) { }

  ngOnInit() {
    this.playerForm = new FormGroup({
      firstName: new FormControl('', [Validators.required], []),
      lastName: new FormControl('', [Validators.required], []),
      number: new FormControl('0', [], []),
    });
  }

  onFormSubmit(): void {
    const newPlayer = this.playerForm.value as Player;
    this.playerService.addNewPlayer(newPlayer);
    this.playerForm.reset();
  }
}
