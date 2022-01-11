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
    public partial class historiaSerwis : Form
    {
        String login;
        public historiaSerwis()
        {
            InitializeComponent();
        }

        private void historiaSerwis_Load(object sender, EventArgs e)
        {
            zalogowany.Text = login;
        }

        private void powrot_Click(object sender, EventArgs e)
        {
            this.Hide();
            Serwis sr = new Serwis();
            sr.user(login);
            sr.Show();
        }
        public void user(String user)
        {
            login = user;
            //zalogowany.Text = login;
        }

        private void Wyswietl_Click(object sender, EventArgs e)
        {
            bazaDanych wypozyczenia = new bazaDanych();

            MySqlConnection connect = null;
            connect = wypozyczenia.connect();
            String query = "SELECT poj.nr_rejestracyjny AS 'Numer rejestracyjny', s.data_ostatniego_przegladu AS 'Data ostatniego przeglądu', s.nazwa_serwisu AS 'Nazwa serwisu', u.nazwa_uslugi AS 'Usługa', s.koszt AS 'Koszt usługi' FROM pojazd AS poj JOIN serwis AS s ON poj.id_pojazdu = s.id_pojazdu JOIN usluga AS u ON s.id_uslugi = u.id_uslugi WHERE s.data_ostatniego_przegladu >= '"+ dataOd.Value.ToString("yyyy-MM-dd") + "' AND s.data_ostatniego_przegladu <= '"+ dataDo.Value.ToString("yyyy-MM-dd") + "'; ";
            MySqlDataAdapter aSerw = new MySqlDataAdapter(query, connect);
            //MySqlCommand commandDatabase = new MySqlCommand(query, connect);
            //MySqlDataReader reader;
            DataTable tbSerw = new DataTable();
            aSerw.Fill(tbSerw);
            listaSerwis.DataSource = tbSerw;
        }
    }
}
