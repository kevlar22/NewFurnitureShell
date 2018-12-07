using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DotNetAppSqlDb.Models;

namespace DotNetAppSqlDb.Controllers
{
    public class itemsForSalesController : Controller
    {
        private MyDatabaseContext db = new MyDatabaseContext();

        // GET: itemsForSales
        public ActionResult Index(string id)
        {
            //if (Session["userID"]!= null)
            //{
            //    Response.Cookies["userID"].Value = Session["userID"].ToString();
            //}
            //if ((Session["userID"] == null))
            //{
            //    Session["userID"] = Response.Cookies["userID"].Value;
            //}
           

              int idInt = Convert.ToInt32(Session["userID"]);
           
            var query = db.ITEMS_FOR_SALEs
                       .Where(a => a.userID == idInt)
                       .ToList();
           
            return View(query);
            
        }
       
        // GET: itemsForSales/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            itemsForSale itemsForSale = db.ITEMS_FOR_SALEs.Find(id);
            if (itemsForSale == null)
            {
                return HttpNotFound();
            }
            return View(itemsForSale);
        }

        // GET: itemsForSales/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: itemsForSales/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "itemID, userID, category,price,name,description,image")] itemsForSale itemsForSales, HttpPostedFileBase file)
            
        {
            
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    file.SaveAs(HttpContext.Server.MapPath("~/Images/")
                                                               + file.FileName);
                    itemsForSales.image = ("/Images/" +  file.FileName + "").ToString();
                }
                itemsForSales.userID = Convert.ToInt32(Session["userID"]);;
                db.ITEMS_FOR_SALEs.Add(itemsForSales);
                db.SaveChanges();
                
                return RedirectToAction("Index", "itemsForSales", Session["userID"] = itemsForSales.userID.ToString());
                
                
            }
           
            return View(itemsForSales);

        }

        // GET: itemsForSales/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            itemsForSale itemsForSale = db.ITEMS_FOR_SALEs.Find(id);
            if (itemsForSale == null)
            {
                return HttpNotFound();
            }
            return View(itemsForSale);
        }

    
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "itemID,userID,name,price,description,image,category")] itemsForSale itemsForSale)
        {
            if (ModelState.IsValid)
            {
                itemsForSale.userID = Convert.ToInt32(Session["userID"]);;
                db.Entry(itemsForSale).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(itemsForSale);
        }

        // GET: itemsForSales/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            itemsForSale itemsForSale = db.ITEMS_FOR_SALEs.Find(id);
            if (itemsForSale == null)
            {
                return HttpNotFound();
            }
            return View(itemsForSale);
        }

        // POST: itemsForSales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            itemsForSale itemsForSale = db.ITEMS_FOR_SALEs.Find(id);
            db.ITEMS_FOR_SALEs.Remove(itemsForSale);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

       
    }
}
