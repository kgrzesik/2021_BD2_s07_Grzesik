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
    public partial class Wybor_Pojazdu : Form
    {

        listaPojazdow lp = new listaPojazdow();
        String login;
        MySqlDataAdapter pojazd;
        MySqlConnection connect = null;
        bazaDanych wybor_pojazdu = new bazaDanych();
        MySqlConnection czytaj = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        DataTable tbpoj = new DataTable();
        public Wybor_Pojazdu()
        {
            InitializeComponent();
            lp.wyswietl(listaPoj);
        }
        private void listaPojazdow_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void powrotZarzadzaniePojazdem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Zarządzaj_pojazdem zp = new Zarządzaj_pojazdem();
            zp.user(login);
            zp.Show();
        }

        private void Wybor_Pojazdu_Load(object sender, EventArgs e)
        {
            zalogowany.Text = login;
        }
        public void user(String user)
        {
            login = user;
            //zalogowany.Text = login;
        }
        private void wybierzPojazd_Click(object sender, EventArgs e)
        {

            string listap = (string)listaPoj.Text;
            if (listap != "")
            {
                this.Hide();
                EdycjaPojazdu ep = new EdycjaPojazdu();
                ep.user(login);
                pojazd = new MySqlDataAdapter("SELECT * FROM flota.pojazd WHERE nr_rejestracyjny='" + listaPoj.SelectedItem.ToString() + "'", czytaj);
                pojazd.Fill(tbpoj);
                ep.poj(tbpoj);
                ep.Show();
            }
            else
            {
                string message = "Nie wybrano pojazdu do edycji!";
                string caption = "Błąd";
                DialogResult result;
                result = MessageBox.Show(message, caption);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bazaDanych usun = new bazaDanych();
            MySqlConnection connectus = null;
            connectus = usun.connect();
            String query = "DELETE FROM pojazd WHERE nr_rejestracyjny='"+listaPoj.SelectedItem.ToString()+"'";
            MySqlCommand commandDatabase = new MySqlCommand(query, connectus);
            commandDatabase.ExecuteReader();
            MessageBox.Show("Pojazd został usuniety");
            this.Hide();
            Wybor_Pojazdu wp = new Wybor_Pojazdu();
            wp.user(login);
            wp.Show();
        }
    }
}
