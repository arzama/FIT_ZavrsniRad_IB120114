using PEPmodnaKompanija_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace modnaKompanija_Web
{
    public class Wishlist
    {

        public static PEPBazaEntities1 ctx = new PEPBazaEntities1();

        string WishlistId { get; set; }
        public const string ListSessionKey = "ListId";



        public static Wishlist GetWishlist(HttpContextBase context)
        {
            var list = new Wishlist();
            list.WishlistId = list.GetListId(context);
            return list;
        }

        public static Wishlist GetWishlist(Controller controller)
        {
            return GetWishlist(controller.HttpContext);
        }

        public string GetListId(HttpContextBase context)
        {
            if (context.Session[ListSessionKey] == null)
            {
                if (!string.IsNullOrWhiteSpace(context.User.Identity.Name))
                {
                    context.Session[ListSessionKey] = context.User.Identity.Name;
                }
                else
                {
                    // Generate a new random GUID using System.Guid class
                    Guid tempCartId = Guid.NewGuid();

                    // Send tempCartId back to client as a cookie
                    context.Session[ListSessionKey] = tempCartId.ToString();
                }
            }

            return context.Session[ListSessionKey].ToString();
        }
        public void AddToList(Proizvodi proizvod)
        {

            if (GlobalHelp.prijavljeniKupac != null)
            {
                List<Favourite> list = ctx.Favourite.ToList();
                int postoji = 0;
                int favId = 0;
                int brojN = new Random().Next(1, 1000);
                //if (GlobalHelp.aktivnaWishlist == null)
                foreach (var item in list)
                {
                    if (item.KupacID == GlobalHelp.prijavljeniKupac.KupacID)
                    {
                        postoji = 1;
                        favId = item.FavouriteID;


                    }
                }
                Favourite fav;

                if (postoji == 0)
                {

                    fav = new Favourite();

                    fav.KupacID = GlobalHelp.prijavljeniKupac.KupacID;
                    fav.Datum = DateTime.Now;
                    ctx.Favourite.Add(fav);
                    favId = fav.FavouriteID;
                    FavouiriteProizvod s = new FavouiriteProizvod();
                    ctx.FavouiriteProizvod.Add(s);
                    s.ProizvodID = proizvod.ProizvodID;
                    s.Proizvodi = proizvod;
                    s.FavouriteID = favId;
                }
                else
                {
                    List<FavouiriteProizvod> stavke = ctx.FavouiriteProizvod.ToList();
                    int stavkaPostoji = 0;
                    foreach (var item in stavke)
                    {
                        if (favId == item.FavouriteID && item.ProizvodID == proizvod.ProizvodID)
                        {
                            stavkaPostoji = 1;
                        }
                    }

                    if (stavkaPostoji == 1)
                    {
                        return;
                    }
                    else
                    {
                        FavouiriteProizvod s = new FavouiriteProizvod();

                        s.ProizvodID = proizvod.ProizvodID;
                        //s.Proizvodi = proizvod;
                        s.FavouriteID = favId;
                        ctx.FavouiriteProizvod.Add(s);
                    }
                }
                ctx.SaveChanges();
            }
            else return;

        }
        public static int GetCount()
        {
            int kolicina = 0;
            
            int trazID = 0;
            int postoji = 0;
            if (GlobalHelp.prijavljeniKupac != null)
            {
                List<Favourite> fav = ctx.Favourite.ToList();

                foreach (var item in fav)
                {
               
                    if (item.KupacID == GlobalHelp.prijavljeniKupac.KupacID)
                    {
                        trazID = item.FavouriteID;
                        postoji = 1;
                    }
                }

                if (postoji == 1)
                {
                    kolicina = ctx.FavouiriteProizvod.Where(x => x.FavouriteID == trazID).Count();
                }



                else kolicina = 0;
            }
            else
            {
                kolicina = 0;
            }
            // Return 0 if all entries are null
            return kolicina;
        }

        public static int Postoji(int id)
        {
            int favID=0;
     
            int postoji2 = 0;
       foreach(var x in ctx.Favourite.ToList())
       {
       if(x.KupacID==GlobalHelp.prijavljeniKupac.KupacID)
       favID=x.FavouriteID;
       }


                foreach (var item in ctx.FavouiriteProizvod.ToList())
                {
                    if (item.ProizvodID == id && item.FavouriteID==favID)
                        postoji2 = 1;

                
            }
         
            // Return 0 if all entries are null
            return postoji2;
        }
    }
}