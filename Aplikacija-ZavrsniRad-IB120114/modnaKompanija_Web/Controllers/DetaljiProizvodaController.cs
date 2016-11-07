using PEPmodnaKompanija_API.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace modnaKompanija_Web.Controllers
{
    public class DetaljiProizvodaController : Controller
    {
        public PEPBazaEntities1 ctx = new PEPBazaEntities1();

        public class IndexVM
        {
            public class ProizvodInfo
            {
                public int Id { get; set; }
                public string Naziv { get; set; }
                public string Vrsta { get; set; }
                public string Sezona { get; set; }
                public byte[] Slika { get; set; }
                public string ImeDizajnera { get; set; }
                public int DizajnerID { get; set; }
                public string PrezimeDizajnera { get; set; }
                public decimal Cijena { get; set; }
                public string Sifra { get; set; }
                public int VrstaID { get; set; }
                public int Kolicina { get; set; }
              
            }
            public List<ProizvodInfo> proizvodi { get; set; }
            public List<SelectListItem> VelicineStavke { get; set; }
       [Required(ErrorMessage = "Korisničko ime je obavezno polje!")]
            public int VelicinaId { get; set; }

       public List<VrsteProizvoda> Vrste { get; set; }
       public int VrstaID { get; set; }
       public int ocjenaPostoji { get; set; }

       public List<Ocjene> Ocjene { get; set; }
       public int OcjenaINT { get; set; }
       public int proizvodID { get; set; }
     
        }





        public ActionResult OcjenaSnimi(int Id, int OcjenaINT = 0)
        {
            if (GlobalHelp.GetOcjena(Id) == 0)
            {
                if (OcjenaINT == null || OcjenaINT == 0)
                {

                    return RedirectToAction("IndexOcjena", "DetaljiProizvoda", new { proizvodID = Id, ok = 3 });
                }

                else
                {
                    Ocjene o;
                    o = new Ocjene();
                    ctx.Ocjene.Add(o);
                    o.Datum = DateTime.Now;
                    o.Ocjena = OcjenaINT;
                    o.KupacID = GlobalHelp.prijavljeniKupac.KupacID;
                    o.ProizvodID = Id;

                    ctx.SaveChanges();


                    return RedirectToAction("IndexOcjena", "DetaljiProizvoda", new { proizvodID = Id, ok = 4 });
                }
            }
            else return RedirectToAction("IndexOcjena", "DetaljiProizvoda", new { proizvodID = Id, ok = 4 });
        }

       





        // GET: DetaljiProizvoda
        public ActionResult Index(int proizvodID, int? ok)
        {
            
            List<IndexVM.ProizvodInfo> proizvodInfos = ctx.Proizvodi.Where(x => x.ProizvodID == proizvodID).Select(x => new IndexVM.ProizvodInfo()
            {

                Id = x.ProizvodID,
                 ImeDizajnera=x.Korisnici.Ime,
                  PrezimeDizajnera=x.Korisnici.Prezime,
                   Naziv=x.Naziv,
                    Slika=x.Slika,
                    Sezona=x.Sezone.Naziv,
                     Vrsta=x.VrsteProizvoda.Naziv,
                      Cijena=x.Cijena,
                       Sifra=x.Sifra,
                        VrstaID=x.VrstaID,
                         DizajnerID=x.Korisnici.KorisnikID
                         
                       
            
                        
             
            }).ToList();


            IndexVM model = new IndexVM
            {
                proizvodi=proizvodInfos,
                 Ocjene=ctx.Ocjene.ToList(),
                 VelicineStavke=UcitajVelicine(proizvodID),
                  proizvodID=proizvodID
         
                 
            };
            ViewBag.Uspjesno = ok;
            return View("Index",model);

        }

        public PartialViewResult IndexW(int proizvodID, int? ok)
        {

            List<IndexVM.ProizvodInfo> proizvodInfos = ctx.Proizvodi.Where(x => x.ProizvodID == proizvodID).Select(x => new IndexVM.ProizvodInfo()
            {

                Id = x.ProizvodID,
                ImeDizajnera = x.Korisnici.Ime,
                PrezimeDizajnera = x.Korisnici.Prezime,
                Naziv = x.Naziv,
                Slika = x.Slika,
                Sezona = x.Sezone.Naziv,
                Vrsta = x.VrsteProizvoda.Naziv,
                Cijena = x.Cijena,
                Sifra = x.Sifra,
                VrstaID = x.VrstaID,
                DizajnerID = x.Korisnici.KorisnikID




            }).ToList();


            IndexVM model = new IndexVM
            {
                proizvodi = proizvodInfos,
                Ocjene = ctx.Ocjene.ToList(),
                VelicineStavke = UcitajVelicine(proizvodID),
                 proizvodID=proizvodID


            };
            ViewBag.Uspjesno = ok;
            return PartialView("_Glavni", model);

        }

        public PartialViewResult IndexOcjena(int proizvodID, int? ok)
        {

            List<IndexVM.ProizvodInfo> proizvodInfos = ctx.Proizvodi.Where(x => x.ProizvodID == proizvodID).Select(x => new IndexVM.ProizvodInfo()
            {

                Id = x.ProizvodID,
                ImeDizajnera = x.Korisnici.Ime,
                PrezimeDizajnera = x.Korisnici.Prezime,
                Naziv = x.Naziv,
                Slika = x.Slika,
                Sezona = x.Sezone.Naziv,
                Vrsta = x.VrsteProizvoda.Naziv,
                Cijena = x.Cijena,
                Sifra = x.Sifra,
                VrstaID = x.VrstaID,
                DizajnerID = x.Korisnici.KorisnikID




            }).ToList();


            IndexVM model = new IndexVM
            {
                proizvodi = proizvodInfos,
                Ocjene = ctx.Ocjene.ToList(),
                VelicineStavke = UcitajVelicine(proizvodID),
                proizvodID = proizvodID


            };
            ViewBag.Uspjesno = ok;
            return PartialView("_Ocjena", model);

        }



    
        public List<Proizvodi>proizvodiIstiNaziv { get; set; }
        private List<SelectListItem> UcitajVelicine(int proizvodID)
        {
            var velicine = new List<SelectListItem>();
            string naziv="";
            velicine.Add(new SelectListItem { Value ="0", Text = "(Odaberi velicinu)" });
            foreach (var item in ctx.Proizvodi)
            {
                if (item.ProizvodID == proizvodID)
                {
                    naziv = item.Naziv;
                   
                }
                if (naziv == item.Naziv)
                {
                    foreach(var item2 in ctx.Velicine)
                        if (item.VelicinaID == item2.VelicinaID)
                        {
                            
                            velicine.Add(new SelectListItem { Value = item.VelicinaID.ToString(), Text = item2.Naziv });
                        }
                }

              
            }


           return velicine;
        }




    }
}