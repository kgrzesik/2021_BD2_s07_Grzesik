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
    public partial class WyborUzytkownika : Form
    {
        String login;
        listaUzytkownikow lu = new listaUzytkownikow();
        public WyborUzytkownika()
        {
            InitializeComponent();
            lu.wyswietl(listaUsr);
        }

        private void powrotZarzadzaniePojazdem_Click(object sender, EventArgs e)
        {
            this.Hide();
            zarzadajUzytkownikiem zu = new zarzadajUzytkownikiem();
            zu.user(login);
            zu.Show();

        }

        private void wybierzPojazd_Click(object sender, EventArgs e)
        {
            string listau = (string)listaUsr.Text;
            if (listau != "")
            {
                this.Hide();
                EdycjaUzytkownika eu = new EdycjaUzytkownika();
                bazaDanych wybUsr = new bazaDanych();
                MySqlConnection connect = null;
                connect = wybUsr.connect();
                MySqlDataAdapter adpterUsr = new MySqlDataAdapter("SELECT * FROM pracownik WHERE login='" + listaUsr.SelectedItem.ToString() + "'", connect);
                DataTable tbUsr = new DataTable();
                adpterUsr.Fill(tbUsr);
                eu.usr(tbUsr);
                eu.user(login);
                eu.Show();
            }
            else
            {
                string message = "Nie wybrano użytkownika do edycji!";
                string caption = "Błąd";
                DialogResult result;
                result = MessageBox.Show(message, caption);
            }
        }

        private void WyborUzytkownika_Load(object sender, EventArgs e)
        {
            zalogowany.Text = login;
        }
        public void user(String user)
        {
            login = user;
            //zalogowany.Text = login;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bazaDanych usun = new bazaDanych();
            MySqlConnection connectus = null;
            connectus = usun.connect();
            String query = "DELETE FROM pracownik WHERE login='" + listaUsr.SelectedItem.ToString() + "'";
            MySqlCommand commandDatabase = new MySqlCommand(query, connectus);
            commandDatabase.ExecuteReader();
            MessageBox.Show("Użytkownik został usuniety");
            this.Hide();
            WyborUzytkownika wu = new WyborUzytkownika();
            wu.user(login);
            wu.Show();
        }

        private void helpWybUzyt_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file://C:/Users/Piotrek/Desktop/Flota/manual/manual.chm");
        }
    }
}
