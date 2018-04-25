import { NgModule }              from '@angular/core';
import { RouterModule, Routes }  from '@angular/router';
import { BoardsListComponent } from './boards-list/boards-list.component';
import { BoardKanbanComponent } from './board-kanban/board-kanban.component';
import { BoardsComponent } from './boards.component';


const boardsRoutes: Routes = [
{
    path: '',
    component: BoardsComponent,
    children: [{
        path: '',
        component: BoardsListComponent
    },
    {
        path: ':id',
        component: BoardKanbanComponent
    }]
}
    
    
]

@NgModule({
    imports: [
        RouterModule.forChild(
            boardsRoutes
        )

    ],
    exports: [
        RouterModule
    ],
    providers: []
})
export class BoardsRoutingModule {}