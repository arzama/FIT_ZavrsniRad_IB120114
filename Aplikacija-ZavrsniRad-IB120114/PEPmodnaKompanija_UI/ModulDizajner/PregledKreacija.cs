using PEPmodnaKompanija_API.Models;
using PEPmodnaKompanija_UI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEPmodnaKompanija_UI.ModulDizajner
{
    public partial class PregledKreacija : Form
    {
        WebAPIHelper vrsteProizvodaService = new WebAPIHelper("http://localhost:51062/", "api/VrsteProizvoda");
        WebAPIHelper sezoneService = new WebAPIHelper("http://localhost:51062/", "api/Sezone");
        WebAPIHelper proizvodiService = new WebAPIHelper("http://localhost:51062/", "api/Proizvodi");
        List<usp_PretragaProizvoda__Result> proizvodi;

        public PregledKreacija()
        {
            InitializeComponent();
        }

        private void PregledKreacija_Load(object sender, EventArgs e)
        {
            BindVrsteProizvoda();
            BindSezone();
            BindGrid();
        }
        private void BindVrsteProizvoda()
        {
            HttpResponseMessage response = vrsteProizvodaService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<VrsteProizvoda> vrste = response.Content.ReadAsAsync<List<VrsteProizvoda>>().Result;
                vrste.Insert(0, new VrsteProizvoda());
                vrste[0].Naziv = "Odaberite vrstu";
                vrstaList.DataSource = vrste;
                vrstaList.DisplayMember = "Naziv";
                vrstaList.ValueMember = "VrstaID";
            }

        }

        private void BindSezone()
        {
            HttpResponseMessage response = sezoneService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<Sezone> sezone = response.Content.ReadAsAsync<List<Sezone>>().Result;
                sezone.Insert(0, new Sezone());
                sezone[0].Naziv = "Odaberite sezonu";
                sezonaList.DataSource = sezone;
                sezonaList.DisplayMember = "Naziv";
                sezonaList.ValueMember = "SezonaID";

            }
        }

        //private void BindGrid()
        //{



        //    HttpResponseMessage response = proizvodiService.GetActionResponse("PregledKreacija", Global.prijavljeniKorisnik.KorisnikID.ToString());


        //    if (response.IsSuccessStatusCode)
        //    {

        //        dgProizvodi.AutoGenerateColumns = false;

        //        proizvodi = response.Content.ReadAsAsync<List<Proizvodi>>().Result;
        //        dgProizvodi.DataSource = proizvodi;

        //    }
        //}

        private void btnPretraga_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {



            HttpResponseMessage response = proizvodiService.GetActionResponse4("PregledKreacija",Global.prijavljeniKorisnik.KorisnikID.ToString(), Convert.ToInt32(vrstaList.SelectedValue), Convert.ToInt32(sezonaList.SelectedValue), nazivInput.Text.Trim());


            if (response.IsSuccessStatusCode)
            {

                dgProizvodi.AutoGenerateColumns = false;

                proizvodi = response.Content.ReadAsAsync<List<usp_PretragaProizvoda__Result>>().Result;
                dgProizvodi.DataSource = proizvodi;

            }
        }

        private void dgProizvodi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
