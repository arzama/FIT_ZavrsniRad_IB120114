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
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace PEPmodnaKompanija_Mobile.Katalog
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Lista : Page
    {
        WebAPIHelper katalogServis = new WebAPIHelper("http://localhost:51062/", "api/Katalog");
        public Lista()
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
            HttpResponseMessage response = katalogServis.GetActionResponse("KatalogSelect");

            if (response.IsSuccessStatusCode)
            {


                proizvodiList.ItemsSource = response.Content.ReadAsAsync<List<Proizvodi>>().Result;
                //DatumTxt.Text = response.Content.ReadAsAsync<List<Proizvodi>>().Result.FirstOrDefault().Datum.ToString("dd/MM/yyy");
          
            }

            HttpResponseMessage response1 = katalogServis.GetActionResponse("GetLast");
           
            if (response1.IsSuccessStatusCode)
            {
                Proizvodi p = response1.Content.ReadAsAsync<Proizvodi>().Result;
                DatumTxt.Text = p.Datum.ToString("dd/MM/yyy");
                NazivTxt.Text =p.Naziv;
            }
        }

        private void proizvodiList_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frame.Navigate(typeof(Detalji), ((Proizvodi)e.ClickedItem).ProizvodID);
        }
    }
}
