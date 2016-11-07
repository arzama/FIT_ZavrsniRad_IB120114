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

namespace PEPmodnaKompanija_UI.ModulDizajner
{
    public partial class frm_Statistika_rpt : Form
    {
        PEPBazaDataSet1 ds = new PEPBazaDataSet1();
        int korisnikID = Global.prijavljeniKorisnik.KorisnikID;
        public frm_Statistika_rpt()
        {
            InitializeComponent();
            
        }

        public static void SelectProdajaTotal(PEPBazaDataSet1.ProdajaTotalDataTable dtProdaja, int korisnikID)
        {
            dtProdaja.Clear();

            SqlConnection cn = Connection.GetConnection();

            if (cn.State == ConnectionState.Closed)
                cn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("usp_StatistikaDizajner", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@KorisnikID", SqlDbType.Int).Value = korisnikID;


                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtProdaja);
            }
            finally
            {
                cn.Close();
            }
        }


        private void frm_Statistika_rpt_Load(object sender, EventArgs e)
        {
            PEPBazaDataSet1 ds = new PEPBazaDataSet1();
            SelectProdajaTotal(ds.ProdajaTotal, korisnikID);

            bindingSource1.DataSource = ds.ProdajaTotal;

            ReportDataSource rds = new ReportDataSource("DSProdajaTotal", bindingSource1);
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
