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
    
    public partial class usp_KatalogSelect_Result
    {
        public int ProizvodID { get; set; }
        public string Naziv { get; set; }
        public string Sifra { get; set; }
        public decimal Cijena { get; set; }
        public int VrstaID { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public bool Status { get; set; }
        public int SezonaID { get; set; }
        public int KorisnikID { get; set; }
        public int VelicinaID { get; set; }
        public System.DateTime Datum { get; set; }
        public string NazivKataloga { get; set; }
    }
}