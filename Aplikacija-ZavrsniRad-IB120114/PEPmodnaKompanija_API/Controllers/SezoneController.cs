﻿using System;
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
    public class SezoneController : ApiController
    {
        private PEPBazaEntities1 db = new PEPBazaEntities1();

        // GET: api/Sezone
        public IQueryable<Sezone> GetSezone()
        {
            return db.Sezone.OrderBy(x=> x.Naziv);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}