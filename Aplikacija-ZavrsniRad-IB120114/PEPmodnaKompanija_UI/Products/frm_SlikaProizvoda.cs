using PEPmodnaKompanija_UI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEPmodnaKompanija_UI.Products
{
    public partial class frm_SlikaProizvoda : Form
    {
        public byte[] slika { get; set; }
        public frm_SlikaProizvoda(byte[] slika = null)
        {
            InitializeComponent();
            if (slika != null)
                this.slika = slika;
        }
      

        private void frm_SlikaProizvoda_Load(object sender, EventArgs e)
        {
            int width = Convert.ToInt32(ConfigurationManager.AppSettings["resizeWidthProizvoda"]);
            int height = Convert.ToInt32(ConfigurationManager.AppSettings["resizeHeightProizvoda"]);
            MemoryStream ms = new MemoryStream(slika);
            Image GotovaSlika = Image.FromStream(ms);
            Image resizedImage = UIHelper.ResizeImage(GotovaSlika, new Size(width, height));



            pictureBox1.Image = resizedImage;
        }
    }
}
