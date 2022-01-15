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
    public partial class Wypozyczenia : Form
    {
        MySqlConnection connect = null;
        String login;
        bazaDanych wybor_pojazdu = new bazaDanych();
        MySqlConnection czytaj = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlDataAdapter pojazdy;
        MySqlDataAdapter uzytkownik;
        DataTable tbpoj = new DataTable();
        DataTable tbuz = new DataTable();
        public Wypozyczenia()
        {
            InitializeComponent();
        }

        private void Pojazd_Click(object sender, EventArgs e)
        {

        }

        private void powrotMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.user(login);
            menu.Show();
        }

        private void Wypozyczenia_Load(object sender, EventArgs e)
        {
            zalogowany.Text = login;
            pojazdy = new MySqlDataAdapter("SELECT * FROM flota.pojazd", czytaj);
            pojazdy.Fill(tbpoj);
            textPojazd.DataSource = tbpoj;
            textPojazd.DisplayMember = "nr_rejestracyjny";
            textPojazd.ValueMember = "id_pojazdu";
            textPojazd.Text = "-- Wybierz --";
            uzytkownik = new MySqlDataAdapter("SELECT login FROM flota.pracownik WHERE login='"+login+"'", czytaj);
            uzytkownik.Fill(tbuz);
            textWypozyczajacy.DataSource = tbuz;
            textWypozyczajacy.DisplayMember = "login";

        }
        public void user(String user)
        {
            login = user;
        }

        private void potwierdz_Click(object sender, EventArgs e)
        {

            bazaDanych wypozyczenia = new bazaDanych();
            MySqlConnection nru = null;
            nru = wypozyczenia.connect();
            MySqlCommand commandNru = new MySqlCommand("SELECT id_pracownika FROM pracownik WHERE login='" + login + "'", nru);
            MySqlDataReader readernru;
            readernru = commandNru.ExecuteReader();
            readernru.Read();
            var nrusera = readernru.GetString(0);
            MySqlConnection nrrej = null;
            nrrej = wypozyczenia.connect();
            MySqlCommand commandRej = new MySqlCommand("SELECT id_pojazdu FROM pojazd WHERE nr_rejestracyjny='"+textPojazd.Text+"'", nrrej);
            MySqlDataReader readerrej;
            readerrej= commandRej.ExecuteReader();
            readerrej.Read();
            var poj = readerrej.GetString(0);
            MySqlConnection connect = null;
            connect = wypozyczenia.connect();
            String query = "SELECT * FROM wypozyczenia WHERE((data_od >= '"+dataOd.Value.ToString("yyyy-MM-dd") + "' AND data_od <= '"+dataDo.Value.ToString("yyyy-MM-dd") + "') OR(data_do >= '"+dataOd.Value.ToString("yyyy-MM-dd") + "' AND data_do <= '"+dataDo.Value.ToString("yyyy-MM-dd") + "') OR(data_od <= '"+dataOd.Value.ToString("yyyy-MM-dd") + "' AND data_do >= '"+dataDo.Value.ToString("yyyy-MM-dd") + "')) AND id_pojazdu ="+ poj;
            MySqlCommand commandDatabase = new MySqlCommand(query, connect);
            MySqlDataReader reader;
            reader = commandDatabase.ExecuteReader();
            if (!reader.HasRows)
            {
                bazaDanych term = new bazaDanych();
                MySqlConnection termin = null;
                termin = term.connect();
                MySqlCommand changePassword = new MySqlCommand("INSERT INTO wypozyczenia (id_pojazdu, id_pracownika, data_od, data_do, powod) VALUES ("+poj+","+nrusera+",'"+ dataOd.Value.ToString("yyyy-MM-dd") + "','"+ dataDo.Value.ToString("yyyy-MM-dd") + "', '"+ textPowod.Text+"')", termin);
                changePassword.ExecuteReader();
                MessageBox.Show("Wypożyczenie zostało dodane");
                textPojazd.Text = "-- Wybierz --";
                textPowod.Text = "";
            }
            else
            {
                MessageBox.Show("Pojazd w tym terminie jest wypożyczny");
            }
            //MessageBox.Show(dataDo.Value.ToString("yyyy-MM-dd"));
        }

        private void listaWyp_Click(object sender, EventArgs e)
        {
            this.Hide();
            listaWypozyczen lw = new listaWypozyczen();
            lw.user(login);
            lw.Show();
        }
    }
}
