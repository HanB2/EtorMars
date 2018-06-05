using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web_esm.Controllers
{
    public class BaseController : Controller
    {
        // GET: Base 통화 관리
        public ActionResult BaseCurrency()
        {
            return View();
        }

        // GET: Base 배송가능 국가 관리
        public ActionResult BaseNation()
        {
            return View();
        }

        // GET: Base 공항 관리
        public ActionResult BaseAirport()
        {
            return View();
        }  

        // GET: Base 현지 배송업체 설정
        public ActionResult BaseLocal()
        {
            return View();
        }

        // GET: Base 출고 타입 설정
        public ActionResult BaseOutPutType()
        {
            return View();
        }

    }
}