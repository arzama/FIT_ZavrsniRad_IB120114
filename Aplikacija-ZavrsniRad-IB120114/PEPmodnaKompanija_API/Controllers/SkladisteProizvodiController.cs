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
    public class SkladisteProizvodiController : ApiController
    {
        private PEPBazaEntities1 db = new PEPBazaEntities1();

        // GET: api/SkladisteProizvodi
        public IQueryable<SkladisteProizvodi> GetSkladisteProizvodi()
        {
            return db.SkladisteProizvodi;
        }

        // GET: api/SkladisteProizvodi/5
        [ResponseType(typeof(SkladisteProizvodi))]
        public IHttpActionResult GetSkladisteProizvodi(int id)
        {
            SkladisteProizvodi skladisteProizvodi = db.SkladisteProizvodi.Find(id);
            if (skladisteProizvodi == null)
            {
                return NotFound();
            }

            return Ok(skladisteProizvodi);
        }

        // PUT: api/SkladisteProizvodi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSkladisteProizvodi(int id, SkladisteProizvodi skladisteProizvodi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != skladisteProizvodi.SkladisteProizvodiID)
            {
                return BadRequest();
            }

            db.Entry(skladisteProizvodi).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SkladisteProizvodiExists(id))
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

        // POST: api/SkladisteProizvodi
        [ResponseType(typeof(SkladisteProizvodi))]
        public IHttpActionResult PostSkladisteProizvodi(SkladisteProizvodi skladisteProizvodi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.SkladisteProizvodi.Add(skladisteProizvodi);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = skladisteProizvodi.SkladisteProizvodiID }, skladisteProizvodi);
        }

        // DELETE: api/SkladisteProizvodi/5
        [ResponseType(typeof(SkladisteProizvodi))]
        public IHttpActionResult DeleteSkladisteProizvodi(int id)
        {
            SkladisteProizvodi skladisteProizvodi = db.SkladisteProizvodi.Find(id);
            if (skladisteProizvodi == null)
            {
                return NotFound();
            }

            db.SkladisteProizvodi.Remove(skladisteProizvodi);
            db.SaveChanges();

            return Ok(skladisteProizvodi);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SkladisteProizvodiExists(int id)
        {
            return db.SkladisteProizvodi.Count(e => e.SkladisteProizvodiID == id) > 0;
        }
    }
}