using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace modnaKompanija_Web.Controllers
{
    public class KontaktController : Controller
    {
        // GET: Kontakt
        public ActionResult Index()
        {
            return View("Index");
        }
    }
}