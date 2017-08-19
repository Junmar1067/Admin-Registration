using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin_Registration.Models
{
    public class Information
    {
        public List<Account> Accounts;
        private static Information _information;
        public static Information Context
        {
            get
            {
                if (_information == null)
                {
                    _information = new Information();
                }
                return _information;
            }
        }

        private Information()
        {
            Accounts = new List<Account>();
            //Accounts.Add(new Account { Id = 1, Username = "Admin1", Password = "12345", Name = "My name 1", Age = 12, Address = "Tayud" });
            //Accounts.Add(new Account { Id = 2, Username = "Admin2", Password = "12345", Name = "My name 2", Age = 12, Address = "Tayud" });
            //Accounts.Add(new Account { Id = 3, Username = "Admin3", Password = "12345", Name = "My name 3", Age = 12, Address = "Tayud" });


        }
        public int AssignId()
        {
            return Accounts.Any() ? Accounts.Select(x => x.Id).Max() + 1 : 1;
        }
    }
}