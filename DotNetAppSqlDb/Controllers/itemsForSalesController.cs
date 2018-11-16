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
        public ActionResult Index()
        {
            return View(db.itemsForSales.ToList());
        }
       
        // GET: itemsForSales/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            itemsForSale itemsForSale = db.itemsForSales.Find(id);
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
        public ActionResult Create([Bind(Include = "itemID,userID,name,price,description,image,category")] itemsForSale itemsForSale)
        {
            if (ModelState.IsValid)
            {
                db.itemsForSales.Add(itemsForSale);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(itemsForSale);
        }

        // GET: itemsForSales/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            itemsForSale itemsForSale = db.itemsForSales.Find(id);
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
            itemsForSale itemsForSale = db.itemsForSales.Find(id);
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
            itemsForSale itemsForSale = db.itemsForSales.Find(id);
            db.itemsForSales.Remove(itemsForSale);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
