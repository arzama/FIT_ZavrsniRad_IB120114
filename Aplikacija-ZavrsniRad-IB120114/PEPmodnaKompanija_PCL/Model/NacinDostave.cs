using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEPmodnaKompanija_PCL.Model
{
   public class NacinDostave
    {
        //public NacinDostave()
        //{
        //    this.Narudzbe = new HashSet<Narudzbe>();
        //}

        public int NacinDostaveID { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }

       // public virtual ICollection<Narudzbe> Narudzbe { get; set; }
    }
}
