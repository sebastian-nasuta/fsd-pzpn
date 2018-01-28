import { PlayerSectionComponent } from './players/player-section/player-section.component';
import { TeamsListComponent } from './teams/teams-list/teams-list.component';

export const routes = [
    { path: 'players', component: PlayerSectionComponent },
    { path: 'teams', component: TeamsListComponent },
    { path: '', redirectTo: 'players', pathMatch: 'full' }
];
