import { Component, OnInit, Output, EventEmitter, Input, ViewChild, Injector } from '@angular/core';
import { AppComponentBase } from '@shared/component-base/app-component-base';
import { NzSelectComponent } from 'ng-zorro-antd';
import { BookTagServiceProxy, CreateOrUpdateBookTagInput, BookTagEditDto } from '@shared/service-proxies/service-proxies';

@Component({
  selector: 'app-book-tag',
  templateUrl: './book-tag.component.html',
  styles: []
})
export class BookTagComponent extends AppComponentBase implements OnInit {

  @ViewChild('select') select: NzSelectComponent;

  @Output()
  selectedDataChange = new EventEmitter();

  @Input()
  tagSourceDataChange = new EventEmitter();
  @Input()
  set tagSourceData(value: any) {
    this.loading = true;
    if (value) {
      this.listOfOption = value;
      this.multipleValue = [];
      this.listOfOption.forEach(item => {
        if (item.isSelected) {
          this.multipleValue.push(item.id);
        }
      })
    }
    if (this.selectedDataChange) {
      this.selectedDataChange.emit(this.multipleValue);
    }
    this.loading = false;
  }


  constructor(
    injector: Injector,
    private _bookTagService: BookTagServiceProxy
  ) {
    super(injector);
  }

  isOpen: boolean = false;
  loading: boolean = true;
  listOfOption = [];
  size = 'default';
  multipleValue = [];
  seachValue: string = '';

  ngOnInit() {

  }

  modelChange(): void {
    if (this.selectedDataChange) {
      this.selectedDataChange.emit(this.multipleValue);
    }
  }

  seachValueChange(e): void {
    this.seachValue = e;
  }

  handleInputConfirm(e): void {
    {
      // 先过滤现有列表是否存在
      let exist = false;
      for (let index = 0; index < this.listOfOption.length; index++) {
        let item = this.listOfOption[index];
        if (item.name === this.seachValue || item.name.indexOf(this.seachValue) != -1) {
          exist = true;
          break;
        }
      }
      if (exist) {
        this.seachValueClear();
        return;
      }
    }

    // 校验是否有创建标签的权限
    if (this.permission.isGranted("Pages.BookTag.Create") && this.appSession.tenantId) {
      // 如果现有列表不存在，那么存到服务器
      this.loading = true;
      let input: CreateOrUpdateBookTagInput = new CreateOrUpdateBookTagInput();
      let entityDto: BookTagEditDto = new BookTagEditDto();
      entityDto.name = this.seachValue;
      input.bookTag = entityDto;
      this._bookTagService.create(input)
        .finally(() => {
          this.loading = false;
          this.seachValueClear();
        }).subscribe((res) => {
          let exist = false;
          for (let index = 0; index < this.listOfOption.length; index++) {
            let item = this.listOfOption[index];
            if (item.id === res.id) {
              exist = true;
              break;
            }
          }
          if (!exist) {
            this.listOfOption.push(res);
          }
          this.multipleValue.push(res.id);
        });
    }
  }

  seachValueClear(): void {
    const self = this;
    setTimeout(() => {
      self.select.searchValue = '';
      self.seachValue = '';
    }, 100);
  }

}
