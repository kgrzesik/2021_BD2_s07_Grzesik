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
    public partial class Serwis : Form
    {
        MySqlConnection connect = null;
        String login;
        bazaDanych serwis_db = new bazaDanych();
        MySqlConnection czytaj = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlDataAdapter pojazdy;
        MySqlDataAdapter usluga;
        DataTable tbpoj = new DataTable();
        DataTable tbus = new DataTable();
        public Serwis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu mn = new Menu();
            mn.user(login);
            mn.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void user(String user)
        {
            login = user;
            //zalogowany.Text = login;
        }

        private void Serwis_Load(object sender, EventArgs e)
        {
            zalogowany.Text = login;
            bazaDanych wypozyczenia = new bazaDanych();
            MySqlConnection nru = null;
            nru = wypozyczenia.connect();
            MySqlCommand commandNru = new MySqlCommand("SELECT id_pracownika FROM pracownik WHERE login='" + login + "'", nru);
            MySqlDataReader readernru;
            readernru = commandNru.ExecuteReader();
            readernru.Read();
            var nrusera = readernru.GetString(0);
            readernru.Close();
            pojazdy = new MySqlDataAdapter("SELECT poj.id_pojazdu, poj.nr_rejestracyjny FROM pracownik AS prac JOIN opiekun AS o ON prac.id_pracownika=o.id_pracownika JOIN pojazd AS poj ON o.id_pojazdu = poj.id_pojazdu WHERE o.id_pracownika="+ nrusera + ";", nru);
            pojazdy.Fill(tbpoj);
            textPojazd.DataSource = tbpoj;
            textPojazd.DisplayMember = "nr_rejestracyjny";
            textPojazd.ValueMember = "id_pojazdu";
            textPojazd.Text = "--Wybierz--";

            usluga = new MySqlDataAdapter("SELECT * FROM flota.usluga", czytaj);
            usluga.Fill(tbus);
            textUsluga.DataSource = tbus;
            textUsluga.DisplayMember = "nazwa_uslugi";
            textUsluga.ValueMember = "id_uslugi";
            textUsluga.Text = "--Wybierz--";
        }

        private void historia_Click(object sender, EventArgs e)
        {
            this.Hide();
            historiaSerwis hs = new historiaSerwis();
            hs.user(login);
            hs.Show();
        }

        private void dodajserwis_Click(object sender, EventArgs e)
        {
            string data = (string)dataOstPrzeg.Value.ToString("yyyy-MM-dd");
            string nazwa = (string)serwisName.Text;
            string koszt = (string)kosztText.Text;
            if (data != "" && nazwa != "" && koszt != "")
            {
                bazaDanych serwis = new bazaDanych();
                MySqlConnection nrrej = null;
                nrrej = serwis.connect();
                MySqlCommand commandRej = new MySqlCommand("SELECT id_pojazdu FROM pojazd WHERE nr_rejestracyjny='" + textPojazd.Text + "'", nrrej);
                MySqlDataReader readerrej;
                readerrej = commandRej.ExecuteReader();
                readerrej.Read();
                var poj = readerrej.GetString(0);

                MySqlConnection iduslugi = null;
                iduslugi = serwis.connect();
                MySqlCommand commandiduslugi = new MySqlCommand("SELECT id_uslugi FROM flota.usluga WHERE nazwa_uslugi='" + textUsluga.Text + "'", iduslugi);
                MySqlDataReader readeriduslugi;
                readeriduslugi = commandiduslugi.ExecuteReader();
                readeriduslugi.Read();
                var usluga = readeriduslugi.GetString(0);

                bazaDanych serw = new bazaDanych();
                MySqlConnection serwi = null;
                serwi = serw.connect();
                MySqlCommand changePassword = new MySqlCommand("INSERT INTO flota.serwis (id_pojazdu, data_ostatniego_przegladu, nazwa_serwisu, id_uslugi, koszt) VALUES ('" + poj + "','" + dataOstPrzeg.Value.ToString("yyyy-MM-dd") + "','" + serwisName.Text + "','" + usluga + "','" + kosztText.Text + "')", serwi);
                changePassword.ExecuteReader();
                MessageBox.Show("Dodano serwis");
                textPojazd.Text = "--Wybierz--";
                textUsluga.Text = "--Wybierz--";
                serwisName.Text = "";
                kosztText.Text = "";
            }
            else
            {
                string message = "Należy uzupełnić wszystkie pola";
                string caption = "Błąd";
                DialogResult result;
                result = MessageBox.Show(message, caption);

            }
        }

        private void pomoc_wyp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file://C:/Users/Piotrek/Desktop/Flota/manual/manual.chm");
        }
    }
}
