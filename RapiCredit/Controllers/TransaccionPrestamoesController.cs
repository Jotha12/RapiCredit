using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RapiCredit.Models;

namespace RapiCredit.Controllers
{
    public class TransaccionPrestamoesController : Controller
    {
        private RapiCreditEntities1 db = new RapiCreditEntities1();

        // GET: TransaccionPrestamoes
        public ActionResult Index()
        {
            return View(db.TransaccionPrestamo.ToList());
        }

        // GET: TransaccionPrestamoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TransaccionPrestamo transaccionPrestamo = db.TransaccionPrestamo.Find(id);
            if (transaccionPrestamo == null)
            {
                return HttpNotFound();
            }
            return View(transaccionPrestamo);
        }

        // GET: TransaccionPrestamoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TransaccionPrestamoes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,IdPrestamo,NoCuota,MontoCapital,MontoInteres,MontoMora,Capital,EsCuota,FechaPago,IdSucursal,IdEmpleado,FechaVencimiento")] TransaccionPrestamo transaccionPrestamo)
        {
            if (ModelState.IsValid)
            {
                db.TransaccionPrestamo.Add(transaccionPrestamo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(transaccionPrestamo);
        }

        // GET: TransaccionPrestamoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TransaccionPrestamo transaccionPrestamo = db.TransaccionPrestamo.Find(id);
            if (transaccionPrestamo == null)
            {
                return HttpNotFound();
            }
            return View(transaccionPrestamo);
        }

        // POST: TransaccionPrestamoes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,IdPrestamo,NoCuota,MontoCapital,MontoInteres,MontoMora,Capital,EsCuota,FechaPago,IdSucursal,IdEmpleado,FechaVencimiento")] TransaccionPrestamo transaccionPrestamo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(transaccionPrestamo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(transaccionPrestamo);
        }

        // GET: TransaccionPrestamoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TransaccionPrestamo transaccionPrestamo = db.TransaccionPrestamo.Find(id);
            if (transaccionPrestamo == null)
            {
                return HttpNotFound();
            }
            return View(transaccionPrestamo);
        }

        // POST: TransaccionPrestamoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TransaccionPrestamo transaccionPrestamo = db.TransaccionPrestamo.Find(id);
            db.TransaccionPrestamo.Remove(transaccionPrestamo);
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
