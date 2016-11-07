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
using PEPmodnaKompanija_API.Models;

using PEPmodnaKompanija_UI.Util;
using System.IO;
using System.Configuration;
using System.Text.RegularExpressions;


namespace PEPmodnaKompanija_UI.Products
{
    public partial class AddForm : Form
    {
        WebAPIHelper vrsteProizvodaService = new WebAPIHelper("http://localhost:51062/", "api/VrsteProizvoda");
        WebAPIHelper proizvodiService = new WebAPIHelper("http://localhost:51062/", "api/Proizvodi");
        WebAPIHelper sezoneService = new WebAPIHelper("http://localhost:51062/", "api/Sezone");
        WebAPIHelper dizajneriService = new WebAPIHelper("http://localhost:51062/", "api/Dizajneri");
        WebAPIHelper velicineService = new WebAPIHelper("http://localhost:51062/", "api/Velicine");

          private Proizvodi proizvod { get; set; }

        public AddForm()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            BindVrsteProizvoda();
            BindSezone();
           BindDizajneri();
           BindVelicine();
        }
        private void BindVelicine()
        {
            HttpResponseMessage response = velicineService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<Velicine> velicine = response.Content.ReadAsAsync<List<Velicine>>().Result;
                velicine.Insert(0, new Velicine());
                velicine[0].Naziv = "Odaberite velicinu";
                velicinaList.DataSource = velicine;
                velicinaList.DisplayMember = "Naziv";
                velicinaList.ValueMember = "VelicinaID";

            }
        }


        private void BindVrsteProizvoda()
        {
            HttpResponseMessage response = vrsteProizvodaService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<VrsteProizvoda> vrste = response.Content.ReadAsAsync<List<VrsteProizvoda>>().Result;
                vrste.Insert(0, new VrsteProizvoda());
                vrste[0].Naziv = "Odaberite vrstu";
                vrstaList.DataSource = vrste;
                vrstaList.DisplayMember = "Naziv";
                vrstaList.ValueMember = "VrstaID";
            }
         
        }

        private void BindDizajneri()
        {
            HttpResponseMessage response = dizajneriService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<Korisnici> dizajneri = response.Content.ReadAsAsync<List<Korisnici>>().Result;
                dizajneri.Insert(0, new Korisnici());
                dizajneri[0].Ime = "Odaberite dizajnera";
                dizajneriList.DataSource = dizajneri;
                dizajneriList.DisplayMember = "Ime";
                dizajneriList.ValueMember = "KorisnikID";
            }

        }

        private void BindSezone()
        {
            HttpResponseMessage response = sezoneService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<Sezone> sezone = response.Content.ReadAsAsync<List<Sezone>>().Result;
                sezone.Insert(0, new Sezone());
                sezone[0].Naziv = "Odaberite sezonu";
                sezonaList.DataSource = sezone;
                sezonaList.DisplayMember = "Naziv";
                sezonaList.ValueMember = "SezonaID";
                
            }
        }



        private void dodajSlikuButton_Click(object sender, EventArgs e)
        {
            try{
            proizvod = new Proizvodi();
            openFileDialog.ShowDialog();
            slikaInput.Text = openFileDialog.FileName;

            Image image = Image.FromFile(slikaInput.Text);

            MemoryStream ms = new MemoryStream();  
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            proizvod.Slika = ms.ToArray();   

            int resizedImgWidth = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImgWidth"]);
            int resizedImgHeight = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImgHeight"]);
            int croppedImgWidth = Convert.ToInt32(ConfigurationManager.AppSettings["croppedImgWidth"]);
            int croppedImgHeight = Convert.ToInt32(ConfigurationManager.AppSettings["croppedImgHeight"]);

            if (image.Width > resizedImgWidth)
            {
                
                Image resizedImage = UIHelper.ResizeImage(image, new Size(resizedImgWidth, resizedImgHeight));
                pictureBox.Image = resizedImage;

                Image croppedImage = resizedImage;

                int croppedXPosition= (resizedImage.Width- croppedImgWidth)/2;  
                int croppedYPosition=(resizedImage.Height - croppedImgHeight)/2; 

             
                if (resizedImage.Width >= croppedImgWidth && resizedImage.Height >= croppedImgHeight)
                {

                    croppedImage = UIHelper.CropImage(resizedImage, new Rectangle(croppedXPosition, croppedYPosition, croppedImgWidth, croppedImgHeight));
                    ms = new MemoryStream();
                    croppedImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    proizvod.SlikaThumb = ms.ToArray();
                    pictureBox.Image = croppedImage;
                }
                 }
                 else
                 {
                     MessageBox.Show(Global.GetPoruka("picture_war") + " " + resizedImgWidth + "x" + resizedImgHeight + ".", Global.GetPoruka("warning"),
                                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     proizvod = null;
                 }
            }
             catch (Exception)
            {
                proizvod = null;
                pictureBox.Image = null;
                slikaInput.Text = "";
            }
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (proizvod == null)
                    proizvod = new Proizvodi();

                if (vrstaList.SelectedIndex != 0)
                    proizvod.VrstaID = Convert.ToInt32(vrstaList.SelectedValue);

                if (dizajneriList.SelectedIndex != 0)
                    proizvod.KorisnikID = Convert.ToInt32(dizajneriList.SelectedValue);

                if (velicinaList.SelectedIndex != 0)
                    proizvod.VelicinaID = Convert.ToInt32(velicinaList.SelectedValue);


                if (sezonaList.SelectedIndex != 0)
                    proizvod.SezonaID = Convert.ToInt32(sezonaList.SelectedValue);

                proizvod.Sifra = sifraInput.Text;
                proizvod.Naziv = nazivInput.Text;
                proizvod.Cijena = Convert.ToDecimal(cijenaInput.Text);
                proizvod.Status = true;

                bool postoji = false;
                HttpResponseMessage responsePostoji = proizvodiService.GetResponse();
                List<Proizvodi> getP = responsePostoji.Content.ReadAsAsync<List<Proizvodi>>().Result;
                foreach (var item in getP)
                {
                    if (item.Sifra == sifraInput.Text)
                        postoji = true;
                }

                if (postoji == false)
                {

                    HttpResponseMessage response = proizvodiService.PostResponse(proizvod);
                    if (proizvod.Slika == null)
                    {
                        MessageBox.Show("Obavezno unijeti sve podatke !");
                    }
                    else
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show(Global.GetPoruka("product_succ"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear();
                        }
                        else
                        {
                            MessageBox.Show(response.ReasonPhrase, Global.GetPoruka("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                        Clear();
                    }
                }
                else MessageBox.Show("Već postoji proizvod sa istom šifrom!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 
            }
        }

        private void Clear()
        {
            sifraInput.Text = "";
            nazivInput.Text = "";
            cijenaInput.Text = "";
            sezonaList.SelectedIndex = 0;
            dizajneriList.SelectedIndex = 0;
            vrstaList.SelectedIndex = 0;
            velicinaList.SelectedIndex = 0;
            slikaInput.Text = "";
            pictureBox.Image = null;
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        #region validacija

        private void velicinaList_Validating(object sender, CancelEventArgs e)
        {
            if (velicinaList.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(velicinaList, "Obavezno odabrati veličinu proizvoda!");
            }
            else
            {

                errorProvider1.SetError(velicinaList, "");
            }
        }

        private void vrstaList_Validating(object sender, CancelEventArgs e)
        {
            if (vrstaList.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(vrstaList, "Obavezno odaberite vrstu proizvoda !");
            }
            else
            {

                errorProvider1.SetError(vrstaList, "");
            }
        }

        private void sezonaList_Validating(object sender, CancelEventArgs e)
        {
            if (sezonaList.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(sezonaList, "Obavezno odaberite sezonu !");
            }
            else
            {

                errorProvider1.SetError(sezonaList, "");
            }

        }

        private void dizajneriList_Validating(object sender, CancelEventArgs e)
        {
            if (dizajneriList.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(dizajneriList, "Obavezno odaberite dizajnera!");
            }
            else
            {

                errorProvider1.SetError(dizajneriList, "");
            }
        }

        private void sifraInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(sifraInput.Text.Trim()) || sifraInput.Text.Length < 3)
            {
                e.Cancel = true;
                errorProvider1.SetError(sifraInput, Global.GetPoruka("req"));

            }
            else if (sifraInput.TextLength < 3)
            {
                e.Cancel = true;
                errorProvider1.SetError(sifraInput, "Šifra mora imati najmanje 3 karaktera!");
            }
            else
                errorProvider1.SetError(sifraInput, "");
        }

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

        private void cijenaInput_Validating(object sender, CancelEventArgs e)
        {
            var text = cijenaInput.Text.Trim();


            if (String.IsNullOrEmpty(cijenaInput.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(cijenaInput, Global.GetPoruka("req"));
            }

           
            else
            {
                errorProvider1.SetError(cijenaInput, "");
            }

        }

        private void slikaInput_Validating(object sender, CancelEventArgs e)
        {
        }

     
#endregion  

        private void cijenaInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != ','))
            {
                e.Handled = true;
            }

          
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.Contains(',')))
            {
                e.Handled = true;
            }


          
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

      
    }
}
