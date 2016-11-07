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

namespace PEPmodnaKompanija_UI.ModulDizajner
{
    public partial class AddLookBook : Form
    {

        WebAPIHelper lookBookService = new WebAPIHelper("http://localhost:51062/", "api/LookBook");
        
        WebAPIHelper modeliService = new WebAPIHelper("http://localhost:51062/", "api/Modeli");
       
      
        private ModelLookBook modellookBook { get; set; }
        public AddLookBook()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void AddLookBook_Load(object sender, EventArgs e)
        {
            BindModeli();
        }

        private void BindModeli()
        {
            //HttpResponseMessage response = modeliService.GetResponse();
            HttpResponseMessage response = modeliService.GetActionResponse("GetModeliByDizajnerID",Global.prijavljeniKorisnik.KorisnikID.ToString());
            if (response.IsSuccessStatusCode)
            {
                ((ListBox)modeliList).DataSource = response.Content.ReadAsAsync<List<Modeli>>().Result;
                ((ListBox)modeliList).DisplayMember = "Naziv";
               // ((ListBox)modeliList).DisplayMember = "Slika";
                modeliList.ClearSelected();
                
            }
        }

        private void DodajLookBookBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
            
                 LookBook lookBook = new LookBook();

               
                lookBook.Naziv = nazivInput.Text;
              
                lookBook.KorisnikID = Global.prijavljeniKorisnik.KorisnikID;
                lookBook.Modeli = modeliList.CheckedItems.Cast<Modeli>().ToList();
         
                HttpResponseMessage response = lookBookService.PostResponse(lookBook);
     
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Uspješno ste dodali novi lookbook", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                       
                    }
                    else
                    {
                        MessageBox.Show(response.ReasonPhrase, Global.GetPoruka("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            

        }


        private void Clear()
        {

            nazivInput.Text = "";
            modeliList.ClearSelected();
            for (int index = 0; index < modeliList.Items.Count; ++index)
            {
                modeliList.SetItemChecked(index, false);
            }
        }

        private void nazivInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(nazivInput.Text.Trim()) || nazivInput.Text.Length < 3)
            {
                e.Cancel = true;
                errorProvider1.SetError(nazivInput,"Obavezno unijeti naziv!");

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

        private void modeliList_Validating(object sender, CancelEventArgs e)
        {
            int i = modeliList.CheckedItems.Count;
            if (i < 2)
            {
                e.Cancel = true;
                errorProvider1.SetError(modeliList, "LookBook mora sadržavati najmanje 2 look-a!");
            }
            else
            {
                errorProvider1.SetError(modeliList, "");
            }
        }

    


    }
       
}
