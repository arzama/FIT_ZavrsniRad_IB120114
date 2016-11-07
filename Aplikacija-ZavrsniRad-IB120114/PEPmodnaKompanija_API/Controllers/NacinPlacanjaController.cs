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
    public class NacinPlacanjaController : ApiController
    {
        private PEPBazaEntities1 db = new PEPBazaEntities1();

        // GET: api/NacinPlacanja
        public IQueryable<NacinPlacanja> GetNacinPlacanja()
        {
            return db.NacinPlacanja;
        }

        // GET: api/NacinPlacanja/5
        [ResponseType(typeof(NacinPlacanja))]
        public IHttpActionResult GetNacinPlacanja(int id)
        {
            NacinPlacanja nacinPlacanja = db.NacinPlacanja.Find(id);
            if (nacinPlacanja == null)
            {
                return NotFound();
            }

            return Ok(nacinPlacanja);
        }

        // PUT: api/NacinPlacanja/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutNacinPlacanja(int id, NacinPlacanja nacinPlacanja)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != nacinPlacanja.NacinPlacanjaID)
            {
                return BadRequest();
            }

            db.Entry(nacinPlacanja).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NacinPlacanjaExists(id))
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

        // POST: api/NacinPlacanja
        [ResponseType(typeof(NacinPlacanja))]
        public IHttpActionResult PostNacinPlacanja(NacinPlacanja nacinPlacanja)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.NacinPlacanja.Add(nacinPlacanja);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = nacinPlacanja.NacinPlacanjaID }, nacinPlacanja);
        }

        // DELETE: api/NacinPlacanja/5
        [ResponseType(typeof(NacinPlacanja))]
        public IHttpActionResult DeleteNacinPlacanja(int id)
        {
            NacinPlacanja nacinPlacanja = db.NacinPlacanja.Find(id);
            if (nacinPlacanja == null)
            {
                return NotFound();
            }

            db.NacinPlacanja.Remove(nacinPlacanja);
            db.SaveChanges();

            return Ok(nacinPlacanja);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool NacinPlacanjaExists(int id)
        {
            return db.NacinPlacanja.Count(e => e.NacinPlacanjaID == id) > 0;
        }
    }
}