using System.Web.Mvc;

namespace DemoWebBanHang.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
           
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { action = "Index", controller = "Home",  id = UrlParameter.Optional },
                new[] { "DemoWebBanHang.Areas.Admin.Controllers" }
            );
          
        }
    }
}