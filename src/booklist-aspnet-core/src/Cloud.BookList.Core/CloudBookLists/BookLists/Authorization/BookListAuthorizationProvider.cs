

using System.Linq;
using Abp.Authorization;
using Abp.Configuration.Startup;
using Abp.Localization;
using Cloud.BookList.Authorization;

namespace Cloud.BookList.CloudBookList.BookListManagement.Authorization
{
    /// <summary>
    /// 权限配置都在这里。
    /// 给权限默认设置服务
    /// See <see cref="BookListPermissions" /> for all permission names. BookList
    ///</summary>
    public class BookListAuthorizationProvider : AuthorizationProvider
    {
        private readonly bool _isMultiTenancyEnabled;

        public BookListAuthorizationProvider(bool isMultiTenancyEnabled)
        {
            _isMultiTenancyEnabled = isMultiTenancyEnabled;
        }

        public BookListAuthorizationProvider(IMultiTenancyConfig multiTenancyConfig)
        {
            _isMultiTenancyEnabled = multiTenancyConfig.IsEnabled;
        }

        public override void SetPermissions(IPermissionDefinitionContext context)
		{
			// 在这里配置了BookList 的权限。
			var pages = context.GetPermissionOrNull(AppLtmPermissions.Pages) ?? context.CreatePermission(AppLtmPermissions.Pages, L("Pages"));

			var administration = pages.Children.FirstOrDefault(p => p.Name == AppLtmPermissions.Pages_Administration) ?? pages.CreateChildPermission(AppLtmPermissions.Pages_Administration, L("Administration"));

			var entityPermission = administration.CreateChildPermission(BookListPermissions.Node , L("BookList"));
			entityPermission.CreateChildPermission(BookListPermissions.Query, L("QueryBookList"));
			entityPermission.CreateChildPermission(BookListPermissions.Create, L("CreateBookList"));
			entityPermission.CreateChildPermission(BookListPermissions.Edit, L("EditBookList"));
			entityPermission.CreateChildPermission(BookListPermissions.Delete, L("DeleteBookList"));
			entityPermission.CreateChildPermission(BookListPermissions.BatchDelete, L("BatchDeleteBookList"));
			//entityPermission.CreateChildPermission(BookListPermissions.ExportExcel, L("ExportExcelBookList"));



			 
			 
			 
		}

		private static ILocalizableString L(string name)
		{
			return new LocalizableString(name, BookListConsts.LocalizationSourceName);
		}
    }
}