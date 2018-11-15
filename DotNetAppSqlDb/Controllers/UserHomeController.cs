using DotNetAppSqlDb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace DotNetAppSqlDb.Controllers
{
    public class UserHomeController : Controller
    {
        private MyDatabaseContext db = new MyDatabaseContext();
        
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {


            var query = db.Users.Find(user.userName);
            if (query != null)
            {
                Session["username"] = user.userName;
                return View("UserHome");
            }
            else
            {
                return View("Index");
            }

            
        }

       

    }
}