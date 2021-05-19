using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhoneBookCRUD.Controllers
{
    public class ContactController : Controller
    {
        List<Object> list = new List<object>();
        [HttpPost]
        public bool AddContact(Object obj)
        {
            list.Add(obj);
            return true;
        }
        [HttpGet]
        public List<Object> ViewCintact()
        {
            return list;
        }

        [HttpPost]
        public void DeleteContact(int index)
        {


        }

        [HttpPost]
        public void EditContact()
        {

        }

    }
}