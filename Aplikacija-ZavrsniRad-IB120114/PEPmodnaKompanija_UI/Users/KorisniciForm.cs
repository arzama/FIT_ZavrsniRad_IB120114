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

namespace PEPmodnaKompanija_UI.Users
{
    public partial class AdministracijaKorisnika : Form
    {
        WebAPIHelper korisniciService = new WebAPIHelper("http://localhost:51062/", "api/Korisnici"); 
        Korisnici korisnikEdit { get; set; }
        public AdministracijaKorisnika()
        {
            InitializeComponent();
            dgKorisnici.AutoGenerateColumns = false;
        }

     
        private void BindGrid()
        {
            HttpResponseMessage response = korisniciService.GetActionResponse("SearchKorisnici",imePrezimeInput.Text.Trim());

            if (response.IsSuccessStatusCode)
            {
                List<Korisnici> korisnici = response.Content.ReadAsAsync<List<Korisnici>>().Result;
                dgKorisnici.DataSource = korisnici;
            }
            else
            {
                MessageBox.Show("Error Code" +
                response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }


        private void noviKorisnik_btn_Click(object sender, EventArgs e)
        {
            AddForm form = new AddForm();
            form.Show();
            BindGrid();
        }

        private void btn_Trazi_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void AdministracijaKorisnika_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void dgKorisnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


      

      

     
    }
}
