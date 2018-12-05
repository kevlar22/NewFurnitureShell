using DotNetAppSqlDb.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotNetAppSqlDb.Controllers
{
    public class MatchesController : Controller
    {
        // GET: Matches
        private MyDatabaseContext db = new MyDatabaseContext();

        // GET: addresses
        public async System.Threading.Tasks.Task<ActionResult> Index(string id)
        {
            int userID = (int)Session["userID"];

            SqlParameter parameter = new SqlParameter("@User_ID", userID);
            List<Address> addresses = await db.addresses.SqlQuery("GetAllAddresses @User_ID", parameter).ToListAsync();

            //var query = db.addresses
            //       .Where(a => a.User_ID == userID)
            //       .ToList();
            return View(addresses);

        }
    }
}