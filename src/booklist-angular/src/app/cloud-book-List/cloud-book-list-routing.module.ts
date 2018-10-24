import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { BookTagsComponent } from './book-tag-management/book-tags.component';


const routes: Routes = [
  {
    path: '',
    children: [
      { path: 'book-tags', component: BookTagsComponent },

    ],
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CloudBookListRoutingModule { }
