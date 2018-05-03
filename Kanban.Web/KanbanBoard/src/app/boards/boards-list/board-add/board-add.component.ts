import { Component, OnInit,EventEmitter, Output } from '@angular/core';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { Board } from '../../../entities/board';
import { BoardsService } from '../../../services/boards.service';
import { ActivatedRoute, Router } from '@angular/router';
import { BoardsListComponent } from '../boards-list.component';

@Component({
  selector: 'app-board-add',
  templateUrl: './board-add.component.html',
  styleUrls: ['./board-add.component.css']
})
export class BoardAddComponent implements OnInit {
  board: Board = new Board();
  constructor(public activeModal: NgbActiveModal, private _boardService: BoardsService, private _router: Router) { }

  ngOnInit() {
  }

  onSubmit() {
    this._boardService.addBoard(this.board)
     .subscribe(() => this.activeModal.close('OK'), 
      err => console.log(err));
  }
}
