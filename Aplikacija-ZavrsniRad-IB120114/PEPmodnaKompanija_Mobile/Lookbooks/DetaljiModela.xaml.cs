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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace PEPmodnaKompanija_Mobile.Lookbooks
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DetaljiModela : Page
    {
        WebAPIHelper modeliServis = new WebAPIHelper("http://localhost:51062/", "api/Modeli");
        WebAPIHelper proizvodiServis = new WebAPIHelper("http://localhost:51062/", "api/Proizvodi");
        
        WebAPIHelper ocjeneDizajneraServis = new WebAPIHelper("http://localhost:51062/", "api/OcjeneDizajnera");

        int dizajnerID;
        public DetaljiModela()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {

            HttpResponseMessage response = modeliServis.GetActionResponse("GetModeliPhone", e.Parameter.ToString());

            if (response.IsSuccessStatusCode)
            {
                Modeli m = response.Content.ReadAsAsync<Modeli>().Result;

                nazivvLabel.Text = m.Naziv;
                //nazivLabel.Text = m.Naziv;
                imeLabel.Text = m.Dizajner + " " + "(Prosječna ocjena: " + Math.Round((float)m.Prosjek, 2).ToString()+")";
               // prezimeLabel.Text = m.Prezime;
                opisLabel.Text = m.Opis;
                lookbookLabel.Text = m.Lookbook;
                revijaLabel.Text = m.Revija;
                dizajnerID = m.KorisnikID;



                MemoryStream ms = new MemoryStream(m.Slika);
                BitmapImage image = new BitmapImage();

                await image.SetSourceAsync(ms.AsRandomAccessStream());

                modelImage.Source = image;


                if (Global.prijavljeniKupac != null)
                {
                    labelOcjene.Visibility = Windows.UI.Xaml.Visibility.Visible;
                    gridOcjene.Visibility = Windows.UI.Xaml.Visibility.Visible;
                }
            }

            BindProizvodi(e.Parameter.ToString());
        }

        private void BindProizvodi(string ModelId)
        {
            HttpResponseMessage response = proizvodiServis.GetActionResponse("ProizvodiByModelPhone", ModelId);

            if (response.IsSuccessStatusCode)
            {


                proizvodiList.ItemsSource = response.Content.ReadAsAsync<List<Proizvodi>>().Result;
            }
        }



        private void proizvodiList_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frame.Navigate(typeof(Products.Detalji), ((Proizvodi)e.ClickedItem).ProizvodID);
        }


        #region stars
        private async void star1_Click(object sender, RoutedEventArgs e)
        {
            if (Global.prijavljeniKupac == null)
                return;

            HttpResponseMessage response = ocjeneDizajneraServis.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<OcjeneDizajnera> ocjene = response.Content.ReadAsAsync<List<OcjeneDizajnera>>().Result;
                if (ocjene.Where(x => x.KorisnikID == dizajnerID && x.KupacID == Global.prijavljeniKupac.KupacID).Count() > 0)
                {
                    MessageDialog msg = new MessageDialog("Već ste ocijenili ovog dizajnera.");
                    await msg.ShowAsync();
                    return;
                }
            }

            star1.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            star1Full.Visibility = Windows.UI.Xaml.Visibility.Visible;

            ocjeneDizajneraServis.GetActionResponse3("OcjenaDizajnera", dizajnerID, Global.prijavljeniKupac.KupacID, "1");

        }

        private async void star2_Click(object sender, RoutedEventArgs e)
        {
            if (Global.prijavljeniKupac == null)
                return;

            HttpResponseMessage response = ocjeneDizajneraServis.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<OcjeneDizajnera> ocjene = response.Content.ReadAsAsync<List<OcjeneDizajnera>>().Result;
                if (ocjene.Where(x => x.KorisnikID == dizajnerID && x.KupacID == Global.prijavljeniKupac.KupacID).Count() > 0)
                {
                    MessageDialog msg = new MessageDialog("Već ste ocijenili ovag dizajnera.");
                    await msg.ShowAsync();
                    return;
                }
            }

            star1.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            star1Full.Visibility = Windows.UI.Xaml.Visibility.Visible;

            star2.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            star2Full.Visibility = Windows.UI.Xaml.Visibility.Visible;

            ocjeneDizajneraServis.GetActionResponse3("OcjenaDizajnera", dizajnerID, Global.prijavljeniKupac.KupacID, "2");


        }

        private async void star3_Click(object sender, RoutedEventArgs e)
        {

            if (Global.prijavljeniKupac == null)
                return;


            HttpResponseMessage response = ocjeneDizajneraServis.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<OcjeneDizajnera> ocjene = response.Content.ReadAsAsync<List<OcjeneDizajnera>>().Result;
                if (ocjene.Where(x => x.KorisnikID == dizajnerID && x.KupacID == Global.prijavljeniKupac.KupacID).Count() > 0)
                {
                    MessageDialog msg = new MessageDialog("Već ste ocijenili ovag dizajnera.");
                    await msg.ShowAsync();
                    return;
                }
            }

            star1.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            star1Full.Visibility = Windows.UI.Xaml.Visibility.Visible;

            star2.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            star2Full.Visibility = Windows.UI.Xaml.Visibility.Visible;

            star3.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            star3Full.Visibility = Windows.UI.Xaml.Visibility.Visible;

            ocjeneDizajneraServis.GetActionResponse3("OcjenaDizajnera", dizajnerID, Global.prijavljeniKupac.KupacID, "3");

        }

        private async void star4_Click(object sender, RoutedEventArgs e)
        {
            if (Global.prijavljeniKupac == null)
                return;


            HttpResponseMessage response = ocjeneDizajneraServis.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<OcjeneDizajnera> ocjene = response.Content.ReadAsAsync<List<OcjeneDizajnera>>().Result;
                if (ocjene.Where(x => x.KorisnikID == dizajnerID && x.KupacID == Global.prijavljeniKupac.KupacID).Count() > 0)
                {
                    MessageDialog msg = new MessageDialog("Već ste ocijenili ovag dizajnera.");
                    await msg.ShowAsync();
                    return;
                }
            }


            star1.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            star1Full.Visibility = Windows.UI.Xaml.Visibility.Visible;

            star2.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            star2Full.Visibility = Windows.UI.Xaml.Visibility.Visible;

            star3.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            star3Full.Visibility = Windows.UI.Xaml.Visibility.Visible;

            star4.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            star4Full.Visibility = Windows.UI.Xaml.Visibility.Visible;


            ocjeneDizajneraServis.GetActionResponse3("OcjenaDizajnera", dizajnerID, Global.prijavljeniKupac.KupacID, "4");

        }

        private async void star5_Click(object sender, RoutedEventArgs e)
        {
            if (Global.prijavljeniKupac == null)
                return;


            HttpResponseMessage response = ocjeneDizajneraServis.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<OcjeneDizajnera> ocjene = response.Content.ReadAsAsync<List<OcjeneDizajnera>>().Result;
            
                if (ocjene.Where(x =>  x.KupacID == Global.prijavljeniKupac.KupacID).Count() > 0)
                {  
                    MessageDialog msg = new MessageDialog("Već ste ocijenili ovag dizajnera.");
                    await msg.ShowAsync();
                    return;
                }
            }
            star1.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            star1Full.Visibility = Windows.UI.Xaml.Visibility.Visible;

            star2.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            star2Full.Visibility = Windows.UI.Xaml.Visibility.Visible;

            star3.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            star3Full.Visibility = Windows.UI.Xaml.Visibility.Visible;

            star4.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            star4Full.Visibility = Windows.UI.Xaml.Visibility.Visible;

            star5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            star5Full.Visibility = Windows.UI.Xaml.Visibility.Visible;




            ocjeneDizajneraServis.GetActionResponse3("OcjenaDizajnera", dizajnerID, Global.prijavljeniKupac.KupacID, "5");

        }

        #endregion

    }
}
