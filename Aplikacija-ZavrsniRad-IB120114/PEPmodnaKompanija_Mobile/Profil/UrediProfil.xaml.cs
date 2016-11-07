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
    public sealed partial class UrediProfil : Page
    {
        WebAPIHelper kupacServis = new WebAPIHelper("http://localhost:51062/", "api/Kupci");

        private Kupci kupac { get; set; }

        public UrediProfil()
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

            HttpResponseMessage response = kupacServis.GetActionResponse("GetKupciByUsername", Global.prijavljeniKupac.KorisnickoIme.ToString());


            if (response.IsSuccessStatusCode)
            {


              kupac= response.Content.ReadAsAsync<Kupci>().Result;
              imeTxt.Text = kupac.Ime;
              prezimeTxt.Text = kupac.Prezime;
              emailTxt.Text = kupac.Email;
              datumTxt.Text = kupac.DatumRegistracije.ToString("dd/MM/yyy");
              usernameTxt.Text = kupac.KorisnickoIme;

              imeTxb.PlaceholderText = kupac.Ime;
              prezimeTxb.PlaceholderText = kupac.Prezime;
              emailTxb.PlaceholderText = kupac.Email;

            }

        }

        private void urediBtn_Click(object sender, RoutedEventArgs e)
        {

            imeTxt.Visibility = Visibility.Collapsed;
            prezimeTxt.Visibility = Visibility.Collapsed;
            datumTxt.Visibility = Visibility.Collapsed;
            emailTxt.Visibility = Visibility.Collapsed;
         
            usernameTxt.Visibility = Visibility.Collapsed;

            imeLbl.Visibility = Visibility.Collapsed;
            prezimeLbl.Visibility = Visibility.Collapsed;
            datumLbl.Visibility = Visibility.Collapsed;
            emailLbl.Visibility = Visibility.Collapsed;
           
            usernameLbl.Visibility = Visibility.Collapsed;

            urediBtn.Visibility = Visibility.Collapsed;
            sacuvajBtn.Visibility = Visibility.Visible;
            imeTxb.Visibility = Visibility.Visible;
            prezimeTxb.Visibility = Visibility.Visible;
            emailTxb.Visibility = Visibility.Visible;
            
        }

        private void sacuvajBtn_Click(object sender, RoutedEventArgs e)
        {

            int kupacId = Global.prijavljeniKupac.KupacID;
            #region EditKupca
            Kupci k = new Kupci();
            if (imeTxb.Text != "") k.Ime = imeTxb.Text; else k.Ime = Global.prijavljeniKupac.Ime;
            if (prezimeTxb.Text != "") k.Prezime = prezimeTxb.Text; else k.Prezime = Global.prijavljeniKupac.Prezime;
            if (emailTxb.Text != "") k.Email = emailTxb.Text; else k.Email = Global.prijavljeniKupac.Email;
            
            #endregion
            HttpResponseMessage response = kupacServis.GetActionResponse4("EditKupac", kupacId.ToString(), k.Ime, k.Prezime, k.Email);
            string message = "Greška prilikom promjene podataka! ";
            if (response.IsSuccessStatusCode)
            {
                Kupci c = response.Content.ReadAsAsync<Kupci>().Result;
                imeTxb.Text = c.Ime; prezimeTxb.Text = c.Prezime; emailTxb.Text = c.Email; 
                message = "Uspješno promjenjeni podaci!";
            }

            MessageDialog msg = new MessageDialog(message);
            msg.ShowAsync();
            Frame.Navigate(typeof(UrediProfil));
        }
    }
}
