import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CloudBookListRoutingModule } from './cloud-book-list-routing.module';

import { HttpClientModule } from '@angular/common/http';
import { SharedModule } from '@shared/shared.module';

import { AbpModule, LocalizationService } from '@yoyo/abp';
import { TitleService } from '@yoyo/theme';

import { BookTagsComponent } from './book-tag-management/book-tags.component';
import { CreateOrEditBookTagComponent } from './book-tag-management/create-or-edit-book-tag/create-or-edit-book-tag.component';


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

  ],
  entryComponents: [
    BookTagsComponent,
    CreateOrEditBookTagComponent,
  ],
  providers: [
    LocalizationService,
    TitleService
  ],
})
export class CloudBookListModule { }
