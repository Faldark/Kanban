import { Component, OnInit } from '@angular/core';
import { BoardsService } from '../../services/boards.service';
import { Board } from '../../entities/board';
import { ActivatedRoute } from '@angular/router';
import { Cards } from '../../entities/cards';
import { Statuses } from '../../entities/statuses';
import { CardsService } from '../../services/cards.service';
import { Card } from '../../entities/card';

@Component({
  selector: 'app-board-kanban',
  templateUrl: './board-kanban.component.html',
  styleUrls: ['./board-kanban.component.css']
})
export class BoardKanbanComponent implements OnInit {

  constructor(private _boardsService: BoardsService, private _route: ActivatedRoute, private _cardsService : CardsService) { }


  board : Board = new Board;
  statusesList: Statuses = new Statuses;
  cardsList: Cards = new Cards;
  
  ngOnInit() {
    const id = +this._route.snapshot.paramMap.get('id');
    this.getBoardById(id);
    this.getCardsByBoardId(id);
    this.getStatusesByBoard(id);
    // var statuses = Object.keys(Statuses);
    // this.statuses = statuses.slice(statuses.length/2);
  }

  getBoardById(id: number) : void {
    this._boardsService.getBoardById(id).subscribe(
      board => this.board = board
    );
  }

  getCardsByBoardId(id:number): void{
    this._boardsService.getCardsByBoardId(id).subscribe(
      cards => this.cardsList = cards
    );
  }

  getStatusesByBoard(id:number): void{
    this._boardsService.getStatusesByBoardId(id).subscribe(
      statuses => this.statusesList = statuses
    );
  }

  moveCard(e: any, id:number) {
    e.dragData.statusId = id;
    this._cardsService.moveCard(e.dragData.id, e.dragData).subscribe(
      responce => {console.log(responce)
      });
  }
  test(e: any) {
    console.log("OnDragStartTest");
  }_
}
