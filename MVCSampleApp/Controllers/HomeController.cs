using System;
using System.Runtime.Versioning;
using System.Web.Mvc;


namespace MVCSampleApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var mvcName = typeof(Controller).Assembly.GetName();
            var isMono = Type.GetType("Mono.Runtime") != null;

            ViewData["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
            ViewData["Runtime"] = isMono ? "Mono" : ".NET";

            //Store the values in Session
            Session["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
            Session["Runtime"] = isMono ? "Mono" : ".NET";

            return View();
        }
    }
}
