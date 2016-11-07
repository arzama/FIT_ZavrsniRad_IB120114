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

namespace PEPmodnaKompanija_Mobile.Lookbooks
{

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PregledModela : Page
    {
        WebAPIHelper lookbookServis = new WebAPIHelper("http://localhost:51062/", "api/LookBook");
        WebAPIHelper modeliServis = new WebAPIHelper("http://localhost:51062/", "api/Modeli");
        public PregledModela()
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
            //BindLookbook();
            BindModeli();
           
        }


        private void lookbookList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BindModeli();
        }

        private void BindModeli()
        {
            
            HttpResponseMessage response = modeliServis.GetActionResponse("ModeliByLookbookPhone");

            if (response.IsSuccessStatusCode)
            {


                modeliList.ItemsSource = response.Content.ReadAsAsync<List<Modeli>>().Result;
            }
        }


        //private void BindLookbook()
        //{
        //    HttpResponseMessage respone = lookbookServis.GetResponse();

        //    if (respone.IsSuccessStatusCode)
        //    {
        //        lookbookList.ItemsSource = respone.Content.ReadAsAsync<List<Lookbook>>().Result;
        //        lookbookList.DisplayMemberPath = "Naziv";
        //    }
        //}

        private void modeliList_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frame.Navigate(typeof(DetaljiModela), ((Modeli)e.ClickedItem).ModelID);
        }

    }
}
