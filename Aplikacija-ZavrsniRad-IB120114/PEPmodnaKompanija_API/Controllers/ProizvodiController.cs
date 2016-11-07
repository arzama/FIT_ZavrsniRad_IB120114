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
    public class ProizvodiController : ApiController
    {
        private PEPBazaEntities1 db = new PEPBazaEntities1();

        // GET: api/Proizvodi
        public IQueryable<Proizvodi> GetProizvodi()
        {
            return db.Proizvodi;
        }


        [HttpGet]
        [Route("api/Proizvodi/GetProizvodi/{id}")]
        [ResponseType(typeof(usp_Proizvodi_SelectById_Result))]
        public IHttpActionResult GetProizvodi(int id)
        {
            usp_Proizvodi_SelectById_Result proizvodi = db.usp_Proizvodi_SelectById(id).FirstOrDefault();

            if (proizvodi == null)
            {
                return NotFound();
            }

            return Ok(proizvodi);
        }

        [HttpGet]
        [Route("api/Proizvodi/ProizvodByVelicina/{velicinaID}/{naziv}")]
        public Proizvodi ProizvodByVelicina(int velicinaID, string naziv = "")
        {
            return db.Proizvodi.Where(x => x.Naziv == naziv && x.VelicinaID==velicinaID).FirstOrDefault();
        }


        [HttpGet]
        [Route("api/Proizvodi/PregledKreacija/{korisnikID}")]
        public List<Proizvodi> PregledKreacija(int korisnikID)
        {
            return db.Proizvodi.Where(x=>x.KorisnikID==korisnikID).ToList();
        }

        [HttpGet]
        [Route("api/Proizvodi/ProizvodiBySkladiste/{skladisteId}")]
        public List<usp_Select_ProizvodiBySkladiste_Result> ProizvodiBySkladiste(int skladisteID)
        {
            return db.usp_Select_ProizvodiBySkladiste(skladisteID).ToList();
        }

        [HttpGet]
        [Route("api/Proizvodi/ProizvodiByModel/{modelId}")]
        public List<usp_ProizvodiByModel_Result> ProizvodiByModel(int modelId)
        {
            return db.usp_ProizvodiByModel(modelId).ToList();
        }

        [HttpGet]
        [Route("api/Proizvodi/ProizvodiByModelPhone/{modelId}")]
        public List<usp_ProizvodiByModelPhone_Result> ProizvodiByModelPhone(int modelId)
        {
            return db.usp_ProizvodiByModelPhone(modelId).ToList();
        }

       
        [HttpGet]
        [Route("api/Proizvodi/ProizvodiByKatalog/{katalogID}")]
        public List<usp_ProizvodiByKatalog_Result> ProizvodiByKatalog(int katalogID)
        {
            return db.usp_ProizvodiByKatalog(katalogID).ToList();
        }

        [HttpGet]
        [Route("api/Proizvodi/ProizvodiByNaziv/{naziv}")]
        public List<Proizvodi> ProizvodiByNaziv(string naziv)
        {
            return db.Proizvodi.Where(x => x.Naziv == naziv).ToList();
        }

        [HttpGet]
        [Route("api/Proizvodi/ProizvodiBySezonaRevija/{sezonaID}")]
        public List<uspProizvodiBySezonaRevija_Result> ProizvodiBySezonaRevija(int? sezonaID)
        {
            return db.uspProizvodiBySezonaRevija(sezonaID).GroupBy(x => x.Naziv).Select(y => y.First()).ToList();
        }


        [HttpGet]
        [Route("api/Proizvodi/PretragaProizvoda/{vrstaID?}/{sezonaID?}/{naziv?}")]
        public List<usp_PretragaProizvoda__Result> PretragaProizvoda(int? vrstaID, int? sezonaID, string naziv = "")
        {


            return db.usp_PretragaProizvoda_(vrstaID, sezonaID, naziv).GroupBy(x=>x.Naziv).Select(x=>x.First()).ToList();
        }
     

        [HttpGet]
        [Route("api/Proizvodi/PregledKreacija/{korisnikID}/{vrstaID?}/{sezonaID?}/{naziv?}")]
        public List<usp_PretragaProizvoda__Result> PregledKreacija( int korisnikID,int? vrstaID, int? sezonaID, string naziv = "")
        {


            return db.usp_PretragaProizvoda_(vrstaID, sezonaID, naziv).Where(x=>x.KorisnikID==korisnikID).ToList();
        }

        // PUT: api/Proizvodi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProizvodi(int id, Proizvodi proizvodi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != proizvodi.ProizvodID)
            {
                return BadRequest();
            }

            db.Entry(proizvodi).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProizvodiExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }






        [ResponseType(typeof(Proizvodi))]
        public IHttpActionResult PostProizvodi(Proizvodi p)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.usp_Proizvodi_Insert(p.Naziv, p.Sifra, p.Cijena, p.VrstaID, p.Slika, p.SlikaThumb, p.Status, p.SezonaID, p.KorisnikID,p.VelicinaID);

            return CreatedAtRoute("DefaultApi", new { id = p.ProizvodID }, p);
        }

        // DELETE: api/Proizvodi/5
        [ResponseType(typeof(Proizvodi))]
        public IHttpActionResult DeleteProizvodi(int id)
        {
            Proizvodi proizvodi = db.Proizvodi.Find(id);
            if (proizvodi == null)
            {
                return NotFound();
            }

            db.Proizvodi.Remove(proizvodi);
            db.SaveChanges();

            return Ok(proizvodi);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProizvodiExists(int id)
        {
            return db.Proizvodi.Count(e => e.ProizvodID == id) > 0;
        }
    }
}