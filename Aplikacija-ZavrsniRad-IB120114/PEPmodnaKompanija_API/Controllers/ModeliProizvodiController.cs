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
    public class ModeliProizvodiController : ApiController
    {
        private PEPBazaEntities1 db = new PEPBazaEntities1();

        // GET: api/ModeliProizvodi
        public IQueryable<ModeliProizvodi> GetModeliProizvodi()
        {
            return db.ModeliProizvodi;
        }

        // GET: api/ModeliProizvodi/5
        [ResponseType(typeof(ModeliProizvodi))]
        public IHttpActionResult GetModeliProizvodi(int id)
        {
            ModeliProizvodi modeliProizvodi = db.ModeliProizvodi.Find(id);
            if (modeliProizvodi == null)
            {
                return NotFound();
            }

            return Ok(modeliProizvodi);
        }

        // PUT: api/ModeliProizvodi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutModeliProizvodi(int id, ModeliProizvodi modeliProizvodi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != modeliProizvodi.ModeliProizvodiID)
            {
                return BadRequest();
            }

            db.Entry(modeliProizvodi).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ModeliProizvodiExists(id))
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

        // POST: api/ModeliProizvodi
        [ResponseType(typeof(ModeliProizvodi))]
        public IHttpActionResult PostModeliProizvodi(ModeliProizvodi modeliProizvodi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ModeliProizvodi.Add(modeliProizvodi);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = modeliProizvodi.ModeliProizvodiID }, modeliProizvodi);
        }

        // DELETE: api/ModeliProizvodi/5
        [ResponseType(typeof(ModeliProizvodi))]
        public IHttpActionResult DeleteModeliProizvodi(int id)
        {
            ModeliProizvodi modeliProizvodi = db.ModeliProizvodi.Find(id);
            if (modeliProizvodi == null)
            {
                return NotFound();
            }

            db.ModeliProizvodi.Remove(modeliProizvodi);
            db.SaveChanges();

            return Ok(modeliProizvodi);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ModeliProizvodiExists(int id)
        {
            return db.ModeliProizvodi.Count(e => e.ModeliProizvodiID == id) > 0;
        }
    }
}