using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Flota
{
    public partial class listaWypozyczen : Form
    {
        MySqlConnection connect = null;
        String login;
        MySqlDataAdapter pojazd;
        
        bazaDanych wybor_pojazdu = new bazaDanych();
        MySqlConnection czytaj = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        DataTable tbpoj = new DataTable();
        public listaWypozyczen()
        {
            InitializeComponent();
        }

        private void listaWypozyczen_Load(object sender, EventArgs e)
        {
            zalogowany.Text = login;
        }
        public void user(String user)
        {
            login = user;
        }

        private void powrot_Click(object sender, EventArgs e)
        {
            this.Hide();
            Wypozyczenia wy = new Wypozyczenia();
            wy.user(login);
            wy.Show();
        }

        private void Wyswietl_Click(object sender, EventArgs e)
        {
            bazaDanych wypozyczenia = new bazaDanych();

            MySqlConnection connect = null;
            connect = wypozyczenia.connect();
            String query = "SELECT poj.nr_rejestracyjny AS 'Numer rejestracyjny', prac.login AS 'Nazwa użytkownika', w.data_od AS 'Data od', w.data_do AS 'Data do', w.powod AS 'Powód' FROM pojazd AS poj JOIN wypozyczenia AS w ON poj.id_pojazdu = w.id_pojazdu JOIN pracownik AS prac ON w.id_pracownika = prac.id_pracownika WHERE((data_od >= '" + dataOd.Value.ToString("yyyy-MM-dd") + "' AND data_od <= '" + dataDo.Value.ToString("yyyy-MM-dd") + "') OR(data_do >= '" + dataOd.Value.ToString("yyyy-MM-dd") + "' AND data_do <= '" + dataDo.Value.ToString("yyyy-MM-dd") + "') OR(data_od <= '" + dataOd.Value.ToString("yyyy-MM-dd") + "' AND data_do >= '" + dataDo.Value.ToString("yyyy-MM-dd") + "')); ";
            MySqlDataAdapter aWyp = new MySqlDataAdapter(query, connect);
            //MySqlCommand commandDatabase = new MySqlCommand(query, connect);
            //MySqlDataReader reader;
            DataTable tbWyp = new DataTable();
            aWyp.Fill(tbWyp);
            listaWyp.DataSource = tbWyp;
        }
    }
}
