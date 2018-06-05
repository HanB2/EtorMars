using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web_esm.Controllers
{
    public class EsmController : Controller
    {
        // GET:ESM 관리자 설정 ESM 계정 그룹 관리
        public ActionResult EsmGrade()
        {
            return View();
        }

        // GET:ESM 관리자 설정 ESM 계정 관리
        public ActionResult EsmAccount()
        {
            return View();
        }

        // GET:ESM 관리자 설정 로그인 이력 조회
        public ActionResult EsmLoginHis()
        {
            return View();
        }
    }
}