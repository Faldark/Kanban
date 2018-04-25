import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BoardsComponent } from './boards.component';
import { BoardsListComponent } from './boards-list/boards-list.component';
import { AppRoutingModule } from '../app-routing.module';
import { BoardsRoutingModule } from './boards-routing.module';
import { BoardsService } from '../services/boards.service';
import {NgbModule} from '@ng-bootstrap/ng-bootstrap';
import { BoardKanbanComponent } from './board-kanban/board-kanban.component';
import { CardKanbanComponent } from './board-kanban/card-kanban/card-kanban.component';
import { CardsService } from '../services/cards.service';
@NgModule({
  imports: [
    CommonModule,
    BoardsRoutingModule,
    NgbModule
  ],
  declarations: [BoardsComponent, BoardsListComponent, BoardKanbanComponent, CardKanbanComponent],
  providers: [BoardsService,
  CardsService]
})
export class BoardsModule { }
