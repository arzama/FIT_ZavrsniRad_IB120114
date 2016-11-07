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
    public partial class AddRevija : Form
    {
        WebAPIHelper revijeService = new WebAPIHelper("http://localhost:51062/", "api/Revije");

        private Revije revije { get; set; }
        private Revije revijaEdit { get; set; }
        public AddRevija()
        {
            InitializeComponent();
        }

        private void DodajRevijuBtn_Click(object sender, EventArgs e)
        {
            if (revije == null)
                revije = new Revije();

            revije.Datum = Convert.ToDateTime(datumDatePicker.Value);
            revije.KorisnikID = Global.prijavljeniKorisnik.KorisnikID;
            revije.Naziv = nazivInput.Text;
            revije.Napomena = napomenaInput.Text;

           
            HttpResponseMessage response;
            if (revije.RevijaID == 0) 
            {
                response = revijeService.PostResponse(revije);
            }
            else response = revijeService.PutResponse(revije.RevijaID,revije);
                
        
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Uspješno ste sačuvali podatke o održanoj reviji.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            else
            {
                MessageBox.Show(response.ReasonPhrase, Global.GetPoruka("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            BindGrid();
            Clear();
        }

        private void BindGrid()
        {
            HttpResponseMessage response = revijeService.GetActionResponse("SelectRevijeByKorisnik", Global.prijavljeniKorisnik.KorisnikID.ToString());
          
           
            if (response.IsSuccessStatusCode)
            {

                   
                        revijeGrid.DataSource = response.Content.ReadAsAsync<List<RevijeByKorisnik>>().Result;
                    
                


            }
        }

        private void Clear()
        {
            napomenaInput.Text = "";
            nazivInput.Text = "";
            datumDatePicker.Text = "";

        }

        #region Validacija
        private void nazivInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(nazivInput.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(nazivInput, Global.GetPoruka("req"));
            }

            else
            {
                errorProvider1.SetError(nazivInput, "");

            }
        }

        private void datumDatePicker_Validating(object sender, CancelEventArgs e)
        {
            if (datumDatePicker.Value == null)
            {
                e.Cancel = true;
                errorProvider1.SetError(datumDatePicker, Global.GetPoruka("req"));
            }
            else if (DateTime.Now < datumDatePicker.Value)
            {
                e.Cancel = true;
                errorProvider1.SetError(datumDatePicker, Global.GetPoruka("datumRevije_err"));
            }


            else
            {
                errorProvider1.SetError(datumDatePicker, "");

            }
        #endregion
        }

        private void AddRevija_Load(object sender, EventArgs e)
        {
            revijeGrid.AutoGenerateColumns = false;
            BindGrid();
        }

        private void revijeGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string revijaID = Convert.ToString(revijeGrid.SelectedRows[0].Cells[0].Value);
         
            HttpResponseMessage response = revijeService.GetResponse(revijaID);
            if (response.IsSuccessStatusCode)
            {
                revije = response.Content.ReadAsAsync<Revije>().Result;
                LoadData();
               

            }
        }

        private void LoadData()
        {
            nazivInput.Text = revije.Naziv;
            datumDatePicker.Value = revije.Datum;
            napomenaInput.Text = revije.Napomena;
        
        }
    }
}
