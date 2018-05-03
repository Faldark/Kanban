import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import { Cards } from '../entities/cards';
import { Card } from '../entities/card';

@Injectable()
export class CardsService {
  private _cardsUrl = 'http://localhost:19489/api/cards';

  constructor(private _http: HttpClient ) { }

  getCardsByBoardId(id: number) : Observable<Cards> {
    return this._http.get<Cards>(this._cardsUrl + "/" + id)
  }
  moveCard(id: number, card: Card) : Observable<any> {
    return this._http.put(this._cardsUrl + "/" + id + "/move", card, { headers: new HttpHeaders({ 'Content-Type': 'application/json'}),
    responseType: 'text'});
  }
  addCard(card: Card) :Observable<any> {
    return this._http.post(this._cardsUrl, card);
  }
}
