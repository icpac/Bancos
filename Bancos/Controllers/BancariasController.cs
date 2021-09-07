using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Bancos.DataContext;
using Bancos.Models;

namespace Bancos.Controllers
{
    public class BancariasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Bancarias
        public ActionResult Index()
        {
            return View(db.BancariaObj.ToList());
        }

        // GET: Bancarias/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bancaria bancaria = db.BancariaObj.Find(id);
            if (bancaria == null)
            {
                return HttpNotFound();
            }
            return View(bancaria);
        }

        // GET: Bancarias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bancarias/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Oid")] Bancaria bancaria)
        {
            if (ModelState.IsValid)
            {
                db.BancariaObj.Add(bancaria);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bancaria);
        }

        // GET: Bancarias/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bancaria bancaria = db.BancariaObj.Find(id);
            if (bancaria == null)
            {
                return HttpNotFound();
            }
            return View(bancaria);
        }

        // POST: Bancarias/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Oid")] Bancaria bancaria)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bancaria).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bancaria);
        }

        // GET: Bancarias/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bancaria bancaria = db.BancariaObj.Find(id);
            if (bancaria == null)
            {
                return HttpNotFound();
            }
            return View(bancaria);
        }

        // POST: Bancarias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Bancaria bancaria = db.BancariaObj.Find(id);
            db.BancariaObj.Remove(bancaria);
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
