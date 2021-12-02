using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flota
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            zarzadajUzytkownikiem zu = new zarzadajUzytkownikiem();
            zu.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void zarzadzajPojazdem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Zarządzaj_pojazdem zp = new Zarządzaj_pojazdem();
            zp.Show();
        }

        private void wyloguj_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPanel lp = new LoginPanel();
            lp.Show();
        }

        private void zarzadzajBazaDanych_Click(object sender, EventArgs e)
        {
            this.Hide();
            zarzadzajBazaDanych zbd = new zarzadzajBazaDanych();
            zbd.Show();
        }
    }
}
