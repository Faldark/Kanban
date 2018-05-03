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
import { NgDragDropModule } from 'ng-drag-drop';
import { BoardAddComponent } from './boards-list/board-add/board-add.component';
import { FormsModule } from '@angular/forms';
import { CardAddComponent } from './board-kanban/card-kanban/card-add/card-add.component';
@NgModule({
  imports: [
    CommonModule,
    BoardsRoutingModule,
    NgbModule,
    NgDragDropModule.forRoot(),
    FormsModule
  ],
  declarations: [BoardsComponent, BoardsListComponent, BoardKanbanComponent, CardKanbanComponent, BoardAddComponent, CardAddComponent],
  providers: [BoardsService,
  CardsService],
  bootstrap: [BoardAddComponent, CardAddComponent]

})
export class BoardsModule { }
