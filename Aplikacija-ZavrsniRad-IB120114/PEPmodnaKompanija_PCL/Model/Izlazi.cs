using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEPmodnaKompanija_PCL.Model
{
   public class Izlazi
    {
        public int IzlazID { get; set; }
        public string BrojRacuna { get; set; }
        public System.DateTime Datum { get; set; }
        public int KorisnikID { get; set; }
        public bool Zakljucen { get; set; }
        public Nullable<int> NarudzbaID { get; set; }
        public int SkladisteID { get; set; }

       
        public virtual Narudzbe Narudzbe { get; set; }
       
        public virtual ICollection<IzlazStavke> IzlazStavke { get; set; }
    }
}
