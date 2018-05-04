import { Component, OnInit } from '@angular/core';
import { BoardsService } from '../../services/boards.service';
import { Board } from '../../entities/board';
import { ActivatedRoute } from '@angular/router';
import { Cards } from '../../entities/cards';
import { Statuses } from '../../entities/statuses';
import { CardsService } from '../../services/cards.service';
import { Card } from '../../entities/card';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { CardAddComponent } from './card-kanban/card-add/card-add.component';

@Component({
  selector: 'app-board-kanban',
  templateUrl: './board-kanban.component.html',
  styleUrls: ['./board-kanban.component.css']
})
export class BoardKanbanComponent implements OnInit {
  closeResult : boolean;
  constructor(private _boardsService: BoardsService, private _route: ActivatedRoute, private _cardsService : CardsService, private _modalService: NgbModal) { }


  board : Board = new Board;
  statusesList: Statuses = new Statuses;
  cardsList: Cards = new Cards;
  boardId : number;
  
  ngOnInit() {
    const id = +this._route.snapshot.paramMap.get('id');
    this.boardId = id;
    this.getBoardById(id);
    this.getCardsByBoardId(id);
    this.getStatusesByBoard(id);
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

  onDeleteDrop(e:any) {
    this._cardsService.deleteCard(e.dragData.id).subscribe(
      () => this.getCardsByBoardId(this.boardId)
    );
  }

  openCardModal() {
    const ModalRef = this._modalService.open(CardAddComponent);
    ModalRef.componentInstance.card.boardId = this.boardId;
    ModalRef.result.then((result) => {this.closeResult = result == 'OK' ? true: false; if(this.closeResult) {this.ngOnInit()} });

    
  }

  
  
}
