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

namespace PEPmodnaKompanija_Mobile
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Registracija : Page
    {
        WebAPIHelper servis = new WebAPIHelper("http://localhost:51062/", "api/Kupci");
        public Registracija()
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
        }

        private async void registracijaButton_Click(object sender, RoutedEventArgs e)
        {
            Kupci k = new Kupci();
            k.Ime = imeInput.Text;
            k.Prezime = prezimeInput.Text;
            k.Email = emailInput.Text;
            k.KorisnickoIme = korisnickoImeInput.Text;
            k.LozinkaSalt = UIHelper.GenerateSalt();
            k.LozinkaHash = UIHelper.GenerateHash(lozinkaInput.Password, k.LozinkaSalt);
            k.DatumRegistracije = DateTime.Now;
            k.Status = true;
            if (k.Ime != "" && k.Prezime != "" && k.KorisnickoIme != "" && lozinkaInput.Password != "")
            {
                HttpResponseMessage rsp = servis.GetActionResponse("GetKupciByUsername", k.KorisnickoIme);
                if (rsp.IsSuccessStatusCode)
                {
                    MessageDialog msg = new MessageDialog("Uneseno korisničko ime već postoji, pokušajte sa drugim!");
                    await msg.ShowAsync();
                }
                else
                {
                    HttpResponseMessage response = servis.PostResponse(k);
                    if (response.IsSuccessStatusCode)
                    {
                        MessageDialog msg = new MessageDialog("Registracija uspješna !");
                        await msg.ShowAsync();
                        Frame.Navigate(typeof(Login));
                    }
                    else
                    {
                        MessageDialog msg = new MessageDialog("Došlo je do greške: " + response.ReasonPhrase);
                        await msg.ShowAsync();
                    }
                }
            }
            else
            {
                MessageDialog msg = new MessageDialog("Došlo je do greške: Niste unijeli sve podatke! ");
                await msg.ShowAsync();

            }
        }
    }
}
