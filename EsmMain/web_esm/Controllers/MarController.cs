using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web_esm.Controllers
{
    public class MarController : Controller
    {
        // GET: Mar Mar 충전요청
        public ActionResult MarInReq()
        {
            return View();
        }

		// GET: Mar Mar 출금요청(EST)
		public ActionResult MarOutEst()
		{
			return View();
		}

		// GET: Mar Mar 출금요청(ESE)
		public ActionResult MarOutEse()
		{
			return View();
		}

		// GET: Mar Mar 입출금 현황
		public ActionResult MarInOut()
		{
			return View();
		}

	}
}