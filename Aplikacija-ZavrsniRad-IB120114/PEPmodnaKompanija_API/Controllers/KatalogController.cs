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
    public class KatalogController : ApiController
    {
        private PEPBazaEntities1 db = new PEPBazaEntities1();

        // GET: api/Katalog
        public IQueryable<Katalog> GetKatalog()
        {
            return db.Katalog;
        }

        // GET: api/Katalog/5
        [ResponseType(typeof(Katalog))]
        public IHttpActionResult GetKatalog(int id)
        {
            Katalog katalog = db.Katalog.Find(id);
            if (katalog == null)
            {
                return NotFound();
            }

            return Ok(katalog);
        }

        // PUT: api/Katalog/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutKatalog(int id, Katalog katalog)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != katalog.KatalogID)
            {
                return BadRequest();
            }

            db.Entry(katalog).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KatalogExists(id))
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

        [HttpGet]
        [Route("api/Katalog/KatalogSelect")]
        public List<usp_KatalogSelect_Result> KatalogSelect()
        {
            return db.usp_KatalogSelect().ToList();
        }

        [HttpGet]
        [Route("api/Katalog/KatalogByVrsta")]
        public List<usp_KatalogByVrsta_Result> KatalogByVrsta()
        {
            return db.usp_KatalogByVrsta().ToList();
        }
        [HttpGet]
        [Route("api/Katalog/GetLast")]
        public Katalog GetLast()
        {
            return db.Katalog.OrderByDescending(x=>x.KatalogID).Take(1).FirstOrDefault();
        }

        // POST: api/Katalog
        [ResponseType(typeof(Katalog))]
        public IHttpActionResult PostKatalog(Katalog katalog)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

        
            katalog.KatalogID= Convert.ToInt32(db.usp_Katalog_Insert(katalog.Naziv,katalog.KorisnikID).FirstOrDefault());
           

            foreach (Proizvodi item in katalog.Proizvodi)
            {
                db.usp_KatalogProizvod_Insert(katalog.KatalogID, item.ProizvodID);
            }

            return CreatedAtRoute("DefaultApi", new { id = katalog.KatalogID }, katalog);
        }

        // DELETE: api/Katalog/5
        [ResponseType(typeof(Katalog))]
        public IHttpActionResult DeleteKatalog(int id)
        {
            Katalog katalog = db.Katalog.Find(id);
            if (katalog == null)
            {
                return NotFound();
            }

            db.Katalog.Remove(katalog);
            db.SaveChanges();

            return Ok(katalog);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool KatalogExists(int id)
        {
            return db.Katalog.Count(e => e.KatalogID == id) > 0;
        }
    }
}