using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Flota
{
    public partial class zarzadzajBazaDanych : Form
    {
        String login;
        public zarzadzajBazaDanych()
        {
            InitializeComponent();
        }

        private void powrotMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.user(login);
            menu.Show();
        }
        public void user(String user)
        {
            login = user;
            //zalogowany.Text = login;
        }

        private void zarzadzajBazaDanych_Load(object sender, EventArgs e)
        {
            zalogowany.Text = login;
        }

        private void kopiaBazy_Click(object sender, EventArgs e)
        {
            //mysqldump -u root -p flota > C:\kopia_floty.sql
            string fileName = "pobierz.bat";
            string  fullPath = "C:/Users/Piotrek/Desktop/Flota/bat/pobierz.bat";
            string path = Path.Combine(@"..bat\", fileName);
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = fullPath;
            ps.UseShellExecute = true;
            ps.Verb = "runas";
            Process.Start(ps);
            MessageBox.Show("Pobrano backup");
        }

        private void helpZarzBD_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file://C:/Users/Piotrek/Desktop/Flota/manual/manual.chm");
        }
    }
}
