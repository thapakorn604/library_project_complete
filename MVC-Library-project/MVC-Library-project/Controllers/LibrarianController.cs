using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLibraryproject.Controllers
{
    public class LibrarianController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Service()
        {
            return View();
        }
        public ActionResult LibrarianProfile()
        {
            return View();
        }
        public ActionResult History()
        {
            return View();
        }
    }
}
