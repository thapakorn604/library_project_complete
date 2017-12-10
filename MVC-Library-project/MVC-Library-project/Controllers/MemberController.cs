using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

<<<<<<< HEAD
=======
//Just for test the views
>>>>>>> bd609e611fbeb26126e7726becbe9397710a4db2
namespace MVCLibraryproject.Controllers
{
    public class MemberController : Controller
    {
<<<<<<< HEAD
        public ActionResult Home()
        {
            return View ();
        }
=======
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
>>>>>>> bd609e611fbeb26126e7726becbe9397710a4db2
    }
}
