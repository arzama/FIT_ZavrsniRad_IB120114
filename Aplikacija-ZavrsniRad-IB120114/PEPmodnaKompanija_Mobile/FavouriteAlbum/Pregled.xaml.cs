using PEPmodnaKompanija_Mobile.Products;
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

namespace PEPmodnaKompanija_Mobile.FavouriteAlbum
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Pregled : Page
    {
        WebAPIHelper favouriteServis = new WebAPIHelper("http://localhost:51062/", "api/Favourite");
        WebAPIHelper favouriteProizvodServis = new WebAPIHelper("http://localhost:51062/", "api/FavouiriteProizvod");
        List<Proizvodi> proizvodi;
        public Pregled()
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
            BindFavourite();
        }
        int favID=0;

        private void BindFavourite()
        {
               HttpResponseMessage response = favouriteServis.GetActionResponse("FavouriteByKupac1", Global.prijavljeniKupac.KupacID.ToString());
               HttpResponseMessage responseF = favouriteServis.GetActionResponse("FavouriteByKupac", Global.prijavljeniKupac.KupacID.ToString());
               int favouriteID = 0;
               if (response.IsSuccessStatusCode)
               {
                   if (responseF.IsSuccessStatusCode)
                   {
                       if (responseF.Content.ReadAsAsync<List<Favourite>>().Result.Count > 0)
                       {
                           favouriteID = response.Content.ReadAsAsync<Favourite>().Result.FavouriteID;
                           favID=favouriteID;
                       }
                   }
             
                 
                 
                  // HttpResponseMessage response2 = favouriteProizvodServis.GetActionResponse("GetCount", favouriteID.ToString());
                   //if (response2.Content.ReadAsAsync<int>().Result > 0)
                   //{
                   if (favouriteID != 0)
                   {
                       HttpResponseMessage response1 = favouriteProizvodServis.GetActionResponse("ProizvodiIzFavourite", favouriteID.ToString());
                       proizvodi = response1.Content.ReadAsAsync<List<Proizvodi>>().Result;
                       if (response1.IsSuccessStatusCode)
                       {
                       

                           if (proizvodi.Count() == 0)
                           {
                               cijenaList.Visibility = Visibility.Collapsed;
                               korpaPraznaLabel.Visibility = Visibility.Visible;
                               favouriteList.Visibility = Visibility.Collapsed;
                           }
                           else
                           {
                               
                               favouriteList.ItemsSource = proizvodi;
                               korpaPraznaLabel.Visibility = Visibility.Collapsed;
                               favouriteList.Visibility = Visibility.Visible;

                           }

                       }
                   }
                   else
                   {
                       cijenaList.Visibility = Visibility.Collapsed;
                       korpaPraznaLabel.Visibility = Visibility.Visible;
                       favouriteList.Visibility = Visibility.Collapsed;
                   }



           
              }
      
        }

        public int kliknutiProizvodID=0;
        private void favouriteList_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frame.Navigate(typeof(Products.Detalji), ((Proizvodi)e.ClickedItem).ProizvodID);
       
        }


        private void cijenaList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            string content = ((ComboBoxItem)cijenaList.SelectedItem).Content.ToString();

            if (content == "Cijeni-najvišoj")
            {
                favouriteList.ItemsSource = proizvodi.OrderByDescending(x=>x.Cijena);

            }
            else if (content == "Cijeni-najnižoj")
            {
                favouriteList.ItemsSource = proizvodi.OrderBy(x=>x.Cijena);

            }

        }

        private async void obrisiButton_Click(object sender, RoutedEventArgs e)
        {
            var proizvodID=((Button)sender).Tag;
             HttpResponseMessage response = favouriteProizvodServis.GetActionResponse2("DeleteFavouiriteProizvod",Convert.ToInt32(proizvodID), Convert.ToInt32(favID));
             if (response.IsSuccessStatusCode)
             {
                 MessageDialog msg = new MessageDialog("Uspješno obrisano!");
                 await msg.ShowAsync();
                 BindFavourite();
                 //Frame.Navigate(typeof(FavouriteAlbum.Pregled));
             }
             else
             {
                 MessageDialog msg = new MessageDialog("Došlo je do greške: " + response.ReasonPhrase);
                 await msg.ShowAsync();
             }
        }
    }
}
