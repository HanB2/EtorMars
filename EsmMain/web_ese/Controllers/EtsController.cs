using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web_ese.Controllers
{
    public class EtsController : Controller
    {
        // GET: Ets 배송 일반 배송 신청
        public ActionResult EtsReq()
        {
            return View();
        }


        // GET: Ets 배송 대량 배송 신청
        public ActionResult EtsReqExcel()
        {
            return View();
        }

        // GET: Ets 배송 배송 라벨 출력
        public ActionResult EstLabel()
        {
            return View();
        }

        // GET: Ets 배송 배송 상태 조회
        public ActionResult EtsList()
        {
            return View();
        }
    }
}