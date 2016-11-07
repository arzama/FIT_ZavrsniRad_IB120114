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

namespace PEPmodnaKompanija_Mobile.Products
{
   
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Detalji : Page
    {
        WebAPIHelper proizvodiServis = new WebAPIHelper("http://localhost:51062/", "api/Proizvodi");
        WebAPIHelper favouriteServis = new WebAPIHelper("http://localhost:51062/", "api/Favourite");
        WebAPIHelper favouriteProizvodServis = new WebAPIHelper("http://localhost:51062/", "api/FavouiriteProizvod");
        WebAPIHelper preporukaServis = new WebAPIHelper("http://localhost:51062/", "api/Preporuka");
        WebAPIHelper ocjeneServis = new WebAPIHelper("http://localhost:51062/", "api/Ocjene");
        WebAPIHelper skladistaServis = new WebAPIHelper("http://localhost:51062/", "api/SkladisteProizvodi");
        WebAPIHelper velicineServis = new WebAPIHelper("http://localhost:51062/", "api/Velicine");
        WebAPIHelper izlazServis = new WebAPIHelper("http://localhost:51062/", "api/Izlazi");
        WebAPIHelper narudzbeServis = new WebAPIHelper("http://localhost:51062/", "api/Narudzbe");

        private Proizvodi proizvod { get; set; }
        private Proizvodi proizvodPoVelicini { get; set; }
        bool prvaOcjena = true;
        Ocjene o;
        public Detalji()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        public string proizvodNaziv = "";
        public int proizvodID = 0;
        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
        

            int proizvodId = Convert.ToInt32(e.Parameter);
            proizvodID = Convert.ToInt32(e.Parameter);

        
            HttpResponseMessage response = proizvodiServis.GetActionResponse("GetProizvodi", e.Parameter.ToString());
          
            if (response.IsSuccessStatusCode)
            {
         
                proizvod = response.Content.ReadAsAsync<Proizvodi>().Result;
                proizvodNaziv = proizvod.Naziv;

                vrstaLabel.Text = "Vrsta: " + proizvod.VrstaProizvoda;
                nazivLabel.Text = proizvod.Naziv;
                sezonaLabel.Text = "Za sezonu: " + proizvod.Sezona;
              
                cijenaLabel.Text = proizvod.Cijena.ToString() + " KM";
                prosjekLabel.Text = "Prosječna ocjena: " + Math.Round((float)proizvod.ProsjecnaOcjena, 2).ToString();
          
                MemoryStream ms = new MemoryStream(proizvod.Slika);
                BitmapImage image = new BitmapImage();

                await image.SetSourceAsync(ms.AsRandomAccessStream());

                proizvodImage.Source = image;

                if (Global.prijavljeniKupac != null)
                {
                     HttpResponseMessage responseZ = ocjeneServis.GetResponse();
                     if (responseZ.IsSuccessStatusCode)
                     {
                         List<Ocjene> ocjene = responseZ.Content.ReadAsAsync<List<Ocjene>>().Result;
                         if (ocjene.Where(x => x.ProizvodID == proizvod.ProizvodID && x.KupacID == Global.prijavljeniKupac.KupacID).Count() > 0)
                         {

                             PrikaziZvjezdice();
                         }
                     }
                    BindVelicine();
                    kolicinaInput.Visibility = Windows.UI.Xaml.Visibility.Visible;
                    kupiButton.Visibility = Windows.UI.Xaml.Visibility.Visible;
                    favouriteCbx.Visibility = Windows.UI.Xaml.Visibility.Visible;
                    if (VecKupljen(proizvodId) == true)
                    {
                        gridOcjene.Visibility = Windows.UI.Xaml.Visibility.Visible;
                    }
                    velicinaList.Visibility = Windows.UI.Xaml.Visibility.Visible;
              
                    HttpResponseMessage preporukaResponse = preporukaServis.GetActionResponse2("GetTakodjerKupili", e.Parameter.ToString(), Global.prijavljeniKupac.KupacID);
                    if (preporukaResponse.IsSuccessStatusCode)
                    {

                        List<Proizvodi> preporuceniProizvodi = preporukaResponse.Content.ReadAsAsync<List<Proizvodi>>().Result;
                        if (preporuceniProizvodi.Count > 0)
                        {
                            label.Visibility = Windows.UI.Xaml.Visibility.Visible;
                            preporuceniProizvodiList.ItemsSource = preporuceniProizvodi;
                            if (preporuceniProizvodi.Count == 0)
                            {

                                label.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                            }
                        }

                    }


                    HttpResponseMessage response3 = favouriteProizvodServis.GetActionResponse2("PostojiUListi", proizvod.ProizvodID, Global.prijavljeniKupac.KupacID);
                    if (response3.IsSuccessStatusCode)
                    {
                        if (response3.Content.ReadAsAsync<FavouiriteProizvod>().Result != null)
                            favouriteCbx.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

                        else favouriteCbx.Visibility = Windows.UI.Xaml.Visibility.Visible;

                    }
                    else
                    {
                        favouriteCbx.Visibility = Windows.UI.Xaml.Visibility.Visible;
                    }
               
                }

    


                HttpResponseMessage najprodavanijiResponse = preporukaServis.GetActionResponse("GetNajprodavanije");
                if (najprodavanijiResponse.IsSuccessStatusCode)
                {
                    List<Proizvodi> najprodavanijiProizvodi = najprodavanijiResponse.Content.ReadAsAsync<List<Proizvodi>>().Result;



                    najprodavanijiProizvodiList.ItemsSource = najprodavanijiProizvodi;

                }


              
            }
         
            
        }

