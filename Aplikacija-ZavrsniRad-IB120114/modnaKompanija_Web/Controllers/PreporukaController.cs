using PEPmodnaKompanija_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace modnaKompanija_Web.Controllers
{
    public class PreporukaController : Controller
    {
        public  PEPBazaEntities1 ctx = new PEPBazaEntities1();
        // GET: Preporuka
        public ActionResult Index()
        {
            return View();
        }

        #region Najbolje ocijenjeni proizvodi
        public class NajOcijenjeniVM
        {
            public List<usp_najboljeOcijenjeniProizvodi_Result> najOcijenjeni{ get; set; }
            public List<Proizvodi> p { get; set; }
            public List<Proizvodi> sviProizvodi { get; set; }

        }


        public PartialViewResult GetNajOcijenjeneProizvode()
        {


            var model = new NajOcijenjeniVM
            {


                sviProizvodi = ctx.Proizvodi.ToList(),
                najOcijenjeni = NajOcijenjeniProizvod()

            };
            return PartialView("NajOcijenjeniProizvod", model);
        }

        public List<usp_najboljeOcijenjeniProizvodi_Result> NajOcijenjeniProizvod()
        {

            return ctx.usp_najboljeOcijenjeniProizvodi().GroupBy(x=>x.Naziv).Select(y=>y.First()).ToList();
        }

        #endregion
        #region Najprodavaniji
        public class NajprodavanijiVM
        {
            public List<usp_Select_NajprodavanijiProizvodi_Result> najprodavaniji { get; set; }
            public List<Proizvodi> p { get; set; }
            public List<Proizvodi> sviProizvodi { get; set; }
        
        }


        public PartialViewResult GetNajprodavanije()
        {
         
     
            var model = new NajprodavanijiVM
            {
                
    
            sviProizvodi=ctx.Proizvodi.ToList(),
             najprodavaniji=Najprodavanije()

            };
            return PartialView("Najprodavaniji", model);
        }

        public List<usp_Select_NajprodavanijiProizvodi_Result> Najprodavanije()
        {

            return ctx.usp_Select_NajprodavanijiProizvodi().GroupBy(x=>x.Naziv).Select(y=>y.First()).ToList();
        }


        #endregion

#region proizvodi od najbolje ocijenjenog dizajnera
        public class NajboljeOcijenjeniVM
        {
            public List<usp_Select_NajboljeOcijenjeniDizajner_Result> dizajner { get; set; }
            public List<Proizvodi> p { get; set; }
            public List<Proizvodi> sviProizvodi { get; set; }

        }


        public PartialViewResult GetNajOcijenjenog()
        {
            int korisnikId= NajboljeOcijenjeni().KorisnikID;
            List<Proizvodi> preporuceni = ctx.Proizvodi.Where(x => x.KorisnikID == korisnikId).OrderByDescending(x=>x.ProizvodID).ToList();

            var model = new NajboljeOcijenjeniVM
            {


                sviProizvodi = ctx.Proizvodi.ToList(),
                p = preporuceni.GroupBy(x => x.Naziv).Select(y => y.First()).Take(3).ToList()

            };
            return PartialView("NajDizajner", model);
        }

        public usp_Select_NajboljeOcijenjeniDizajner_Result NajboljeOcijenjeni()
        {
           
            

            return ctx.usp_Select_NajboljeOcijenjeniDizajner().FirstOrDefault();
        }

#endregion


        #region Preporuka/Kupci koji su ovo kupili su takodjer kupili.. 
        public class UserBasedVM
        {

            public List<usp_UserBased_Preporuka_Result> preporuceni { get; set; }
            public List<Proizvodi> p { get; set; }
            public List<Proizvodi> sviProizvodi { get; set; }
        
        }
            
            
    
        public PartialViewResult UserBased(int proizvodID)
        {
            var model = new UserBasedVM
            {


                sviProizvodi = ctx.Proizvodi.ToList(),
                preporuceni=GetUserBased(proizvodID)

            };
            return PartialView("UserBased",model);
        }

    public List<usp_UserBased_Preporuka_Result> GetUserBased(int proizvodID)
        {

            return ctx.usp_UserBased_Preporuka(proizvodID, GlobalHelp.prijavljeniKupac.KupacID).ToList();
        }

        #endregion


    #region Preporuka/ Proizvodi koje su kupili slicni kupaci
    public class UserBased2VM
    {

        public List<usp_UserBased2_Result> preporuceni { get; set; }
        public List<Proizvodi> p { get; set; }
        public List<Proizvodi> sviProizvodi { get; set; }

    }



    public PartialViewResult UserBased2()
    {
        var model = new UserBased2VM
        {


            sviProizvodi = ctx.Proizvodi.ToList(),
            preporuceni = GetUserBased2()

        };
        return PartialView("UserBased2", model);
    }

    public List<usp_UserBased2_Result> GetUserBased2()
    {

        return ctx.usp_UserBased2(GlobalHelp.prijavljeniKupac.KupacID).ToList();
    }
    #endregion

    }
}