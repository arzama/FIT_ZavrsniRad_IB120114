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
    
    public partial class usp_Modeli_SelectByIdPhone_Result
    {
        public int ModelID { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public string Opis { get; set; }
        public string Naziv { get; set; }
        public int RevijaID { get; set; }
        public string Revija { get; set; }
        public string Lookbook { get; set; }
        public int KorisnikID { get; set; }
        public string Dizajner { get; set; }
        public Nullable<double> Prosjek { get; set; }
    }
}
