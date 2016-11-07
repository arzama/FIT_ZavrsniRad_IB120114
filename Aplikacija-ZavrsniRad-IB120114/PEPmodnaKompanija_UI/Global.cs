using PEPmodnaKompanija_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace PEPmodnaKompanija_UI
{
   public  class Global
   {
       public static Korisnici prijavljeniKorisnik { get; set; }

       public static string GetPoruka(string key)
       {
           ResourceManager rm = new ResourceManager("PEPmodnaKompanija_UI.Poruke", Assembly.GetExecutingAssembly());
           return rm.GetString(key);
       }
    }
}
