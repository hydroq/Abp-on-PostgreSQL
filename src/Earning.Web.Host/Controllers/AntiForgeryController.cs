using Microsoft.AspNetCore.Antiforgery;
using Earning.Controllers;

namespace Earning.Web.Host.Controllers
{
    public class AntiForgeryController : EarningControllerBase
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
