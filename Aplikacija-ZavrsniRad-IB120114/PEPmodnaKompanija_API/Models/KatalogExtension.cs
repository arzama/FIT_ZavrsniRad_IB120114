using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PEPmodnaKompanija_API.Models
{
    public partial class Katalog
    {
        public List<Proizvodi> Proizvodi { get; set; }
    }
}