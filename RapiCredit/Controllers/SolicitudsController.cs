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
    public class SolicitudsController : Controller
    {
        private RapiCreditEntities1 db = new RapiCreditEntities1();

        // GET: Solicituds
        public ActionResult Index()
        {
            return View(db.Solicitud.ToList());
        }

        // GET: Solicituds/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Solicitud solicitud = db.Solicitud.Find(id);
            if (solicitud == null)
            {
                return HttpNotFound();
            }
            return View(solicitud);
        }

        // GET: Solicituds/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Solicituds/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,IdPrestamo,IdCliente,PrimerNombre,SegundoNombre,PrimerApellido,SegundoApellido,DPI,FechaNacimiento,Telefono,Correo,Monto,Cuotas,Estado,FechaSolicitud")] Solicitud solicitud)
        {
            if (ModelState.IsValid)
            {
                db.Solicitud.Add(solicitud);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(solicitud);
        }

        // GET: Solicituds/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Solicitud solicitud = db.Solicitud.Find(id);
            if (solicitud == null)
            {
                return HttpNotFound();
            }
            return View(solicitud);
        }

        // POST: Solicituds/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,IdPrestamo,IdCliente,PrimerNombre,SegundoNombre,PrimerApellido,SegundoApellido,DPI,FechaNacimiento,Telefono,Correo,Monto,Cuotas,Estado,FechaSolicitud")] Solicitud solicitud)
        {
            if (ModelState.IsValid)
            {
                db.Entry(solicitud).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(solicitud);
        }

        // GET: Solicituds/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Solicitud solicitud = db.Solicitud.Find(id);
            if (solicitud == null)
            {
                return HttpNotFound();
            }
            return View(solicitud);
        }

        // POST: Solicituds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Solicitud solicitud = db.Solicitud.Find(id);
            db.Solicitud.Remove(solicitud);
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
