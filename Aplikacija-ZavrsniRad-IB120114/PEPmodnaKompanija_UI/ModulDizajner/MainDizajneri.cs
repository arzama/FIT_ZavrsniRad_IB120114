using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEPmodnaKompanija_UI.ModulDizajner
{
    public partial class MainDizajneri : Form
    {
        public MainDizajneri()
        {
            InitializeComponent();
        }

        private void MainDizajneri_Load(object sender, EventArgs e)
        {
            //lblImePrezime.Text = Global.prijavljeniKorisnik.Ime.ToString() + ' ' + Global.prijavljeniKorisnik.Prezime.ToString();

        }

      

        private void sveRevijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModulDizajner.SveRevije s = new ModulDizajner.SveRevije();
            s.MdiParent = this;
            s.Show();
        }

        private void kreirajLookBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModulDizajner.AddLookBook a = new ModulDizajner.AddLookBook();
            a.MdiParent = this;
            a.Show();
        }

        private void pregledajLookbookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModulDizajner.PregledLookBooka p = new ModulDizajner.PregledLookBooka();
            p.MdiParent = this;
            p.Show();
        }

        private void novaRevijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModulDizajner.AddRevija novaRevija = new ModulDizajner.AddRevija();
            novaRevija.MdiParent = this;
            novaRevija.Show();
        }

        private void pregledRevijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModulDizajner.SveRevije s = new ModulDizajner.SveRevije();
            s.MdiParent = this;
            s.Show();
        }

        private void noviLookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModulDizajner.AddForm novaKreacija = new ModulDizajner.AddForm();
            novaKreacija.MdiParent = this;
            novaKreacija.Show();
        }

        private void dodajKreacijuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pregledSvihLookovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModulDizajner.SviModeli modeli = new ModulDizajner.SviModeli();
            modeli.MdiParent = this;
            modeli.Show();
        }

        private void pregledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModulDizajner.PregledKreacija kreacije = new ModulDizajner.PregledKreacija();
            kreacije.MdiParent = this;
            kreacije.Show();

        }

        private void prodajaKreacijaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ModulDizajner.frm_Statistika_rpt kreacije = new ModulDizajner.frm_Statistika_rpt();
            //kreacije.FormBorderStyle = FormBorderStyle.None;
            kreacije.MdiParent = this;
            kreacije.Show();

        }

        private void odjavaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Global.prijavljeniKorisnik = null;
            Application.Restart();
        }

        //private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        //{
         
        //    LoginForm login = new LoginForm();
        //    login.ShowDialog();
        //    this.Close();
        //    if (login.DialogResult == DialogResult.OK && Global.prijavljeniKorisnik.UlogaID == 4)
        //        Application.Run(new ModulDizajner.MainDizajneri());
        //    else if (login.DialogResult == DialogResult.OK && Global.prijavljeniKorisnik.UlogaID == 1)
        //        Application.Run(new MainForm());
        //}
    }
}
