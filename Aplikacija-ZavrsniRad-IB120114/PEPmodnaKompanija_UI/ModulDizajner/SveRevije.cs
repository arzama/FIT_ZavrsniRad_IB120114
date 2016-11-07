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
    public partial class SveRevije : Form
    {
        WebAPIHelper revijeService = new WebAPIHelper("http://localhost:51062/", "api/Revije");


        public bool prviBind = true;
        public SveRevije()
        {
            InitializeComponent();
        }

     
  
        private void BindGrid()
        {
              HttpResponseMessage response;
            if (prviBind)
                response = revijeService.GetActionResponse22("RevijeByDatum",DateTime.MinValue.ToString("dd-MM-yyyy"), DateTime.MaxValue.ToString("dd-MM-yyyy"));
             else response = revijeService.GetActionResponse22("RevijeByDatum", odPicker.Value.ToString("dd-MM-yyyy"), doPicker.Value.ToString("dd-MM-yyyy"));
       

            if (response.IsSuccessStatusCode)
            {
                dgAllRevije.AutoGenerateColumns = false;
                dgAllRevije.DataSource = response.Content.ReadAsAsync<List<usp_RevijeByDatum_Result>>().Result;
                prviBind = false;
            }
        }


        private void SveRevije_Load_1(object sender, EventArgs e)
        {
          
            BindGrid();
        }

        private void btnPretraga_Click(object sender, EventArgs e)
        {
            
            BindGrid();

        }

    }
}
