//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PEPmodnaKompanija_API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class VrsteProizvoda
    {
        public VrsteProizvoda()
        {
            this.Proizvodi = new HashSet<Proizvodi>();
        }
    
        public int VrstaID { get; set; }
        public string Naziv { get; set; }
    
        public virtual ICollection<Proizvodi> Proizvodi { get; set; }
    }
}