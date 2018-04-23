import { NgModule }              from '@angular/core';
import { RouterModule, Routes }  from '@angular/router';
import { BoardsListComponent } from './boards-list/boards-list.component';


const boardsRoutes: Routes = [
    {
        path: '',
        component: BoardsListComponent
    }
    // {
    //     path: '/id',
    //     component: 
    // }
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