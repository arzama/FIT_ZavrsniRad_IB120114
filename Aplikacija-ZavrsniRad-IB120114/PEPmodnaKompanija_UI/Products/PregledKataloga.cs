using PEPmodnaKompanija_API.Models;
using PEPmodnaKompanija_UI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEPmodnaKompanija_UI.Products
{
    public partial class PregledKataloga : Form
    {
        WebAPIHelper katalogService = new WebAPIHelper("http://localhost:51062/", "api/Katalog");
        WebAPIHelper vrsteKatalogaService = new WebAPIHelper("http://localhost:51062/", "api/VrsteKataloga");
        WebAPIHelper proizvodiService = new WebAPIHelper("http://localhost:51062/", "api/Proizvodi");

        List<usp_KatalogByVrsta_Result> katalozi { get; set; }
        List<usp_ProizvodiByKatalog_Result> proizvodi { get; set; }
        public PregledKataloga()
        {
            InitializeComponent();
            
        }


        private void PregledKataloga_Load(object sender, EventArgs e)
        {
            BindGridKatalog();
        }

       

        private void BindGridKatalog()
        {


            HttpResponseMessage response = katalogService.GetActionResponse("KatalogByVrsta");


            if (response.IsSuccessStatusCode)
            {
                dgKatalog.AutoGenerateColumns = false;
                katalozi = response.Content.ReadAsAsync<List<usp_KatalogByVrsta_Result>>().Result;
                dgKatalog.DataSource = katalozi;


            }
        }

        private void BindGridKatalogStavke(int Id)
        {


            HttpResponseMessage response = proizvodiService.GetActionResponse("ProizvodiByKatalog", Id.ToString());


            if (response.IsSuccessStatusCode)
            {
                dgKatalogStavke.AutoGenerateColumns = false;
                   proizvodi = response.Content.ReadAsAsync<List<usp_ProizvodiByKatalog_Result>>().Result;
                   dgKatalogStavke.DataSource = proizvodi;


            }
        }

      
        private void dgKatalog_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = dgKatalog.SelectedCells[0].RowIndex; 

            int Id = Convert.ToInt32(dgKatalog.Rows[selectedrowindex].Cells[0].Value);

              foreach (usp_KatalogByVrsta_Result item in katalozi){
                  if (Id == item.KatalogID)
                  {
                      BindGridKatalogStavke(Id);
                  
                  }
            }
        }

        //private void dgKatalogStavke_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    int selectedrowindex = dgKatalogStavke.SelectedCells[0].RowIndex; 

        //    int Id = Convert.ToInt32(dgKatalogStavke.Rows[selectedrowindex].Cells[0].Value);

        //    byte[] slika = null;
        //    foreach (usp_ProizvodiByKatalog_Result item in proizvodi)
        //    {
        //        if (Id== item.ProizvodID)
        //        {

        //            MemoryStream ms = new MemoryStream(item.SlikaThumb);
        //            Image GotovaSlika = Image.FromStream(ms);

        //            proizvodPictureBox.Image = GotovaSlika;

        //        }

        //    }
        //}

        private void dgKatalogStavke_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      

    }
}
