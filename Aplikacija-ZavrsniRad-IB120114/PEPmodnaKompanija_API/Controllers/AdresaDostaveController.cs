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
    public class AdresaDostaveController : ApiController
    {
        private PEPBazaEntities1 db = new PEPBazaEntities1();

        // GET: api/AdresaDostave
        public IQueryable<AdresaDostave> GetAdresaDostave()
        {
            return db.AdresaDostave;
        }
        [HttpGet]
        [Route("api/AdresaDostave/GetLast")]
        public AdresaDostave GetLast()
        {
            return db.AdresaDostave.OrderByDescending(x=>x.AdresaDostaveID).Take(1).FirstOrDefault();
        }

        // GET: api/AdresaDostave/5
        [ResponseType(typeof(AdresaDostave))]
        public IHttpActionResult GetAdresaDostave(int id)
        {
            AdresaDostave adresaDostave = db.AdresaDostave.Find(id);
            if (adresaDostave == null)
            {
                return NotFound();
            }

            return Ok(adresaDostave);
        }

        // PUT: api/AdresaDostave/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAdresaDostave(int id, AdresaDostave adresaDostave)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != adresaDostave.AdresaDostaveID)
            {
                return BadRequest();
            }

            db.Entry(adresaDostave).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdresaDostaveExists(id))
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

        // POST: api/AdresaDostave
        [ResponseType(typeof(AdresaDostave))]
        public IHttpActionResult PostAdresaDostave(AdresaDostave adresaDostave)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.AdresaDostave.Add(adresaDostave);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = adresaDostave.AdresaDostaveID }, adresaDostave);
        }

        // DELETE: api/AdresaDostave/5
        [ResponseType(typeof(AdresaDostave))]
        public IHttpActionResult DeleteAdresaDostave(int id)
        {
            AdresaDostave adresaDostave = db.AdresaDostave.Find(id);
            if (adresaDostave == null)
            {
                return NotFound();
            }

            db.AdresaDostave.Remove(adresaDostave);
            db.SaveChanges();

            return Ok(adresaDostave);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AdresaDostaveExists(int id)
        {
            return db.AdresaDostave.Count(e => e.AdresaDostaveID == id) > 0;
        }
    }
}