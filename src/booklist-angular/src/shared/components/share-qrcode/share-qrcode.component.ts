import { Component, OnInit, Injector } from '@angular/core';
import { ModalComponentBase } from '@shared/component-base/modal-component-base';

@Component({
  selector: 'app-share-qrcode',
  template: `
   <qr-code [value]="qrcodeUrl" [size]="256" *ngIf="qrcodeUrl" style="width:256px;;display: block;margin:0 auto;"></qr-code>
   <span>{{qrcodeUrl}}</span>
    `
})
export class ShareQrcodeComponent extends ModalComponentBase {
  qrcodeUrl: string;
  constructor(
    injector: Injector,
  ) {
    super(injector);
  }
}
