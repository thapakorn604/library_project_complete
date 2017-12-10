using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


<<<<<<< HEAD
//Just for test the views

namespace MVCLibraryproject.Controllers
{
    public class MemberController : Controller
    {

        public ActionResult Home()
        {
            return View ();
        }

=======
//Just for test the views
namespace MVCLibraryproject.Controllers
{
    public class MemberController : Controller
    {
        public ActionResult Home()
        {
            return View ();
        }
>>>>>>> 0085273344bbb5ef4fd698ae41d2eb7536c58096
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
<<<<<<< HEAD
        }

=======
        }
>>>>>>> 0085273344bbb5ef4fd698ae41d2eb7536c58096
    }
}
