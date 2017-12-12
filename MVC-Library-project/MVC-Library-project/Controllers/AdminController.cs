using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLibraryproject.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Index()
        {
            return View ();
        }
        public ActionResult LibrarianRegister(){
            return View();
        }

    }
}
