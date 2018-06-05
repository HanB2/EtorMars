using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web_ese.Controllers
{
    public class StocController : Controller
    {
        // GET: Stoc 보관 신청
        public ActionResult StocReq()
        {
            return View();
        }

        // GET: Stoc 보관 신청 현황 조회
        public ActionResult StocReqList()
        {
            return View();
        }

        // GET: Stoc 재고조회
        public ActionResult StocList()
        {
            return View();
        }

        // GET: Stoc 입출고 내역 조회
        public ActionResult StocInOut()
        {
            return View();
        }
    }
}