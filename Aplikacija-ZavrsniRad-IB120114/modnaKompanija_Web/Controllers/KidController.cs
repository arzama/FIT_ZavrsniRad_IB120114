using PEPmodnaKompanija_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace modnaKompanija_Web.Controllers
{
    public class KidController : Controller
    {
        public PEPBazaEntities1 ctx = new PEPBazaEntities1();


        public class IndexVM
        {
            public List<Proizvodi> proizvodi { get; set; }
            public int broj { get; set; }
        
        }


        // GET: Man
        public ActionResult Index()
        {


            var model = new IndexVM
            {
                broj = ctx.Proizvodi.Where(x => x.VrstaID == 3).Count(),
                proizvodi = ctx.Proizvodi.Where(x => x.VrstaID == 3).ToList()
            };
                
            return View("Index", model);
        }

    }
}