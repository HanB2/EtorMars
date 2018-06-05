using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web_ese.Controllers
{
    public class MarController : Controller
    {
        // GET: Mar MAR 충전(PG)
        public ActionResult MarReqPg()
        {
            return View();
        }

        // GET: Mar MAR 충전(이체)
        public ActionResult MarReq()
        {
            return View();
        }

        // GET: Mar Mar 충전/사용 이력
        public ActionResult MarInOut()
        {
            return View();
        }

        // GET: Mar MAR 환불 신청
        public ActionResult MarOutReq()
        {
            return View();
        }
    }
}