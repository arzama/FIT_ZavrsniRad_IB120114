using PEPmodnaKompanija_PCL.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media.Imaging;

namespace PEPmodnaKompanija_Mobile.Lookbooks
{
    public class ImageConverter: IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            MemoryStream ms = new MemoryStream(((Modeli)value).Slika);

            BitmapImage image = new BitmapImage();

            image.SetSourceAsync(ms.AsRandomAccessStream());

            return image;
        }
        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return null;
        }
    }

 
}
