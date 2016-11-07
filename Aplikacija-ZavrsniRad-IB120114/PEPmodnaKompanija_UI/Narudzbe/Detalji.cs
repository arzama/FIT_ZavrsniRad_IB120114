using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PEPmodnaKompanija_API.Models;
using PEPmodnaKompanija_UI.Util;
using System.Net.Http;

namespace PEPmodnaKompanija_UI.Narudzbe
{
    public partial class Detalji : Form
    {
        WebAPIHelper narudzbeService = new WebAPIHelper("http://localhost:51062/", "api/Narudzbe");
        WebAPIHelper skladistaService = new WebAPIHelper("http://localhost:51062/", "api/Skladista");
        WebAPIHelper skladistaProizvodiServis = new WebAPIHelper("http://localhost:51062/", "api/SkladisteProizvodi");

        public usp_Narudzbe_SelectAktivne_Result narudzba { get; set; }
       public  List<usp_NarudzbeStavke_SelectByNarudzbaID_Result> stavkeNarudzbe { get; set; }
        public Detalji(usp_Narudzbe_SelectAktivne_Result narudzba)
        {
            InitializeComponent();
            if(narudzba!=null)
            this.narudzba = narudzba;
            this.AutoValidate = AutoValidate.Disable;
        }

        private void Detalji_Load(object sender, EventArgs e)
        {
            BindForm();
            BindSkladista();
        }
        private void BindSkladista()
        {
            HttpResponseMessage response = skladistaService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                List<Skladista> skladista = response.Content.ReadAsAsync<List<Skladista>>().Result;
                skladista.Insert(0, new Skladista());
                skladista[0].Naziv = "Odaberite skladište";
                skladistaList.DataSource = skladista;
                skladistaList.DisplayMember = "Naziv";
                skladistaList.ValueMember = "SkladisteID";
            }
        }

        private void BindForm()
        {
            brNarudzbeLabel.Text = narudzba.BrojNarudzbe;
            datumLabel.Text = narudzba.Datum.ToShortDateString();
            kupacLabel.Text = narudzba.Kupac;
            iznosNarudzbeLabel.Text = narudzba.Iznos.ToString() + "KM";


            HttpResponseMessage response = narudzbeService.GetActionResponse("GetStavkeNarudzbe", narudzba.NarudzbaID.ToString());
        
            if (response.IsSuccessStatusCode)
            {
                stavkeNarudzbe = response.Content.ReadAsAsync<List<usp_NarudzbeStavke_SelectByNarudzbaID_Result>>().Result;
                stavkeNarudzbeGrid.DataSource = stavkeNarudzbe;
                stavkeNarudzbeGrid.Columns[0].Visible = false;
                stavkeNarudzbeGrid.Columns[1].Visible = false;
                stavkeNarudzbeGrid.ClearSelection();
            }
        }

        private void procesirajButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                HttpResponseMessage responseSkladista = skladistaProizvodiServis.GetResponse();
                List<SkladisteProizvodi> skl = responseSkladista.Content.ReadAsAsync<List<SkladisteProizvodi>>().Result;

                string message = "";
                bool dostupan = true;
                foreach (var item in skl)
                {
                    foreach (var item2 in stavkeNarudzbe)
                        if (item.ProizvodID != item2.ProizvodID && item.SkladisteID != Convert.ToInt32(skladistaList.SelectedValue))
                        {
                            dostupan = false;
                           message="Na odabranom skladištu nema proizvoda: " + item2.Naziv ;

                        }

                        else 
                        {
                            foreach(var item3 in stavkeNarudzbe)
                                if (item.Kolicina > 0 && item.Kolicina > item3.Kolicina)
                                {
                                    item.Kolicina -= item2.Kolicina;
                                    responseSkladista = skladistaProizvodiServis.PutResponse(item.SkladisteProizvodiID, item);
                                   dostupan = true;
                                }
                                else
                                {
                                    dostupan = false;
                                    message = "Na odabranom skladištu nema dovoljno proizvoda: " + item2.Naziv; 
                                }
                        }
                }

                if (dostupan == true)
                {
                    ////////////
                    Izlazi izlaz = new Izlazi();

                    izlaz.NarudzbaID = narudzba.NarudzbaID;
                    izlaz.SkladisteID = Convert.ToInt32(skladistaList.SelectedValue);
                    izlaz.KorisnikID = Global.prijavljeniKorisnik.KorisnikID;

                   

                    HttpResponseMessage response = narudzbeService.PostActionResponse("ProcesirajNarudzbu", izlaz);

                    if (response.IsSuccessStatusCode)
                    {

                        MessageBox.Show("Narudžba uspješno procesirana.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        PEPBazaDataSet ds = new PEPBazaDataSet();
                        Račun rpt = new Račun(narudzba.NarudzbaID);
                        rpt.Show();
                    }
                    else { MessageBox.Show("Greska."+ izlaz.IzlazID, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }
                else { MessageBox.Show(message); }
            }
        }
        private void skladistaList_Validating(object sender, CancelEventArgs e)
        {
            if (skladistaList.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(skladistaList, "Obavezno odaberite skladište!");
            }
            else
            {

                errorProvider1.SetError(skladistaList, "");
            }
        }

     


    }
}
