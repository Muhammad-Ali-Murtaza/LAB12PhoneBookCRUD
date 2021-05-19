using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhoneBookCRUD.Controllers
{
    public class PagesController : Controller
    {
        // GET: Pages
        public ActionResult AddConttact()
        {
            return View();
        }
        
        public ActionResult ViewContact()
        {
            return View();
        }
        
        public ActionResult DeleteContact()
        {
            return View();
        }
        
        public ActionResult EditContact()
        {
            return View();
        }
    }
}