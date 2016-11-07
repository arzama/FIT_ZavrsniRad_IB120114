using PEPmodnaKompanija_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace modnaKompanija_Web
{
    public class GlobalHelp
    {
        public static PEPBazaEntities1 ctx = new PEPBazaEntities1();

        public static Kupci prijavljeniKupac { get; set; }
        //public static Favourite favouriteAlbum { get; set; }
        public static Narudzbe aktivnaNarudzba { get; set; }
        public static Favourite aktivnaWishlist { get; set; }
        public static double prosjecnaOcjenaProizvoda(int proizvodID)
        {

            double prosjek = 0;
                if(ctx.Ocjene.Where(x=>x.ProizvodID==proizvodID).Count()>0){
            prosjek=ctx.Ocjene.Where(x => x.ProizvodID == proizvodID).Average(x => x.Ocjena);
                }
            return prosjek;
        }
        public static double prosjecnaOcjenaDizajnera(int dizajnerID)
        {

            double prosjek = 0;
            if (ctx.OcjeneDizajnera.Where(x => x.KorisnikID == dizajnerID).Count() > 0)
            {
                prosjek = ctx.OcjeneDizajnera.Where(x => x.KorisnikID == dizajnerID).Average(x => x.Ocjena);
            }
            return prosjek;
        }
       
        public static int GetOcjena(int proizvodID)
        {
            List<Ocjene> o = ctx.Ocjene.ToList();
            int ocjena = 0;
            foreach (var item in o)
            {
                if (item.KupacID == GlobalHelp.prijavljeniKupac.KupacID && item.ProizvodID == proizvodID)
                {
                    ocjena = item.Ocjena;
                }
            }


            return ocjena;
        }
        public static bool VecKupljen(int proizvodID)
        {
            List<Narudzbe> o = ctx.Narudzbe.Where(x => x.KupacID == GlobalHelp.prijavljeniKupac.KupacID).ToList();
            List<NarudzbaStavke> izs = ctx.NarudzbaStavke.ToList();
            bool vec = false;
            foreach (var item in o)
            {
               foreach (var item1 in izs)
                    {
                       if (item1.NarudzbaID == item.NarudzbaID && item1.ProizvodID == proizvodID)
                        {
                           vec =true;
                        }
                   }

            }


            return vec;
        }

        public static int GetOcjenaDizajnera(int dizajnerID)
        {
            List<OcjeneDizajnera> o = ctx.OcjeneDizajnera.ToList();
            int ocjena = 0;
            foreach (var item in o)
            {
                if (item.KupacID == GlobalHelp.prijavljeniKupac.KupacID && item.KorisnikID == dizajnerID)
                {
                    ocjena = item.Ocjena;
                }
            }


            return ocjena;
        }

    }
}