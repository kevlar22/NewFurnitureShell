using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotNetAppSqlDb.Controllers
{
    public class MatchesController : Controller
    {
        // GET: Matches
        public ActionResult Index()
        {
            return View();
        }
    }
}