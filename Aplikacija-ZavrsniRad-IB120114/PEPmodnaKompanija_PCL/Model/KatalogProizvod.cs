using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEPmodnaKompanija_PCL.Model
{
   public class KatalogProizvod
    {
        public int KatalogProizvodID { get; set; }
        public int ProizvodID { get; set; }
        public int KatalogID { get; set; }

        public virtual Katalog Katalog { get; set; }
        public virtual Proizvodi Proizvodi { get; set; }
    }
}
