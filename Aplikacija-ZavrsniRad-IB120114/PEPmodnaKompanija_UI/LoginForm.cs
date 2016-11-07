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

namespace PEPmodnaKompanija_UI
{
    public partial class LoginForm : Form
    {
        WebAPIHelper korisniciService = new WebAPIHelper("http://localhost:51062/", "api/Korisnici");
     
        public LoginForm()
        {

            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = korisniciService.GetResponse(txtUsername.Text);
            if (response.IsSuccessStatusCode)
            {
                
                Korisnici k = response.Content.ReadAsAsync<Korisnici>().Result;

                if (UIHelper.GenerateHash(txtLozinka.Text, k.LozinkaSalt) == k.LozinkaHash )
                {
                    
                    Global.prijavljeniKorisnik = k;
                     this.DialogResult = DialogResult.OK;
                       
              

                }
              
               
                    else
                    MessageBox.Show(Global.GetPoruka("login_pass_err"), Global.GetPoruka("warning"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
            else
            {

                MessageBox.Show("Error: " + response.StatusCode + " Poruka: " + response.ReasonPhrase);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
          
        }

      

    }
}
