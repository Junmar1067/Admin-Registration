using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin_Registration.Models
{
    public class Account
    {
        public String Name { get; set; }
        public int Id { get; set; }
        public int Age { get; set; }
        public String Password { get; set; }
        public String Username { get; set; }
        public String Address { get; set; }
    }
}