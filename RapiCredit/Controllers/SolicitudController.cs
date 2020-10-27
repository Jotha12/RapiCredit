using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RapiCredit.Models;
using RapiCredit.Models.ViewModels;

namespace RapiCredit.Controllers
{
    public class SolicitudController : Controller
    {
        // GET: Solicitud
        public ActionResult Solicitud()
        {
            List<ViewSolicitud> lst;
            using (RapiCreditEntities1 db = new RapiCreditEntities1())
            {
                 lst = (from d in db.Solicitud
                           select new ViewSolicitud
                           {
                               Id = d.ID,
                               PrimerNombre = d.PrimerNombre,
                               SegundoNombre = d.SegundoNombre,
                               PrimerApellido = d.PrimerApellido,
                               SegundoApellido = d.SegundoApellido,
                               DPI = d.DPI,
                             
                               Telefono = d.Telefono,
                               Correo =d.Correo,
                             








                           }).ToList();
            }

                return View(lst);
        }

        // GET: Solicitud/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Solicitud/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Solicitud/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Solicitud/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Solicitud/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Solicitud/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Solicitud/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
