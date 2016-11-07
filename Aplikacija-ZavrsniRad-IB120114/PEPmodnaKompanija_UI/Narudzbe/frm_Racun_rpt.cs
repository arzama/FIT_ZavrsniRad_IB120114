using Microsoft.Reporting.WinForms;
using PEPmodnaKompanija_UI.PEPBazaDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEPmodnaKompanija_UI.Narudzbe
{
    public partial class Račun : Form
    {
        PEPBazaDataSet ds = new PEPBazaDataSet ();
        int narudzbaID;
        public Račun(int narudzbaID)
        {
            InitializeComponent();
            this.narudzbaID = narudzbaID;
           
        }


        public static void SelectRacun( PEPBazaDataSet.usp_Select_RacunDataTable dtRacun, int narudzbaid)
        {
            dtRacun.Clear();

            SqlConnection cn = Connection.GetConnection();

            if (cn.State == ConnectionState.Closed)
                cn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("usp_Select_Racun", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NarudzbaID", SqlDbType.Int).Value = narudzbaid;
              

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtRacun);
            }
            finally
            {
                cn.Close();
            }
        }

        private void frm_Racun_rpt_Load(object sender, EventArgs e)
        {

            PEPBazaDataSet ds = new PEPBazaDataSet();
            SelectRacun(ds.usp_Select_Racun, narudzbaID);

            bindingSource1.DataSource = ds.usp_Select_Racun;

            ReportDataSource rds = new ReportDataSource("DS_Racun", bindingSource1);
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
