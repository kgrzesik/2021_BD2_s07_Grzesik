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
    public partial class Eksploatacja : Form
    {
        MySqlConnection connect = null;
        String login;
        bazaDanych serwis_db = new bazaDanych();
        MySqlConnection czytaj = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlDataAdapter pojazdy;
        MySqlDataAdapter czynnosc;
        DataTable tbpoj = new DataTable();
        DataTable tbcz = new DataTable();
        public Eksploatacja()
        {
            InitializeComponent();
        }

        private void Eksploatacja_Load(object sender, EventArgs e)
        {
            zalogowany.Text = login;
            pojazdy = new MySqlDataAdapter("SELECT * FROM flota.pojazd", czytaj);
            pojazdy.Fill(tbpoj);
            textPojazd.DataSource = tbpoj;
            textPojazd.DisplayMember = "nr_rejestracyjny";
            textPojazd.ValueMember = "id_pojazdu";

            czynnosc = new MySqlDataAdapter("SELECT * FROM flota.czynnosci", czytaj);
            czynnosc.Fill(tbcz);
            textCzynnosc.DataSource = tbcz;
            textCzynnosc.DisplayMember = "nazwa_czynnosci";
            textCzynnosc.ValueMember = "id_czynnosci";
        }

        private void powrotButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu mn = new Menu();
            mn.user(login);
            mn.Show();
        }
        public void user(String user)
        {
            login = user;
            //zalogowany.Text = login;
        }

        private void historia_Click(object sender, EventArgs e)
        {
            this.Hide();
            historiaEksploatacja he = new historiaEksploatacja();
            he.user(login);
            he.Show();
        }

        private void zapiszButton_Click(object sender, EventArgs e)
        {

            string data = (string)dataWyk.Value.ToString("yyyy-MM-dd");
            string koszt = (string)kosztText.Text;
            if (data != "" &&  koszt != "")
            {
                bazaDanych Exploa = new bazaDanych();
            MySqlConnection nrrej = null;
            nrrej = Exploa.connect();
            MySqlCommand commandRej = new MySqlCommand("SELECT id_pojazdu FROM pojazd WHERE nr_rejestracyjny='" + textPojazd.Text + "'", nrrej);
            MySqlDataReader readerrej;
            readerrej = commandRej.ExecuteReader();
            readerrej.Read();
            var poj = readerrej.GetString(0);

            MySqlConnection idczynnosci = null;
            idczynnosci = Exploa.connect();
            MySqlCommand commandidczynnosci = new MySqlCommand("SELECT id_czynnosci FROM flota.czynnosci WHERE nazwa_czynnosci='" + textCzynnosc.Text + "'", idczynnosci);
            MySqlDataReader readeridczynnosci;
            readeridczynnosci = commandidczynnosci.ExecuteReader();
            readeridczynnosci.Read();
            var czyn = readeridczynnosci.GetString(0);

            MySqlConnection nru = null;
            nru = Exploa.connect();
            MySqlCommand commandNru = new MySqlCommand("SELECT id_pracownika FROM pracownik WHERE login='" + login + "'", nru);
            MySqlDataReader readernru;
            readernru = commandNru.ExecuteReader();
            readernru.Read();
            var nrusera = readernru.GetString(0);

            bazaDanych exp = new bazaDanych();
            MySqlConnection exploatacja = null;
            exploatacja = exp.connect();
            MySqlCommand changePassword = new MySqlCommand("INSERT INTO flota.eksploatacja (id_pojazdu, nazwa_czynnsci, koszt, id_pracownika, data_wykonania) VALUES ('" + poj + "','" + textCzynnosc.Text + "','" + kosztText.Text + "','" + nrusera + "','" + dataWyk.Value.ToString("yyyy-MM-dd") + "')", exploatacja);
            changePassword.ExecuteReader();
            MessageBox.Show("Dodano exploatacje");

            }
            else
            {
                string message = "Należy uzupełnić wszystkie pola";
                string caption = "Błąd";
                DialogResult result;
                result = MessageBox.Show(message, caption);

            }
        }
    }
}
