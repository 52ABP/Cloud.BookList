
import { Component, OnInit, Injector, Input, ViewChild, AfterViewInit } from '@angular/core';
import { ModalComponentBase } from '@shared/component-base/modal-component-base';
import { CreateOrUpdateBookInput, BookEditDto, BookServiceProxy } from '@shared/service-proxies/service-proxies';
import { Validators, AbstractControl, FormControl } from '@angular/forms';

@Component({
  selector: 'create-or-edit-book',
  templateUrl: './create-or-edit-book.component.html',
  styleUrls: [
    'create-or-edit-book.component.less'
  ],
})

export class CreateOrEditBookComponent
  extends ModalComponentBase
  implements OnInit {
  /**
  * 编辑时DTO的id
  */
  id: any;

  entity: BookEditDto = new BookEditDto();

  tags: any; // 标签列表数据
  selectTags: any = [];
  /**
  * 初始化的构造函数
  */
  constructor(
    injector: Injector,
    private _bookService: BookServiceProxy
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
    this._bookService.getForEdit(this.id).subscribe(result => {
      this.entity = result.book;
      this.tags = result.bookTags;
    });
  }

  /**
  * 保存方法,提交form表单
  */
  submitForm(): void {
    const input = new CreateOrUpdateBookInput();
    input.book = this.entity;
    input.tagIds = this.selectTags;

    this.saving = true;

    this._bookService.createOrUpdate(input)
      .finally(() => (this.saving = false))
      .subscribe(() => {
        this.notify.success(this.l('SavedSuccessfully'));
        this.success(true);
      });
  }

  tagSelectChange(data: any[]) {
    this.selectTags = data;
  }
}
