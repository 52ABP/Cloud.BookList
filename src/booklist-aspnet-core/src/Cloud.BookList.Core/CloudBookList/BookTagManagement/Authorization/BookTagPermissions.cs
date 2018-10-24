

namespace Cloud.BookList.CloudBookList.BookTagManagement.Authorization
{
	/// <summary>
    /// 定义系统的权限名称的字符串常量。
    /// <see cref="BookTagAuthorizationProvider" />中对权限的定义.
    ///</summary>
	public static  class BookTagPermissions
	{
		/// <summary>
		/// BookTag权限节点
		///</summary>
		public const string Node = "Pages.BookTag";

		/// <summary>
		/// BookTag查询授权
		///</summary>
		public const string Query = "Pages.BookTag.Query";

		/// <summary>
		/// BookTag创建权限
		///</summary>
		public const string Create = "Pages.BookTag.Create";

		/// <summary>
		/// BookTag修改权限
		///</summary>
		public const string Edit = "Pages.BookTag.Edit";

		/// <summary>
		/// BookTag删除权限
		///</summary>
		public const string Delete = "Pages.BookTag.Delete";

        /// <summary>
		/// BookTag批量删除权限
		///</summary>
		public const string BatchDelete = "Pages.BookTag.BatchDelete";

		/// <summary>
		/// BookTag导出Excel
		///</summary>
		public const string ExportExcel="Pages.BookTag.ExportExcel";

		 
		 
         
    }

}

