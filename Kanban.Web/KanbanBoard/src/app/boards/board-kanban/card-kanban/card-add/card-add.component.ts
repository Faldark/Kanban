import { Component, OnInit } from '@angular/core';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { CardsService } from '../../../../services/cards.service';
import { Card } from '../../../../entities/card';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-card-add',
  templateUrl: './card-add.component.html',
  styleUrls: ['./card-add.component.css']
})
export class CardAddComponent implements OnInit {
  card : Card = new Card() ;
  boardId: number;
  constructor(public activeModal: NgbActiveModal, private _cardService: CardsService, private _route: ActivatedRoute) { }

  ngOnInit() {
     
  }

  onSubmit() {
    this.card.statusId = 1;
    
    this._cardService.addCard(this.card).subscribe(() => this.activeModal.close('OK') );
  }

}
