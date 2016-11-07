using PEPmodnaKompanija_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace modnaKompanija_Web.Helper
{
    public class Autentifikacija
    {
         private const string LogiraniKorisnik = "logirani_korisnik";
        
        public static void PokreniNovuSesiju(Kupci k, HttpContextBase context, bool zapamtiPassword)
        {
            context.Session.Add(LogiraniKorisnik, k);

            if (zapamtiPassword)
            {
                HttpCookie cookie = new HttpCookie("_mvc_session", k != null ? k.KupacID.ToString() : "");
                cookie.Expires = DateTime.Now.AddDays(10);
                context.Response.Cookies.Add(cookie);
            }
        }

        public static Kupci GetLogiraniKorisnik(HttpContextBase context)
        {
            Kupci korisnik = (Kupci)context.Session[LogiraniKorisnik];

            if (korisnik != null)
                return korisnik;

            HttpCookie cookie = context.Request.Cookies.Get("_mvc_session");

            if (cookie == null)
                return null;

            long userId;
            try
            {
                userId = long.Parse(cookie.Value);
            }
            catch
            {
                return null;
            }



            using (PEPBazaEntities1 db = new PEPBazaEntities1())
            {
                Kupci k = db.Kupci
              
               

                   .SingleOrDefault(x => x.KupacID == userId);

                PokreniNovuSesiju(k, context, true);
                return k;
            }
        }

    
    }
}