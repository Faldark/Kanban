import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Boards } from '../entities/boards';
import { Observable } from 'rxjs/Observable';
import { Board } from '../entities/board';

@Injectable()
export class BoardsService {
  private _boardsUrl = 'http://localhost:19489/api/boards';

  constructor(private _http: HttpClient) { }

  getAllBoards(): Observable<Boards> {
    return this._http.get<Boards>(this._boardsUrl)
  }

}
