import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { PublicRoutingModule } from './public-routing.module';
import { BookListShareComponent } from './book-list-share/book-list-share.component';
import { PublicComponent } from './public.component';
import { NgZorroAntdModule } from 'ng-zorro-antd';
import { FormsModule } from '@angular/forms';
import { HttpModule, JsonpModule } from '@angular/http';
import { AbpModule } from 'yoyo-ng-module';
import { SharedModule } from '@shared/shared.module';
import { ServiceProxyModule } from '@shared/service-proxies/service-proxy.module';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    HttpModule,
    JsonpModule,
    NgZorroAntdModule,
    AbpModule,
    SharedModule,
    ServiceProxyModule,
    PublicRoutingModule,
  ],
  declarations: [
    BookListShareComponent,
    PublicComponent
  ],
  entryComponents: [
  ]
})
export class PublicModule { }
