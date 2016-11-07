using PEPmodnaKompanija_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace modnaKompanija_Web.Controllers
{
    public class MeniController : Controller
    {
        // GET: Meni
        public ActionResult Index()
        {
            PEPBazaEntities1 ctx = new PEPBazaEntities1();
            List<Korisnici> k = ctx.Korisnici.ToList();
       
            return View("Index",k);
        }
    }
}