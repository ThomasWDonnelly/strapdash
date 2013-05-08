using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bootstapDash.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET : /
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }


        //
        // GET: /Search?query=
        public string Search(string query)
        {
            return "[\"#30 - Stephen Curry\", \"#5 - Kevin Garnett\", \"#24 - Kobe Bryant\", \"#21 - Tim Duncan\", \"#9 - Rajon Rondo\"]";
        }

    }
}
