using PEPmodnaKompanija_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace modnaKompanija_Web.Controllers
{
    public class KatalogController : Controller
    {
        public PEPBazaEntities1 ctx = new PEPBazaEntities1();

       
        public class IndexVM
        {
            public string Naziv { get; set; }
            public DateTime Datum { get; set; }
        


            public Katalog katalog { get; set; }
            public List<KatalogProizvod> katalogProizvodi { get; set; }
            public List<Proizvodi> proizvodi { get; set; }
        }

        // GET: Katalog
        public ActionResult Index()
        {
            int katalogID=ctx.Katalog.OrderByDescending(p=>p.Datum).Take(1).FirstOrDefault().KatalogID;
        Katalog  kat=ctx.Katalog.OrderByDescending(p=>p.Datum).Take(1).FirstOrDefault();

            var model = new IndexVM
            {
            katalogProizvodi=ctx.KatalogProizvod.Where(x=>x.KatalogID==katalogID).ToList(),
                proizvodi=ctx.Proizvodi.ToList(),
                 Datum=kat.Datum,
                  Naziv=kat.Naziv

                
                

            };
            return View("Index", model);
        }
    }
}