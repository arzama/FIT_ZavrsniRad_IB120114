using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Web.Http;
using PEPmodnaKompanija_API.Models;
using PEPmodnaKompanija_API.Util;

namespace PEPmodnaKompanija_API.Controllers
{
    public class PreporukaController : ApiController
    {
        private PEPBazaEntities1 db = new PEPBazaEntities1();

        [HttpGet]
        [Route("api/Preporuka/GetSlicneProizvode/{id}")]
        public List<usp_Proizvodi_SelectById_Result> GetSlicneProizvode(int id)
        {
            Preporuka preporuka = new Preporuka();

            return preporuka.GetSlicneProizvode(id);
        }

        [HttpGet]
        [Route("api/Preporuka/GetTakodjerKupili/{proizvodID}/{kupacID}")]
        public List<Proizvodi> GetTakodjerKupili(int proizvodID, int kupacID)
        {
            List<usp_UserBased_Preporuka_Result> vraceni = db.usp_UserBased_Preporuka(proizvodID, kupacID).ToList();
            List<Proizvodi> proizvodi = new List<Proizvodi>();
            foreach(var item in vraceni){
                foreach(var p in  db.Proizvodi.ToList()){
                    if (p.ProizvodID == item.ProizvodID)
                    {

                        proizvodi.Add(p);
                    }
                }
            }

            return proizvodi;
        }

        [HttpGet]
        [Route("api/Preporuka/GetNajprodavanije")]
        public List<usp_Select_NajprodavanijiProizvodi_Result> GetNajprodavanije()
        {

            return db.usp_Select_NajprodavanijiProizvodi().ToList();
        }


        [HttpGet]
        [Route("api/Preporuka/NajboljeOcijenjeniProizvodi")]
        public List<usp_najboljeOcijenjeniProizvodi_Result> NajboljeOcijenjeniProizvodi()
        {
            return db.usp_najboljeOcijenjeniProizvodi().ToList();
        }

        [HttpGet]
        [Route("api/Preporuka/NajboljeOcijenjeniDizajneri")]
        public List<usp_najboljeOcijenjeniDizajneri_Result> NajboljeOcijenjeniDizajneri()
        {
            return db.usp_najboljeOcijenjeniDizajneri().ToList();
        }



        [HttpGet]
        [Route("api/Preporuka/NajprodavanijiByMjesec/{datum}")]
        public List<usp_NajprodavanijiByMjesec_Result> NajprodavanijiByMjesec(string datum)
        {
            DateTime datumm = Convert.ToDateTime(datum);
            return db.usp_NajprodavanijiByMjesec(datumm).ToList();
        }


    }
}