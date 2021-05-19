using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneBookCRUD.Models
{
    public class Contact
    {
        public int Index { get; set; }
        public string Name {get ; set; }
        public string Email {get ; set; }
        public string Number {get ; set; }
        public string Address {get ; set; }
    }
}