        public bool VecKupljen(int proizvodID)
        {
              HttpResponseMessage response78 = izlazServis.GetActionResponse("GetIzlazStavke");
              List<NarudzbaStavke> izs = response78.Content.ReadAsAsync<List<NarudzbaStavke>>().Result;

              HttpResponseMessage response79 = narudzbeServis.GetResponse();
              List<Narudzbe> o = response79.Content.ReadAsAsync<List<Narudzbe>>().Result.Where(x => x.KupacID == Global.prijavljeniKupac.KupacID).ToList();


           
            bool vec = false;
            foreach (var item in o)
            {
                foreach (var item1 in izs)
                {
                    if (item1.NarudzbaID == item.NarudzbaID && item1.ProizvodID == proizvodID)
                    {
                        vec = true;
                    }
                }

            }


            return vec;
        }


        private void BindVelicine()
        {
            HttpResponseMessage response = velicineServis.GetActionResponse("DostupneVelicine",proizvodNaziv);
           
            if (response.IsSuccessStatusCode )
            {
               
                
                velicinaList.ItemsSource = response.Content.ReadAsAsync<List<Velicine>>().Result;
              
                velicinaList.DisplayMemberPath = "Naziv";


            }
        }


        private async void kupiButton_Click(object sender, RoutedEventArgs e)
        {
            int velicinaId = 0;
            if (velicinaList.SelectedIndex != -1) 
                velicinaId = ((Velicine)velicinaList.SelectedValue).VelicinaID;

            if(velicinaId!=0)
            { 
            HttpResponseMessage responseProizvodiBy = proizvodiServis.GetActionResponse2("ProizvodByVelicina", velicinaId, proizvodNaziv);
            proizvodPoVelicini = responseProizvodiBy.Content.ReadAsAsync<Proizvodi>().Result;

            proizvod = proizvodPoVelicini;

            HttpResponseMessage responseSkladista = skladistaServis.GetResponse();
            List<SkladistaProizvodi> skl = responseSkladista.Content.ReadAsAsync<List<SkladistaProizvodi>>().Result;


            bool dostupno1 = false;
            bool naskladistu=false;
           
            string msg2 = "Proizvod nije dostupan na skladištu";

            foreach (var item in skl)
            {


                if (item.ProizvodID == proizvod.ProizvodID && item.Kolicina > Convert.ToInt32(kolicinaInput.Text))
                {
                    dostupno1 = true;
                    naskladistu = true;


                }
                else
                {
                    if (item.ProizvodID == proizvod.ProizvodID && item.Kolicina < Convert.ToInt32(kolicinaInput.Text))
                    {
                        dostupno1 = false;
                        naskladistu = true;
                        msg2 = "Količina proizvoda '" + proizvod.Naziv + "' na skladištu je samo:  " + item.Kolicina + " komad/a.";

                    }
                    else if (item.ProizvodID != proizvod.ProizvodID && naskladistu == false)
                    {
                        dostupno1 = false;
                        msg2 = "Proizvod '" + proizvod.Naziv + "' trenutno nije dostupan na skladištu!";
                    }

                }
            }
               
            


            ///////////


            if (dostupno1== true)
            {
                int brojN = new Random().Next(1, 1000);
                if (Global.aktivnaNarudzba == null)
                {
                    Global.aktivnaNarudzba = new Narudzbe();

                    Global.aktivnaNarudzba.BrojNarudzbe = brojN.ToString() + "/" + DateTime.Now.Year;
                    Global.aktivnaNarudzba.Datum = DateTime.Now;
                    Global.aktivnaNarudzba.KupacID = Global.prijavljeniKupac.KupacID;
                }

                bool proizvodPostoji = false;
                foreach (NarudzbaStavke item in Global.aktivnaNarudzba.NarudzbaStavke)
                {
                    if (item.ProizvodID == proizvod.ProizvodID)
                    {
                        item.Kolicina += Convert.ToInt32(kolicinaInput.Text);
                        proizvodPostoji = true;
                        break;
                    }
                }

                string message = "Uspješno ste dodali proizvod u korpu.";
                if (proizvodPostoji == true)
                {
                    message = "Uspješno ste izmijenili količinu proizvoda u korpi.";
                }
                else
                {
                    NarudzbaStavke s = new NarudzbaStavke();
                    s.ProizvodID = proizvod.ProizvodID;
                    s.Proizvodi = proizvod;
                    s.Kolicina = Convert.ToInt32(kolicinaInput.Text);

                    Global.aktivnaNarudzba.NarudzbaStavke.Add(s);
                }


                MessageDialog msg = new MessageDialog(message);
                await msg.ShowAsync();

                narudbaInfoLabel.Text = "Broj naručenih proizvoda: " + Global.aktivnaNarudzba.NarudzbaStavke.Count;
                zakljuciButton.Visibility = Windows.UI.Xaml.Visibility.Visible;
            }

            else if(dostupno1==false ){
                MessageDialog msg3 = new MessageDialog(msg2);
                await msg3.ShowAsync();
           
            }
            }
            else
            {
                MessageDialog msg = new MessageDialog("Došlo je do greške: Odaberite veličinu! ");
                await msg.ShowAsync();

            }
        }
        private void zakljuciButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Profil.AktivneNarudzbe));
        }



        private async void favouriteCbx_Checked(object sender, RoutedEventArgs e)
        {
            
             HttpResponseMessage response = favouriteServis.GetActionResponse("FavouriteByKupac", Global.prijavljeniKupac.KupacID.ToString());
          
              if (response.IsSuccessStatusCode)
              {
                  int brojFav = response.Content.ReadAsAsync<List<Favourite>>().Result.Count();
                  if (brojFav != 0)
                  {
                     HttpResponseMessage response6 = favouriteServis.GetActionResponse("FavouriteByKupac1", Global.prijavljeniKupac.KupacID.ToString());

                     if (response6.IsSuccessStatusCode)
                     {
                         int favouriteID = response6.Content.ReadAsAsync<Favourite>().Result.FavouriteID;
                         FavouiriteProizvod fp = new FavouiriteProizvod();
                         fp.FavouriteID = favouriteID;
                         fp.ProizvodID = proizvod.ProizvodID;

                         HttpResponseMessage response3 = favouriteProizvodServis.PostResponse(fp);
                         if (response3.IsSuccessStatusCode)
                         {
                             HttpResponseMessage response4 = favouriteProizvodServis.GetActionResponse("ListaByFavouriteID", favouriteID.ToString());
                             if (response4.IsSuccessStatusCode)
                             {

                                 int broj = 0;
                                 broj = response4.Content.ReadAsAsync<List<FavouiriteProizvod>>().Result.Count;
                                 narudbaInfoLabel.Text = "Broj proizvoda u favourite albumu: " + broj;
                             }
                             else
                             {
                                 MessageDialog msg = new MessageDialog("Došlo je do greške4: " + response4.ReasonPhrase);
                                 await msg.ShowAsync();
                             }
                         }
                         else
                         {
                             MessageDialog msg = new MessageDialog("Došlo je do greške: " + response3.ReasonPhrase);
                             await msg.ShowAsync();
                         }
                     }
                     else
                     {
                         MessageDialog msg = new MessageDialog("Došlo je do greške: " + response6.ReasonPhrase);
                         await msg.ShowAsync();
                     }
                  }
                  else 
                  {
                      Favourite k = new Favourite();
                      k.Datum = DateTime.Now;
                      k.KupacID = Global.prijavljeniKupac.KupacID;
                   
                      HttpResponseMessage response2 = favouriteServis.PostResponse(k);
                      if (response2.IsSuccessStatusCode)
                      {

                          HttpResponseMessage response6 = favouriteServis.GetActionResponse("FavouriteByKupac1", Global.prijavljeniKupac.KupacID.ToString());

                          if (response6.IsSuccessStatusCode)
                          {
                              int favouriteID = response6.Content.ReadAsAsync<Favourite>().Result.FavouriteID;
                              FavouiriteProizvod fp = new FavouiriteProizvod();
                              fp.FavouriteID = favouriteID;
                              fp.ProizvodID = proizvod.ProizvodID;
                          
                              HttpResponseMessage response3 = favouriteProizvodServis.PostResponse(fp);
                              if (response3.IsSuccessStatusCode)
                              { //narudbaInfoLabel.Text = "Broj proizvoda u favourite albumu: " + 33;
                                  HttpResponseMessage response4 = favouriteProizvodServis.GetActionResponse("ListaByFavouriteID", favouriteID.ToString());


                                  if (response4.IsSuccessStatusCode)
                                  {
                                      int broj = response4.Content.ReadAsAsync<List<FavouiriteProizvod>>().Result.Count();
                                      narudbaInfoLabel.Text = "Broj proizvoda u favourite albumu: " + broj;
                                  }
                                  else
                                  {
                                      MessageDialog msg = new MessageDialog("Došlo je do greške: " + response4.ReasonPhrase);
                                      await msg.ShowAsync();
                                  }
                              }
                              else
                              {
                                  MessageDialog msg = new MessageDialog("Došlo je do greške33: " + response3.ReasonPhrase);
                                  await msg.ShowAsync();
                              }
                          }
                          else
                          {
                              MessageDialog msg = new MessageDialog("Došlo je do greške6: " + response6.ReasonPhrase);
                              await msg.ShowAsync();
                          }

                          
                      }
                    
                      else
                      {
                          MessageDialog msg = new MessageDialog("Došlo je do greškeG: " + response2.ReasonPhrase);
                          await msg.ShowAsync();
                      }

                  }
              }
                  else 
                  {
                      MessageDialog msg = new MessageDialog("Došlo je do greškeZZ: " + response.ReasonPhrase);
                    await msg.ShowAsync();
                  }
              



        }
        public void PrikaziZvjezdice()
        {
            if (Global.prijavljeniKupac == null)
                return;

                   HttpResponseMessage response = ocjeneServis.GetResponse();
                   if (response.IsSuccessStatusCode)
                   {
                       List<Ocjene> ocjene = response.Content.ReadAsAsync<List<Ocjene>>().Result;
                       if (ocjene.Where(x => x.ProizvodID == proizvod.ProizvodID && x.KupacID == Global.prijavljeniKupac.KupacID).FirstOrDefault().Ocjena == 3)
                       {

                           star1.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                           star1Full.Visibility = Windows.UI.Xaml.Visibility.Visible;

                           star2.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                           star2Full.Visibility = Windows.UI.Xaml.Visibility.Visible;

                           star3.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                           star3Full.Visibility = Windows.UI.Xaml.Visibility.Visible;

                       }
                       if (ocjene.Where(x => x.ProizvodID == proizvod.ProizvodID && x.KupacID == Global.prijavljeniKupac.KupacID).FirstOrDefault().Ocjena == 2)
                       {

                           star1.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                           star1Full.Visibility = Windows.UI.Xaml.Visibility.Visible;

                           star2.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                           star2Full.Visibility = Windows.UI.Xaml.Visibility.Visible;


                       }
                       if (ocjene.Where(x => x.ProizvodID == proizvod.ProizvodID && x.KupacID == Global.prijavljeniKupac.KupacID).FirstOrDefault().Ocjena == 1)
                       {

                           star1.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                           star1Full.Visibility = Windows.UI.Xaml.Visibility.Visible;



                       }

                       if (ocjene.Where(x => x.ProizvodID == proizvod.ProizvodID && x.KupacID == Global.prijavljeniKupac.KupacID).FirstOrDefault().Ocjena == 4)
                       {

                           star1.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                           star1Full.Visibility = Windows.UI.Xaml.Visibility.Visible;

                           star2.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                           star2Full.Visibility = Windows.UI.Xaml.Visibility.Visible;

                           star3.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                           star3Full.Visibility = Windows.UI.Xaml.Visibility.Visible;

                           star4.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                           star4Full.Visibility = Windows.UI.Xaml.Visibility.Visible;

                       }

                       if (ocjene.Where(x => x.ProizvodID == proizvod.ProizvodID && x.KupacID == Global.prijavljeniKupac.KupacID).FirstOrDefault().Ocjena == 5)
                       {

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

                       }

                   }
                   else return;
        
        }
     

        private void preporuceniProizvodiList_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            Frame.Navigate(typeof(Detalji), ((Proizvodi)e.ClickedItem).ProizvodID);
        }

        private void najprodavanijiProizvodiList_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frame.Navigate(typeof(Detalji), ((Proizvodi)e.ClickedItem).ProizvodID);
        }



        #region stars
        private async void star1_Click(object sender, RoutedEventArgs e)
        {
            if (Global.prijavljeniKupac== null)
                return;

            HttpResponseMessage response = ocjeneServis.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<Ocjene> ocjene = response.Content.ReadAsAsync<List<Ocjene>>().Result;
                if (ocjene.Where(x => x.ProizvodID == proizvod.ProizvodID && x.KupacID == Global.prijavljeniKupac.KupacID).Count()>0)
                {
                    MessageDialog msg = new MessageDialog("Već ste ocijenili ovaj porizvod");
                    await msg.ShowAsync();
                    return;
                }
            }

            star1.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            star1Full.Visibility = Windows.UI.Xaml.Visibility.Visible;

            proizvodiServis.GetActionResponse3("OcjenaProizvoda", proizvod.ProizvodID, Global.prijavljeniKupac.KupacID, "1");

        }

        private async void star2_Click(object sender, RoutedEventArgs e)
        {
            if (Global.prijavljeniKupac == null)
                return;

            HttpResponseMessage response = ocjeneServis.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<Ocjene> ocjene = response.Content.ReadAsAsync<List<Ocjene>>().Result;
                if (ocjene.Where(x => x.ProizvodID == proizvod.ProizvodID && x.KupacID == Global.prijavljeniKupac.KupacID).Count() > 0)
                {
                    MessageDialog msg = new MessageDialog("Već ste ocijenili ovaj porizvod");
                    await msg.ShowAsync();
                    return;
                }
            }

            star1.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            star1Full.Visibility = Windows.UI.Xaml.Visibility.Visible;

            star2.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            star2Full.Visibility = Windows.UI.Xaml.Visibility.Visible;

            ocjeneServis.GetActionResponse3("OcjenaProizvoda", proizvod.ProizvodID, Global.prijavljeniKupac.KupacID, "2");


        }

        private async void star3_Click(object sender, RoutedEventArgs e)
        {

            if (Global.prijavljeniKupac == null)
                return;

            HttpResponseMessage response = ocjeneServis.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<Ocjene> ocjene = response.Content.ReadAsAsync<List<Ocjene>>().Result;
                if (ocjene.Where(x => x.ProizvodID == proizvod.ProizvodID && x.KupacID == Global.prijavljeniKupac.KupacID).Count() > 0)
                {
                  
                    MessageDialog msg = new MessageDialog("Već ste ocijenili ovaj porizvod");
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

          ocjeneServis.GetActionResponse3("OcjenaProizvoda", proizvod.ProizvodID, Global.prijavljeniKupac.KupacID, "3");

        }

        private async void star4_Click(object sender, RoutedEventArgs e)
        {
            if (Global.prijavljeniKupac == null)
                return;

            HttpResponseMessage response = ocjeneServis.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<Ocjene> ocjene = response.Content.ReadAsAsync<List<Ocjene>>().Result;
                if (ocjene.Where(x => x.ProizvodID == proizvod.ProizvodID && x.KupacID == Global.prijavljeniKupac.KupacID).Count() > 0)
                {
                    MessageDialog msg = new MessageDialog("Već ste ocijenili ovaj porizvod");
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


         ocjeneServis.GetActionResponse3("OcjenaProizvoda", proizvod.ProizvodID, Global.prijavljeniKupac.KupacID, "4");
   
        }

        private async  void star5_Click(object sender, RoutedEventArgs e)
        {
            if (Global.prijavljeniKupac == null)
                return;

            HttpResponseMessage response = ocjeneServis.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<Ocjene> ocjene = response.Content.ReadAsAsync<List<Ocjene>>().Result;
                if (ocjene.Where(x => x.ProizvodID == proizvod.ProizvodID && x.KupacID == Global.prijavljeniKupac.KupacID).Count() > 0)
                {
                    MessageDialog msg = new MessageDialog("Već ste ocijenili ovaj porizvod");
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


            

            ocjeneServis.GetActionResponse3("OcjenaProizvoda", proizvod.ProizvodID, Global.prijavljeniKupac.KupacID, "5");
   
        }

        #endregion

       

        private void kolicinaInput_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text.Contains('.'))
            {
                txt.Text = txt.Text.Replace(".", "");
                txt.SelectionStart = txt.Text.Length;
            }
        }
    }
}
