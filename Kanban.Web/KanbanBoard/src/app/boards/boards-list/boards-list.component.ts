import { Component, OnInit } from '@angular/core';
import { BoardsService } from '../../services/boards.service';
import { Boards } from '../../entities/boards';
import { Board } from '../../entities/board';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { BoardAddComponent } from './board-add/board-add.component';

@Component({
  selector: 'app-boards-list',
  templateUrl: './boards-list.component.html',
  styleUrls: ['./boards-list.component.css']
})
export class BoardsListComponent implements OnInit {
  closeResult: boolean;
  constructor(private _boardsService: BoardsService, private modalService: NgbModal) { }

  boardsList: Boards = new Boards;

  ngOnInit() {
    this.getAllBoards();
  
  }
  open() {
    const modalRef = this.modalService.open(BoardAddComponent).result.then((result) => {this.closeResult= result == 'OK' ? true: false; if(this.closeResult) {this.ngOnInit()} });
    
  }

  getAllBoards() : void {
    this._boardsService.getAllBoards().subscribe(
      boards => this.boardsList = boards
    );
   
    
  }
  deleteBoard(id: number) : void {
    this._boardsService.deleteBoard(id).subscribe(
      () => this.ngOnInit()
    );
  }

}
