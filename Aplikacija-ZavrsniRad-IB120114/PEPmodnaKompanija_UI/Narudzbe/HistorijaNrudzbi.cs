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

namespace PEPmodnaKompanija_UI.Narudzbe
{
    public partial class HistorijaNrudzbi : Form
    {
        WebAPIHelper narudzbeServis = new WebAPIHelper("http://localhost:51062/", "api/Narudzbe");

        public List<usp_SelectNarudzbeDesk_Result> narudzbe { get; set; }
        public HistorijaNrudzbi()
        {
            InitializeComponent();
        }

        private void HistorijaNrudzbi_Load(object sender, EventArgs e)
        {
            BindNarudzbe();

        }

        private void BindNarudzbe()
        {
            HttpResponseMessage response = narudzbeServis.GetActionResponse("SelectNarudzbe");

            if (response.IsSuccessStatusCode)
            {


                dgNarudzbe.AutoGenerateColumns = false;
                    narudzbe= response.Content.ReadAsAsync<List<usp_SelectNarudzbeDesk_Result>>().Result;
                    dgNarudzbe.DataSource = narudzbe;

            }
        }

        private void dgNarudzbe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BindStavke(narudzbe[e.RowIndex]);
        
           
        }

        private void BindStavke(usp_SelectNarudzbeDesk_Result n)
        {

            HttpResponseMessage response = narudzbeServis.GetActionResponse("GetStavkeNarudzbe", n.NarudzbaID.ToString());

            if (response.IsSuccessStatusCode)
            {


                dgStavke.AutoGenerateColumns = false;
                dgStavke.DataSource = response.Content.ReadAsAsync<List<usp_NarudzbeStavke_SelectByNarudzbaID_Result>>().Result;
            

            }
        }

    }
}
