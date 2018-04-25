import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Boards } from '../entities/boards';
import { Observable } from 'rxjs/Observable';
import { Board } from '../entities/board';
import { Statuses } from '../entities/statuses';
import { Cards } from '../entities/cards';

@Injectable()
export class BoardsService {
  private _boardsUrl = 'http://localhost:19489/api/boards';

  constructor(private _http: HttpClient) { }

  getAllBoards(): Observable<Boards> {
    return this._http.get<Boards>(this._boardsUrl)
  }
  getBoardById(id: number): Observable<Board> {
    return this._http.get<Board>(this._boardsUrl + "/" + id)
  }

  getStatusesByBoardId(id: number):Observable<Statuses> {
    return this._http.get<Statuses>(this._boardsUrl + "/" + id + "/statuses")
  }

  getCardsByBoardId(id:number) :Observable<Cards> {
    return this._http.get<Cards>(this._boardsUrl + "/" + id + "/cards")
  }

  

}
