import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { BookTagsComponent } from './book-tag-management/book-tags.component';
import { BooksComponent } from './books-management/books.component';


const routes: Routes = [
  {
    path: '',
    children: [
      { path: 'book-tags', component: BookTagsComponent },
      { path: 'books', component: BooksComponent },
    ],
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CloudBookListRoutingModule { }
