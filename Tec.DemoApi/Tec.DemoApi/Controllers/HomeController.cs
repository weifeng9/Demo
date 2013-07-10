using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tec.DemoApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string temp = "Hi Mike! checking in now, update on repository";
            var temp1 = "change again";
            var temp2 = "change again";
            


            return View();
        }
    }
}
