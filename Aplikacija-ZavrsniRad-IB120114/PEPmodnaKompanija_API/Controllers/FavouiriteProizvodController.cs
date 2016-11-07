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
    public class FavouiriteProizvodController : ApiController
    {
        private PEPBazaEntities1 db = new PEPBazaEntities1();

        // GET: api/FavouiriteProizvod
        public IQueryable<FavouiriteProizvod> GetFavouiriteProizvod()
        {
            return db.FavouiriteProizvod;
        }

        // GET: api/FavouiriteProizvod/5
        [ResponseType(typeof(FavouiriteProizvod))]
        public IHttpActionResult GetFavouiriteProizvod(int id)
        {
            FavouiriteProizvod favouiriteProizvod = db.FavouiriteProizvod.Find(id);
            if (favouiriteProizvod == null)
            {
                return NotFound();
            }

            return Ok(favouiriteProizvod);
        }
            [HttpGet]
   [Route("api/FavouiriteProizvod/PostojiUListi/{proizvodID}/{kupacID}")]
        public FavouiriteProizvod PostojiUListi(int proizvodID, int kupacID)
        {

      

            return db.usp_ProizvodUFavourite(proizvodID, kupacID).FirstOrDefault();
        
             
        }

            [HttpGet]
   [Route("api/FavouiriteProizvod/ListaByFavouriteID/{favouriteID}")]
   public List<FavouiriteProizvod> ListaByFavouriteID(int favouriteID)
   {
       return db.FavouiriteProizvod.Where(x => x.FavouriteID == favouriteID).ToList();
   }

          [HttpGet]
            [Route("api/FavouiriteProizvod/ProizvodiIzFavourite/{favouriteID}")]
            public List<Proizvodi> ProizvodiIzFavourite(int favouriteID)
            {
                return db.usp_ProizvodiIzFavourite(favouriteID).ToList();
            }

          [HttpGet]
          [Route("api/FavouiriteProizvod/GetCount/{favouriteID}")]
          public int GetCount(int favouriteID)
          {
              return db.usp_ProizvodiIzFavourite(favouriteID).Count();
          }


        // PUT: api/FavouiriteProizvod/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutFavouiriteProizvod(int id, FavouiriteProizvod favouiriteProizvod)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != favouiriteProizvod.FavouriteProizvodID)
            {
                return BadRequest();
            }

            db.Entry(favouiriteProizvod).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FavouiriteProizvodExists(id))
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

        // POST: api/FavouiriteProizvod

        [ResponseType(typeof(FavouiriteProizvod))]
        public IHttpActionResult PostFavouiriteProizvod(FavouiriteProizvod favouiriteProizvod)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.FavouiriteProizvod.Add(favouiriteProizvod);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = favouiriteProizvod.FavouriteProizvodID }, favouiriteProizvod);
        }

        // DELETE: api/FavouiriteProizvod/5
            [HttpGet]
            [Route("api/FavouiriteProizvod/DeleteFavouiriteProizvod/{id}/{favouriteID}")]
        [ResponseType(typeof(FavouiriteProizvod))]
        public IHttpActionResult DeleteFavouiriteProizvod(int id, int favouriteID)
        {
            FavouiriteProizvod favouiriteProizvod = db.FavouiriteProizvod.Where(x=> x.ProizvodID==id && x.FavouriteID==favouriteID ).FirstOrDefault();
            //if (favouiriteProizvod == null)
            //{
            //    return NotFound();
            //}

            db.FavouiriteProizvod.Remove(favouiriteProizvod);
            db.SaveChanges();

            return Ok(favouiriteProizvod);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool FavouiriteProizvodExists(int id)
        {
            return db.FavouiriteProizvod.Count(e => e.FavouriteProizvodID == id) > 0;
        }
    }
}