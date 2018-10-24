using Microsoft.AspNetCore.Antiforgery;
using Cloud.BookList.Controllers;

namespace Cloud.BookList.Web.Host.Controllers
{
    public class AntiForgeryController : BookListControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
