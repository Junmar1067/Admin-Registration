using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Admin_Registration.Models;

namespace Admin_Registration.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index(string search = "", string id = "")
        {

            if (search != "")
            {
                return View(Information.Context.Accounts.Where(a => a.Age.ToString() == search || a.Name == search));
            }
            
            return View(Information.Context.Accounts);
        }

        public ActionResult Add()
        {
            return View();
        }

        public ActionResult Save(Account acc)
        {
            var selected = Information.Context.Accounts.FirstOrDefault(x => x.Id == acc.Id);
            if (selected != null)
            {
                selected.Id = acc.Id;
                selected.Username = acc.Username; 
                selected.Password = acc.Password;
                selected.Name = acc.Name;
                selected.Age = acc.Age;
                selected.Address = acc.Address;
            }
            else
            {
                acc.Id = Information.Context.AssignId();
                Information.Context.Accounts.Add(acc);
            }

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int Id)
        {
            return View(Information.Context.Accounts.FirstOrDefault(x => x.Id == Id));
        }

        public ActionResult Delete(int id)
        {
            var selected = Information.Context.Accounts.FirstOrDefault(x => x.Id == id);
            if (selected != null)
            {
                Information.Context.Accounts.Remove(selected);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Search()
      
    }
}
