using PEPmodnaKompanija_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace modnaKompanija_Web.Controllers
{
    public class NekiController : Controller
    {
        private PEPBazaEntities1 ctx = new PEPBazaEntities1();
        // GET: Neki
        public ActionResult Index()
        {
              PEPBazaEntities1 ctx = new PEPBazaEntities1();
   List<Korisnici> k=ctx.Korisnici.ToList();
        return Json(k, JsonRequestBehavior.AllowGet);
        }

        public List<usp_Select_NajprodavanijiProizvodi_Result> GetNajprodavanije()
        {

            return ctx.usp_Select_NajprodavanijiProizvodi().ToList();
        }


    }
}