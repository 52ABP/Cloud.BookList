
import { Component, Injector, OnInit } from '@angular/core';
import * as _ from 'lodash';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { PagedListingComponentBase, PagedRequestDto } from "@shared/component-base/paged-listing-component-base";
import { BookListServiceProxy, PagedResultDtoOfBookListListDto, BookListListDto } from '@shared/service-proxies/service-proxies';
import { CreateOrEditBookListComponent } from './create-or-edit-book-list/create-or-edit-book-list.component';
import { AppConsts } from '@shared/AppConsts';
import { ShareQrcodeComponent } from '@shared/components/share-qrcode/share-qrcode.component';
//import { FileDownloadService } from '@shared/utils/file-download.service';

@Component({
	templateUrl: './book-lists.component.html',
	styleUrls: ['./book-lists.component.less'],
	animations: [appModuleAnimation()],
})


export class BookListsComponent extends PagedListingComponentBase<BookListListDto>
	implements OnInit {

	constructor(
		injector: Injector,
		private _bookListService: BookListServiceProxy
	) {
		super(injector);
	}

	/**
	* 获取后端数据列表信息
	* @param request 请求的数据的dto 请求必需参数 skipCount: number; maxResultCount: number;
	* @param pageNumber 当前页码
	* @param finishedCallback 完成后回调函数
	*/
	protected fetchDataList(request: PagedRequestDto, pageNumber: number, finishedCallback: Function): void {
		this._bookListService.getAll(
			this.filterText,
			request.sorting,
			request.maxResultCount,
			request.skipCount,
		).finally(() => {
			finishedCallback();
		}).subscribe(result => {
			this.dataList = result.items;

		});
	}

	/**
	* 新增或编辑DTO信息
	* @param id 当前DTO的Id
	*/
	createOrEdit(id?: number): void {
		this.modalHelper.static(CreateOrEditBookListComponent, { id: id })
			.subscribe(result => {
				if (result) {
					this.refresh();
				}
			});
	}


	/**
	* 删除功能
	* @param entity 角色的实体信息
	*/
	delete(entity: BookListListDto): void {
		this._bookListService.delete(entity.id)
			.subscribe(() => {
				/**
				* 刷新表格数据并跳转到第一页（`pageNumber = 1`）
				*/
				this.refreshGoFirstPage();
				this.notify.success(this.l('SuccessfullyDeleted'));
			});
	}

	/**
	* 批量删除
	*/
	batchDelete(): void {
		const selectCount = this.selectedDataItems.length;
		if (selectCount <= 0) {
			abp.message.warn(this.l('PleaseSelectAtLeastOneItem'));
			return;
		}

		abp.message.confirm(
			this.l('ConfirmDeleteXItemsWarningMessage', selectCount),
			res => {
				if (res) {
					const ids = _.map(this.selectedDataItems, 'id');
					this._bookListService.batchDelete(ids).subscribe(() => {
						this.refreshGoFirstPage();
						this.notify.success(this.l('SuccessfullyDeleted'));
					});
				}
			},
		);
	}


	/**
	* 导出为Excel表
	*/
	exportToExcel(): void {
		abp.message.error('功能开发中！！！！');
	}
	shareQrCode(id: string, tid: string) {
		let url = AppConsts.appBaseUrl + "/public/book-list-share;tid=" + tid + ";id=" + id;
		this.modalHelper.open(ShareQrcodeComponent, { qrcodeUrl: url }, "sm")
			.subscribe(() => {

			});
	}
}

