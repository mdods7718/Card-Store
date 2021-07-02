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
    public class MagicController : Controller
    {
        private MagicDBContext db = new MagicDBContext();

        // GET: Magic
        public ActionResult Index()
        {
            return View(db.Magic.ToList());
        }

        // GET: Magic/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Magic magic = db.Magic.Find(id);
            if (magic == null)
            {
                return HttpNotFound();
            }
            return View(magic);
        }

        // GET: Magic/Create
        [Authorize(Users = "Admin")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Magic/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Users = "Admin")]
        public ActionResult Create([Bind(Include = "Name,Rarety,MarketPrice,ImagePath")] Magic magic)
        {
            if (ModelState.IsValid)
            {
                db.Magic.Add(magic);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(magic);
        }

        // GET: Magic/Edit/5
        [Authorize(Users = "Admin")]
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Magic magic = db.Magic.Find(id);
            if (magic == null)
            {
                return HttpNotFound();
            }
            return View(magic);
        }

        // POST: Magic/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Users = "Admin")]
        public ActionResult Edit([Bind(Include = "Name,Rarety,MarketPrice,ImagePath")] Magic magic)
        {
            if (ModelState.IsValid)
            {
                db.Entry(magic).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(magic);
        }

        // GET: Magic/Delete/5
        [Authorize(Users = "Admin")]
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Magic magic = db.Magic.Find(id);
            if (magic == null)
            {
                return HttpNotFound();
            }
            return View(magic);
        }

        // POST: Magic/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Magic magic = db.Magic.Find(id);
            db.Magic.Remove(magic);
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
