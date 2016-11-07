using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEPmodnaKompanija_PCL.Model
{
    public class Katalog
    {
    //    public Katalog()
    //    {
    //        this.KatalogProizvod = new HashSet<KatalogProizvod>();
    //    }

        public int KatalogID { get; set; }
        public int KorisnikID { get; set; }
        public string Naziv { get; set; }
        public System.DateTime Datum { get; set; }

        //public virtual Korisnici Korisnici { get; set; }
    //    public virtual ICollection<KatalogProizvod> KatalogProizvod { get; set; }
    }
}
