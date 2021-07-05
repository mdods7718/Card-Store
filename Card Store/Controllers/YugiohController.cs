using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Card_Store.Models;

namespace Card_Store.Controllers
{
    public class YugiohController : Controller
    {
        private YugiohDBContext db = new YugiohDBContext();

        // GET: Yugioh
        public ActionResult Index()
        {
            return View(db.Magic.ToList());
        }

        // GET: Yugioh/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Yugioh yugioh = db.Magic.Find(id);
            if (yugioh == null)
            {
                return HttpNotFound();
            }
            return View(yugioh);
        }

        // GET: Yugioh/Create
        [Authorize(Users = "Admin")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Yugioh/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name,Rarety,MarketPrice,ImagePath")] Yugioh yugioh)
        {
            if (ModelState.IsValid)
            {
                db.Magic.Add(yugioh);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(yugioh);
        }

        // GET: Yugioh/Edit/5
        [Authorize(Users = "Admin")]
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Yugioh yugioh = db.Magic.Find(id);
            if (yugioh == null)
            {
                return HttpNotFound();
            }
            return View(yugioh);
        }

        // POST: Yugioh/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Users = "Admin")]
        public ActionResult Edit([Bind(Include = "Name,Rarety,MarketPrice,ImagePath")] Yugioh yugioh)
        {
            if (ModelState.IsValid)
            {
                db.Entry(yugioh).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(yugioh);
        }

        // GET: Yugioh/Delete/5
        [Authorize(Users = "Admin")]
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Yugioh yugioh = db.Magic.Find(id);
            if (yugioh == null)
            {
                return HttpNotFound();
            }
            return View(yugioh);
        }

        // POST: Yugioh/Delete/5
        [Authorize(Users = "Admin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Yugioh yugioh = db.Magic.Find(id);
            db.Magic.Remove(yugioh);
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
