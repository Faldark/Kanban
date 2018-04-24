import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BoardsComponent } from './boards.component';
import { BoardsListComponent } from './boards-list/boards-list.component';
import { AppRoutingModule } from '../app-routing.module';
import { BoardsRoutingModule } from './boards-routing.module';
import { BoardsService } from '../services/boards.service';
import {NgbModule} from '@ng-bootstrap/ng-bootstrap';
@NgModule({
  imports: [
    CommonModule,
    BoardsRoutingModule,
    NgbModule
  ],
  declarations: [BoardsComponent, BoardsListComponent],
  providers: [BoardsService]
})
export class BoardsModule { }
