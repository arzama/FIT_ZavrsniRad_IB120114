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
    public partial class MainForm : Form
    {
        WebAPIHelper narudzbeService = new WebAPIHelper("http://localhost:51062/", "api/Narudzbe");

        public MainForm()
        {
            InitializeComponent();
        }

        private void noviKorisnikToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Users.AddForm novikorisnikForm = new Users.AddForm();
            novikorisnikForm.MdiParent = this;
            novikorisnikForm.Show();
        }

        private void administracijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users.AdministracijaKorisnika administracijaKorisnikForm = new Users.AdministracijaKorisnika();
            administracijaKorisnikForm.MdiParent = this;
            administracijaKorisnikForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //lblImePrezime.Text = Global.prijavljeniKorisnik.Ime.ToString() + ' '+Global.prijavljeniKorisnik.Prezime.ToString();
          

            HttpResponseMessage response = narudzbeService.GetActionResponse("GetBrojAktivnihNarudzbi");

            if (response.IsSuccessStatusCode)
            {
                int brNarudzbi = response.Content.ReadAsAsync<int>().Result;

                if (brNarudzbi > 0)
                {
                    notifyIcon.ShowBalloonTip(4000, "Nove narudžbe", "Broj narudžbi: " + brNarudzbi, ToolTipIcon.Info);

                }
            }

        }

        private void dodajProizvodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products.AddForm noviproizvodForm = new Products.AddForm();
            noviproizvodForm.MdiParent = this;
            noviproizvodForm.Show();
        }

        private void pretragaProizvodaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products.PretragaProizvoda pretraga = new Products.PretragaProizvoda();
            pretraga.MdiParent = this;
            pretraga.Show();
        }

       

        private void dodajNoviKatalogToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Products.AddKatalog katalog = new Products.AddKatalog();
            katalog.MdiParent = this;
            katalog.Show();
        }

        private void pregledajKatalogeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products.PregledKataloga kat = new Products.PregledKataloga();
            kat.MdiParent = this;
            kat.Show();
        }

     

        private void notifyIcon_BalloonTipClicked(object sender, EventArgs e)
        {

            Narudzbe.AktivneNarudzbe aktivneNarudzbeForm = new Narudzbe.AktivneNarudzbe();
            aktivneNarudzbeForm.MdiParent = this;
            aktivneNarudzbeForm.Show();
        }

        private void aktivneNarudzbeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Narudzbe.AktivneNarudzbe aktivneNarudzbeForm = new Narudzbe.AktivneNarudzbe();
            aktivneNarudzbeForm.MdiParent = this;
            aktivneNarudzbeForm.Show();
        }

        private void skladištenjeProizvodaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Products.Skladistenje s = new Products.Skladistenje();
          s.MdiParent = this;
            s.Show();
        }

        private void statistikaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Products.StatistikaFrm st = new Products.StatistikaFrm();
            st.MdiParent = this;
            st.Show();
        }

        private void historijaNarudzbiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Narudzbe.HistorijaNrudzbi h = new Narudzbe.HistorijaNrudzbi();
            h.MdiParent = this;
            h.Show();
        }
        //------------------------------------------------------------------------------------
     
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Users.AddForm novikorisnikForm = new Users.AddForm();
            novikorisnikForm.MdiParent = this;
            novikorisnikForm.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Users.AdministracijaKorisnika administracijaKorisnikForm = new Users.AdministracijaKorisnika();
            administracijaKorisnikForm.MdiParent = this;
            administracijaKorisnikForm.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Products.AddForm noviproizvodForm = new Products.AddForm();
            noviproizvodForm.MdiParent = this;
            noviproizvodForm.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Products.PretragaProizvoda pretraga = new Products.PretragaProizvoda();
            pretraga.MdiParent = this;
            pretraga.Show();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {

            Products.AddKatalog katalog = new Products.AddKatalog();
            katalog.MdiParent = this;
            katalog.Show();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Products.PregledKataloga kat = new Products.PregledKataloga();
            kat.MdiParent = this;
            kat.Show();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            Narudzbe.AktivneNarudzbe aktivneNarudzbeForm = new Narudzbe.AktivneNarudzbe();
            aktivneNarudzbeForm.MdiParent = this;
            aktivneNarudzbeForm.Show();
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            Products.Skladistenje s = new Products.Skladistenje();
            s.MdiParent = this;
            s.Show();
        }

        private void statistikaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Products.StatistikaFrm st = new Products.StatistikaFrm();
            st.MdiParent = this;
            st.Dock = DockStyle.Fill;
            st.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Global.prijavljeniKorisnik = null;
           
            //LoginForm l = new LoginForm();
           
            //l.Show();
            Global.prijavljeniKorisnik = null;
            Application.Restart();
         
        }

        private void statistikaToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

  

     
      

       
    
    }
}
