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

namespace PEPmodnaKompanija_API.Controllers
{
    public class LookBookController : ApiController
    {
        private PEPBazaEntities1 db = new PEPBazaEntities1();

        // GET: api/LookBook
        public IQueryable<LookBook> GetLookBook()
        {
            return db.LookBook.OrderBy(x=> x.Naziv);
        }

        // GET: api/LookBook/5
        [ResponseType(typeof(LookBook))]
        public IHttpActionResult GetLookBook(int id)
        {
            LookBook lookBook = db.LookBook.Find(id);
            if (lookBook == null)
            {
                return NotFound();
            }

            return Ok(lookBook);
        }

        // PUT: api/LookBook/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutLookBook(int id, LookBook lookBook)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != lookBook.LookBookID)
            {
                return BadRequest();
            }

            db.Entry(lookBook).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LookBookExists(id))
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

        // POST: api/LookBook
        [ResponseType(typeof(LookBook))]
        public IHttpActionResult PostLookBook(LookBook lookBook)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

         
                lookBook.LookBookID = Convert.ToInt32(db.usp_LookBook_Insert(lookBook.Naziv, lookBook.KorisnikID).FirstOrDefault());
      
            
            foreach (Modeli item in lookBook.Modeli)
            {
                db.usp_ModelLookBook_Insert(lookBook.LookBookID, item.ModelID);
            }
            return CreatedAtRoute("DefaultApi", new { id = lookBook.LookBookID }, lookBook);
        }


        private HttpResponseException CreateHttpResponseException(string reason, HttpStatusCode code)
        {
            var response = new HttpResponseMessage
            {
                StatusCode = code,
                ReasonPhrase = reason,
                Content = new StringContent(reason)
            };

            return new HttpResponseException(response);
        }

        // DELETE: api/LookBook/5
        [ResponseType(typeof(LookBook))]
        public IHttpActionResult DeleteLookBook(int id)
        {
            LookBook lookBook = db.LookBook.Find(id);
            if (lookBook == null)
            {
                return NotFound();
            }

            db.LookBook.Remove(lookBook);
            db.SaveChanges();

            return Ok(lookBook);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LookBookExists(int id)
        {
            return db.LookBook.Count(e => e.LookBookID == id) > 0;
        }
    }
}