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

namespace PEPmodnaKompanija_UI.ModulDizajner
{
    public partial class PregledLookBooka : Form
    {
        WebAPIHelper lookBookService = new WebAPIHelper("http://localhost:51062/", "api/LookBook");
        WebAPIHelper modeliService = new WebAPIHelper("http://localhost:51062/", "api/Modeli");
        WebAPIHelper proizvodiService = new WebAPIHelper("http://localhost:51062/", "api/Proizvodi");
        public byte[] slika { get; set; }
        public int Id { get; set; }
        public List<usp_ProizvodiByModel_Result> proizvodi;


        public List<usp_ModeliByLookBook_Result> modeli;

        public PregledLookBooka()
        {
            InitializeComponent();
        }

        private void PregledLookBooka_Load(object sender, EventArgs e)
        {
           
            BindLookBookLista();
        }

        
        private void BindLookBookLista()
        {
            HttpResponseMessage response = lookBookService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                
                List<LookBook> l = response.Content.ReadAsAsync<List<LookBook>>().Result;
                
                l.Insert(0, new LookBook());
                l[0].Naziv = "Odaberite lookbook";
                LookBookLista.DataSource = l;
                LookBookLista.DisplayMember = "Naziv";
                LookBookLista.ValueMember = "LookBookID";
            
            }

        }


        private void BindGrid()
        {


           HttpResponseMessage response = modeliService.GetActionResponse("ModeliByLookBook", LookBookLista.SelectedValue.ToString());


            if (response.IsSuccessStatusCode)
            {
                
                modeli = response.Content.ReadAsAsync<List<usp_ModeliByLookBook_Result>>().Result;
                dgModeli.DataSource =modeli;

             

            }
        }

        private void LookBookLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

        

        private void dgModeli_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                int selectedrowindex = dgModeli.SelectedCells[0].RowIndex; 

                int Id = Convert.ToInt32(dgModeli.Rows[selectedrowindex].Cells[0].Value);

                byte[] slika = null;
                foreach (usp_ModeliByLookBook_Result item in modeli)
                {
                    if (item.ModelID == Id)
                        slika = item.Slika;
                }

                //PregledLooka frm = new PregledLooka(Id, slika);
                //frm.Show();
                this.Id = Id;

                if (slika != null)
                    this.slika = slika;
                PostaviSliku();
                BindGrid1();
            
        }

        private void PostaviSliku()
        {

            int width = Convert.ToInt32(ConfigurationManager.AppSettings["resizeWidthPregledLooka"]);
            int height = Convert.ToInt32(ConfigurationManager.AppSettings["resizeHeightPregledLooka"]);
            MemoryStream ms = new MemoryStream(slika);
            Image GotovaSlika = Image.FromStream(ms);
            Image resizedImage = UIHelper.ResizeImage(GotovaSlika, new Size(width, height));


            ModelpictureBox.Image = resizedImage;
        }

        private void BindGrid1()
        {


            HttpResponseMessage response = proizvodiService.GetActionResponse("ProizvodiByModel", Id.ToString());


            if (response.IsSuccessStatusCode)
            {
                dgStavkeModela.AutoGenerateColumns = false;
                proizvodi = response.Content.ReadAsAsync<List<usp_ProizvodiByModel_Result>>().Result;
                dgStavkeModela.DataSource = proizvodi;


            }
        }


    }
}
