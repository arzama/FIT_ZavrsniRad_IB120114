using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEPmodnaKompanija_PCL.Model
{
   public class IzlazStavke
    {
        public int IzlazStavkaID { get; set; }
        public int IzlazID { get; set; }
        public int ProizvodID { get; set; }
        public int Kolicina { get; set; }
        public decimal Cijena { get; set; }

        public virtual Izlazi Izlazi { get; set; }
    }
}
