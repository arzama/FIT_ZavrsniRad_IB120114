using PEPmodnaKompanija_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace modnaKompanija_Web
{
      
    public class Korpa
    {
        public static PEPBazaEntities1 ctx = new PEPBazaEntities1();

        string ShoppingCartId { get; set; }
       

        public const string CartSessionKey = "CartId";

        public static Korpa GetCart(HttpContextBase context)
        {
            var cart = new Korpa();
            cart.ShoppingCartId = cart.GetCartId(context);
            return cart;
        }

        public static Korpa GetCart(Controller controller)
        {
            return GetCart(controller.HttpContext);
        }




        public void AddToKorpa(Proizvodi proizvod,int kolicina)
        {
         
            int brojN = new Random().Next(1, 1000);
            if (GlobalHelp.aktivnaNarudzba == null)
            {
               
                       GlobalHelp.aktivnaNarudzba = new Narudzbe();
            
                    GlobalHelp.aktivnaNarudzba.BrojNarudzbe = brojN.ToString() + "/" + DateTime.Now.Year;
                    GlobalHelp.aktivnaNarudzba.Datum = DateTime.Now;
                    GlobalHelp.aktivnaNarudzba.KupacID = 8;
                       
            
            }

 bool proizvodPostoji = false;
                foreach (NarudzbaStavke item in GlobalHelp.aktivnaNarudzba.NarudzbaStavke)
                {
                    if (item.ProizvodID == proizvod.ProizvodID)
                    {
                      item.Kolicina+=kolicina;
                        proizvodPostoji = true;
                        break;
                    }
                }

               
                if(proizvodPostoji==false)
                {
                    NarudzbaStavke s = new NarudzbaStavke();
                    
                    s.ProizvodID = proizvod.ProizvodID;
                   s.Proizvodi = proizvod;
                    s.Kolicina = kolicina ; //         POPRAVITI !!!!!!!!!! da se postavi unesena kolicina
                    
                    GlobalHelp.aktivnaNarudzba.NarudzbaStavke.Add(s);
                }

        }


        public string GetCartId(HttpContextBase context)
        {
            if (context.Session[CartSessionKey] == null)
            {
                if (!string.IsNullOrWhiteSpace(context.User.Identity.Name))
                {
                    context.Session[CartSessionKey] = context.User.Identity.Name;
                }
                else
                {
                    // Generate a new random GUID using System.Guid class
                    Guid tempCartId = Guid.NewGuid();

                    // Send tempCartId back to client as a cookie
                    context.Session[CartSessionKey] = tempCartId.ToString();
                }
            }

            return context.Session[CartSessionKey].ToString();
        }
        public static int GetCount()
        {
            int kolicina=0;
            if (GlobalHelp.aktivnaNarudzba != null)
            {
                foreach (var item in GlobalHelp.aktivnaNarudzba.NarudzbaStavke) {
                    kolicina += item.Kolicina;
                }
                // Get the count of each item in the cart and sum them up
                //kolicina = GlobalHelp.aktivnaNarudzba.NarudzbaStavke.Count();
            }
            else kolicina = 0;
            // Return 0 if all entries are null
            return kolicina;
        }

        public static decimal GetTotal()
        {
            // Multiply album price by count of that album to get 
            // the current price for each of those albums in the cart
            // sum all album price totals to get the cart total
            decimal total=0;
           
            if (GlobalHelp.aktivnaNarudzba != null)
            {
                // Get the count of each item in the cart and sum them up
                foreach (var item in GlobalHelp.aktivnaNarudzba.NarudzbaStavke)
                {
                    total += item.Kolicina* item.Proizvodi.Cijena;
                }
                    }
  


            
            else total = 0;
            // Return 0 if all entries are null
            return total;
        }

        public static decimal? Total(int narudzbaID)
        {
            decimal? total = 0;
            //List<NarudzbaStavke> stavke;
            
            //stavke = ctx.NarudzbaStavke.ToList();
            //foreach (var item in stavke)
            //{
            //    if(item.NarudzbaID==narudzbaID)
            //    total += item.Kolicina * item.Proizvodi.Cijena;
            //}

            total = ctx.NarudzbaStavke.Where(x => x.NarudzbaID == narudzbaID).Sum(x => (decimal?)x.Kolicina * (decimal?)x.Proizvodi.Cijena);

            return total;

        }

    }
}