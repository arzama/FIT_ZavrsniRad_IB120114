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

namespace PEPmodnaKompanija_UI.Products
{
    public partial class Skladistenje : Form
    {
        WebAPIHelper skladistenjeService = new WebAPIHelper("http://localhost:51062/", "api/SkladisteProizvodi");
           WebAPIHelper skladistaService = new WebAPIHelper("http://localhost:51062/", "api/Skladista");
           WebAPIHelper proizvodiService = new WebAPIHelper("http://localhost:51062/", "api/Proizvodi");
          
      
        public SkladisteProizvodi skladistenje{get; set;}
        public Skladistenje()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

          private void BindSkladista()
        {
            HttpResponseMessage response = skladistaService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<Skladista> skladista = response.Content.ReadAsAsync<List<Skladista>>().Result;
                skladista.Insert(0, new Skladista());
                skladista[0].Naziv = "Odaberite skladište";
                skladisteList.DataSource = skladista;
                skladisteList.DisplayMember = "Naziv";
                skladisteList.ValueMember = "SkladisteID";

            }
        }
          
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                skladistenje = new SkladisteProizvodi();
                HttpResponseMessage response = proizvodiService.GetResponse();
                List<Proizvodi> p = response.Content.ReadAsAsync<List<Proizvodi>>().Result;
                int proizvodID = 0;
                bool postoji = false;
                foreach (var item in p)
                {
                    if (item.Sifra == sifraInput.Text )
                    {
                        proizvodID = item.ProizvodID;
                        postoji = true;
                       
                    }
                }

               
                if (skladisteList.SelectedIndex != 0)
                    skladistenje.SkladisteID = Convert.ToInt32(skladisteList.SelectedValue);
               
                skladistenje.Kolicina = Convert.ToInt32(kolicinaInput.Text);
               
                skladistenje.KorisnikID = Global.prijavljeniKorisnik.KorisnikID;
                skladistenje.ProizvodID = proizvodID;
                skladistenje.Datum = DateTime.Now;


                if (postoji == false)
                {
                    MessageBox.Show("Proizvod sa unesenom šifrom ne postoji !", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                }

               
                else
                {
                    HttpResponseMessage response1 = skladistenjeService.PostResponse(skladistenje);
                    if (response.IsSuccessStatusCode)
                    {

                        HttpResponseMessage response3 = skladistenjeService.GetResponse();
                        List<SkladisteProizvodi> sp = response3.Content.ReadAsAsync<List<SkladisteProizvodi>>().Result;
                        int kolicina=0;
                        foreach(SkladisteProizvodi item in sp)
                        {
                            if (item.SkladisteID == skladistenje.SkladisteID && item.ProizvodID == skladistenje.ProizvodID)
                                kolicina += item.Kolicina;
                        }


                        MessageBox.Show("Uspješno ste dodali proizvod u skladište. Ukupna količina ovog proizvoda na skladištu je " + kolicina + " komada.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        Clear();

                    }
                    else
                    {
                        MessageBox.Show(response.ReasonPhrase, Global.GetPoruka("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            } 
                
            }


        private void Clear()
        {
            sifraInput.Text = "";
            kolicinaInput.Text = "";
            
            BindGrid();

        }
        private void BindGrid()
        {


            HttpResponseMessage response = proizvodiService.GetActionResponse("ProizvodiBySkladiste", skladisteList.SelectedValue.ToString());
           

            if (response.IsSuccessStatusCode)
            {
                dgStavkeSkladistenja.AutoGenerateColumns = false;
                dgStavkeSkladistenja.DataSource = response.Content.ReadAsAsync<List<usp_Select_ProizvodiBySkladiste_Result>>().Result;
                
            }

     
        }

        private void Skladistenje_Load(object sender, EventArgs e)
        {
            BindSkladista();
           
        }

        private void skladisteList_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGrid();
        }


        # region validacija
        private void sifraInput_Validating(object sender, CancelEventArgs e)
        {
            

            if (String.IsNullOrEmpty(sifraInput.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(sifraInput, Global.GetPoruka("req"));

            }
          
            else
            {
                errorProvider1.SetError(sifraInput, "");
            }
        }

        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        private void kolicinaInput_Validating(object sender, CancelEventArgs e)
        {
            bool b = IsDigitsOnly(kolicinaInput.Text.Trim());

            if (String.IsNullOrEmpty(kolicinaInput.Text.Trim()) || b==false )
            {
                e.Cancel = true;
                errorProvider1.SetError(kolicinaInput, Global.GetPoruka("req"));

            }
           

            else
            {
                errorProvider1.SetError(kolicinaInput, "");
            }
        }

        private void skladisteList_Validating(object sender, CancelEventArgs e)
        {
            if (skladisteList.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(skladisteList, "Obavezno odabrati skladište!");
            }
            else
            {

                errorProvider1.SetError(skladisteList, "");
            }
        }



#endregion

        private void btnNoviProizvod_Click(object sender, EventArgs e)
        {
            AddForm frm = new AddForm();
            frm.Show();
        }

        private void btnPretraziProizvode_Click(object sender, EventArgs e)
        {
           PretragaProizvoda f = new PretragaProizvoda();
            f.Show();
        }

   

      }
}

