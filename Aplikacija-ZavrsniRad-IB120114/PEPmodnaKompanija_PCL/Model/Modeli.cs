using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEPmodnaKompanija_PCL.Model
{
   public class Modeli
    {
        public int ModelID { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public string Opis { get; set; }
        public string Naziv { get; set; }
        public int RevijaID { get; set; }
        public string Revija { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Dizajner { get; set; }
        public string Lookbook { get; set; }
        public float Prosjek { get; set; }
        public int KorisnikID { get; set; }  //dizajner
    }
}
