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
    public class MatchBuyertoSellers_ResultController : Controller
    {
        private MyDatabaseContext db = new MyDatabaseContext();

        // GET: MatchBuyertoSellers_Result
        public ActionResult Index()
        {

            return View(db.MatchBuyertoSellers_Result.ToList());
        }

        // GET: MatchBuyertoSellers_Result/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MatchBuyertoSellers_Result matchBuyertoSellers_Result = db.MatchBuyertoSellers_Result.Find(id);
            if (matchBuyertoSellers_Result == null)
            {
                return HttpNotFound();
            }
            return View(matchBuyertoSellers_Result);
        }

        // GET: MatchBuyertoSellers_Result/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MatchBuyertoSellers_Result/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "itemID,sellerID,userID,name,price,description,image,category,buyerID,buyerFirst")] MatchBuyertoSellers_Result matchBuyertoSellers_Result)
        {
            if (ModelState.IsValid)
            {
                db.MatchBuyertoSellers_Result.Add(matchBuyertoSellers_Result);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(matchBuyertoSellers_Result);
        }

        // GET: MatchBuyertoSellers_Result/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MatchBuyertoSellers_Result matchBuyertoSellers_Result = db.MatchBuyertoSellers_Result.Find(id);
            if (matchBuyertoSellers_Result == null)
            {
                return HttpNotFound();
            }
            return View(matchBuyertoSellers_Result);
        }

        // POST: MatchBuyertoSellers_Result/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "itemID,sellerID,userID,name,price,description,image,category,buyerID,buyerFirst")] MatchBuyertoSellers_Result matchBuyertoSellers_Result)
        {
            if (ModelState.IsValid)
            {
                db.Entry(matchBuyertoSellers_Result).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(matchBuyertoSellers_Result);
        }

        // GET: MatchBuyertoSellers_Result/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MatchBuyertoSellers_Result matchBuyertoSellers_Result = db.MatchBuyertoSellers_Result.Find(id);
            if (matchBuyertoSellers_Result == null)
            {
                return HttpNotFound();
            }
            return View(matchBuyertoSellers_Result);
        }

        // POST: MatchBuyertoSellers_Result/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MatchBuyertoSellers_Result matchBuyertoSellers_Result = db.MatchBuyertoSellers_Result.Find(id);
            db.MatchBuyertoSellers_Result.Remove(matchBuyertoSellers_Result);
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
