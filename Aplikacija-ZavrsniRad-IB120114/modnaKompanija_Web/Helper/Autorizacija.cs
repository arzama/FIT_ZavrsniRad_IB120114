using PEPmodnaKompanija_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace modnaKompanija_Web.Helper
{
    public class Autorizacija : FilterAttribute, IAuthorizationFilter
    {
          private readonly Uloge[] _dozvoljeneUloge;

        public Autorizacija(params Uloge[] dozvoljeneUloge)
        {
            _dozvoljeneUloge = dozvoljeneUloge;
        }

        public void OnAuthorization(AuthorizationContext filterContext)
        {
            Kupci k = Autentifikacija.GetLogiraniKorisnik(filterContext.HttpContext);

            if (k == null)
            {
                filterContext.HttpContext.Response.Redirect("/Login");
                return;
            }

            else { GlobalHelp.prijavljeniKupac = k;
                return; }

            ////provjera
            //foreach (Uloge x in _dozvoljeneUloge)
            //{
            //    if (x ==Uloge.Kupac )
            //        return;
               
            //}
            //ako funkcija nije prekinuta pomoću "return", onda korisnik nema pravo pistupa pa će se vršiti redirekcija na "/Home/Index"
            filterContext.HttpContext.Response.Redirect("/Meni");
        }
    }
    public enum Uloge
    {
       
       
       Kupac
    


    }
}