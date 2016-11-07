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
using PEPmodnaKompanija_UI.Util;
using PEPmodnaKompanija_API.Models;

namespace PEPmodnaKompanija_UI
{
    public partial class frmKorisnici : Form
    {
        WebAPIHelper korisniciService = new WebAPIHelper("http://localhost:51062/", "api/Korisnici"); //Prvi parametar je uri adresa na kojoj se nalazi nas servis (APi, desni klik, properties imamo adresu ili iz browsera uzmemo
                                                                                                    //Drugi parametar je route, tacna putanja,poziv metode sa kojom zelimo da komuniciramo. sve metode defaultno vracaju objekat tipa HTTTP Response message

        public frmKorisnici()
        {
            InitializeComponent();
        }

        private void korisniciGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void apiCallerBtn_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = korisniciService.GetResponse();
        //DA PROVJERIMO DA LIJE POZIV BIO USPJESAN
            if (response.IsSuccessStatusCode)
            {
               List<Korisnici> korisnici = response.Content.ReadAsAsync<List<Korisnici>>().Result;
                korisniciGrid.DataSource = korisnici;
            }
            else {

                MessageBox.Show("Error je: " + response.StatusCode + " Poruka: " + response.ReasonPhrase);
            }

        }
    }
}
