using DotNetAppSqlDb.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.EntityClient;
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



            int zip = Convert.ToInt32(Session["zip"]);

            int userID = (int)Session["userID"];
            db.Database.ExecuteSqlCommand(
                "exec dbo.[MatchBuyertoSellers] @Zipcode,@myUserId",
                  new SqlParameter("@Zipcode", zip),
                  new SqlParameter("@myUserId", userID)
                );
            SqlParameter param1 = new SqlParameter("@UserID", userID);
            List<Matches> matches =await db.Matches.SqlQuery("GetMatches @UserID", param1).ToListAsync();





            //var query = db.addresses
            //       .Where(a => a.User_ID == userID)
            //       .ToList();
            return View(matches);

        }
    }
}