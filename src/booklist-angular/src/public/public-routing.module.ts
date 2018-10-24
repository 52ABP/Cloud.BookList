import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { BookListShareComponent } from './book-list-share/book-list-share.component';
import { PublicComponent } from './public.component';

const routes: Routes = [
  {
    path: '',
    component: PublicComponent,
    children: [
      { path: 'book-list-share', component: BookListShareComponent }
    ],
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PublicRoutingModule { }
