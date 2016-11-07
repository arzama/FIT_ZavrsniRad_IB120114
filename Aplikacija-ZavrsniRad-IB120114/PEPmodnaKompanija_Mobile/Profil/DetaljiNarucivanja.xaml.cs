using PEPmodnaKompanija_PCL.Model;
using PEPmodnaKompanija_PCL.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace PEPmodnaKompanija_Mobile.Profil
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DetaljiNarucivanja : Page
    {
        WebAPIHelper dostavaServis = new WebAPIHelper("http://localhost:51062/", "api/NacinDostave");
        WebAPIHelper placanjeServis = new WebAPIHelper("http://localhost:51062/", "api/NacinPlacanja");
        WebAPIHelper adresaServis = new WebAPIHelper("http://localhost:51062/", "api/AdresaDostave");
        WebAPIHelper narudzbeServis = new WebAPIHelper("http://localhost:51062/", "api/Narudzbe");

        public DetaljiNarucivanja()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            BindNacinDostave();
            BindNacinPlacanja();
        }
            int adresaID = 0;
        private async void zakljuciButton_Click(object sender, RoutedEventArgs e)
        {

            AdresaDostave k = new AdresaDostave();
            k.Ime = imeInput.Text;
            k.Prezime = prezimeInput.Text;
            k.Email = emailInput.Text;
            k.Telefon = telefonInput.Text;
            k.PostanskiBroj = postanskiInput.Text;
            k.Drzava = drzavaInput.Text;
            k.Ulica = ulicaInput.Text;

            if (k.Ime != "" && k.Prezime != "" && k.Email != "" && k.Telefon != "" && k.PostanskiBroj != "" && k.Drzava != "" && k.Ulica != "")
            {


                HttpResponseMessage response = adresaServis.PostResponse(k);

                if (response.IsSuccessStatusCode)
                {

                    HttpResponseMessage response1 = adresaServis.GetResponse("GetLast");
                    if (response1.IsSuccessStatusCode)
                    {


                        adresaID = response1.Content.ReadAsAsync<AdresaDostave>().Result.AdresaDostaveID;
                    }




                }
                else
                {
                    MessageDialog msg = new MessageDialog("Došlo je do greške: " + response.ReasonPhrase);
                    await msg.ShowAsync();
                }
            }
            else
            {
                MessageDialog msg = new MessageDialog("Došlo je do greške: Niste unijeli sve podatke! ");
                await msg.ShowAsync();

            }
            if (adresaID != 0)
            {
                int dostava = 0;
                int placanje = 0;

                if (dostavaList.SelectedIndex != -1)
                    dostava = ((NacinDostave)dostavaList.SelectedValue).NacinDostaveID;
                if (placanjeList.SelectedIndex != -1)
                    placanje = ((NacinPlacanja)placanjeList.SelectedValue).NacinPlacanjaID;

                if (dostavaList.SelectedIndex != -1 && placanjeList.SelectedIndex != -1)
                {
                    Global.aktivnaNarudzba.AdresaDostaveID = Convert.ToInt32(adresaID);

                    Global.aktivnaNarudzba.NacinDostaveID = Convert.ToInt32(dostava);
                    Global.aktivnaNarudzba.NacinPlacanjaID = Convert.ToInt32(placanje);

                    HttpResponseMessage response3 = narudzbeServis.PostResponse(Global.aktivnaNarudzba);

                    if (response3.IsSuccessStatusCode)
                    {


                        MessageDialog msg = new MessageDialog("Uspješno ste zaključili narudžbu.");
                        await msg.ShowAsync();

                        Global.aktivnaNarudzba = null;

                        Frame.Navigate(typeof(Profil.ListaNarudzbi));
                    }
                    else
                    {
                        MessageDialog msg = new MessageDialog("Došlo je do greške: " + response3.ReasonPhrase);
                        await msg.ShowAsync();
                    }
                }
                else {
                    MessageDialog msg = new MessageDialog("Došlo je do greške: Niste unijeli sve podatke! ");
                    await msg.ShowAsync();
                }
            }
            else { return; }
        }
        private void BindNacinDostave()
        {
            HttpResponseMessage response = dostavaServis.GetResponse();

            if (response.IsSuccessStatusCode)
            {

                dostavaList.ItemsSource = response.Content.ReadAsAsync<List<NacinDostave>>().Result;
                dostavaList.DisplayMemberPath = "Naziv";


            }
        }
        private void BindNacinPlacanja()
        {
            HttpResponseMessage response = placanjeServis.GetResponse();

            if (response.IsSuccessStatusCode)
            {

                placanjeList.ItemsSource = response.Content.ReadAsAsync<List<NacinPlacanja>>().Result;
                placanjeList.DisplayMemberPath = "Naziv";


            }
        }

    }
}
