
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web_esm.Controllers
{
    public class CsController : Controller
    {
        // GET: Cs C/S 공지사항 관리
        public ActionResult CsNotice()
        {
            return View();
        }

        // GET: Cs C/S 문의 사항 관리
        public ActionResult CsQna()
        {
            return View();
        }

    }
}