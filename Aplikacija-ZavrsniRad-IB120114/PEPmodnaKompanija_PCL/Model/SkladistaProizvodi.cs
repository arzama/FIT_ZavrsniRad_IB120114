using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEPmodnaKompanija_PCL.Model
{
   public class SkladistaProizvodi
   {
       public int SkladistaProizvodiID { get; set; }
       public int KorisnikID { get; set; }
       public int ProizvodID { get; set; }
       public System.DateTime Datum { get; set; }
       public int SkladisteID { get; set; }
       public int Kolicina { get; set; }
    }
}
