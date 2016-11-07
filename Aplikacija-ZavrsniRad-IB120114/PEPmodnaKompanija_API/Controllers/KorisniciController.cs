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
using System.Data.Entity.Core;
using System.Data.SqlClient;
using PEPmodnaKompanija_API.Util;

namespace PEPmodnaKompanija_API.Controllers
{
  
    public class KorisniciController : ApiController
    {
        private PEPBazaEntities1 db = new PEPBazaEntities1();

        // GET: api/Korisnici
        public IQueryable<Korisnici> GetKorisnici()
        {
            return db.Korisnici;
        }

        // GET api/Korisnici/SearchKorisnici
        [Route("api/Korisnici/SearchKorisnici/{name?}")]
        [HttpGet]
        public List<Korisnici> SearchKorisnici(string name = "")
        {
            return db.usp_Korisnici_SelectByImePrezime(name).ToList();
        }
      
       

       
        [ResponseType(typeof(Korisnici))]
        [Route("api/Korisnici/{username}")]
        public IHttpActionResult GetKorisnici(string username)   //za logiranje
        {
            Korisnici korisnik = db.Korisnici.Where(x=> x.KorisnickoIme==username).FirstOrDefault();
            if (korisnik == null)
            {
                return NotFound();
            }

            return Ok(korisnik);
        }

        // PUT: api/Korisnici/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutKorisnici(int id, Korisnici korisnici)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != korisnici.KorisnikID)
            {
                return BadRequest();
            }

            db.Entry(korisnici).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KorisniciExists(id))
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

        // POST: api/Korisnici                               // DODAVANJE KORISNIKA
        [ResponseType(typeof(Korisnici))]

        public IHttpActionResult PostKorisnici(Korisnici korisnici)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
           {
                korisnici.KorisnikID = Convert.ToInt32(db.usp_Korisnici_Insert(korisnici.Ime, korisnici.Prezime, korisnici.Email, korisnici.Telefon, korisnici.KorisnickoIme,
                    korisnici.LozinkaSalt, korisnici.LozinkaHash, korisnici.Status,korisnici.UlogaID).FirstOrDefault());

           }

            catch(EntityException ex)
            {
              throw CreateHttpResponseEcxeption(Util.ExceptionHandler.HandleException(ex), HttpStatusCode.Conflict);
            }
         
            return CreatedAtRoute("DefaultApi", new { id = korisnici.KorisnikID }, korisnici);
        }

         // EXCEPTION Handler /API  
        private HttpResponseException CreateHttpResponseEcxeption(string reason, HttpStatusCode status)
        {
            HttpResponseMessage msg = new HttpResponseMessage()
            {
                StatusCode = status,
                ReasonPhrase = reason,
                Content = new StringContent(reason)

            };

            return new HttpResponseException(msg);
        }


        // DELETE: api/Korisnici/5
        [ResponseType(typeof(Korisnici))]
        public IHttpActionResult DeleteKorisnici(int id)
        {
            Korisnici korisnici = db.Korisnici.Find(id);
            if (korisnici == null)
            {
                return NotFound();
            }

            db.Korisnici.Remove(korisnici);
            db.SaveChanges();

            return Ok(korisnici);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool KorisniciExists(int id)
        {
            return db.Korisnici.Count(e => e.KorisnikID == id) > 0;
        }
    }
}