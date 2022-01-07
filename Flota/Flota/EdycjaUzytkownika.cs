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
    public partial class EdycjaUzytkownika : Form
    {
        String login;
        MySqlConnection connect = null;
        bazaDanych edytuj_uzytkownika = new bazaDanych();
        DataTable tbUsr = new DataTable();
        public EdycjaUzytkownika()
        {
            InitializeComponent();
        }

        private void edytuj_uzytkow_Click(object sender, EventArgs e)
        {
            try
            {
                string imie = (string)txtImie.Text;
                string nazwisko = (string)txtNazwisko.Text;
                string pesel = (string)txtPesel.Text;
                string telefon = (string)txtTel.Text;
                string stanowisko = (string)txtStanowisko.Text;
                string adres = (string)txtAdres.Text;
                string miejscowosc = (string)txtMiejscowosc.Text;
                
                if (imie != "" && nazwisko != "" && pesel != "" && telefon != "" && stanowisko != "")
                {
                    connect = edytuj_uzytkownika.connect();
                    //pobranie id stanowiska
                    bazaDanych pobieraniedanych = new bazaDanych();
                    MySqlConnection pobieranie = null;
                    pobieranie = pobieraniedanych.connect();
                    MySqlCommand commandstan = new MySqlCommand("SELECT id_stanowiska FROM stanowisko WHERE nazwa='" + stanowisko + "'", pobieranie);
                    MySqlDataReader readerstan;
                    readerstan = commandstan.ExecuteReader();
                    string stan = "";
                    if (readerstan.Read())
                    {
                        stan = readerstan.GetString(0);
                    }
                    readerstan.Close();
                    //dodac dodawanie id_stanowiska i id_zamieszkania
                    string query = "UPDATE pracownik SET imie = '" + imie + "', nazwisko = '" + nazwisko + "', pesel = '" + pesel + "', nr_tel = '" + telefon + "', id_stanowiska = '" + stan + "', adres = '" + adres + "', miejscowosc = '" + miejscowosc + "' WHERE id_pracownika = '" + tbUsr.Rows[0][0].ToString() + "'";
                    MySqlCommand commandDatabase = new MySqlCommand(query, connect);
                    commandDatabase.ExecuteNonQuery();

                    string message = "Zmodyfikowano uzytkownika";
                    string caption = "Sukces";
                    DialogResult result;
                    result = MessageBox.Show(message, caption);

                    connect.Close();
                }
                else
                {
                    string message = "Należy uzupełnić wszystkie pola";
                    string caption = "Błąd";
                    DialogResult result;
                    result = MessageBox.Show(message, caption);

                }

            }
            catch (MySqlException sqlEX)
            {
                MessageBox.Show(sqlEX.ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            WyborUzytkownika wu = new WyborUzytkownika();
            wu.user(login);
            wu.Show();
        }

        private void EdycjaUzytkownika_Load(object sender, EventArgs e)
        {
            zalogowany.Text = login;
            txtImie.Text = tbUsr.Rows[0][1].ToString();
            txtNazwisko.Text = tbUsr.Rows[0][2].ToString();
            txtTel.Text = tbUsr.Rows[0][3].ToString();
            txtPesel.Text = tbUsr.Rows[0][4].ToString();

            bazaDanych pobieraniedanych = new bazaDanych();
            MySqlConnection pobieranie = null;
            pobieranie = pobieraniedanych.connect();
            MySqlDataAdapter pobstaowisko = new MySqlDataAdapter("SELECT * FROM stanowisko", pobieranie);
            DataTable daneStanowiska = new DataTable();
            pobstaowisko.Fill(daneStanowiska);
            txtStanowisko.DataSource = daneStanowiska;
            txtStanowisko.DisplayMember = "nazwa";
            txtStanowisko.ValueMember = "id_stanowiska";

            MySqlCommand commandstan = new MySqlCommand("SELECT nazwa FROM stanowisko WHERE id_stanowiska='" + tbUsr.Rows[0][5] + "'", pobieranie);
            MySqlDataReader readerstan;
            readerstan = commandstan.ExecuteReader();
            string nstan = "";
            if (readerstan.Read())
            {
                nstan = readerstan.GetString(0);
            }
            readerstan.Close();
            txtStanowisko.Text = nstan;
            txtAdres.Text = tbUsr.Rows[0][6].ToString();
            txtMiejscowosc.Text = tbUsr.Rows[0][9].ToString();
        }
        public void user(String user)
        {
            login = user;
            //zalogowany.Text = login;
        }
        public void usr(DataTable usr)
        {
            tbUsr = usr;
        }
    }
    
}
