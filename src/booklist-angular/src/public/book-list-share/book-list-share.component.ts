import { Component, OnInit, Injector } from '@angular/core';
import { AppComponentBase } from '@shared/component-base/app-component-base';
import { ActivatedRoute } from '@angular/router';
import { BookListServiceProxy, BookListShareDto } from '@shared/service-proxies/service-proxies';
import { AppConsts } from '@shared/AppConsts';
import { ShareQrcodeComponent } from '@shared/components/share-qrcode/share-qrcode.component';

@Component({
  selector: 'app-book-list-share',
  templateUrl: './book-list-share.component.html',
  styles: [
    './book-list-share.component.less'
  ]
})
export class BookListShareComponent extends AppComponentBase
  implements OnInit {

  id: number;
  tid: number;

  loading: boolean = false;

  entity: BookListShareDto;

  constructor(
    injector: Injector,
    private _activatedRoute: ActivatedRoute,
    private _bookListService: BookListServiceProxy,
  ) {
    super(injector);
  }
  ngOnInit() {
    this.tid = this._activatedRoute.snapshot.params["tid"];
    this.id = this._activatedRoute.snapshot.params["id"];


    // 查询数据
    if (this.tid && this.id) {
      this._bookListService.getShare(this.id, this.tid)
        .finally(() => {
          this.loading = false;
        }).subscribe((result) => {
          this.entity = result;
        });
    }

  }


  shareQrCode(id: string) {
    let url = AppConsts.appBaseUrl + "/public/book-list-share;tid=" + this.tid + ";id=" + this.id;
    this.modalHelper.open(ShareQrcodeComponent, { qrcodeUrl: url }, "sm")
      .subscribe(() => {

      });
  }
}
