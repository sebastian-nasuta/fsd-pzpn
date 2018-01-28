import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PlayerCreateFormComponent } from './player-create-form.component';

describe('PlayerCreateFormComponent', () => {
  let component: PlayerCreateFormComponent;
  let fixture: ComponentFixture<PlayerCreateFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PlayerCreateFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PlayerCreateFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
