using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoWebBanHang.Areas.Admin.Controllers
{
    public class HomeController : BaseController
    {
       
        // GET: Admin/Home
        public ActionResult Index()
        {
          
            return View();
        }
       
        public ActionResult Tables()
        {
            return View();
        }
       
      
    }
}