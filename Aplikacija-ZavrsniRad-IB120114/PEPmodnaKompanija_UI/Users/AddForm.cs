using PEPmodnaKompanija_API.Models;
using PEPmodnaKompanija_UI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEPmodnaKompanija_UI.Users
{
    public partial class AddForm : Form
    {
     
        public WebAPIHelper korisniciService = new WebAPIHelper("http://localhost:51062/", "api/Korisnici");
        public WebAPIHelper ulogeService = new WebAPIHelper("http://localhost:51062/", "api/Uloge");
      
        public AddForm()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;

   
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }


        private void dodaj_btn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                
           
                   Korisnici  k = new Korisnici();
                

                k.Status = false;
                k.Ime = Imetxt.Text;
                k.Prezime = Prezimetxt.Text;
                k.Email = Emailtxt.Text;
                k.Telefon = Telefontxt.Text;
                k.KorisnickoIme = KorisnickoImetxt.Text;
                k.Status = true;

                k.LozinkaSalt = UIHelper.GenerateSalt();
                k.LozinkaHash = UIHelper.GenerateHash(Lozinkatxt.Text, k.LozinkaSalt);

                if (radioDizajner.Checked)
                    k.UlogaID = 4;
                else if (radioAdministrator.Checked)
                    k.UlogaID = 1;

                //item.KorisnickoIme == KorisnickoImetxt.Text && item.Ime==Imetxt.Text && item.Prezime==Prezimetxt.Text && 
                HttpResponseMessage getResponse = korisniciService.GetResponse();
                List<Korisnici> korisnici;
                korisnici = getResponse.Content.ReadAsAsync<List<Korisnici>>().Result;
               foreach(var item in korisnici)
               {
                   if (item.KorisnickoIme==k.KorisnickoIme)
                   {
                       MessageBox.Show("Već postoji korisnik sa tim korisničkim imenom", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       KorisnickoImetxt.Text = "";
                       k.KorisnickoIme = KorisnickoImetxt.Text;
                       Lozinkatxt.Text = "";
                       k.LozinkaSalt = UIHelper.GenerateSalt();
                       k.LozinkaHash = UIHelper.GenerateHash(Lozinkatxt.Text, k.LozinkaSalt);
                   }
                  
               
               }

               if (KorisnickoImetxt.Text != "" || Lozinkatxt.Text != "")
               {
                   HttpResponseMessage response = korisniciService.PostResponse(k);





                   if (response.IsSuccessStatusCode)
                   {
                       MessageBox.Show(Global.GetPoruka("user_succ"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       Clear();
                   }
                   else
                   {


                       MessageBox.Show(Global.GetPoruka(response.ReasonPhrase), Global.GetPoruka("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                   }

               }
            }
        }

        private void Clear()
        {
            Imetxt.Text = "";
            Prezimetxt.Text = "";
            Emailtxt.Text = "";
            Telefontxt.Text = "";
            KorisnickoImetxt.Text = "";
            Lozinkatxt.Text = "";
            radioAdministrator.Checked = false;
            radioDizajner.Checked = false;
        }


     

        #region Validacija
        private void Imetxt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(Imetxt.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(Imetxt, Global.GetPoruka("fname_req"));
            }

            else {
                errorProvider1.SetError(Imetxt, "");
            
            }
        }

        private void Emailtxt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(Emailtxt.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(Emailtxt, Global.GetPoruka("email_req"));
            }
            else
            { 
                try
                {
                    MailAddress mail = new MailAddress(Emailtxt.Text);
                    errorProvider1.SetError(Emailtxt, "");
                }
                catch(Exception)
                {
                e.Cancel = true;
                errorProvider1.SetError(Emailtxt, Global.GetPoruka("email_err"));
                }
            }
        }

       

        private void Lozinkatxt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(Lozinkatxt.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Lozinkatxt, Global.GetPoruka("pass_req"));
            }
            else if (Lozinkatxt.TextLength < 6)
            {
                e.Cancel = true;
                errorProvider1.SetError(Lozinkatxt, Global.GetPoruka("pass_err"));
            }
            else
                errorProvider1.SetError(Lozinkatxt, "");
        }

        private void KorisnickoImetxt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(KorisnickoImetxt.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(KorisnickoImetxt, Global.GetPoruka("username_req"));
            }
            else if (KorisnickoImetxt.TextLength < 3)
            {
                e.Cancel = true;
                errorProvider1.SetError(KorisnickoImetxt, Global.GetPoruka("username_err"));
            }
            else
                errorProvider1.SetError(KorisnickoImetxt, "");
        }

        private void radioDizajner_Validating(object sender, CancelEventArgs e)
        {
            if (radioAdministrator.Checked == false && radioDizajner.Checked == false)
            {
                e.Cancel = true;
                errorProvider1.SetError(radioDizajner, Global.GetPoruka("radio_err"));
                errorProvider1.SetError(radioAdministrator, Global.GetPoruka("radio_err"));
            }
            else {
                errorProvider1.SetError(radioAdministrator, ""); 
                errorProvider1.SetError(radioDizajner, ""); 
            }
        }
     #endregion

      

     
    }
}
