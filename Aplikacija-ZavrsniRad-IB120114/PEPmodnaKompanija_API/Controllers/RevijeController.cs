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
    public class RevijeController : ApiController
    {
        private PEPBazaEntities1 db = new PEPBazaEntities1();
        
        // GET: api/Revije
        public IQueryable<Revije> GetRevije()
        {   

            return db.Revije;
        }

        // GET: api/Revije/5
        [ResponseType(typeof(Revije))]
        public IHttpActionResult GetRevije(int id)
        {
            Revije revije = db.Revije.Find(id);
            if (revije == null)
            {
                return NotFound();
            }

            return Ok(revije);
        }
        [HttpGet]
        [Route("api/Revije/GetAllRevije")]
        public List<usp_AllRevije_Result> GetAllRevije()
        {
            return db.usp_AllRevije().ToList();
        }

        [HttpGet]
        [Route("api/Revije/SelectRevijeByKorisnik/{typeId}")]
        public List<RevijeByKorisnik> SelectRevijeByKorisnik(int typeId)
        {
            return db.usp_RevijeByKorisnik(typeId).ToList();
        }

        [HttpGet]
        [Route("api/Revije/RevijeByDatum/{Od}/{Do}")]
        public List<usp_RevijeByDatum_Result> RevijeByDatum(string Od, string Do)
        {
         DateTime datumOd = Convert.ToDateTime(Od);
            DateTime datumDo = Convert.ToDateTime(Do);
            return db.usp_RevijeByDatum(datumOd,datumDo).ToList();
        }

        [HttpGet]
        [Route("api/Revije/RevijeByKorisnikLook/{typeId}")]
        public List<usp_RevijeByKorisnikLook_Result> RevijeByKorisnikLook(int typeId)
        {
            return db.usp_RevijeByKorisnikLook(typeId).ToList();
        }
        // PUT: api/Revije/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRevije(int id, Revije revije)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != revije.RevijaID)
            {
                return BadRequest();
            }

            db.Entry(revije).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RevijeExists(id))
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

        // POST: api/Revije
        [ResponseType(typeof(Revije))]
        public IHttpActionResult PostRevije(Revije revije)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Revije.Add(revije);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = revije.RevijaID }, revije);
        }

        // DELETE: api/Revije/5
        [ResponseType(typeof(Revije))]
        public IHttpActionResult DeleteRevije(int id)
        {
            Revije revije = db.Revije.Find(id);
            if (revije == null)
            {
                return NotFound();
            }

            db.Revije.Remove(revije);
            db.SaveChanges();

            return Ok(revije);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RevijeExists(int id)
        {
            return db.Revije.Count(e => e.RevijaID == id) > 0;
        }
    }
}