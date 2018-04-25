import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import { Cards } from '../entities/cards';

@Injectable()
export class CardsService {
  private _cardsUrl = 'http://localhost:19489/api/cards';

  constructor(private _http: HttpClient ) { }

  getCardsByBoardId(id: number) : Observable<Cards> {
    return this._http.get<Cards>(this._cardsUrl + "/" + id)
  }

}
