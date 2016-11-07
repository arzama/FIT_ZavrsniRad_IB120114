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
    public partial class PregledLooka : Form
    {
        WebAPIHelper proizvodiService = new WebAPIHelper("http://localhost:51062/", "api/Proizvodi");
        public byte[] slika { get; set; }
        public int Id { get; set; }
        public List<usp_ProizvodiByModel_Result> proizvodi;

        public PregledLooka(int IdModela, byte[] slika = null)
        {
            InitializeComponent();
            this.Id = IdModela;
         
            if (slika != null)
                this.slika = slika;
        }

        private void PregledLooka_Load(object sender, EventArgs e)
        {

            PostaviSliku();
            BindGrid();
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

        private void BindGrid()
        {


            HttpResponseMessage response = proizvodiService.GetActionResponse("ProizvodiByModel", Id.ToString());


            if (response.IsSuccessStatusCode)
            {
                dgStavkeModela.AutoGenerateColumns = false;
                proizvodi = response.Content.ReadAsAsync<List<usp_ProizvodiByModel_Result>>().Result;
                dgStavkeModela.DataSource = proizvodi;


            }
        }

        private void ModelpictureBox_Click(object sender, EventArgs e)
        {

        }

     

        private void dgStavkeModela_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
                int selectedrowindex = dgStavkeModela.SelectedCells[0].RowIndex; 

                string Naziv = Convert.ToString(dgStavkeModela.Rows[selectedrowindex].Cells[1].Value);

                byte[] slikaThumb = null;
                foreach (usp_ProizvodiByModel_Result item in proizvodi)
                {
                    if (Naziv==item.Naziv)
                    {
                        slikaThumb = item.SlikaThumb;
                        if (slikaThumb == null)
                        { return; }
                        else
                        {
                            MemoryStream ms = new MemoryStream(slikaThumb);
                            Image GotovaSlika = Image.FromStream(ms);

                            proizvodPictureBox.Image = GotovaSlika;
                        }
                    }
                  
                }
            
        }

        private void dgStavkeModela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
