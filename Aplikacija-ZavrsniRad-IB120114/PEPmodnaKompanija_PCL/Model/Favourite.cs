using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEPmodnaKompanija_PCL.Model
{
    public class Favourite
    {
        public Favourite()
        {
            this.FavouiriteProizvod = new HashSet<FavouiriteProizvod>();
        }

        public int FavouriteID { get; set; }
        public Nullable<System.DateTime> Datum { get; set; }
        public int KupacID { get; set; }

        public virtual ICollection<FavouiriteProizvod> FavouiriteProizvod { get; set; }
        public virtual Kupci Kupci { get; set; }
    }
}
