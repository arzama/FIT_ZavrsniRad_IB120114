using Microsoft.Reporting.WinForms;
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

namespace PEPmodnaKompanija_UI.Products
{
    public partial class frm_KolicinaProdanih_rpt : Form
    {
        public frm_KolicinaProdanih_rpt()
        {
            InitializeComponent();
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

        private void frm_KolicinaProdanih_rpt_Load(object sender, EventArgs e)
        {

            PEPBazaDataSet1 ds = new PEPBazaDataSet1();
            SelectKolicinaByVrsta(ds.KolicinaProdanih);

            bindingSource1.DataSource = ds.KolicinaProdanih;

            ReportDataSource rds = new ReportDataSource("DS_KolicinaProdanih", bindingSource1);
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
