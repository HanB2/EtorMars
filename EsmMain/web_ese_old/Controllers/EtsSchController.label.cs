﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web_ese_old.Filter;

namespace web_ese_old.Controllers
{
	[CustomFilter]
	public partial class EtsSchController : Controller
	{
		public ActionResult EtsSchLabel()
        {
            return View();
        }
    }
}