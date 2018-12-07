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
    public class itemNeedRequestsController : Controller
    {
        private MyDatabaseContext db = new MyDatabaseContext();

        // GET: itemNeedRequests
        public ActionResult Index()
        {
            int userID = Convert.ToInt32(Session["userID"]);
            string userIDString = userID.ToString();
            var query = db.itemNeedRequests
                       .Where(a => a.userId == userID)
                       .ToList();
            return View(query);
        }

        // GET: itemNeedRequests/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            itemNeedRequests itemNeedRequests = db.itemNeedRequests.Find(id);
            if (itemNeedRequests == null)
            {
                return HttpNotFound();
            }
            return View(itemNeedRequests);
        }

        // GET: itemNeedRequests/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: itemNeedRequests/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "requestId,userId,category,minPrice,maxPrice")] itemNeedRequests itemNeedRequests)
        {
            if (ModelState.IsValid)
            {
                itemNeedRequests.userId = Convert.ToInt32(Session["userID"]);;
                db.itemNeedRequests.Add(itemNeedRequests);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(itemNeedRequests);
        }

        // GET: itemNeedRequests/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            itemNeedRequests itemNeedRequests = db.itemNeedRequests.Find(id);
            if (itemNeedRequests == null)
            {
                return HttpNotFound();
            }
            return View(itemNeedRequests);
        }

        // POST: itemNeedRequests/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "requestId,userId,category,minPrice,maxPrice")] itemNeedRequests itemNeedRequests)
        {
            if (ModelState.IsValid)
            {
                db.Entry(itemNeedRequests).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(itemNeedRequests);
        }

        // GET: itemNeedRequests/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            itemNeedRequests itemNeedRequests = db.itemNeedRequests.Find(id);
            if (itemNeedRequests == null)
            {
                return HttpNotFound();
            }
            return View(itemNeedRequests);
        }

        // POST: itemNeedRequests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            itemNeedRequests itemNeedRequests = db.itemNeedRequests.Find(id);
            db.itemNeedRequests.Remove(itemNeedRequests);
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
