using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomInputHelper.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var items = new string[3] { "Item1", "Item2", "Item3" };
            return View(items);
        }

    }
}
