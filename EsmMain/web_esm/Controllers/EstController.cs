using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web_esm.Controllers
{
    public class EstController : Controller
    {
        // GET: Est EST STATION EST 정보 관리
        public ActionResult EstInfo()
        {
            return View();
        }

        // GET: Est EST STATION Est 계정 등급 관리
        public ActionResult EstGrade()
        {
            return View();
        }

        // GET: Est EST STATION EST 계정 관리
        public ActionResult EstAccount()
        {
            return View();
        }

        // GET: Est EST STATION EST 출고 현황
        public ActionResult EstInOutStat()
        {
            return View();
        }
    }
}