import { Component, OnInit, Input } from '@angular/core';
import { Card } from '../../../entities/card';

@Component({
  selector: 'app-card-kanban',
  templateUrl: './card-kanban.component.html',
  styleUrls: ['./card-kanban.component.css']
})
export class CardKanbanComponent implements OnInit {

  @Input() card: Card;
  constructor() { }

  ngOnInit() {
  }

}
