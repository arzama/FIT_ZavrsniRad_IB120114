using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEPmodnaKompanija_PCL.Model
{
    public class Proizvodi
    {
        public int ProizvodID { get; set; }
        public string Naziv { get; set; }
        public string Sifra { get; set; }
        public decimal Cijena { get; set; }
        public string VrstaProizvoda { get; set; }
        public string Sezona { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public int VelicinaID { get; set; }

        public string NazivKataloga { get; set; }
        public DateTime Datum { get; set; }
        public Nullable<decimal> ProsjecnaOcjena { get; set; }

     
    }
}
