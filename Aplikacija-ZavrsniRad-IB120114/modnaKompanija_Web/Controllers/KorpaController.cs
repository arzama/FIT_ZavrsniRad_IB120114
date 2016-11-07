using PEPmodnaKompanija_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace modnaKompanija_Web.Controllers
{
    public class KorpaController : Controller
    {
        public PEPBazaEntities1 ctx = new PEPBazaEntities1();

        // GET: Korpa

     

        public ActionResult AddToKorpa(int id, string naziv , int kolicina,int velicinaId)
        {
            int ID = ctx.Proizvodi.Where(x => x.ProizvodID == id).FirstOrDefault().ProizvodID;
          if(velicinaId==0)
          {
             
              return RedirectToAction("Index", "DetaljiProizvoda",new{ proizvodID=id, ok=1 });
            
          }
            
          if (KolicinaNaSkladistu(id) > kolicina)
          {
              var addedProizvod = ctx.Proizvodi.Where(x => x.Naziv == naziv && x.VelicinaID == velicinaId).FirstOrDefault();

              //ctx.Proizvodi.Where(x => x.Naziv == naziv && x.VelicinaID == velicinaId).SingleOrDefault();

              // Add it to the shopping cart
              var cart = Korpa.GetCart(this.HttpContext);

              cart.AddToKorpa(addedProizvod, kolicina);


              return RedirectToAction("Index", "DetaljiProizvoda", new { proizvodID = id, ok = 2 });
          }
          else { return RedirectToAction("Index", "DetaljiProizvoda", new { proizvodID = id, ok = 16 }); }
              
        }

        public int KolicinaNaSkladistu(int Id)
        {
            int kolicina = 0;  
            List<SkladisteProizvodi> lista=ctx.SkladisteProizvodi.Where(x => x.ProizvodID == Id).ToList();

            if( lista.Count>0)
            {
                kolicina = ctx.SkladisteProizvodi.Where(x => x.ProizvodID == Id).Sum(x => x.Kolicina);
            }

                
            return kolicina;
        
        }

        public PartialViewResult VratiCount()
        {


            //return RedirectToAction("Index","Man", new { vrstaID = addedProizvod.VrstaID });
            return PartialView("_Count");


        }



        public class IndexVM
        {
   
            public int broj { get; set; }
            public int total { get; set; }
            public Narudzbe aktivnaNarudzba { get; set; }
            public List<Velicine> velicina { get; set; }
        }


        // GET: Man
        public ActionResult Index()
        {
            if (GlobalHelp.aktivnaNarudzba != null)
            {

                var model = new IndexVM
                {

                    broj = GlobalHelp.aktivnaNarudzba.NarudzbaStavke.Count(),
                    velicina = ctx.Velicine.ToList(),
                    aktivnaNarudzba = GlobalHelp.aktivnaNarudzba,
                  
                };
                return View("Index", model);
            }
            else {
                var model = new IndexVM
                {

                    broj =0,
                    velicina = ctx.Velicine.ToList(),
                    aktivnaNarudzba = GlobalHelp.aktivnaNarudzba
                };
                return View("Index", model);
            
            }
           
        }


        public ActionResult Obrisi(int proizvodID)
        {

            NarudzbaStavke stavka=null;
            foreach(var y in GlobalHelp.aktivnaNarudzba.NarudzbaStavke){
                if (y.ProizvodID == proizvodID)
                {
                   stavka = y;
                  
                }
            }

            GlobalHelp.aktivnaNarudzba.NarudzbaStavke.Remove(stavka);
   
         



            return RedirectToAction("Index");
        }



        public ActionResult Zakljuci()
        {

            Narudzbe narudzbe = new Narudzbe();

         
           
            narudzbe.BrojNarudzbe = GlobalHelp.aktivnaNarudzba.BrojNarudzbe;
            narudzbe.Datum =GlobalHelp.aktivnaNarudzba.Datum;
            narudzbe.AdresaDostaveID = GlobalHelp.aktivnaNarudzba.AdresaDostaveID;
            narudzbe.NacinDostaveID = GlobalHelp.aktivnaNarudzba.NacinDostaveID;
            narudzbe.NacinPlacanjaID = GlobalHelp.aktivnaNarudzba.NacinPlacanjaID;

            if (GlobalHelp.prijavljeniKupac != null)
            {
                narudzbe.KupacID = GlobalHelp.prijavljeniKupac.KupacID;
            }
            else { narudzbe.KupacID = GlobalHelp.aktivnaNarudzba.KupacID; }
            
            narudzbe.Otkazano = false;
            narudzbe.Status = true;

            foreach (var item in GlobalHelp.aktivnaNarudzba.NarudzbaStavke)
            {
                NarudzbaStavke stavka = new NarudzbaStavke();
                ctx.NarudzbaStavke.Add(stavka);
                stavka.ProizvodID = item.ProizvodID;
                stavka.NarudzbaID = item.NarudzbaID;
                stavka.Kolicina = item.Kolicina;

            }
            ctx.Narudzbe.Add(narudzbe);
            GlobalHelp.aktivnaNarudzba = null;
            ctx.SaveChanges();
            return RedirectToAction("Index","HistorijaNarudzbi");
        }



    }
}