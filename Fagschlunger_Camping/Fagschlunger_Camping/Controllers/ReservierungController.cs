using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fagschlunger_Camping.Controllers
{
    public class ReservierungController : Controller
    {
        // GET: Reservierung
        public ActionResult Reservierung()
        {
            return View();
        }
        public ActionResult Anfrage()
        {
            return View();
        }
    }
}