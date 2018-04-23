import { Component, OnInit } from '@angular/core';
import { BoardsService } from '../../services/boards.service';
import { Boards } from '../../entities/boards';
import { Board } from '../../entities/board';

@Component({
  selector: 'app-boards-list',
  templateUrl: './boards-list.component.html',
  styleUrls: ['./boards-list.component.css']
})
export class BoardsListComponent implements OnInit {

  constructor(private _boardsService: BoardsService) { }

  // boardsList: Board[] = new Array<Board>();
  boardsList: Boards = new Boards;
  // testArray: Array<{id: number, title:string}>;

  ngOnInit() {
    this.getAllBoards();
    // this.testArray = [
    //   {id: 1, title: 'TestTitle'}
    // ];
  }

  getAllBoards() : void {
    this._boardsService.getAllBoards().subscribe(
      boards => this.boardsList = boards
    );
    // this.boardsList.boards = [
    //   {id: 1, title: 'test', description: 'testDescription' }
    // ];
    
  }

}
