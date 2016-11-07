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
    public sealed partial class AktivneNarudzbe : Page
    {
        WebAPIHelper narudzbeServis = new WebAPIHelper("http://localhost:51062/", "api/Narudzbe");
        WebAPIHelper skladistaServis = new WebAPIHelper("http://localhost:51062/", "api/SkladisteProizvodi");

        public AktivneNarudzbe()
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
            BindNarudzba();
        }
        private void BindNarudzba()
        {
            if (Global.aktivnaNarudzba != null)
            {
                zakljuciButton.Visibility = Windows.UI.Xaml.Visibility.Visible;

                narudzbaList.ItemsSource = Global.aktivnaNarudzba.NarudzbaStavke;


                decimal iznos = 0;

                foreach (NarudzbaStavke item in Global.aktivnaNarudzba.NarudzbaStavke)
                {
                    iznos += item.Proizvodi.Cijena * item.Kolicina;
                }

                iznosLabel.Text = "Ukupan iznos: " + Math.Round(iznos, 2) + "KM";
            }
            else korpaPraznaLabel.Visibility = Windows.UI.Xaml.Visibility.Visible;
        }

        private async void zakljuciButton_Click(object sender, RoutedEventArgs e)
        {


            HttpResponseMessage responseSkladista = skladistaServis.GetResponse();
            List<SkladistaProizvodi> skl = responseSkladista.Content.ReadAsAsync<List<SkladistaProizvodi>>().Result;
  bool dostupno1 = false;
            string msg2 = "";
            foreach (var item in skl)
            {
                foreach (var item2 in Global.aktivnaNarudzba.NarudzbaStavke)
                {

                    if (item.ProizvodID == item2.Proizvodi.ProizvodID && item.Kolicina > item2.Kolicina)
                    {
                        dostupno1 = true;
                       
                    }
                    else if (item.ProizvodID == item2.Proizvodi.ProizvodID && item.Kolicina < item2.Kolicina)
                    {
                        dostupno1 = false;
                        msg2 = "Dostupna količina proizvoda '" + item2.Proizvodi.Naziv+ "' na skladištu je manja od dodane količine!";
                     

                   
                    }
                }
            }

                if (dostupno1 == true)
                {
                    //HttpResponseMessage response = narudzbeServis.PostResponse(Global.aktivnaNarudzba);


                    //if (response.IsSuccessStatusCode)
                    //{


                    //    MessageDialog msg = new MessageDialog("Uspješno ste zaključili narudžbu.");
                    //    await msg.ShowAsync();

                    //    Global.aktivnaNarudzba = null;

                    //    Frame.Navigate(typeof(Profil.ListaNarudzbi));
                    //}

                    Frame.Navigate(typeof(Profil.DetaljiNarucivanja));
                }

                else
                {
                   
                    MessageDialog msg1 = new MessageDialog(msg2);
                    await msg1.ShowAsync();

                    Global.aktivnaNarudzba = null;
                    Frame.Navigate(typeof(Profil.AktivneNarudzbe));
                }
            }
        }
    }

