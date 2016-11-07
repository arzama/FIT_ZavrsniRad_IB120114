using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEPmodnaKompanija_UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm login= new LoginForm();
            login.ShowDialog();
            if (login.DialogResult == DialogResult.OK && Global.prijavljeniKorisnik.UlogaID == 4)
                Application.Run(new ModulDizajner.MainDizajneri());
            else if(login.DialogResult == DialogResult.OK && Global.prijavljeniKorisnik.UlogaID == 1)
                Application.Run(new MainForm());
                

        }
    }
}
