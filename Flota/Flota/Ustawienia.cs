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
using System.Data;
using System.Windows.Forms;


namespace Flota
{
    public partial class Ustawienia : Form
    {
        String login;
        public Ustawienia()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void powrotZarzadzajPojazdem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu mn = new Menu();
            mn.user(login);
            mn.Show();
        }

        private void Ustawienia_Load(object sender, EventArgs e)
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
            bazaDanych ustawienia = new bazaDanych();
            MySqlConnection connect = null;
            connect = ustawienia.connect();
            String query = "SELECT * FROM pracownik WHERE login='" + login + "' AND haslo='" + oldPassword.Text + "'";
            MySqlCommand commandDatabase = new MySqlCommand(query, connect);
            MySqlDataReader reader;
            reader = commandDatabase.ExecuteReader();
            if (reader.HasRows)
            {
                if (newPassword.Text == newPasword2.Text)
                {
                    if (oldPassword.Text == newPassword.Text)
                    {
                        MessageBox.Show("Stare i nowe hasło jest to samo");
                    }
                    else
                    {
                        bazaDanych pass = new bazaDanych();
                        MySqlConnection passcon = null;
                        passcon = pass.connect();
                        MySqlCommand changePassword = new MySqlCommand("UPDATE pracownik SET haslo = " + newPassword.Text + " WHERE login = '" + login + "'", passcon);
                        changePassword.ExecuteReader();
                        MessageBox.Show("Hasło zostało zmienione");
                    }
                }
                else
                {
                    MessageBox.Show("Hasła nie są takie same");
                }
            }
            else
            {
                MessageBox.Show("Błędny stare hasło");
            }
        }
    }
}
