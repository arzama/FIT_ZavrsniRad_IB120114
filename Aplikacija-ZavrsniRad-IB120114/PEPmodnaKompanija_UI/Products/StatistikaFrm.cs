using PEPmodnaKompanija_API.Models;
using PEPmodnaKompanija_UI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEPmodnaKompanija_UI.Products
{
    public partial class StatistikaFrm : Form
    {
        WebAPIHelper preporukaService = new WebAPIHelper("http://localhost:51062/", "api/Preporuka");


        public StatistikaFrm()
        {
            InitializeComponent();
        }



        private void StatistikaFrm_Load(object sender, EventArgs e)
        {
            BindNajprodavaniji();
            BindDizajneri();
            BindProizvodi();
            //this.rV1.RefreshReport();

            PEPBazaDataSet1 ds = new PEPBazaDataSet1();
            SelectZaradaByMjesec(ds.ZaradaByMjesec);

            chart1.DataSource = ds.ZaradaByMjesec.ToList();
            chart1.Series["Total"].XValueMember = "Month";
            chart1.Series["Total"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;

            chart1.Series["Total"].YValueMembers = "Zarada";
            chart1.Series["Total"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            chart1.Series["Total"].IsValueShownAsLabel = true;



            SelectKolicinaByVrsta(ds.KolicinaProdanih);

            chart2.DataSource = ds.KolicinaProdanih.ToList();
            chart2.Series["Vrsta"].XValueMember = "Naziv";
            chart2.Series["Vrsta"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;

            chart2.Series["Vrsta"].YValueMembers = "Kolicina";
            chart2.Series["Vrsta"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chart2.Series["Vrsta"].IsValueShownAsLabel = true;



            //bindingSource1.DataSource = ds.ProdajaTotal;

            //ReportDataSource rds = new ReportDataSource("DSProdajaTotal", bindingSource1);
            //reportViewer1.LocalReport.DataSources.Add(rds);
            //this.reportViewer1.RefreshReport();
            //this.reportViewer1.RefreshReport();

        }


        public static void SelectKolicinaByVrsta(PEPBazaDataSet1.KolicinaProdanihDataTable dtProdaja)
        {
            dtProdaja.Clear();

            SqlConnection cn = Connection.GetConnection();

            if (cn.State == ConnectionState.Closed)
                cn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("usp_KolicinaProdanihByVrsta", cn);





                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtProdaja);
            }
            finally
            {
                cn.Close();
            }
        }


        public static void SelectZaradaByMjesec(PEPBazaDataSet1.ZaradaByMjesecDataTable dtProdaja)
        {
            dtProdaja.Clear();

            SqlConnection cn = Connection.GetConnection();

            if (cn.State == ConnectionState.Closed)
                cn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("usp_StatistikaZarada", cn);
                cmd.CommandType = CommandType.StoredProcedure;

              


                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtProdaja);
            }
            finally
            {
                cn.Close();
            }
        }

        private void BindNajprodavaniji()
        {
            // response = revijeService.GetActionResponse22("RevijeByDatum", odPicker.Value.ToString("dd-MM-yyyy"), doPicker.Value.ToString("dd-MM-yyyy"));

            HttpResponseMessage response = preporukaService.GetActionResponse("NajprodavanijiByMjesec", dtp_mjesec.Value.ToString("dd-MM-yyyy"));


            if (response.IsSuccessStatusCode)
            {

                dgProizvodiNajprodavaniji.AutoGenerateColumns = false;
                dgProizvodiNajprodavaniji.DataSource = response.Content.ReadAsAsync<List<usp_NajprodavanijiByMjesec_Result>>().Result;


            }
        }

        private void BindProizvodi()
        {

            HttpResponseMessage response = preporukaService.GetResponse("NajboljeOcijenjeniProizvodi");


            if (response.IsSuccessStatusCode)
            {

                dgProizvodiOcjena.AutoGenerateColumns = false;
                dgProizvodiOcjena.DataSource = response.Content.ReadAsAsync<List<usp_najboljeOcijenjeniProizvodi_Result>>().Result;


            }
        }

        private void BindDizajneri()
        {

            HttpResponseMessage response = preporukaService.GetResponse("NajboljeOcijenjeniDizajneri");


            if (response.IsSuccessStatusCode)
            {

                dgDizajneri.AutoGenerateColumns = false;
                dgDizajneri.DataSource = response.Content.ReadAsAsync<List<usp_najboljeOcijenjeniDizajneri_Result>>().Result;


            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dtp_mjesec_ValueChanged(object sender, EventArgs e)
        {
            BindNajprodavaniji();
        }

        private void btnPrint1_Click(object sender, EventArgs e)
        {
            frm_Report zarada = new frm_Report();

            //zarada.MdiParent = this;
            zarada.Show();
        }

        private void btnPrint2_Click(object sender, EventArgs e)
        {
            frm_KolicinaProdanih_rpt kolicina = new frm_KolicinaProdanih_rpt();

            //zarada.MdiParent = this;
            kolicina.Show();
        }


    }
}
