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
    public sealed partial class ListaNarudzbi : Page
    {

        WebAPIHelper narudzbeServis = new WebAPIHelper("http://localhost:51062/", "api/Narudzbe");

        public ListaNarudzbi()
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

            
            HttpResponseMessage response = narudzbeServis.GetActionResponse("GetListaNarudzbi",Global.prijavljeniKupac.KupacID.ToString());
        

            if (response.IsSuccessStatusCode)
            {
                

                narudzbeKorisnikaList.ItemsSource = response.Content.ReadAsAsync<List<Narudzbe>>().Result;

             
            }

            BindNarudzbe();
        }

        private void BindNarudzbe()
        {
       
            HttpResponseMessage response = narudzbeServis.GetActionResponse("GetListaNarudzbi",Global.prijavljeniKupac.KupacID.ToString());

            if (response.IsSuccessStatusCode)
            {


                narudzbeKorisnikaList.ItemsSource = response.Content.ReadAsAsync<List<Narudzbe>>().Result;
             

            }
        }

        private void narudzbeKorisnikaList_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frame.Navigate(typeof(ListaNarudzbaStavke), ((Narudzbe)e.ClickedItem).NarudzbaID);
             
        }
    }
}
