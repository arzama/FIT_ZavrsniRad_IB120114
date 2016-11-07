using modnaKompanija_Web.Helper;
using PEPmodnaKompanija_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using PagedList;
using System.Web;
using System.Web.Mvc;

namespace modnaKompanija_Web.Controllers
{
    public class ManController : Controller
    {
        public  PEPBazaEntities1 ctx = new PEPBazaEntities1();




        public class IndexVM
        {
            public List<Proizvodi> proizvodi { get; set; }
            public int broj { get; set; }
            public int vrstaId { get; set; }

            public List<SelectListItem> FiltrirajStavke { get; set; }
            public int FiltrirajId { get; set; }

            public int selektovani { get; set; }
            public List<Korisnici> dizajneriList { get; set; }

            public int selektovanaSezona { get; set; }
            public List<Sezone> sezoneList { get; set; }
        }

        private List<SelectListItem> UcitajZaFiltriraj()
        {
            var items = new List<SelectListItem>();
            items.Add(new SelectListItem { Value = null, Text = " " });
            items.Add(new SelectListItem { Value = "1", Text = "Cijena(od manje ka većoj)" });
            items.Add(new SelectListItem { Value = "2", Text = "Cijena(od veće ka manjoj)" });
            items.Add(new SelectListItem { Value = "3", Text = "Naziv(od A do Z)" });
            items.Add(new SelectListItem { Value = "4", Text = "Naziv(od Z do A)" });

           
            return items;
        }

      
        public ActionResult Index(int vrstaID, int? filtrirajId)
        {
          

            List<Proizvodi> p = ctx.Proizvodi.Where(x => x.VrstaID == vrstaID).OrderByDescending(x=>x.ProizvodID).ToList();

            switch (filtrirajId)
            {
                case 1:
                    p = ctx.Proizvodi.Where(x => x.VrstaID == vrstaID).OrderBy(x => x.Cijena).ToList();

                    break;
                case 2:
                    p = ctx.Proizvodi.Where(x => x.VrstaID == vrstaID).OrderByDescending(x => x.Cijena).ToList();

                    break;
                case 3:
                    p = ctx.Proizvodi.Where(x => x.VrstaID == vrstaID).OrderBy(x => x.Naziv).ToList();

                    break;
                case 4:
                    p = ctx.Proizvodi.Where(x => x.VrstaID == vrstaID).OrderByDescending(x => x.Naziv).ToList();

                    break;
                default:
                    ctx.Proizvodi.Where(x => x.VrstaID == vrstaID).OrderByDescending(x=>x.ProizvodID).ToList();
                    break;
            }

            var model = new IndexVM
            {
                vrstaId = vrstaID,
                broj = ctx.Proizvodi.Where(x => x.VrstaID == vrstaID).Count(),

                proizvodi = p.GroupBy(x=>x.Naziv).Select(y=>y.First()).ToList(),
                FiltrirajStavke = UcitajZaFiltriraj(),
                 selektovani=0,
                  dizajneriList=ctx.Korisnici.Where(x=>x.UlogaID==4).ToList(),
                   selektovanaSezona=0,
                    sezoneList=ctx.Sezone.ToList()
                    


            };

            return View("Index", model);
        }

        public PartialViewResult IndexW(int vrstaID, string search, int? filtrirajId, int? selektovani, int? selektovanaSezona)
        {


            List<Proizvodi> p = ctx.Proizvodi.Where(x => x.VrstaID == vrstaID).Where(x => x.Naziv.StartsWith(search) || search == null).Where(x => x.KorisnikID == selektovani || selektovani == 0).Where(x => x.SezonaID == selektovanaSezona || selektovanaSezona == 0).OrderByDescending(x => x.ProizvodID).ToList();

            switch (filtrirajId)
            {
                case 1:
                    p = ctx.Proizvodi.Where(x => x.VrstaID == vrstaID).Where(x => x.Naziv.StartsWith(search) || search == null).Where(x => x.KorisnikID == selektovani || selektovani == 0).Where(x => x.SezonaID == selektovanaSezona || selektovanaSezona == 0).OrderBy(x => x.Cijena).ToList();

                    break;
                case 2:
                    p = ctx.Proizvodi.Where(x => x.VrstaID == vrstaID).Where(x => x.Naziv.StartsWith(search) || search == null).Where(x => x.KorisnikID == selektovani || selektovani == 0).Where(x => x.SezonaID == selektovanaSezona || selektovanaSezona == 0).OrderByDescending(x => x.Cijena).ToList();

                    break;
                case 3:
                    p = ctx.Proizvodi.Where(x => x.VrstaID == vrstaID).Where(x => x.Naziv.StartsWith(search) || search == null).Where(x => x.KorisnikID == selektovani || selektovani == 0).Where(x => x.SezonaID == selektovanaSezona || selektovanaSezona == 0).OrderBy(x => x.Naziv).ToList();

                    break;
                case 4:
                    p = ctx.Proizvodi.Where(x => x.VrstaID == vrstaID).Where(x => x.Naziv.StartsWith(search) || search == null).Where(x => x.KorisnikID == selektovani || selektovani == 0).Where(x => x.SezonaID == selektovanaSezona || selektovanaSezona == 0).OrderByDescending(x => x.Naziv).ToList();

                    break;
                default:
                    p = ctx.Proizvodi.Where(x => x.VrstaID == vrstaID).Where(x => x.Naziv.StartsWith(search) || search == null).Where(x => x.KorisnikID == selektovani || selektovani == 0).Where(x => x.SezonaID == selektovanaSezona || selektovanaSezona == 0).OrderByDescending(x => x.ProizvodID).ToList();
                    break;




            }

            var model = new IndexVM
            {
                vrstaId = vrstaID,
                broj = ctx.Proizvodi.Where(x => x.VrstaID == vrstaID).Count(),

                proizvodi = p.GroupBy(x => x.Naziv).Select(y => y.First()).ToList(),
                FiltrirajStavke = UcitajZaFiltriraj(),

                dizajneriList = ctx.Korisnici.Where(x => x.UlogaID == 4).ToList()


            };

            return PartialView("_proizvodi", model);
        }



        public PartialViewResult IndexW2(int vrstaID)
        {
            List<Proizvodi> pom=ctx.Proizvodi.Where(x => x.VrstaID == vrstaID).OrderByDescending(x => x.ProizvodID).ToList();

            var model = new IndexVM
            {
                vrstaId = vrstaID,
                broj = ctx.Proizvodi.Where(x => x.VrstaID == vrstaID).Count(),
                proizvodi = pom.GroupBy(x=>x.Naziv).Select(y=>y.First()).ToList(),
                FiltrirajStavke = UcitajZaFiltriraj(),

                dizajneriList = ctx.Korisnici.Where(x => x.UlogaID == 4).ToList()
            };

            return PartialView("_proizvodi", model);
        }








        public ActionResult SviProizvodi()
        {


            var model = new IndexVM
            {
                broj = ctx.Proizvodi.Count(),
                proizvodi = ctx.Proizvodi.ToList()
            };

            return View("Index", model);
        }




    }
}