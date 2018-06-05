using System.Web.Mvc;
using web_esm.Models_Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web_esm.Controllers
{
    public class SettingController : Controller
    {
        // GET: Setting 설정 메일서버 설정
        public ActionResult SettingEmail()
        {
			SettingDbModels db = new SettingDbModels();
			EmailSettingModel returnModel = db.GetEmailSettingModel();


			return View(returnModel);
        }
    }
}