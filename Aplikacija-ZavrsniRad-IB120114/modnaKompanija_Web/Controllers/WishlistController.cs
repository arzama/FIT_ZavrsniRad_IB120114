using PEPmodnaKompanija_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace modnaKompanija_Web.Controllers
{
    public class WishlistController : Controller
    {
        public PEPBazaEntities1 ctx = new PEPBazaEntities1();
        // GET: Wishlist
        public ActionResult AddToList(int id, int vrstaID, int detalji)
        {
            if (detalji == 0)
            {
                var addedProizvod = ctx.Proizvodi.Where(x => x.ProizvodID == id).FirstOrDefault();




                var list = Wishlist.GetWishlist(this.HttpContext);

                list.AddToList(addedProizvod);


                return RedirectToAction("IndexW2", "Man", new { vrstaID = addedProizvod.VrstaID });
                //return PartialView("_Count");
            }
            else {

                var addedProizvod = ctx.Proizvodi.Where(x => x.ProizvodID == id).FirstOrDefault();




                var list = Wishlist.GetWishlist(this.HttpContext);

                list.AddToList(addedProizvod);


                return RedirectToAction("IndexW", "DetaljiProizvoda", new { proizvodID = id, ok=2});
            
            
            
            }
      
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
            public Favourite aktivnaWishlist { get; set; }
           public List<FavouiriteProizvod> stavke { get; set; }
            public List<Proizvodi> proizvodi { get; set; }
        }


        // GET: Man
        public ActionResult Index()
        {
            int trazID = ctx.Favourite.Where(x => x.KupacID == GlobalHelp.prijavljeniKupac.KupacID).FirstOrDefault().FavouriteID; 
            var model = new IndexVM
                    {

         
                        broj = ctx.FavouiriteProizvod.Where(x=>x.FavouriteID==trazID).Count(),
                       proizvodi=ctx.Proizvodi.ToList(),
                        aktivnaWishlist =ctx.Favourite.Where(x=>x.FavouriteID==trazID).FirstOrDefault(),
                        stavke = ctx.FavouiriteProizvod.Where(x => x.FavouriteID == trazID).OrderByDescending(x=>x.FavouriteProizvodID).ToList()
                        
                    };
                    return View("Index", model);
            
            
            

        }

        public PartialViewResult IndexW()
        {

       
            int trazID = ctx.Favourite.Where(x => x.KupacID == GlobalHelp.prijavljeniKupac.KupacID).FirstOrDefault().FavouriteID;
           
            var model = new IndexVM
            {


                broj = ctx.FavouiriteProizvod.Where(x => x.FavouriteID == trazID).Count(),
                proizvodi = ctx.Proizvodi.ToList(),
                aktivnaWishlist = ctx.Favourite.Where(x => x.FavouriteID == trazID).FirstOrDefault(),
                stavke = ctx.FavouiriteProizvod.Where(x => x.FavouriteID == trazID).ToList()

            };
            return PartialView("ManPart", model);
            
            


        }




        public ActionResult Obrisi(int proizvodID)
        {

            int favouriteID = ctx.Favourite.Where(x => x.KupacID == GlobalHelp.prijavljeniKupac.KupacID).FirstOrDefault().FavouriteID;
         
            FavouiriteProizvod stavka = ctx.FavouiriteProizvod.Where(x => x.ProizvodID == proizvodID && x.FavouriteID == favouriteID).FirstOrDefault();
      
               ctx.FavouiriteProizvod.Remove(stavka);
               ctx.SaveChanges();


            return RedirectToAction("IndexW");
    
        
        }



        public ActionResult Sacuvaj()
        {

            Favourite favourite = new Favourite();

            favourite.Datum = DateTime.Now;

          

            if (GlobalHelp.prijavljeniKupac != null)
            {
                favourite.KupacID = GlobalHelp.prijavljeniKupac.KupacID;
            }
            else { favourite.KupacID = GlobalHelp.aktivnaNarudzba.KupacID; }

         

            foreach (var item in GlobalHelp.aktivnaWishlist.FavouiriteProizvod)
            {
                FavouiriteProizvod stavka = new FavouiriteProizvod();
                ctx.FavouiriteProizvod.Add(stavka);
                stavka.ProizvodID = item.ProizvodID;
                stavka.FavouriteID = item.FavouriteID;
                

            }
            ctx.Favourite.Add(favourite);
           
            ctx.SaveChanges();
            return RedirectToAction("Index", "Wishlist");
        }


    }
}