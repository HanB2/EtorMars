using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web_ese.Controllers
{
    public class ProdController : Controller
    {
        // GET: Prod 상품 등록
        public ActionResult ProdAdd()
        {
            return View();
        }

        // GET: Prod 등록 상품 조회
        public ActionResult ProdList()
        {
            return View();
        }

    }
}