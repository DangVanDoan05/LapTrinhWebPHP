using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web2.Controllers
{
    public class HomeController : Controller
    {

        // GET: Home
        // Luôn chạy File Index đầu tiên.
        public ActionResult Trangchu()
        {
            // Chuyển hướng qua action khác , cùng controller.
            // return RedirectToAction("DangNhap");
            // 2.Chuyển hướng khác controller
            //  return RedirectToAction("DanhSachTinTuc", "TinTuc");
            // 3.Chuyển hướng tới 1 Url
           
            // 4.
            return View();
        }

        public ActionResult GioiThieu()
        {
            return View();
        }

        public ActionResult DangNhap()
        {
            return View();
        }
     
    }
}