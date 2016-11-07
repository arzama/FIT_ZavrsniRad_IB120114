using modnaKompanija_Web.Helper;
using PEPmodnaKompanija_API.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace modnaKompanija_Web.Controllers
{
    public class LoginController : Controller
    {
        private PEPBazaEntities1 ctx = new PEPBazaEntities1();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Provjera(string username, string password, string zapamti)
        {
            Kupci k = ctx.Kupci
                ////.Include(x => x.Student)
                //.Include(x => x.Zaposlenik)
                .Where(x => x.KorisnickoIme == username)
                .SingleOrDefault();
    


            if (k == null)
            {
               
                return RedirectToAction("RegistracijaUredi","Login",new {ok=9});
            }
            if ((WebHelper.GenerateHash(password, k.LozinkaSalt)) == k.LozinkaHash && username==k.KorisnickoIme)
            {
                Autentifikacija.PokreniNovuSesiju(k, HttpContext, (zapamti == "on"));
                Kupci korisnik = Autentifikacija.GetLogiraniKorisnik(HttpContext);
                GlobalHelp.prijavljeniKupac = Autentifikacija.GetLogiraniKorisnik(HttpContext);
                if (GlobalHelp.aktivnaNarudzba != null)
                {
                    return RedirectToAction("Index", "Korpa", new { });
                }
              
               else  return RedirectToAction("Index", "Pocetna", new { });
            }

            else return Redirect("/Login/RegistracijaUredi");
           
        }

        public ActionResult Logout()
        {
            GlobalHelp.aktivnaNarudzba = null;
            GlobalHelp.aktivnaWishlist = null;
            GlobalHelp.prijavljeniKupac = null;
         
            Autentifikacija.PokreniNovuSesiju(null, HttpContext, true);
            return RedirectToAction("RegistracijaUredi");
        }



        public class RegistracijaVM
        {
            public List<Kupci> kupci;
            public int Id { get; set; }
            [Required(ErrorMessage = "Ime je obavezno polje!")]
            public string Ime { get; set; }
            [Required(ErrorMessage = "Prezime je obavezno polje!")]
            public string Prezime { get; set; }
           
            [EmailAddress]
            public string Email { get; set; }
    
            [Required(ErrorMessage = "Korisničko ime je obavezno polje!")]
            public string KorisnickoIme { get; set; }
            [Required(ErrorMessage = "Lozinka je obavezno polje!")]
            public string Lozinka { get; set; }
        }


        public ActionResult RegistracijaUredi(int? koId,int? ok)
        {
          
            RegistracijaVM Model = new RegistracijaVM();
            if (koId == 0)
            {
               
                Kupci korisnik = ctx.Kupci.FirstOrDefault();

                Model.Id = korisnik.KupacID;
                Model.Ime = korisnik.Ime;
                Model.Prezime = korisnik.Prezime;

                Model.Email = korisnik.Email;

                Model.KorisnickoIme = korisnik.KorisnickoIme;

                korisnik.LozinkaSalt = WebHelper.GenerateSalt();
                korisnik.LozinkaHash = WebHelper.GenerateHash(Model.Lozinka, korisnik.LozinkaSalt);

          
            }
            else
            {
                Kupci korisnik = ctx.Kupci.Where(x => x.KupacID == koId).FirstOrDefault();
            }

            ViewBag.Uspjesno = ok;
            return View("Registracija", Model);

        }
        public ActionResult Registracija(RegistracijaVM kupac)
        {
            if (!ModelState.IsValid)
            {
                return View("Index","Pocetna");
           }
            int postoji = 0;
           foreach(var item in ctx.Kupci){
               if (item.KorisnickoIme == kupac.KorisnickoIme)
                  postoji = 1;
           }
           if (postoji == 0)
           {

               Kupci kupacDB;

               if (kupac.Id == 0)
               {
                   kupacDB = new Kupci();

                   ctx.Kupci.Add(kupacDB);
               }

               else
               {
                   kupacDB = ctx.Kupci.Where(o => o.KupacID == kupac.Id).FirstOrDefault();
               }


               kupacDB.Ime = kupac.Ime;
               kupacDB.Prezime = kupac.Prezime;
               kupacDB.DatumRegistracije = DateTime.Now;
               kupacDB.Email = kupac.Email;

               kupacDB.KorisnickoIme = kupac.KorisnickoIme;
               kupacDB.LozinkaSalt = WebHelper.GenerateSalt();
               kupacDB.LozinkaHash = WebHelper.GenerateHash(kupac.Lozinka, kupacDB.LozinkaSalt);
               kupacDB.Status = true;

               ctx.SaveChanges();
                 return RedirectToAction("RegistracijaUredi", new { ok=1});
           }
           else
               return RedirectToAction("RegistracijaUredi", new { ok = 2 });
        }


    }
}