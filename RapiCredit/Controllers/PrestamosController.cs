using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RapiCredit.Controllers
{
    public class PrestamosController : Controller
    {
        // GET: Prestamos
        public ActionResult Prestamos()
        {
            return View();
        }
    }
}