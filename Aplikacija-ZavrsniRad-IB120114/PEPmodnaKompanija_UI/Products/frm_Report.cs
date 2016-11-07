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
    public partial class frm_Report : Form
    {
        PEPBazaDataSet1 ds = new PEPBazaDataSet1();
        public frm_Report()
        {
            InitializeComponent();
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


        private void frm_Report_Load(object sender, EventArgs e)
        {
            PEPBazaDataSet1 ds = new PEPBazaDataSet1();
            SelectZaradaByMjesec(ds.ZaradaByMjesec);

            bindingSource1.DataSource = ds.ZaradaByMjesec;

            ReportDataSource rds = new ReportDataSource("DS_Zarada", bindingSource1);
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
          
        }
    }
}
