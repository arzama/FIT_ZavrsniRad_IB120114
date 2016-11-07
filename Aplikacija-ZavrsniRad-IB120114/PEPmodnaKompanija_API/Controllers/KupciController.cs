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
    public class KupciController : ApiController
    {
        private PEPBazaEntities1 db = new PEPBazaEntities1();

        // GET: api/Kupci
        public IQueryable<Kupci> GetKupci()
        {
            return db.Kupci;
        }

        [Route("api/Kupci/GetKupciByUsername/{username?}")]
        public IHttpActionResult GetKupciByUsername(string username="")
        {
            Kupci k = db.Kupci.Where(x => x.KorisnickoIme == username && x.Status == true).FirstOrDefault();
            if (k == null)
            {
                return NotFound();
            }

            return Ok(k);
        }

        // GET: api/Kupci/5
        [ResponseType(typeof(Kupci))]
        public IHttpActionResult GetKupci(int id)
        {
            Kupci kupci = db.Kupci.Find(id);
            if (kupci == null)
            {
                return NotFound();
            }

            return Ok(kupci);
        }
        [HttpGet]
        [ResponseType(typeof(Kupci))]
        [Route("api/Kupci/EditKupac/{id}/{ime}/{prezime}/{email}")]
        public IHttpActionResult EditKupac(int id, string ime, string prezime, string email)
        {

            Kupci kupac = db.Kupci.Where(x => x.KupacID == id).FirstOrDefault();
            db.Entry(kupac).State = EntityState.Modified;
            kupac.Ime = ime; kupac.Prezime = prezime; kupac.Email = email; 
            db.SaveChanges();
            if (kupac == null)
            {
                return NotFound();
            }

            return Ok(kupac);
        }


        // PUT: api/Kupci/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutKupci(int id, Kupci kupci)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != kupci.KupacID)
            {
                return BadRequest();
            }

            db.Entry(kupci).State = EntityState.Modified;

            try
            {
               
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KupciExists(id))
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

        // POST: api/Kupci
        [ResponseType(typeof(Kupci))]
        public IHttpActionResult PostKupci(Kupci kupci)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Kupci.Add(kupci);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = kupci.KupacID }, kupci);
        }

        // DELETE: api/Kupci/5
        [ResponseType(typeof(Kupci))]
        public IHttpActionResult DeleteKupci(int id)
        {
            Kupci kupci = db.Kupci.Find(id);
            if (kupci == null)
            {
                return NotFound();
            }

            db.Kupci.Remove(kupci);
            db.SaveChanges();

            return Ok(kupci);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool KupciExists(int id)
        {
            return db.Kupci.Count(e => e.KupacID == id) > 0;
        }
    }
}