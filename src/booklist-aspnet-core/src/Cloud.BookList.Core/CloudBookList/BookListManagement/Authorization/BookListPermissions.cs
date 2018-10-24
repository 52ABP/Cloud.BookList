

namespace Cloud.BookList.CloudBookList.BookListManagement.Authorization
{
	/// <summary>
    /// 定义系统的权限名称的字符串常量。
    /// <see cref="BookListAuthorizationProvider" />中对权限的定义.
    ///</summary>
	public static  class BookListPermissions
	{
		/// <summary>
		/// BookList权限节点
		///</summary>
		public const string Node = "Pages.BookList";

		/// <summary>
		/// BookList查询授权
		///</summary>
		public const string Query = "Pages.BookList.Query";

		/// <summary>
		/// BookList创建权限
		///</summary>
		public const string Create = "Pages.BookList.Create";

		/// <summary>
		/// BookList修改权限
		///</summary>
		public const string Edit = "Pages.BookList.Edit";

		/// <summary>
		/// BookList删除权限
		///</summary>
		public const string Delete = "Pages.BookList.Delete";

        /// <summary>
		/// BookList批量删除权限
		///</summary>
		public const string BatchDelete = "Pages.BookList.BatchDelete";

		/// <summary>
		/// BookList导出Excel
		///</summary>
		public const string ExportExcel="Pages.BookList.ExportExcel";

		 
		 
         
    }

}

