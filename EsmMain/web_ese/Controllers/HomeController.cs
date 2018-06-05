#region Using

using System.Web.Mvc;

#endregion

namespace web_ese.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        // GET: home/index
        public ActionResult Index()
        {
            return View();
        }
    }
}