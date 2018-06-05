using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web_esm.Controllers
{
    public class ProdController : Controller
    {
        // GET: Prod 통관 상품 관리 
        public ActionResult ProdList()
        {
            return View();
        }
    }
}