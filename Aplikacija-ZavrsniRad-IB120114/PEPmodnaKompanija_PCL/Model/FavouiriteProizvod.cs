using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEPmodnaKompanija_PCL.Model
{
    public class FavouiriteProizvod
    {
        public int FavouriteProizvodID { get; set; }
        public int FavouriteID { get; set; }
        public int ProizvodID { get; set; }

        //public virtual Favourite Favourite { get; set; }
        public virtual Proizvodi Proizvodi { get; set; }
    }
}
