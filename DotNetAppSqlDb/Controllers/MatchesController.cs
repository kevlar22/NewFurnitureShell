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
           
            int zip = (int)Session["zip"];
            int userID = (int)Session["userID"];

            SqlParameter zipParameter = new SqlParameter("@Zipcode", zip);
            SqlParameter myUserIdParameter = new SqlParameter("@myUserID", userID);
            List<Matches> matches = await db.Matches.SqlQuery("MatchBuyertoSellers @Zipcode", zipParameter, "@myUserID", myUserIdParameter).ToListAsync();

            //var query = db.addresses
            //       .Where(a => a.User_ID == userID)
            //       .ToList();
            return View(matches);

        }
    }
}