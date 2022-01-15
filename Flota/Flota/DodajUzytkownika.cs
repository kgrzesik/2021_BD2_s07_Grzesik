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
    public partial class DodajUzytkownika : Form
    {
        MySqlConnection connect = null;
        bazaDanych dodaj_uzytkownika = new bazaDanych();
        String loginw;
        public DodajUzytkownika()
        {
            InitializeComponent();
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
                try
                {
                    string imie = (string)txtImie.Text;
                    string nazwisko = (string)txtNazwisko.Text;
                    string pesel = (string)txtTel.Text;
                    string telefon = (string)txtPesel.Text;
                    string stanowisko = (string)txtStanowisko.Text;
                    string adres = (string)txtAdres.Text;
                string miejscowosc = (string)txtMiejscowosc.Text;
                    string login = (string)txtLogin.Text;
                    string haslo = (string)txtHaslo.Text;
                    string haslo_p = (string)txtHaslo2.Text;
                if (imie != "" && nazwisko != "" && pesel != "" && telefon != "" && stanowisko != "" && login != "" && haslo != "" && haslo_p !="" && haslo==haslo_p)
                   {
                        connect = dodaj_uzytkownika.connect();
                    //Pobrnie id stanowiska
                    MySqlConnection constan = null;
                    constan = dodaj_uzytkownika.connect();
                    MySqlCommand commandstan = new MySqlCommand("SELECT id_stanowiska FROM stanowisko WHERE nazwa='" + txtStanowisko.Text + "'", constan);
                    MySqlDataReader readerstan;
                    readerstan = commandstan.ExecuteReader();
                    readerstan.Read();
                    var idStan = readerstan.GetString(0);

                    //dodac dodawanie id_stanowiska i id_zamieszkania
                    string query = "INSERT INTO pracownik (imie, nazwisko, nr_tel,pesel,id_stanowiska,adres,miejscowosc,login,haslo) VALUES ('" + imie + "','" + nazwisko + "','" + telefon + "','" + pesel + "','" + idStan + "','" + adres + "','" + miejscowosc + "','" + login + "','" + haslo + "');";
                    MySqlCommand commandDatabase = new MySqlCommand(query, connect);
                        commandDatabase.ExecuteNonQuery();

                        string message = "Dodano uzytkownika";
                        string caption = "Sukces";
                        DialogResult result;
                        result = MessageBox.Show(message, caption);
                        txtStanowisko.Text = "--Wybierz--";
                        txtImie.Text = "";
                        txtNazwisko.Text = "";
                        txtTel.Text = "";
                        txtPesel.Text = "";
                        txtAdres.Text = "";
                        txtMiejscowosc.Text = "";
                        txtLogin.Text = "";
                        txtHaslo.Text = "";
                        txtHaslo2.Text = "";
                        connect.Close();
                  }
                    else
                    {
                        string message = "Należy uzupełnić wszystkie pola / wpisac poprawnie haslo";
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
            zarzadajUzytkownikiem back = new zarzadajUzytkownikiem();
            back.user(loginw);
            back.Show();
        }

        private void DodajUzytkownika_Load(object sender, EventArgs e)
        {
            zalogowany.Text = loginw;
            bazaDanych pobieraniedanych = new bazaDanych();
            MySqlConnection pobieranie = null;
            pobieranie = pobieraniedanych.connect();
            MySqlDataAdapter pobstaowisko = new MySqlDataAdapter("SELECT * FROM stanowisko", pobieranie);
            DataTable daneStanowiska = new DataTable();
            pobstaowisko.Fill(daneStanowiska);
            txtStanowisko.DataSource = daneStanowiska;
            txtStanowisko.DisplayMember = "nazwa";
            txtStanowisko.ValueMember = "id_stanowiska";
            txtStanowisko.Text = "--Wybierz--";
        }
        public void user(String user)
        {
            loginw = user;
            //zalogowany.Text = login;
        }
    }
}
