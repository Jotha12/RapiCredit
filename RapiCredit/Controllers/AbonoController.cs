using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RapiCredit.Controllers
{
    public class AbonoController : Controller
    {
        // GET: Abono
        public ActionResult Abono()
        {
            return View();
        }

        // POST: Abono
        [HttpPost]
        public ActionResult Abono(double noPrestamo, double dpi, string nombre, float cuota)
        {
            return View();
        }
    }
}