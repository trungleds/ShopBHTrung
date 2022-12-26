using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoWebBanHang.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Shopping_Item()
        {
            return View();
        }
        public ActionResult Shopping_Cart()
        {
            return View();
        }



    }
}