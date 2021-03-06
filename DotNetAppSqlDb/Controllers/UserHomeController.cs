﻿using DotNetAppSqlDb.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        
        public ActionResult UserProfile(User user)
        {
            string userName = user.userName;
            string l = null;
            string sql = "SELECT userName FROM Users WHERE userName = @userName";
            using (SqlConnection conn = new SqlConnection("Data Source=uncc.database.windows.net;Initial Catalog=Moving_App;Persist Security Info=True;User ID=kparso12;Password=Sugarrush1"))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@userName", userName);
                try
                {
                    conn.Open();
                     l = (string)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            string password = user.password;
            string p = null;
            string sqlpassword = "SELECT password FROM Users WHERE password = @password";
            using (SqlConnection conn = new SqlConnection("Data Source=uncc.database.windows.net;Initial Catalog=Moving_App;Persist Security Info=True;User ID=kparso12;Password=Sugarrush1"))
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

            if (l != null && p != null)
                {
                    Session["username"] = l;
                    return View("Profile");
                }
                else
                {
                
                return RedirectToAction("Index");
                
                }

            
        }

       

    }
}