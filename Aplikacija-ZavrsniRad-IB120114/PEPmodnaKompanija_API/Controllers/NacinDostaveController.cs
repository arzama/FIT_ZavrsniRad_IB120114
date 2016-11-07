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
    public class NacinDostaveController : ApiController
    {
        private PEPBazaEntities1 db = new PEPBazaEntities1();

        // GET: api/NacinDostave
        public IQueryable<NacinDostave> GetNacinDostave()
        {
            return db.NacinDostave;
        }

        // GET: api/NacinDostave/5
        [ResponseType(typeof(NacinDostave))]
        public IHttpActionResult GetNacinDostave(int id)
        {
            NacinDostave nacinDostave = db.NacinDostave.Find(id);
            if (nacinDostave == null)
            {
                return NotFound();
            }

            return Ok(nacinDostave);
        }

        // PUT: api/NacinDostave/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutNacinDostave(int id, NacinDostave nacinDostave)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != nacinDostave.NacinDostaveID)
            {
                return BadRequest();
            }

            db.Entry(nacinDostave).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NacinDostaveExists(id))
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

        // POST: api/NacinDostave
        [ResponseType(typeof(NacinDostave))]
        public IHttpActionResult PostNacinDostave(NacinDostave nacinDostave)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.NacinDostave.Add(nacinDostave);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = nacinDostave.NacinDostaveID }, nacinDostave);
        }

        // DELETE: api/NacinDostave/5
        [ResponseType(typeof(NacinDostave))]
        public IHttpActionResult DeleteNacinDostave(int id)
        {
            NacinDostave nacinDostave = db.NacinDostave.Find(id);
            if (nacinDostave == null)
            {
                return NotFound();
            }

            db.NacinDostave.Remove(nacinDostave);
            db.SaveChanges();

            return Ok(nacinDostave);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool NacinDostaveExists(int id)
        {
            return db.NacinDostave.Count(e => e.NacinDostaveID == id) > 0;
        }
    }
}