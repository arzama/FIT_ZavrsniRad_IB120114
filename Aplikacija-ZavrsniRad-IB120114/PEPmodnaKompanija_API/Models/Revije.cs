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
    
    public partial class Revije
    {
        public Revije()
        {
            this.Modeli = new HashSet<Modeli>();
        }
    
        public int RevijaID { get; set; }
        public System.DateTime Datum { get; set; }
        public int KorisnikID { get; set; }
        public string Naziv { get; set; }
        public string Napomena { get; set; }
    
        public virtual Korisnici Korisnici { get; set; }
        public virtual ICollection<Modeli> Modeli { get; set; }
    }
}
