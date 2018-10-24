using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Cloud.BookList.Controllers
{
    public abstract class BookListControllerBase: AbpController
    {
        protected BookListControllerBase()
        {
            LocalizationSourceName = BookListConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
