import { Component, OnInit, Injector, Input } from '@angular/core';
import { ModalComponentBase } from '@shared/component-base/modal-component-base';

@Component({
    selector: 'app-img-show',
    template: `
    <img [src]="imgUrl" style="width:100%;height:100%;margin-top: 20px;" />
    `,
    styles: []
})
export class ImgShowComponent extends ModalComponentBase {

    imgUrl: string = '';
    constructor(
        injector: Injector,
    ) {
        super(injector);
    }
}
