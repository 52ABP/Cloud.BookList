import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CloudBookListRoutingModule } from './cloud-book-list-routing.module';

import { HttpClientModule } from '@angular/common/http';
import { SharedModule } from '@shared/shared.module';

import { AbpModule, LocalizationService } from '@yoyo/abp';
import { TitleService } from '@yoyo/theme';

import { BookTagsComponent } from './book-tag-management/book-tags.component';
import { CreateOrEditBookTagComponent } from './book-tag-management/create-or-edit-book-tag/create-or-edit-book-tag.component';
import { BooksComponent } from './books-management/books.component';
import { CreateOrEditBookComponent } from './books-management/create-or-edit-book/create-or-edit-book.component';
import { ImgShowComponent } from './components/img-show/img-show.component';
import { BookTagComponent } from './components/book-tag/book-tag.component';


@NgModule({
  imports: [
    CommonModule,
    HttpClientModule,
    SharedModule,
    AbpModule,
    CloudBookListRoutingModule,
  ],
  declarations: [
    BookTagsComponent,
    CreateOrEditBookTagComponent,
    //
    BooksComponent,
    CreateOrEditBookComponent,
    ImgShowComponent,
    BookTagComponent,
  ],
  entryComponents: [
    BookTagsComponent,
    CreateOrEditBookTagComponent,
    BooksComponent,
    CreateOrEditBookComponent,
    ImgShowComponent,
  ],
  providers: [
    LocalizationService,
    TitleService
  ],
})
export class CloudBookListModule { }
