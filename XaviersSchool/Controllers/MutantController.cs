using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using XaviersSchool.Models;

namespace XaviersSchool.Controllers
{
    public class MutantController : Controller
    {
        private SchoolContext db = new SchoolContext();

        // GET: Mutant
        public ActionResult Index()
        {
            return View(db.Mutants.ToList());
        }

        // GET: Mutant/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mutant mutant = db.Mutants.Find(id);
            if (mutant == null)
            {
                return HttpNotFound();
            }
            return View(mutant);
        }

        // GET: Mutant/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mutant/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MutantId,LastName,FirstName,Age,AKA,Interests,Address,Picture,ImagePath")] Mutant mutant)
        {
            if (ModelState.IsValid)
            {
                db.Mutants.Add(mutant);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mutant);
        }

        // GET: Mutant/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mutant mutant = db.Mutants.Find(id);
            if (mutant == null)
            {
                return HttpNotFound();
            }
            return View(mutant);
        }

        // POST: Mutant/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MutantId,LastName,FirstName,Age,AKA,Interests,Address,Picture,ImagePath")] Mutant mutant)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mutant).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mutant);
        }

        // GET: Mutant/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mutant mutant = db.Mutants.Find(id);
            if (mutant == null)
            {
                return HttpNotFound();
            }
            return View(mutant);
        }

        // POST: Mutant/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Mutant mutant = db.Mutants.Find(id);
            db.Mutants.Remove(mutant);
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
