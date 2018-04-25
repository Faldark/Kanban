import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CardKanbanComponent } from './card-kanban.component';

describe('CardKanbanComponent', () => {
  let component: CardKanbanComponent;
  let fixture: ComponentFixture<CardKanbanComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CardKanbanComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CardKanbanComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
