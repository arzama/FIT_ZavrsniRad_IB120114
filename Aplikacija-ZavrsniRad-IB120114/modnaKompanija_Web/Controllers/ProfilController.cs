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
    public class ProfilController : Controller
    {
        private PEPBazaEntities1 ctx = new PEPBazaEntities1();

        public class ProfilVM
        {

            public int KupacID { get; set; }


            [Required(ErrorMessage = "Ime je obavezno polje!")]
            public string Ime { get; set; }
            [Required(ErrorMessage = "Prezime je obavezno polje!")]
            public string Prezime { get; set; }

            [EmailAddress]
            [Required(ErrorMessage = "Email je obavezno polje!")]
            public string Email { get; set; }
            [Required(ErrorMessage = "Korisnicko ime je obavezno polje!")]
            public string KorisnickoIme { get; set; }

            
            public string Lozinka { get; set; }
             
            public string StaraLozinka { get; set; }
           
            public string PotvrdnaLozinka { get; set; }
      
        }
  
        public ActionResult LozinkaSnimi(ProfilVM a)
        {
       
            Kupci db;
            db = ctx.Kupci.Where(o => o.KupacID == a.KupacID).FirstOrDefault();

            if (a.PotvrdnaLozinka == null || a.Lozinka == null || a.StaraLozinka == null)
            { return RedirectToAction("Index", new { ok = 1 }); }
            

            if (a.PotvrdnaLozinka == a.Lozinka && (WebHelper.GenerateHash(a.StaraLozinka, db.LozinkaSalt)) == db.LozinkaHash)
            {

                db.LozinkaSalt = WebHelper.GenerateSalt();

                db.LozinkaHash = WebHelper.GenerateHash(a.PotvrdnaLozinka, db.LozinkaSalt);

                ctx.SaveChanges();

                return RedirectToAction("Logout","Login");
            }
            else return RedirectToAction("Index", new { ok=1});
        }



        // GET: Profil
        public ActionResult Index(int? ok)
        {

            Kupci x = ctx.Kupci.Where(y => y.KupacID == GlobalHelp.prijavljeniKupac.KupacID).FirstOrDefault();
            var model = new ProfilVM
            {

                 KupacID=x.KupacID,
                     Ime = x.Ime,
                Prezime = x.Prezime,
                  Email=x.Email,
                   KorisnickoIme=x.KorisnickoIme


            };
            ViewBag.Uspjesno = ok;
            return View("Index", model);
        }

        public ActionResult ProfilSnimi(ProfilVM a)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", a);
            }
            Kupci db;


          
                db = ctx.Kupci.Where(o => o.KupacID == a.KupacID).FirstOrDefault();
            


            db.Ime = a.Ime;
            db.Prezime = a.Prezime;

            db.Email = a.Email;
            db.KorisnickoIme = a.KorisnickoIme;
       
            ctx.SaveChanges();
         
            return RedirectToAction("Logout","Login");
        }


    }
}