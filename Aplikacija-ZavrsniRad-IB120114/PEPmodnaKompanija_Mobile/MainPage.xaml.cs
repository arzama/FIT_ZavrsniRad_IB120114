using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Phone.UI.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace PEPmodnaKompanija_Mobile
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
            HardwareButtons.BackPressed += HardwareButtons_BackPressed;
        }

        private void HardwareButtons_BackPressed(object sender, BackPressedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;

            if (rootFrame != null)
                if (rootFrame.CanGoBack)
                {
                    rootFrame.GoBack();
                    e.Handled = true;
                }
        }


        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (Global.prijavljeniKupac != null)
            {
                prijavaButton.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                profilButton.Visibility = Windows.UI.Xaml.Visibility.Visible;
                favouriteButton.Visibility = Windows.UI.Xaml.Visibility.Visible;
                narudzbeButton.Visibility = Windows.UI.Xaml.Visibility.Visible;
                urediProfilButton.Visibility = Windows.UI.Xaml.Visibility.Visible;
                odjavaButton.Visibility = Windows.UI.Xaml.Visibility.Visible;
            }
        }

        private void proizvodiButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Products.Search));
        }

        private void prijavaButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Login));
        }

        private void modeliButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Lookbooks.PregledModela));
        }

        private void profilButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Profil.AktivneNarudzbe));
        }

        private void favouriteButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(FavouriteAlbum.Pregled));
        }

        private void narudzbeButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Profil.ListaNarudzbi));
        }

        private void profilButton_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void urediProfilButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Profil.UrediProfil));
        }

        private void katalogButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Katalog.Lista));
        }

        private void odjavaButton_Click(object sender, RoutedEventArgs e)
        {
            Global.prijavljeniKupac = null;
            Frame.Navigate(typeof(Login));
        }
    }
}
