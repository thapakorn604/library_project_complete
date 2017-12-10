using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


//Just for test the views
namespace MVCLibraryproject.Controllers
{
    public class MemberController : Controller
    {
        public ActionResult Home()
        {
            return View ();
        }
        public ActionResult Index()
        {
            return View ();
        }
        public ActionResult MemberProfile()
        {
            return View();
        }
        public ActionResult MemEditProfile(){
            return View();
        }
        public ActionResult MemberSearchBook()
        {
            return View();
        }
        public ActionResult MemberHistory()
        {
            return View();
        }
    }
}
