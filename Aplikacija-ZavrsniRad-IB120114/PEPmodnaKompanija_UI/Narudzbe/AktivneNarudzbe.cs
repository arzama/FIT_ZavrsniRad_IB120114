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

namespace PEPmodnaKompanija_UI.Narudzbe
{
    public partial class AktivneNarudzbe : Form
    {
        WebAPIHelper narudzbeService = new WebAPIHelper("http://localhost:51062/", "api/Narudzbe");
        WebAPIHelper skladistaService = new WebAPIHelper("http://localhost:51062/", "api/Skladista");
        WebAPIHelper skladistaProizvodiServis = new WebAPIHelper("http://localhost:51062/", "api/SkladisteProizvodi");
        private List<usp_Narudzbe_SelectAktivne_Result> narudzbe { get; set; }

        public List<usp_NarudzbeStavke_SelectByNarudzbaID_Result> stavkeNarudzbe { get; set; }
        public usp_Narudzbe_SelectAktivne_Result narudzba { get; set; }
        public AktivneNarudzbe()
        {
            InitializeComponent();
        }

        private void AktivneNarudzbe_Load(object sender, EventArgs e)
        {
            BindGrid();
            label7.AutoSize = false;
            label7.Height = 400;
            label7.Width = 3;
            label7.BorderStyle = BorderStyle.Fixed3D;
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
            //brNarudzbeLabel.Text = narudzba.BrojNarudzbe;
            datumLabel.Text = narudzba.Datum.ToShortDateString();
            //kupacLabel.Text = narudzba.Kupac;
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
/// <summary>
/// /////////////////////////////////////////////////
/// </summary>







        private void BindGrid()
        {
            HttpResponseMessage response = narudzbeService.GetActionResponse("GetAktivneNarudzbe");

            if (response.IsSuccessStatusCode)
            {
                narudzbe = response.Content.ReadAsAsync<List<usp_Narudzbe_SelectAktivne_Result>>().Result;
                dgAktivneNarudzbe.DataSource = narudzbe;
                dgAktivneNarudzbe.Columns[0].Visible = false;
                dgAktivneNarudzbe.Columns[2].Visible = false;
            }
        }

        private void dgAktivneNarudzbe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

           //Detalji detailsForm = new Detalji(narudzbe[e.RowIndex]);
           //this.Close();
           // detailsForm.Show();

            if (narudzbe[e.RowIndex] != null)
                narudzba = narudzbe[e.RowIndex];
            this.AutoValidate = AutoValidate.Disable;

            BindForm();
            BindSkladista();
        }

        private void procesirajButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                HttpResponseMessage responseSkladista = skladistaProizvodiServis.GetResponse();
                List<SkladisteProizvodi> skl = responseSkladista.Content.ReadAsAsync<List<SkladisteProizvodi>>().Result;

                string message = "";
                bool dostupan = true;
                 int ns=0;
                int brojStavki=0;
                //foreach (var item in skl)
                //{
                foreach (var item2 in stavkeNarudzbe)
                {
                    foreach(var item in skl)
                    {
                    if (item.ProizvodID != item2.ProizvodID && item.SkladisteID == Convert.ToInt32(skladistaList.SelectedValue))
                    //{

                    ns ++;
                    }
                }
                           if(ns<stavkeNarudzbe.Count()){
                       
                    dostupan = false;
                    message = "Na odabranom skladištu nema proizvoda nekog od proizvoda iz narudžbe. Pokušajte sa drugim sladišem! ";

                        

                        //else
                        //{
                        //    foreach (var item3 in stavkeNarudzbe)
                        //        if (item.Kolicina > 0 && item.Kolicina > item3.Kolicina)
                        //        {
                        //            item.Kolicina -= item2.Kolicina;
                        //            responseSkladista = skladistaProizvodiServis.PutResponse(item.SkladisteProizvodiID, item);
                        //            dostupan = true;
                        //        }
                        //        else
                        //        {
                        //            dostupan = false;
                        //            message = "Na odabranom skladištu nema dovoljno proizvoda: " + item2.Naziv;
                        //        }
                        //}
               }

                if (dostupan == true)
                {
                    ////////////
                    foreach (var item3 in stavkeNarudzbe)
                    {
                        foreach (var item4 in skl)
                        {
                            if (item3.ProizvodID == item4.ProizvodID && item4.SkladisteID == Convert.ToInt32(skladistaList.SelectedValue) && item3.Kolicina < item4.Kolicina)
                            {
                                item4.Kolicina -= item3.Kolicina;
                                responseSkladista = skladistaProizvodiServis.PutResponse(item4.SkladisteProizvodiID, item4);
                            }
                            else
                            {
                                message = "Na odabranom skladištu nema dovoljno nekog od proizvoda iz narudžbe. Pokušajte sa drugim sladišem!   ";
                            }
                        }

                    }
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
                    else { MessageBox.Show("Greska." + izlaz.IzlazID, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }
                else { MessageBox.Show(message); }
            }
        }

    
    }
}
