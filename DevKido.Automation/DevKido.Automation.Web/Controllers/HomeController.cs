using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevKido.Automation.Library;

namespace DevKido.Automation.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View(); 
        }

        [HttpPost]
        public ActionResult Google()
        {
            var returnMessage = GooglePage.CheckGooglePage();
            string expectedResult = "Gmail";
            string result = "";

            if (expectedResult == returnMessage)
                result = "success";
            else
                result = "fail";

            return Json(new { data = result }, JsonRequestBehavior.AllowGet);

        }
    }
}