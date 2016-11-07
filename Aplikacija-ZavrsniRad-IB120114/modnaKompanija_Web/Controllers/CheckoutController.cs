using PEPmodnaKompanija_API.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace modnaKompanija_Web.Controllers
{
    public class CheckoutController : Controller
    { 
        private PEPBazaEntities1 ctx = new PEPBazaEntities1();
        // GET: Checkout

        #region Address
        public ActionResult CheckoutAddress()
        {
            return View("CheckoutAddress");
        }

 
        public class AddressVM
        {
           
            public int AdresaDostaveID { get; set; }


            [Required(ErrorMessage = "Ime je obavezno polje!")]
            public string Ime { get; set; }
            [Required(ErrorMessage = "Prezime je obavezno polje!")]
            public string Prezime { get; set; }
           
            [EmailAddress]
              [Required(ErrorMessage = "Email je obavezno polje!")]
            public string Email { get; set; }
     [Required(ErrorMessage = "Telefon je obavezno polje!")]
            public string Telefon { get; set; }
               [Required(ErrorMessage = "Poštanski broj je obavezno polje!")]
            public string PostanskiBroj { get; set; }
            
               [Required(ErrorMessage = "Ulica je obavezno polje!")]
            public string Ulica { get; set; }

               [Required(ErrorMessage = "Drzava je obavezno polje!")]
            public string Drzava { get; set; }
        }

          public ActionResult AddressDodaj()
          {
              AddressVM Model = new AddressVM();
    
              return View("CheckoutAddress", Model);
          }


          public ActionResult AddressUredi(int adresaID)
          {


              AdresaDostave x = ctx.AdresaDostave.Where(y => y.AdresaDostaveID == adresaID).FirstOrDefault();
              var model = new AddressVM
              {

                  AdresaDostaveID = x.AdresaDostaveID,
                  Drzava = x.Drzava,
                  PostanskiBroj = x.PostanskiBroj,
                  Telefon = x.Telefon,
                  Ulica = x.Ulica,
                  Ime = x.Ime,
                  Prezime = x.Prezime




              };
              return View("CheckoutAddress", model);
          }
        public ActionResult AddressSnimi(AddressVM a)
        {
            if (!ModelState.IsValid)
            {
                return View("CheckoutAddress", a);
            }
             AdresaDostave db;


             if (a.AdresaDostaveID == 0)
             {
                 db = new AdresaDostave();

                 ctx.AdresaDostave.Add(db);
             }

             else
             {
                 db = ctx.AdresaDostave.Where(o => o.AdresaDostaveID == a.AdresaDostaveID).FirstOrDefault();
             }


                db.Ime = a.Ime;
                db.Prezime = a.Prezime;

                db.Email = a.Email;

                db.Telefon = a.Telefon;
                db.PostanskiBroj = a.PostanskiBroj;
                db.Drzava = a.Drzava;
                db.Ulica = a.Ulica;

                ctx.SaveChanges();
            GlobalHelp.aktivnaNarudzba.AdresaDostaveID=db.AdresaDostaveID;
                return RedirectToAction("CheckoutDelivery");
            }
        #endregion

        #region Delivery
        public class DeliveryVM
        {
            public List<NacinDostave> dostave { get; set; }

             [Required(ErrorMessage = "Obavezno odabrati neki")]
            public int selektovani { get; set; }
        
        }
        public ActionResult CheckoutDelivery()
        {
           if(GlobalHelp.aktivnaNarudzba.NacinDostaveID==null){
            var model = new DeliveryVM
            {
                dostave = ctx.NacinDostave.ToList(),
                
                 selektovani=0
                
        

            };
            return View("CheckoutDelivery", model);
        }
            else
            {
                var model = new DeliveryVM
            {
                dostave = ctx.NacinDostave.ToList(),
                
                 selektovani=GlobalHelp.aktivnaNarudzba.NacinDostaveID
                
        

            };
                return View("CheckoutDelivery", model);
        }
            
        }

       
        public ActionResult DeliverySnimi(DeliveryVM vm)
        {
            if (vm.selektovani==0 || vm.selektovani==null)
            {
                return RedirectToAction("CheckoutDelivery");
            }
            GlobalHelp.aktivnaNarudzba.NacinDostaveID = vm.selektovani;
            return RedirectToAction("CheckoutPayment");
        }

#endregion


        #region Payment
        public class PaymentVM
        {
            public List<NacinPlacanja> placanje { get; set; }
            public int selektovani { get; set; }
        
        }


        public ActionResult CheckoutPayment()
        {
            if (GlobalHelp.aktivnaNarudzba.NacinDostaveID == null)
            {
                var model = new PaymentVM
                {
                    placanje = ctx.NacinPlacanja.ToList(),
                    selektovani = 0
                };

                return View("CheckoutPayment", model);
            }
            else {

                var model = new PaymentVM
                {
                    placanje = ctx.NacinPlacanja.ToList(),
                    selektovani = GlobalHelp.aktivnaNarudzba.NacinPlacanjaID
                };

                return View("CheckoutPayment", model);
            
            }
        }


        public ActionResult PaymentSnimi(PaymentVM vm)
        {

            if (vm.selektovani == 0 || vm.selektovani == null)
            {
                return RedirectToAction("CheckoutPayment");
            }
            GlobalHelp.aktivnaNarudzba.NacinPlacanjaID = vm.selektovani;


            return RedirectToAction("CheckoutReview");
        }
        #endregion

        # region Review

        public class ReviewVM
        {

            public int broj { get; set; }
            public int total { get; set; }
            public Narudzbe aktivnaNarudzba { get; set; }
            public List<Velicine> velicina { get; set; }
    
        }


        // GET: Man
        public ActionResult CheckoutReview()
        {
          

                var model = new ReviewVM
                {

                    broj = GlobalHelp.aktivnaNarudzba.NarudzbaStavke.Count(),
                    velicina = ctx.Velicine.ToList(),
                    aktivnaNarudzba = GlobalHelp.aktivnaNarudzba,
          
                };
                return View("CheckoutReview", model);
          

        }
#endregion
    }
}