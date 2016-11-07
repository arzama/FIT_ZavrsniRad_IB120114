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
    public partial class AddKatalog : Form
    {
        WebAPIHelper vrsteKatalogaService = new WebAPIHelper("http://localhost:51062/", "api/VrsteKataloga");
        WebAPIHelper sezoneService = new WebAPIHelper("http://localhost:51062/", "api/Sezone");
        WebAPIHelper katalogService = new WebAPIHelper("http://localhost:51062/", "api/Katalog");
        WebAPIHelper proizvodiService = new WebAPIHelper("http://localhost:51062/", "api/Proizvodi");
        WebAPIHelper revijeService = new WebAPIHelper("http://localhost:51062/", "api/Revije");

        public List<Proizvodi> odabraniProizvodiKonacno = new List<Proizvodi>();
        public List<uspProizvodiBySezonaRevija_Result> pom= new List<uspProizvodiBySezonaRevija_Result>();
        public List<uspProizvodiBySezonaRevija_Result> proizvodi;
        public AddKatalog()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void AddKatalog_Load(object sender, EventArgs e)
        {
         
            BindSezone();
           
           BindGrid();
       
       
        }

        private void BindSezone()
        {
            HttpResponseMessage response = sezoneService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<Sezone> sezone = response.Content.ReadAsAsync<List<Sezone>>().Result;
                sezone.Insert(0, new Sezone());
                sezone[0].Naziv = "Odaberite sezonu";
                sezoneList.DataSource = sezone;
                sezoneList.DisplayMember = "Naziv";
                sezoneList.ValueMember = "SezonaID";

            }
        }


        private void BindGrid()
        {


            HttpResponseMessage response = proizvodiService.GetActionResponse("ProizvodiBySezonaRevija",Convert.ToInt32(sezoneList.SelectedValue));


            if (response.IsSuccessStatusCode)
            {
                dgProizvodi.AutoGenerateColumns = false;
                proizvodi= response.Content.ReadAsAsync<List<uspProizvodiBySezonaRevija_Result>>().Result;
                dgProizvodi.DataSource = proizvodi;


            }
        }

        

        private void addKatalogBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                HttpResponseMessage responseP = proizvodiService.GetResponse();
                List<Proizvodi> proizvodiBaza = responseP.Content.ReadAsAsync<List<Proizvodi>>().Result;




                Katalog katalog = new Katalog();

               
                katalog.Naziv = nazivInput.Text;

                katalog.KorisnikID = Global.prijavljeniKorisnik.KorisnikID;
                List<int> odabraniProizvodi = new List<int>();
                foreach (DataGridViewRow item in dgProizvodi.Rows)
                {

                    var chk = item.Cells["Odaberi"].Value;
               

                    if (Convert.ToBoolean(chk))
                    {

                        var id = item.Cells["ProizvodID"].Value;
                        odabraniProizvodi.Add(Convert.ToInt32(id));
                    }
                }

                foreach (var proizvod in proizvodi)
                {
                    foreach (var odabrani in odabraniProizvodi)
                    {
                        if (proizvod.ProizvodID == odabrani)
                        {
                            pom.Add(proizvod);
                        }
                    }
                }

                foreach (var odabraniPro in pom)
                {
                    foreach (Proizvodi proBaza in proizvodiBaza)
                    {
                        if (proBaza.ProizvodID == odabraniPro.ProizvodID)
                            odabraniProizvodiKonacno.Add(proBaza);
                    }
                }


                katalog.Proizvodi = odabraniProizvodiKonacno;

                if (katalog.Proizvodi.Count < 3)
                { MessageBox.Show("Katalog ne može imati manje od 3 proizvoda !"); }

                else
                {
                    HttpResponseMessage response = katalogService.PostResponse(katalog);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Uspješno ste dodali novi katalog", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
           
        
            sezoneList.SelectedIndex = 0;
            nazivInput.Text = "";
            BindGrid();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        //private void dgProizvodi_DoubleClick(object sender, EventArgs e)
        //{
        //    int selectedrowindex = dgProizvodi.SelectedCells[0].RowIndex; 

        //    string naziv = Convert.ToString(dgProizvodi.Rows[selectedrowindex].Cells[2].Value);

        //    byte[] slika = null;
        //    foreach ( uspProizvodiBySezonaRevija_Result item in proizvodi)
        //    {
        //       if (item.Naziv == naziv)
        //       {
        //            slika = item.Slika;
               
        //       }
        //    }

        //    if (slika != null)
        //    {
        //        frm_SlikaProizvoda f = new frm_SlikaProizvoda(slika);
        //        f.Show();
        //    }
        //    else { MessageBox.Show("Ovaj proizvod nema unesenu sliku!"); }
        //}

        private void nazivInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(nazivInput.Text.Trim()) || nazivInput.Text.Length < 3)
            {
                e.Cancel = true;
                errorProvider1.SetError(nazivInput, Global.GetPoruka("req"));

            }
            else if (nazivInput.TextLength < 3)
            {
                e.Cancel = true;
                errorProvider1.SetError(nazivInput, "Naziv mora imati najmanje 3 karaktera!");
            }
            else
            {
                errorProvider1.SetError(nazivInput, "");
            }
        }

       

        private void dgProizvodi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

     
       
    

    }
}
