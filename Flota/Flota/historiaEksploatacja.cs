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
    public partial class historiaEksploatacja : Form
    {
        String login;
        public historiaEksploatacja()
        {
            InitializeComponent();
        }

        private void powrot_Click(object sender, EventArgs e)
        {
            this.Hide();
            Eksploatacja us = new Eksploatacja();
            us.user(login);
            us.Show();
        }

        private void historiaEksploatacja_Load(object sender, EventArgs e)
        {
            zalogowany.Text = login;
        }
        public void user(String user)
        {
            login = user;
            //zalogowany.Text = login;
        }

        private void listaEksplo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Wyswietl_Click(object sender, EventArgs e)
        {
            bazaDanych wypozyczenia = new bazaDanych();

            MySqlConnection connect = null;
            connect = wypozyczenia.connect();
            String query = "SELECT prac.login AS 'Nazwa użytkownika', poj.nr_rejestracyjny AS 'Numer rejestracyjny', e.nazwa_czynnsci AS 'Czynność eksploatacyjna', e.data_wykonania AS 'Data wykonania', e.koszt AS 'Koszt eksploatacji' FROM pojazd AS poj  JOIN eksploatacja AS e ON poj.id_pojazdu = e.id_pojazdu  JOIN pracownik AS prac ON e.id_pracownika = prac.id_pracownika WHERE e.data_wykonania >= '" + dataOd.Value.ToString("yyyy-MM-dd") + "' AND e.data_wykonania <= '" + dataDo.Value.ToString("yyyy-MM-dd") + "';";
            MySqlDataAdapter aEksplo = new MySqlDataAdapter(query, connect);
            //MySqlCommand commandDatabase = new MySqlCommand(query, connect);
            //MySqlDataReader reader;
            DataTable tbEksplo = new DataTable();
            aEksplo.Fill(tbEksplo);
            listaEksplo.DataSource = tbEksplo;
        }
    }
}
