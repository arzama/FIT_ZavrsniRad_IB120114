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
    public class NarudzbeController : ApiController
    {
        private PEPBazaEntities1 db = new PEPBazaEntities1();

        // GET: api/Narudzbe
        public IQueryable<Narudzbe> GetNarudzbe()
        {
            return db.Narudzbe;
        }

        // GET: api/Narudzbe/5
        [ResponseType(typeof(Narudzbe))]
        public IHttpActionResult GetNarudzbe(int id)
        {
            Narudzbe narudzbe = db.Narudzbe.Find(id);
            if (narudzbe == null)
            {
                return NotFound();
            }

            return Ok(narudzbe);
        }



        [HttpGet]
        [Route("api/Narudzbe/GetBrojAktivnihNarudzbi")]
        public int GetBrojAktivnihNarudzbi()
        {
            return db.Narudzbe.Where(x => x.Status == true).Count();
        }


        [HttpGet]
        [Route("api/Narudzbe/SelectNarudzbe")]
        public List<usp_SelectNarudzbeDesk_Result> SelectNarudzbe()
        {
            return db.usp_SelectNarudzbeDesk().ToList();
        }


       
        [HttpGet]
        [Route("api/Narudzbe/GetAktivneNarudzbe")]
        public List<usp_Narudzbe_SelectAktivne_Result> GetAktivneNarudzbe()
        {
            return db.usp_Narudzbe_SelectAktivne().ToList();
        }

        [HttpGet]
        [Route("api/Narudzbe/GetListaNarudzbi/{kupacId}")]
        public List<usp_Select_Narudzbe_Result> GetListaNarudzbi(int kupacId)
        {
            return db.usp_Select_Narudzbe(kupacId).ToList();
        }


        [HttpGet]
        [Route("api/Narudzbe/GetStavkeNarudzbe/{id}")]
        public List<usp_NarudzbeStavke_SelectByNarudzbaID_Result> GetStavkeNarudzbe(int id)
        {
            return db.usp_NarudzbeStavke_SelectByNarudzbaID(id).ToList();
        }

        // PUT: api/Narudzbe/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutNarudzbe(int id, Narudzbe narudzbe)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != narudzbe.NarudzbaID)
            {
                return BadRequest();
            }

            db.Entry(narudzbe).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NarudzbeExists(id))
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

        [HttpPost]
        [Route("api/Narudzbe/ProcesirajNarudzbu")]
        public void ProcesirajNarudzbu(Izlazi izlaz)
        {

            db.usp_Izlazi_InsertByNarudzbaID(izlaz.NarudzbaID,izlaz.SkladisteID, izlaz.KorisnikID);
        }


        // POST: api/Narudzbe
        [ResponseType(typeof(Narudzbe))]
        public IHttpActionResult PostNarudzbe(Narudzbe narudzbe)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            narudzbe.NarudzbaID = Convert.ToInt32(db.usp_Narudzbe_Insert(narudzbe.BrojNarudzbe, narudzbe.KupacID, narudzbe.Datum, narudzbe.AdresaDostaveID, narudzbe.NacinDostaveID, narudzbe.NacinPlacanjaID).FirstOrDefault());

            foreach (NarudzbaStavke item in narudzbe.NarudzbaStavke)
            {
                db.usp_NarudzbaStavke_Insert(narudzbe.NarudzbaID, item.ProizvodID, item.Kolicina);
            }

            return CreatedAtRoute("DefaultApi", new { id = narudzbe.NarudzbaID }, narudzbe);
        }

        // DELETE: api/Narudzbe/5
        [ResponseType(typeof(Narudzbe))]
        public IHttpActionResult DeleteNarudzbe(int id)
        {
            Narudzbe narudzbe = db.Narudzbe.Find(id);
            if (narudzbe == null)
            {
                return NotFound();
            }

            db.Narudzbe.Remove(narudzbe);
            db.SaveChanges();

            return Ok(narudzbe);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool NarudzbeExists(int id)
        {
            return db.Narudzbe.Count(e => e.NarudzbaID == id) > 0;
        }
    }
}