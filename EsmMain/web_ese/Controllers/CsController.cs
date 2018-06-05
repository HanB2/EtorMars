using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web_ese.Controllers
{
    public class CsController : Controller
    {
        // GET: Cs 고객센터 ETOMARS 공지
        public ActionResult CsEsmNotice()
        {
            return View();
        }

        // GET: Cs 고객센터 STATION 공지
        public ActionResult CsEstNotice()
        {
            return View();
        }

        // GET: Cs 고객센터 1:1 문의
        public ActionResult CsQna()
        {
            return View();
        }
    }
}