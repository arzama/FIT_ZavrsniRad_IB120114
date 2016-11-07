using PEPmodnaKompanija_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace modnaKompanija_Web.Controllers
{
    public class HistorijaNarudzbiController : Controller
    {
         public static PEPBazaEntities1 ctx = new PEPBazaEntities1();

        // GET: HistorijaNarudzbi
         public class IndexVM
        {
   
            public int broj { get; set; }
            public decimal total { get; set; }
            public List<Narudzbe> narudzbe { get; set; }
            public List<Velicine> velicina { get; set; }
        }

        public ActionResult Index()
        {
         

                var model = new IndexVM
                {
                    narudzbe=ctx.Narudzbe.Where(x=>x.KupacID==GlobalHelp.prijavljeniKupac.KupacID).OrderByDescending(x=>x.NarudzbaID).ToList(),
           
              
                };
                return View("Index", model);
           
            
               
            }

        public class StavkeVM
        {

            public class StavkeInfo
            {
                public byte[] Slika { get; set; }
                public int Id { get; set; }
                public int Kolicina { get; set; }
                public decimal Cijena { get; set; }
                public string Naziv { get; set; }
                public decimal UkupnoRow { get; set; }
                public int ProizvodId { get; set; }
               
            }
            public List<StavkeInfo> stavke { get; set; }
            public decimal TotalSve { get; set; }
            public string BrojNarudzbe { get; set; }
            public DateTime DatumNarudzbe { get; set; }
            public bool sttausNardzbe { get; set; }
            public List<AdresaDostave> adrese { get; set; }
            public int adresaID { get; set; }

        }


        public ActionResult Stavke(int narudzbaID)
        {

            List<StavkeVM.StavkeInfo> stavkeInfos = ctx.NarudzbaStavke.Where(x => x.NarudzbaID == narudzbaID).Select(x => new StavkeVM.StavkeInfo
            {
              Id=x.NarudzbaStavkaID,
               Cijena=x.Proizvodi.Cijena,
                Kolicina=x.Kolicina,
                 Naziv=x.Proizvodi.Naziv,
                  Slika=x.Proizvodi.Slika,
                  UkupnoRow=x.Proizvodi.Cijena*x.Kolicina,
                   ProizvodId=x.Proizvodi.ProizvodID
                  
                 
              


            }).ToList();


            StavkeVM model = new StavkeVM
            {
                stavke = stavkeInfos,
                  TotalSve=ctx.NarudzbaStavke.Where(x=>x.NarudzbaID==narudzbaID).Sum(x=>x.Kolicina*x.Proizvodi.Cijena),
                   BrojNarudzbe=ctx.Narudzbe.Where(x=>x.NarudzbaID==narudzbaID).FirstOrDefault().BrojNarudzbe,
                   DatumNarudzbe=ctx.Narudzbe.Where(x=>x.NarudzbaID==narudzbaID).FirstOrDefault().Datum,
                sttausNardzbe = ctx.Narudzbe.Where(x => x.NarudzbaID == narudzbaID).FirstOrDefault().Status,
       adrese=ctx.AdresaDostave.ToList(),
       adresaID=ctx.Narudzbe.Where(x => x.NarudzbaID == narudzbaID).FirstOrDefault().AdresaDostaveID
                
            };

            return View("Stavke", model);



        }
      




    }
}