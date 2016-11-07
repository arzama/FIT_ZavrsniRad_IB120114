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
    public class OcjeneDizajneraController : ApiController
    {
        private PEPBazaEntities1 db = new PEPBazaEntities1();

        // GET: api/OcjeneDizajnera
        public IQueryable<OcjeneDizajnera> GetOcjeneDizajnera()
        {
            return db.OcjeneDizajnera;
        }

        // GET: api/OcjeneDizajnera/5
        [ResponseType(typeof(OcjeneDizajnera))]
        public IHttpActionResult GetOcjeneDizajnera(int id)
        {
            OcjeneDizajnera ocjeneDizajnera = db.OcjeneDizajnera.Find(id);
            if (ocjeneDizajnera == null)
            {
                return NotFound();
            }

            return Ok(ocjeneDizajnera);
        }


        [HttpGet]                                                                 
        [Route("api/OcjeneDizajnera/OcjenaDizajnera/{dizajnerID}/{kupacID}/{ocjena}")]
        public void OcjenaDizajnera(int dizajnerID, int kupacID, int ocjena)
        {
         
            db.usp_OcjenaDizajnera_Insert(dizajnerID, kupacID, ocjena);

            
        }



        // PUT: api/OcjeneDizajnera/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutOcjeneDizajnera(int id, OcjeneDizajnera ocjeneDizajnera)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != ocjeneDizajnera.OcjenaDizajneraID)
            {
                return BadRequest();
            }

            db.Entry(ocjeneDizajnera).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OcjeneDizajneraExists(id))
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

        // POST: api/OcjeneDizajnera
        [ResponseType(typeof(OcjeneDizajnera))]
        public IHttpActionResult PostOcjeneDizajnera(OcjeneDizajnera ocjeneDizajnera)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.OcjeneDizajnera.Add(ocjeneDizajnera);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = ocjeneDizajnera.OcjenaDizajneraID }, ocjeneDizajnera);
        }

        // DELETE: api/OcjeneDizajnera/5
        [ResponseType(typeof(OcjeneDizajnera))]
        public IHttpActionResult DeleteOcjeneDizajnera(int id)
        {
            OcjeneDizajnera ocjeneDizajnera = db.OcjeneDizajnera.Find(id);
            if (ocjeneDizajnera == null)
            {
                return NotFound();
            }

            db.OcjeneDizajnera.Remove(ocjeneDizajnera);
            db.SaveChanges();

            return Ok(ocjeneDizajnera);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OcjeneDizajneraExists(int id)
        {
            return db.OcjeneDizajnera.Count(e => e.OcjenaDizajneraID == id) > 0;
        }
    }
}