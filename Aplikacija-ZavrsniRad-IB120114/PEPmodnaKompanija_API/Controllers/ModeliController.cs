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
    public class ModeliController : ApiController
    {
        private PEPBazaEntities1 db = new PEPBazaEntities1();

        // GET: api/Modeli
        public IQueryable<Modeli> GetModeli()
        {
            return db.Modeli;
        }

        [HttpGet]
        [Route("api/Modeli/GetModeliByDizajnerID/{korisnikID}")]
        public List<Modeli> GetModeliByDizajnerID(int korisnikID)
        {
            return db.Modeli.Where(x=>x.ModeliProizvodi.FirstOrDefault().Proizvodi.KorisnikID==korisnikID).ToList();
        }

     [HttpGet]
        [Route("api/Modeli/GetLastModel")]
        public Modeli GetLastModel()
        {
            return db.usp_Modeli().Last();
        }

     [HttpGet]
     [Route("api/Modeli/ModeliByLookBook/{typeId}")]
     public List<usp_ModeliByLookBook_Result> ModeliByLookBook(int typeId)
     {
         return db.usp_ModeliByLookBook(typeId).ToList();
     }

     //[HttpGet]
     //[Route("api/Modeli/ModeliByLookbookPhone/{lookbookID?}")]
     //public List<usp_ModeliByLookbookPhone_Result> ModeliByLookbookPhone(int? lookbookID)
     //{
     //    return db.usp_ModeliByLookbookPhone(lookbookID).ToList();
     //}
     [HttpGet]
     [Route("api/Modeli/ModeliByLookbookPhone")]
     public  List<usp_ModeliByLookbookPhone_Result> ModeliByLookbookPhone()
     {
   
         return db.usp_ModeliByLookbookPhone().ToList();
     }

     [HttpGet]
     [Route("api/Modeli/AllModeli")]
     public List<usp_AllModeli_Result> AllModeli()
     {
         return db.usp_AllModeli().ToList();
     }



     // GET: api/Modeli/5
        [Route("api/Modeli/GetModeliPhone/{id}")]
     [ResponseType(typeof(usp_Modeli_SelectByIdPhone_Result))]
     public IHttpActionResult  GetModeliPhone(int id)
     {
         usp_Modeli_SelectByIdPhone_Result modeli = db.usp_Modeli_SelectByIdPhone(id).FirstOrDefault();

         if (modeli == null)
         {
             return NotFound();
         }

         return Ok(modeli);
     }


        // GET: api/Modeli/5
        [ResponseType(typeof(Modeli))]
        public IHttpActionResult GetModeli(int id)
        {
            Modeli modeli = db.Modeli.Find(id);
            if (modeli == null)
            {
                return NotFound();
            }

            return Ok(modeli);
        }

        // PUT: api/Modeli/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutModeli(int id, Modeli modeli)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != modeli.ModelID)
            {
                return BadRequest();
            }

            db.Entry(modeli).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ModeliExists(id))
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

        // POST: api/Modeli
        [ResponseType(typeof(Modeli))]
        public IHttpActionResult PostModeli(Modeli modeli)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Modeli.Add(modeli);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = modeli.ModelID }, modeli);
        }

        // DELETE: api/Modeli/5
        [ResponseType(typeof(Modeli))]
        public IHttpActionResult DeleteModeli(int id)
        {
            Modeli modeli = db.Modeli.Find(id);
            if (modeli == null)
            {
                return NotFound();
            }

            db.Modeli.Remove(modeli);
            db.SaveChanges();

            return Ok(modeli);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ModeliExists(int id)
        {
            return db.Modeli.Count(e => e.ModelID == id) > 0;
        }
    }
}