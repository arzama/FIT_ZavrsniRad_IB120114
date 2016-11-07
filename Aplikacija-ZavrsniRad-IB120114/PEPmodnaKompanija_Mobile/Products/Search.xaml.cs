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
using PEPmodnaKompanija_PCL.Model;
using PEPmodnaKompanija_PCL.Util;
using System.Net.Http;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace PEPmodnaKompanija_Mobile.Products
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Search : Page
    {
        WebAPIHelper vrsteProizvodaServis = new WebAPIHelper("http://localhost:51062/", "api/VrsteProizvoda");
        WebAPIHelper sezoneServis = new WebAPIHelper("http://localhost:51062/", "api/Sezone");
        WebAPIHelper proizvodiServis = new WebAPIHelper("http://localhost:51062/", "api/Proizvodi");
        public Search()
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
            BindVrsteProizvoda();
            BindProizvodi();
            BindSezone();
        }

        private void BindProizvodi()
        {
            int vrstaId = 0;
            if (vrstaProizvodaList.SelectedIndex != -1) 
                vrstaId = ((VrsteProizvoda)vrstaProizvodaList.SelectedValue).VrstaID;

            int sezonaId = 0;
            if (sezonaList.SelectedIndex != -1)
                sezonaId = ((Sezone)sezonaList.SelectedValue).SezonaID;
            HttpResponseMessage response = proizvodiServis.GetActionResponse3("PretragaProizvoda", Convert.ToInt32(vrstaId), Convert.ToInt32(sezonaId), nazivInput.Text.Trim());
        
            if (response.IsSuccessStatusCode)
            {
                
                    
                proizvodiList.ItemsSource = response.Content.ReadAsAsync<List<Proizvodi>>().Result;
            }
        }

        private void BindVrsteProizvoda()
        {
            HttpResponseMessage response = vrsteProizvodaServis.GetResponse();

            if(response.IsSuccessStatusCode)
            {
                vrstaProizvodaList.ItemsSource = response.Content.ReadAsAsync<List<VrsteProizvoda>>().Result;
                vrstaProizvodaList.DisplayMemberPath = "Naziv";


            }
        }

        private void BindSezone()
        {
            HttpResponseMessage response = sezoneServis.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                
                sezonaList.ItemsSource = response.Content.ReadAsAsync<List<Sezone>>().Result;
                sezonaList.DisplayMemberPath = "Naziv";
                

            }
        }

        private void pretragaButton_Click(object sender, RoutedEventArgs e)
        {
            BindProizvodi();
        }

        private void proizvodiList_ItemClick(object sender, ItemClickEventArgs e)
        {
            

            Frame.Navigate(typeof(Detalji), ((Proizvodi)e.ClickedItem).ProizvodID);
        }

     

       
    }
}
