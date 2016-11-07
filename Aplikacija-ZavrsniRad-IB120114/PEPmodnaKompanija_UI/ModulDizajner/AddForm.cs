using PEPmodnaKompanija_API.Models;
using PEPmodnaKompanija_UI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEPmodnaKompanija_UI.ModulDizajner
{
    public partial class AddForm : Form
    {
        
        WebAPIHelper proizvodiService = new WebAPIHelper("http://localhost:51062/", "api/Proizvodi");

        WebAPIHelper revijeService = new WebAPIHelper("http://localhost:51062/", "api/Revije");
        WebAPIHelper modeliService = new WebAPIHelper("http://localhost:51062/", "api/Modeli");
        WebAPIHelper modeliProizvodiService = new WebAPIHelper("http://localhost:51062/", "api/ModeliProizvodi");

        private Proizvodi proizvod { get; set; }
        private Modeli model { get; set; }
    
       

        public AddForm()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void AddForm_Load(object sender, EventArgs e)
        {
           BindRevije();
         
        }
      
      
        private void doajSlikuModelaBtn_Click(object sender, EventArgs e)
        {
          
            try
            {
                model = new Modeli();

                
                openFileDialog1.ShowDialog();
                slikaModelaInput.Text = openFileDialog1.FileName;

                Image image = Image.FromFile(slikaModelaInput.Text);

                MemoryStream ms = new MemoryStream();   
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                model.Slika = ms.ToArray();    

               
                int resizedImgWidth = Convert.ToInt32(ConfigurationManager.AppSettings["resizeImgWidthModel"]);
                int resizedImgHeight = Convert.ToInt32(ConfigurationManager.AppSettings["resizeImgHeightModel"]);
                int croppedImgWidth = Convert.ToInt32(ConfigurationManager.AppSettings["croppedImgWidth"]);
                int croppedImgHeight = Convert.ToInt32(ConfigurationManager.AppSettings["croppedImgHeight"]);

                if (image.Width > resizedImgWidth)
                {
                    
                    Image resizedImage = UIHelper.ResizeImage(image, new Size(resizedImgWidth, resizedImgHeight));
                    ModelpictureBox.Image = resizedImage;

                  
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
                ModelpictureBox.Image = null;
                slikaModelaInput.Text = "";
            }
        }



        private void BindRevije()
        {
            HttpResponseMessage response = revijeService.GetActionResponse("RevijeByKorisnikLook", Global.prijavljeniKorisnik.KorisnikID.ToString());
            if (response.IsSuccessStatusCode)
            {
                List<usp_RevijeByKorisnikLook_Result> revije = response.Content.ReadAsAsync<List<usp_RevijeByKorisnikLook_Result>>().Result;
                revije.Insert(0, new usp_RevijeByKorisnikLook_Result());
                revije[0].Naziv = "Odaberite reviju";
                revijeCbx.DataSource = revije;
                revijeCbx.DisplayMember = "Naziv";
                revijeCbx.ValueMember = "RevijaID";

            }
        }

        private void Clear()
        {
            revijeCbx.SelectedIndex = 0;
            nazivInput.Text = "";
            opisInput.Text = "";
            slikaModelaInput.Text = "";
            ModelpictureBox.Image = null;
            
        }
      
       

        private void dodajModelBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (model == null)
                    model = new Modeli();
                if (revijeCbx.SelectedIndex != 0)
                    model.RevijaID = Convert.ToInt32(revijeCbx.SelectedValue);
                model.Opis = opisInput.Text;
                model.Naziv = nazivInput.Text;

                HttpResponseMessage response = modeliService.PostResponse(model);

                if (model.Slika == null)
                {
                    MessageBox.Show("Obavezno unijeti sve podatke !");
                }
                else
                {
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Uspješno ste dodali novi look", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                 
                    
                        AddStavkeModela sm = new AddStavkeModela();
                        sm.Show();
                    }
                    else
                    {
                        MessageBox.Show(response.ReasonPhrase, Global.GetPoruka("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    
        private void slikaModelaInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(slikaModelaInput.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(slikaModelaInput, Global.GetPoruka("slikaModela_req"));
            }

            else
            {
                errorProvider1.SetError(slikaModelaInput, "");

            }

        }

        private void opisInput_Validating(object sender, CancelEventArgs e)
        {

            if (String.IsNullOrEmpty(opisInput.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(opisInput, "Obavezno unijeti opis!");

            }

            else {
                errorProvider1.SetError(opisInput, "");
            }
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

        private void revijeCbx_Validating(object sender, CancelEventArgs e)
        {
            if (revijeCbx.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(revijeCbx, Global.GetPoruka("req"));
            }
            else
            {

                errorProvider1.SetError(revijeCbx, "");
            }
        }

        private void AddForm_Validating(object sender, CancelEventArgs e)
        {

        }


    }
}
