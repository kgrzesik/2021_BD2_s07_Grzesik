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
            Zarzadzaj_pojazdem zp = new Zarzadzaj_pojazdem();
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
            zalogowany.Text = login;
            bazaDanych pobieraniedanych = new bazaDanych();
            MySqlConnection pobieranie = null;
            pobieranie = pobieraniedanych.connect();
            MySqlCommand commmandStanowisko = new MySqlCommand("SELECT id_stanowiska FROM pracownik WHERE login='" + login + "'", pobieranie);
            MySqlDataReader readStanowisko;
            readStanowisko = commmandStanowisko.ExecuteReader();
            string stanowiskoZalogowanego = "";
            if (readStanowisko.Read())
            {
                stanowiskoZalogowanego = readStanowisko.GetString(0);
            }

            readStanowisko.Close();
            if (Int64.Parse(stanowiskoZalogowanego) == 2) //flotmistrz
            {
                zarzadzajBazaDanych.Enabled = false;
                zarzadzajUzytkownikiem.Enabled = false;
                czynnosciEksploatacyjne.Enabled = false;
                czynnosciSerwisowe.Enabled = false;
                wypozyczenia.Enabled = false;
            }
            if (Int64.Parse(stanowiskoZalogowanego) == 3) //pracownik
            {
                zarzadzajBazaDanych.Enabled = false;
                zarzadzajUzytkownikiem.Enabled = false;
                zarzadzajPojazdem.Enabled = false;
                czynnosciSerwisowe.Enabled = false;
            }
            if (Int64.Parse(stanowiskoZalogowanego) == 4) //opiekun
            {
                zarzadzajBazaDanych.Enabled = false;
                zarzadzajUzytkownikiem.Enabled = false;
                zarzadzajPojazdem.Enabled = false;
            }
            if (Int64.Parse(stanowiskoZalogowanego) == 5) //opiekun
            {
                zarzadzajPojazdem.Enabled = false;
                czynnosciSerwisowe.Enabled = false;
                czynnosciEksploatacyjne.Enabled = false;
                wypozyczenia.Enabled = false;
            }
        }
        public void user(String user)
        {
            login = user;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void helpmenu_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file://C:/Users/Piotrek/Desktop/Flota/manual/manual.chm");
        }
    }
}
