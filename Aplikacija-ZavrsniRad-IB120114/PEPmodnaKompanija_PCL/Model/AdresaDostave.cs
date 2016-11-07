using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEPmodnaKompanija_PCL.Model
{
    public class AdresaDostave
    {
        //public AdresaDostave()
        //{
        //    this.Narudzbe = new HashSet<Narudzbe>();
        //}

        public int AdresaDostaveID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string PostanskiBroj { get; set; }
        public string Ulica { get; set; }
        public string Drzava { get; set; }

        //public virtual ICollection<Narudzbe> Narudzbe { get; set; }
    }
}
