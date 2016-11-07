using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEPmodnaKompanija_PCL.Model
{
  public class Narudzba_Proizvodi
    {
      public int NarudzbaStavkaID { get; set; }
      public int ProizvodID { get; set; }
      public string Naziv { get; set; }
      public string Sifra { get; set; }
      public double Cijena { get; set; }
      public int Kolicina { get; set; }
      public double Iznos { get; set; }
      public byte[] SlikaThumb { get; set; }
    }
}
