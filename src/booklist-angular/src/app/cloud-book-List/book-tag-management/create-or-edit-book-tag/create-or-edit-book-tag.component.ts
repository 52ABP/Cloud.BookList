
import { Component, OnInit, Injector, Input, ViewChild, AfterViewInit } from '@angular/core';
import { ModalComponentBase } from '@shared/component-base/modal-component-base';
import { CreateOrUpdateBookTagInput, BookTagEditDto, BookTagServiceProxy } from '@shared/service-proxies/service-proxies';
import { Validators, AbstractControl, FormControl } from '@angular/forms';

@Component({
  selector: 'create-or-edit-book',
  templateUrl: './create-or-edit-book-tag.component.html',
  styleUrls: [
    'create-or-edit-book-tag.component.less'
  ],
})

export class CreateOrEditBookTagComponent
  extends ModalComponentBase
  implements OnInit {
  /**
  * 编辑时DTO的id
  */
  id: any;

  entity: BookTagEditDto = new BookTagEditDto();

  /**
  * 初始化的构造函数
  */
  constructor(
    injector: Injector,
    private _bookTagService: BookTagServiceProxy
  ) {
    super(injector);
  }

  ngOnInit(): void {
    this.init();
  }


  /**
  * 初始化方法
  */
  init(): void {
    this._bookTagService.getForEdit(this.id).subscribe(result => {
      this.entity = result.bookTag;
    });
  }

  /**
  * 保存方法,提交form表单
  */
  submitForm(): void {
    const input = new CreateOrUpdateBookTagInput();
    input.bookTag = this.entity;

    this.saving = true;

    this._bookTagService.createOrUpdate(input)
      .finally(() => (this.saving = false))
      .subscribe(() => {
        this.notify.success(this.l('SavedSuccessfully'));
        this.success(true);
      });
  }

  // =====End===
}
