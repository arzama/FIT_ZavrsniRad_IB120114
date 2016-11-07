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
    public partial class AddStavkeModela : Form
    {
        WebAPIHelper vrsteProizvodaService = new WebAPIHelper("http://localhost:51062/", "api/VrsteProizvoda");
        WebAPIHelper proizvodiService = new WebAPIHelper("http://localhost:51062/", "api/Proizvodi");
        WebAPIHelper sezoneService = new WebAPIHelper("http://localhost:51062/", "api/Sezone");
        WebAPIHelper velicineService = new WebAPIHelper("http://localhost:51062/", "api/Velicine");
        WebAPIHelper modeliService = new WebAPIHelper("http://localhost:51062/", "api/Modeli");
        WebAPIHelper modeliProizvodiService = new WebAPIHelper("http://localhost:51062/", "api/ModeliProizvodi");

        private List<usp_ProizvodiByModel_Result> proizvodi { get; set; }
       private ModeliProizvodi modeliProizvodi { get; set; }
       // private Modeli model { get; set; }

        public AddStavkeModela()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void AddStavkeModela_Load(object sender, EventArgs e)
        {
            stavkeGrid.AutoGenerateColumns = false;

        }




        int ModelZadni = 0;
        private void dodajStavkuButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {




                int proizvodID=0;
                bool postoji = false;
                HttpResponseMessage responsePostoji = proizvodiService.GetResponse();
                List<Proizvodi> getP = responsePostoji.Content.ReadAsAsync<List<Proizvodi>>().Result;
                foreach (var item in getP)
                {
                    if (item.Sifra == sifraInput.Text)
                    {
                        postoji = true;
                        proizvodID = item.ProizvodID;
                    }
                }

                if (postoji == true)
                {
                    modeliProizvodi = new ModeliProizvodi();
                    modeliProizvodi.ProizvodID = proizvodID;
                    HttpResponseMessage response1 = modeliService.GetResponse("GetLastModel");
                    modeliProizvodi.ModelID = response1.Content.ReadAsAsync<Modeli>().Result.ModelID;
                    ModelZadni = modeliProizvodi.ModelID;

                    HttpResponseMessage response = modeliProizvodiService.PostResponse(modeliProizvodi);



                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Uspješno ste dodali stavku !", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show(response.ReasonPhrase, Global.GetPoruka("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    BindGrid();

                    Clear();
                }

                else MessageBox.Show("Ne postoji proizvod sa unesenom šifrom!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void BindGrid()
        {


            HttpResponseMessage response = proizvodiService.GetActionResponse("ProizvodiByModel", ModelZadni.ToString());


            if (response.IsSuccessStatusCode)
            {

                proizvodi = response.Content.ReadAsAsync<List<usp_ProizvodiByModel_Result>>().Result;
                stavkeGrid.DataSource = proizvodi;


            }
        }


        private void Clear()
        {
            sifraInput.Text = "";

           


        }




        #region validacija






        private void sifraInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(sifraInput.Text.Trim()) || sifraInput.Text.Length < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(sifraInput, Global.GetPoruka("req"));

            }
            else if (sifraInput.TextLength < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(sifraInput, "Šifra mora imati najmanje 3 karaktera!");
            }
            else
                errorProvider.SetError(sifraInput, "");
        }

       


        #endregion
        private void stavkeGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void zakljuciButton_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = proizvodiService.GetActionResponse("ProizvodiByModel", ModelZadni.ToString());
            if (response.Content.ReadAsAsync<List<usp_ProizvodiByModel_Result>>().Result.Count() < 2)
                MessageBox.Show("Look mora sadržavati najmanje 2 proizvoda", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
            {
                MessageBox.Show("Look sa stavkama je uspješno dodan !", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }

        }



        private void stavkeGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void velicinaList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }






    }
}