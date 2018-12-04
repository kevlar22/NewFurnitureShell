using DotNetAppSqlDb.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Common;
using System.Configuration;

namespace DotNetAppSqlDb.Controllers
{
    public class UserHomeController : Controller
    {
        private MyDatabaseContext db = new MyDatabaseContext(); 
        
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult UserProfile(User user)
        {
            string userName = user.userName;
            int userIDFromDatabase =-1;
            string sql = "SELECT ID FROM Users WHERE userName = @userName";
            string sqlConnection = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(sqlConnection))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@userName", userName);
                try
                {
                    conn.Open();
                     userIDFromDatabase = (int)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            string password = user.password;
            string p = null;
            string sqlpassword = "SELECT password FROM Users WHERE password = @password";
            using (SqlConnection conn = new SqlConnection("Data Source=uncc.database.windows.net;Initial Catalog=uncc.Moving_App.dbo;Persist Security Info=True;User ID=kparso12;Password=Sugarrush1"))
            {
                SqlCommand cmd = new SqlCommand(sqlpassword, conn);
                cmd.Parameters.AddWithValue("@password", password);
                try
                {
                    conn.Open();
                    p = (string)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }


            }

            if (userIDFromDatabase != -1 && p != null)
                {
                    Session["username"] = user.userName;
                    Session["userID"] = userIDFromDatabase;
                    return View("Profile");
                }
                else
                {
                
                return RedirectToAction("Index");
                
                }

            
        }

        public ActionResult BacktoMenu()
        {
            return View("Profile");
        }

    }
}