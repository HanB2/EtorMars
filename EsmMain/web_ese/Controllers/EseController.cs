using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web_ese.Controllers
{
    public class EseController : Controller
    {
        // GET: Ese 계정 정보
        public ActionResult EseInfo()
        {
            return View();
        }

        // GET: Ese 계정 등급 관리
        public ActionResult EseGrade()
        {
            return View();
        }

        // GET: Ese 계정 관리
        public ActionResult EseAccount()
        {
            return View();
        }
    }
}