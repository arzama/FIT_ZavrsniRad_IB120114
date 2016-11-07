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

namespace PEPmodnaKompanija_UI.Products
{
    public partial class PretragaProizvoda : Form
    {
        WebAPIHelper vrsteProizvodaService = new WebAPIHelper("http://localhost:51062/", "api/VrsteProizvoda");
       WebAPIHelper sezoneService = new WebAPIHelper("http://localhost:51062/", "api/Sezone");
       WebAPIHelper proizvodiService = new WebAPIHelper("http://localhost:51062/", "api/Proizvodi");

       List<usp_PretragaProizvoda__Result> proizvodi;
        public PretragaProizvoda()
        {
            InitializeComponent();
        }

        private void PretragaProizvoda_Load(object sender, EventArgs e)
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

        private void btnPretraga_Click(object sender, EventArgs e)
        {
            BindGrid();
        }
        private void BindGrid()
        { 

            

            HttpResponseMessage response = proizvodiService.GetActionResponse3("PretragaProizvoda", Convert.ToInt32(vrstaList.SelectedValue), Convert.ToInt32(sezonaList.SelectedValue), nazivInput.Text.Trim());


            if (response.IsSuccessStatusCode)
            {

                dgProizvodi.AutoGenerateColumns = false;
             
                 proizvodi= response.Content.ReadAsAsync<List<usp_PretragaProizvoda__Result>>().Result;
                 dgProizvodi.DataSource = proizvodi;

            }
        }

        private void dgProizvodi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = dgProizvodi.SelectedCells[0].RowIndex; 

            string naziv = Convert.ToString(dgProizvodi.Rows[selectedrowindex].Cells[0].Value);

            byte[] slika = null;
            foreach ( usp_PretragaProizvoda__Result item in proizvodi)
            {
                if (item.Naziv == naziv)
                    slika = item.Slika;
            }

            frm_SlikaProizvoda frm = new frm_SlikaProizvoda(slika);
           
            frm.Show();
        }

        private void dgProizvodi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
