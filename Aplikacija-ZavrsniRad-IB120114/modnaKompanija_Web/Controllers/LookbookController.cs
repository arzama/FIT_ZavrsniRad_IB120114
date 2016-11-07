using PEPmodnaKompanija_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace modnaKompanija_Web.Controllers
{
    public class LookbookController : Controller
    {
        public PEPBazaEntities1 ctx = new PEPBazaEntities1();

        public class IndexVM
        {
             

                public List<ModeliProizvodi> proizvodi { get; set; }
                public List<ModelLookBook> modeli { get; set; }
                public LookBook lookbook { get; set; }
                public List<Modeli> svimodeli { get; set; }
                public Korisnici dizajner { get; set; }
                public int KorisnikID { get; set; }

         
        }

        public class StavkeVM
        {

            public int ProizvodID { get; set; }
            public string NazivProizvoda { get; set; }
            public decimal Cijena { get; set; }

         


            public Modeli model1 { get; set; }
            public List<ModeliProizvodi> modeliProizvodi { get; set; }
            public List<Proizvodi> proizvodi { get; set; }

        }






        public ActionResult Index(int? ok)
        {


            int lookbookID=ctx.LookBook.OrderByDescending(p => p.Datum).Take(1).FirstOrDefault().LookBookID;
      LookBook  lb=ctx.LookBook.OrderByDescending(p => p.Datum).Take(1).FirstOrDefault();
   
              var model = new IndexVM
                    {

       lookbook=ctx.LookBook.OrderByDescending(p => p.Datum).Take(1).FirstOrDefault(),
       dizajner=ctx.Korisnici.Where(x=>x.KorisnikID== lb.KorisnikID).FirstOrDefault(),
        modeli=ctx.ModelLookBook.Where(p=>p.LookBookID==lookbookID).ToList(),
svimodeli=ctx.Modeli.ToList(),
       KorisnikID = ctx.Korisnici.Where(x => x.KorisnikID == lb.KorisnikID).FirstOrDefault().KorisnikID
    
                        
                    };
              ViewBag.Uspjesno = ok;
                    return View("Index", model);



        }

        public PartialViewResult IndexW(int? ok)
        {


            int lookbookID = ctx.LookBook.OrderByDescending(p => p.Datum).Take(1).FirstOrDefault().LookBookID;
            LookBook lb = ctx.LookBook.OrderByDescending(p => p.Datum).Take(1).FirstOrDefault();

            var model = new IndexVM
            {

                lookbook = ctx.LookBook.OrderByDescending(p => p.Datum).Take(1).FirstOrDefault(),
                dizajner = ctx.Korisnici.Where(x => x.KorisnikID == lb.KorisnikID).FirstOrDefault(),
                modeli = ctx.ModelLookBook.Where(p => p.LookBookID == lookbookID).ToList(),
                svimodeli = ctx.Modeli.ToList(),
                KorisnikID = ctx.Korisnici.Where(x => x.KorisnikID == lb.KorisnikID).FirstOrDefault().KorisnikID


            };
            ViewBag.Uspjesno = ok;
            return PartialView("_Ocjena", model);



        }








        public PartialViewResult ZaPocetnu()
        {
                  int lookbookID=ctx.LookBook.OrderByDescending(p => p.Datum).Take(1).FirstOrDefault().LookBookID;


                  var model = new IndexVM
                        {


                            modeli = ctx.ModelLookBook.Where(p => p.LookBookID == lookbookID).ToList(),
                            svimodeli = ctx.Modeli.ToList()


                        };

            return PartialView("_ZaPocetnu",model);
        }



        public List<Proizvodi> pro { get; set; } 
        public List<Proizvodi> GetListu(int modelID)
        {
            List<ModeliProizvodi> sviModeli = ctx.ModeliProizvodi.ToList();

            List<Proizvodi> sviProizvodi = ctx.Proizvodi.ToList();
            foreach (ModeliProizvodi item in sviModeli)
            {
                if (item.ModelID == modelID)
                {
                    foreach (Proizvodi item2 in sviProizvodi)
                    {
                        if (item2.ProizvodID == item.ProizvodID)
                        {
                            pro.Add(item2);
                        }
                    }
                }
            }
            return pro;
        }



     public ActionResult Stavke(int modelID)
        {
      

            var model = new StavkeVM
            {
                modeliProizvodi=ctx.ModeliProizvodi.Where(x=>x.ModelID==modelID).ToList(),
                 proizvodi= ctx.Proizvodi.ToList(),
                  model1=ctx.Modeli.Where(x=>x.ModelID==modelID).FirstOrDefault()
          

            };


            return View("Stavke",model);
     
     }

     public ActionResult OcjenaDizajneraSnimi(int KorisnikID, int OcjenaINT = 0)
     {
        if( GlobalHelp.GetOcjenaDizajnera(KorisnikID) == 0){
         if (OcjenaINT == null || OcjenaINT == 0)
         {

             return RedirectToAction("IndexW", "Lookbook", new {ok = 7 });
         }


         else
         {
             OcjeneDizajnera o;
             o = new OcjeneDizajnera();
             ctx.OcjeneDizajnera.Add(o);
             o.Datum = DateTime.Now;
             o.Ocjena = OcjenaINT;
             o.KupacID = GlobalHelp.prijavljeniKupac.KupacID;
             o.KorisnikID = KorisnikID;

             ctx.SaveChanges();


             return RedirectToAction("IndexW", "Lookbook", new { ok = 6 });
         }
     }
        else return RedirectToAction("IndexW", "Lookbook", new { ok = 6 });


     }


    }
}