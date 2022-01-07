using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Flota
{
    public partial class Menu : Form
    {
        bazaDanych wybor_pojazdu = new bazaDanych();
        MySqlConnection czytaj = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        String login;
        public Menu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Eksploatacja us = new Eksploatacja();
            us.user(login);
            us.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            zarzadajUzytkownikiem zu = new zarzadajUzytkownikiem();
            zu.user(login);
            zu.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void zarzadzajPojazdem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Zarządzaj_pojazdem zp = new Zarządzaj_pojazdem();
            zp.user(login);
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
            zbd.user(login);
            zbd.Show();
        }

        private void czynnosciSerwisowe_Click(object sender, EventArgs e)
        {
            this.Hide();
            Serwis sr = new Serwis();
            sr.user(login);
            sr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ustawienia us = new Ustawienia();
            us.user(login);
            us.Show();
        }

        private void wypozyczenia_Click(object sender, EventArgs e)
        {
            this.Hide();
            Wypozyczenia wy = new Wypozyczenia();
            wy.user(login);
            wy.Show();
        }
        public void wyswietlenieUzytkowanika(string loginw)
        {
            login = loginw;
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            //MessageBox.Show();
            zalogowany.Text = login;
        }
        public void user(String user)
        {
            login = user;
        }
    }
}
