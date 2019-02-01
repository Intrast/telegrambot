using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TelegramBot.Models;

namespace TelegramBot.Controllers
{
    public class WorkExperiensesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: WorkExperienses
        public ActionResult Index()
        {
            return View(db.WorkExperienses.ToList());
        }

        // GET: WorkExperienses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkExperiense workExperiense = db.WorkExperienses.Find(id);
            if (workExperiense == null)
            {
                return HttpNotFound();
            }
            return View(workExperiense);
        }

        // GET: WorkExperienses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WorkExperienses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Level")] WorkExperiense workExperiense)
        {
            if (ModelState.IsValid)
            {
                db.WorkExperienses.Add(workExperiense);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(workExperiense);
        }

        // GET: WorkExperienses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkExperiense workExperiense = db.WorkExperienses.Find(id);
            if (workExperiense == null)
            {
                return HttpNotFound();
            }
            return View(workExperiense);
        }

        // POST: WorkExperienses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Level")] WorkExperiense workExperiense)
        {
            if (ModelState.IsValid)
            {
                db.Entry(workExperiense).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(workExperiense);
        }

        // GET: WorkExperienses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkExperiense workExperiense = db.WorkExperienses.Find(id);
            if (workExperiense == null)
            {
                return HttpNotFound();
            }
            return View(workExperiense);
        }

        // POST: WorkExperienses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WorkExperiense workExperiense = db.WorkExperienses.Find(id);
            db.WorkExperienses.Remove(workExperiense);
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
