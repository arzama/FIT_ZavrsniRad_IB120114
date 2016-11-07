using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using PEPmodnaKompanija_API.Models;

namespace PEPmodnaKompanija_API.Controllers
{
    public class VelicineController : ApiController
    {
        private PEPBazaEntities1 db = new PEPBazaEntities1();
        // GET: api/Velicine
        public IQueryable<Velicine> GetVelicine()
        {
            return db.Velicine.OrderBy(x => x.Naziv);
        }

        [HttpGet]
        [Route("api/Velicine/DostupneVelicine/{naziv}")]
        public List<Velicine> DostupneVelicine(string naziv)
        {
            return db.usp_DostupneVelicine(naziv).ToList();
        }


        //[HttpGet]
        //[Route("api/Velicine/UcitajVelicine/{proizvodID}")]
        //public List<Velicine> UcitajVelicine(int proizvodID)
        //{
        //    List<Velicine> velicine = new List<Velicine>();
        //    string naziv = "";
        //    naziv = db.Proizvodi.Where(x => x.ProizvodID == proizvodID).FirstOrDefault().Naziv;

        //    List<Proizvodi> sviP = db.Proizvodi.Where(x => x.Naziv == naziv).ToList();
          
        //    foreach (var item in sviP)
        //    {
        //        velicine= db.Velicine.Where(x => x.VelicinaID == item.VelicinaID).ToList();
                   


        //    }


        //    return velicine;
        //}


    }
}