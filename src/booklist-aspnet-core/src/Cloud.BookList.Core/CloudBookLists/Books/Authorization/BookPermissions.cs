

namespace Cloud.BookList.CloudBookList.BookManagement.Authorization
{
	/// <summary>
    /// 定义系统的权限名称的字符串常量。
    /// <see cref="BookAuthorizationProvider" />中对权限的定义.
    ///</summary>
	public static  class BookPermissions
	{
		/// <summary>
		/// Book权限节点
		///</summary>
		public const string Node = "Pages.Book";

		/// <summary>
		/// Book查询授权
		///</summary>
		public const string Query = "Pages.Book.Query";

		/// <summary>
		/// Book创建权限
		///</summary>
		public const string Create = "Pages.Book.Create";

		/// <summary>
		/// Book修改权限
		///</summary>
		public const string Edit = "Pages.Book.Edit";

		/// <summary>
		/// Book删除权限
		///</summary>
		public const string Delete = "Pages.Book.Delete";

        /// <summary>
		/// Book批量删除权限
		///</summary>
		public const string BatchDelete = "Pages.Book.BatchDelete";

		/// <summary>
		/// Book导出Excel
		///</summary>
		public const string ExportExcel="Pages.Book.ExportExcel";

		 
		 
         
    }

}

