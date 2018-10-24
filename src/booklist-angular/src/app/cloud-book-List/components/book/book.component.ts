import { Component, OnInit, Output, EventEmitter, Input, ViewChild, Injector } from '@angular/core';
import { AppComponentBase } from '@shared/component-base/app-component-base';
import { NzSelectComponent } from 'ng-zorro-antd';
import { BookTagServiceProxy, CreateOrUpdateBookTagInput, BookTagEditDto } from '@shared/service-proxies/service-proxies';

@Component({
  selector: 'app-book',
  templateUrl: './book.component.html',
  styles: []
})
export class BookComponent extends AppComponentBase implements OnInit {

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
    injector: Injector
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

  seachValueClear(): void {
    const self = this;
    setTimeout(() => {
      self.select.searchValue = '';
      self.seachValue = '';
    }, 100);
  }

}
