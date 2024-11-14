using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web2.Controllers
{
    public class TinTucController : Controller
    {
        // GET: TinTuc
        public ActionResult DanhSachTinTuc()
        {
            return View();
        }

        public ActionResult NoiDungTin()
        {
            return View();
        }

    }
}