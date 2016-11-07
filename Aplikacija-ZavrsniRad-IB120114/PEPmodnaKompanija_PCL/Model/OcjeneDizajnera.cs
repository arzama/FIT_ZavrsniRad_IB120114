using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEPmodnaKompanija_PCL.Model
{
   public class OcjeneDizajnera
    {
        public int OcjenaID { get; set; }
        public int KorisnikID { get; set; }
        public int KupacID { get; set; }
        public System.DateTime Datum { get; set; }
        public int Ocjena { get; set; }

        public virtual Kupci Kupci { get; set; }
      //  public virtual Korisnici Korisnici { get; set; }
    }
}
