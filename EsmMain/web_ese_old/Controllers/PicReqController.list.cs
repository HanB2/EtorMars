﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web_ese_old.Controllers
{
    public partial class PicReqController : Controller
    {
        // GET: PicReq 픽업조회
        public ActionResult PicReqList()
        {
            return View();
        }
    }
}