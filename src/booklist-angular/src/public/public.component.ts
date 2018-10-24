import { Component, OnInit, Injector } from '@angular/core';
import { AppComponentBase } from '@shared/component-base/app-component-base';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-public',
  templateUrl: './public.component.html',
  styleUrls: [
    './public.component.less'
  ]
})
export class PublicComponent extends AppComponentBase
  implements OnInit {

  id: number;

  constructor(
    injector: Injector,
  ) {
    super(injector);
  }
  ngOnInit() {

  }

}
