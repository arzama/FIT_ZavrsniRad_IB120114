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
    public class FavouriteController : ApiController
    {
        private PEPBazaEntities1 db = new PEPBazaEntities1();

        // GET: api/Favourite
        public IQueryable<Favourite> GetFavourite()
        {
            return db.Favourite;
        }

        // GET: api/Favourite/5
        [ResponseType(typeof(Favourite))]
        public IHttpActionResult GetFavourite(int id)
        {
            Favourite favourite = db.Favourite.Find(id);
            if (favourite == null)
            {
                return NotFound();
            }

            return Ok(favourite);
        }

        [HttpGet]
        [Route("api/Favourite/FavouriteByKupac/{kupacID}")]
        public List<Favourite> FavouriteByKupac(int kupacID)
        {

            return db.Favourite.Where(x => x.KupacID == kupacID).ToList();
        }

        [HttpGet]
        [Route("api/Favourite/FavouriteByKupac1/{kupacID}")]
        public Favourite FavouriteByKupac1(int kupacID)
        {

            return db.Favourite.Where(x => x.KupacID == kupacID).FirstOrDefault();
        }

        [HttpGet]
        [Route("api/Favourite/GetLast")]
        public Favourite GetLast()
        {
            return db.Favourite.OrderByDescending(x => x.FavouriteID).Take(1).FirstOrDefault();
        }

        // PUT: api/Favourite/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutFavourite(int id, Favourite favourite)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != favourite.FavouriteID)
            {
                return BadRequest();
            }

            db.Entry(favourite).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FavouriteExists(id))
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

        // POST: api/Favourite
        [ResponseType(typeof(Favourite))]
        public IHttpActionResult PostFavourite(Favourite favourite)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            favourite.FavouriteID = Convert.ToInt32(db.usp_FavouriteInsert(favourite.KupacID).FirstOrDefault());

            //foreach (FavouiriteProizvod item in favourite.FavouiriteProizvod)
            //{
            //    db.usp_FavouriteProizvod_Insert(favourite.FavouriteID, item.ProizvodID);
            //}


            return CreatedAtRoute("DefaultApi", new { id = favourite.FavouriteID }, favourite);
        }

        // DELETE: api/Favourite/5
        [ResponseType(typeof(Favourite))]
        public IHttpActionResult DeleteFavourite(int id)
        {
            Favourite favourite = db.Favourite.Find(id);
            if (favourite == null)
            {
                return NotFound();
            }

            db.Favourite.Remove(favourite);
            db.SaveChanges();

            return Ok(favourite);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool FavouriteExists(int id)
        {
            return db.Favourite.Count(e => e.FavouriteID == id) > 0;
        }
    }
}