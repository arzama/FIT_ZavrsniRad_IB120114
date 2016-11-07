using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using PEPmodnaKompanija_PCL.Util;
using System.Net.Http;
using PEPmodnaKompanija_PCL.Model;
using Windows.UI.Popups;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace PEPmodnaKompanija_Mobile
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Login : Page
    {
        WebAPIHelper servis = new WebAPIHelper("http://localhost:51062/", "api/Kupci");
        public Login()
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

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            HttpResponseMessage response= servis.GetActionResponse("GetKupciByUsername", korisnickoImeInput.Text);
            string message = string.Empty;
            if(response.IsSuccessStatusCode)
            {
                Kupci k= response.Content.ReadAsAsync<Kupci>().Result;
              
                if(UIHelper.GenerateHash(lozinkaInput.Password, k.LozinkaSalt)== k.LozinkaHash)
                {
                     message="Welcome "+ k.Ime+" "+ k.Prezime;
                    Global.prijavljeniKupac = k;
                    Frame.Navigate(typeof(MainPage));
               
                  
                }
                else 
                {
               message="Podaci nisu validni!";
                  
                }
            }
            else 
            {
             message="Greška u komunikaciji sa WebAPI-om";
          
            }
            MessageDialog msg = new MessageDialog(message);
            await msg.ShowAsync();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Registracija));
        }
    }
}
