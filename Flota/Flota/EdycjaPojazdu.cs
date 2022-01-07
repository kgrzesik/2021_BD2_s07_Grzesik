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
    public partial class EdycjaPojazdu : Form
    {
        String login;
        String idop;
        MySqlConnection connect = null;
        bazaDanych wybor_pojazdu = new bazaDanych();
        MySqlConnection czytaj = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlDataAdapter adapter;
        MySqlDataAdapter adapter2;
        MySqlDataAdapter adapter3;
        MySqlDataAdapter adapter4;
        MySqlDataAdapter adapter5;
        MySqlDataAdapter adapter6;
        DataTable table = new DataTable();
        DataTable table2 = new DataTable();
        DataTable table3 = new DataTable();
        DataTable table4 = new DataTable();
        DataTable table5 = new DataTable();
        DataTable table6 = new DataTable();
        DataTable tbpoj = new DataTable();

        public EdycjaPojazdu()
        {
            InitializeComponent();
        }

        private void EdycjaPojazdu_Load(object sender, EventArgs e)
        {
            
            zalogowany.Text = login;
            nrRej.DataSource = tbpoj;
            //MessageBox.Show(tbpoj.Rows[0][0].ToString());
            //MessageBox.Show(tbpoj.Rows[0][1].ToString()); -------------------------->EDYCJA
            nrRej.DisplayMember = "nr_rejestracyjny";
            vin.Text = tbpoj.Rows[0][2].ToString();
            rok.Text = tbpoj.Rows[0][5].ToString();
            przebieg.Text = tbpoj.Rows[0][6].ToString();
            adapter = new MySqlDataAdapter("SELECT * FROM flota.marka ", czytaj);
            adapter.Fill(table);
            marka.DataSource = table;
            bazaDanych pobieraniedanych = new bazaDanych();
            MySqlConnection pobieranie = null;
            pobieranie = pobieraniedanych.connect();
            MySqlCommand commandmod = new MySqlCommand("SELECT * FROM model WHERE id_modelu='" + tbpoj.Rows[0][3] + "'", pobieranie);
            MySqlDataReader readermod;
            readermod = commandmod.ExecuteReader();
            string imod = "";
            string nmod = "";
            string imark = "";
            if (readermod.Read())
            {
                imod = readermod.GetString(0);
                nmod = readermod.GetString(1);
                imark = readermod.GetString(2);
            }
            readermod.Close();

            MySqlCommand commandmark = new MySqlCommand("SELECT nazwa_marki FROM marka WHERE id_marki='" + imark + "'", pobieranie);
            MySqlDataReader readermark;
            readermark = commandmark.ExecuteReader();
            string nmark = "";
            if (readermark.Read())
            {
                nmark = readermark.GetString(0);
            }
            readermark.Close();
            marka.DisplayMember = "nazwa_marki";
            marka.ValueMember = "id_marki";
            marka.Text = nmark;
            adapter2 = new MySqlDataAdapter("SELECT * FROM flota.model", czytaj);
            adapter2.Fill(table2);
            model.DataSource = table2;
            model.DisplayMember = "nazwa_modelu";
            model.ValueMember = "id_modelu";
            model.Text = nmod;
            adapter3 = new MySqlDataAdapter("SELECT * FROM flota.typ_pojazdu", czytaj);
            adapter3.Fill(table3);
            typ.DataSource = table3;
            typ.DisplayMember = "nazwa_typu";
            typ.ValueMember = "id_typu_pojazdu";

            MySqlCommand commandtyp = new MySqlCommand("SELECT nazwa_typu FROM typ_pojazdu WHERE id_typu_pojazdu='" + tbpoj.Rows[0][4] + "'", pobieranie);
            MySqlDataReader readertyp;
            readertyp = commandtyp.ExecuteReader();
            string ntyp = "";
            if (readertyp.Read())
            {
                ntyp = readertyp.GetString(0);
            }
            readertyp.Close();
            typ.Text = ntyp;
            adapter4 = new MySqlDataAdapter("SELECT * FROM flota.przeznaczenie", czytaj);
            adapter4.Fill(table4);
            przeznaczenie1.DataSource = table4;
            przeznaczenie1.DisplayMember = "nazwa_przeznaczenia";
            przeznaczenie1.ValueMember = "id_przeznaczenia";

            MySqlCommand commandprze = new MySqlCommand("SELECT nazwa_przeznaczenia FROM przeznaczenie WHERE id_przeznaczenia='" + tbpoj.Rows[0][7] + "'", pobieranie);
            MySqlDataReader readerprze;
            readerprze = commandprze.ExecuteReader();
            string nprze = "";
            if (readerprze.Read())
            {
                nprze = readerprze.GetString(0);
            }
            readerprze.Close();
            przeznaczenie1.Text = nprze;
            adapter5 = new MySqlDataAdapter("SELECT * FROM flota.element_wyposazenia", czytaj);
            adapter5.Fill(table5);
            wyposazenie.DataSource = table5;
            wyposazenie.DisplayMember = "nazwa_wypozazenia";
            wyposazenie.ValueMember = "id_wyposazenia";

            MySqlCommand commandwyp = new MySqlCommand("SELECT nazwa_wypozazenia FROM element_wyposazenia WHERE id_wyposazenia='" + tbpoj.Rows[0][8] + "'", pobieranie);
            MySqlDataReader readerwyp;
            readerwyp = commandwyp.ExecuteReader();
            string nwyp = "";
            if (readerwyp.Read())
            {
                nwyp = readerwyp.GetString(0);
            }
            readerwyp.Close();
            wyposazenie.Text = nwyp;

            adapter6 = new MySqlDataAdapter("SELECT * FROM flota.pracownik", czytaj);
            adapter6.Fill(table6);
            opiekun.DataSource = table6;
            opiekun.DisplayMember = "login";
            opiekun.ValueMember = "id_pracownika";

            MySqlCommand commandidusr = new MySqlCommand("SELECT id_pracownika, id_opiekuna FROM opiekun WHERE id_pojazdu='" + tbpoj.Rows[0][0] + "'", pobieranie);
            MySqlDataReader readeridusr;
            readeridusr = commandidusr.ExecuteReader();
            string idusr = "";
            if (readeridusr.Read())
            {
                idusr = readeridusr.GetString(0);
                idop = readeridusr.GetString(1);
            }
            readeridusr.Close();
            MySqlCommand commandnusr = new MySqlCommand("SELECT login FROM pracownik WHERE id_pracownika='" + idusr + "'", pobieranie);
            MySqlDataReader readernusr;
            readernusr = commandnusr.ExecuteReader();
            string nusr = "";
            if (readernusr.Read())
            {
                nusr = readernusr.GetString(0);
            }
            readernusr.Close();
            opiekun.Text = nusr;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void user(String user)
        {
            login = user;
            //zalogowany.Text = login;
        }
        public void poj(DataTable nr)
        {
            tbpoj = nr;
            //zalogowany.Text = login;
        }
        private void powrotZarzadzajPojazdem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Zarządzaj_pojazdem zp = new Zarządzaj_pojazdem();
            zp.user(login);
            zp.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void potwierdz(object sender, EventArgs e)
        {
            try
            {
                string nr_rejestracyjny = (string)nrRej.Text;
                string vin = (string)this.vin.Text;
                string rok = (string)this.rok.Text;
                string przebieg = (string)this.przebieg.Text;
                string Marka = (string)marka.Text;                                
                string przeznaczenie = (string)przeznaczenie1.ValueMember;
                if (nr_rejestracyjny != "" && vin != "" && rok != "" && przebieg != "")
                {
                    connect = wybor_pojazdu.connect();
                    string query = "UPDATE `pojazd` (`nr_rejestracyjny`, `vin`,  `rok_produkcji`, `przebieg`) VALUES ('" + nr_rejestracyjny + "', '" + vin + "', '" + rok + "', '" + przebieg + "');";
                    MySqlCommand commandDatabase = new MySqlCommand(query, connect);
                    commandDatabase.ExecuteNonQuery();

                    string message = "Dodano pojazd";
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


        private void marka_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void model_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void powrotZarzadzajPojazdem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Wybor_Pojazdu wp = new Wybor_Pojazdu();
            wp.user(login);
            wp.Show();
        }

        private void marka_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bazaDanych pobieraniedanych = new bazaDanych();
                string nr_rejestracyjny = (string)nrRej.Text;
                string vin_s = (string)vin.Text;
                string rok_s = (string)rok.Text;
                string przebieg_s = (string)przebieg.Text;
                string txtmod = (string)model.Text;
                MySqlConnection pobieranie = null;
                pobieranie = pobieraniedanych.connect();
                MySqlCommand commandmod = new MySqlCommand("SELECT id_modelu FROM model WHERE nazwa_modelu='" + txtmod + "'", pobieranie);
                MySqlDataReader readermod;
                readermod = commandmod.ExecuteReader();
                string mod = "";
                if (readermod.Read())
                {
                    mod = readermod.GetString(0);
                }
                readermod.Close();

                string txtt = (string)typ.Text;
                MySqlCommand commandt = new MySqlCommand("SELECT id_typu_pojazdu FROM typ_pojazdu WHERE nazwa_typu='" + txtt + "'", pobieranie);
                MySqlDataReader readert;
                readert = commandt.ExecuteReader();
                string t = "";
                if (readert.Read())
                {
                    t = readert.GetString(0);
                }
                readert.Close();


                string txtprze = (string)przeznaczenie1.Text;
                MySqlCommand commandprze = new MySqlCommand("SELECT id_przeznaczenia FROM przeznaczenie WHERE nazwa_przeznaczenia='" + txtprze + "'", pobieranie);
                MySqlDataReader readerprze;
                readerprze = commandprze.ExecuteReader();
                string prze = "";
                if (readerprze.Read())
                {
                    prze = readerprze.GetString(0);
                }
                readerprze.Close();

                string txtwypo = (string)wyposazenie.Text;
                MySqlCommand commandwypo = new MySqlCommand("SELECT id_wyposazenia FROM element_wyposazenia WHERE nazwa_wypozazenia='" + txtwypo + "'", pobieranie);
                MySqlDataReader readerwypo;
                readerwypo = commandwypo.ExecuteReader();
                string wypo = "";
                if (readerwypo.Read())
                {
                    wypo = readerwypo.GetString(0);
                }
                readerwypo.Close();

                string txtopie = (string)opiekun.Text;
                MySqlCommand commandopie = new MySqlCommand("SELECT id_pracownika FROM pracownik WHERE login='" + txtopie + "'", pobieranie);
                MySqlDataReader readeropie;
                readeropie = commandopie.ExecuteReader();
                String opie = "";
                if (readeropie.Read())
                {
                    opie = readeropie.GetString(0);
                }
                readeropie.Close();
                int val;
                Int32.TryParse(marka.SelectedValue.ToString(), out val);
                if (nr_rejestracyjny != "" && vin_s != "" && rok_s != "" && przebieg_s != "" && opie != "")
                {
                    //dodanie pojazdu
                    connect = wybor_pojazdu.connect();
                    string query = "UPDATE pojazd SET nr_rejestracyjny = '" + nr_rejestracyjny + "', vin = '" + vin_s + "', rok_produkcji = '" + rok_s + "', przebieg = '" + przebieg_s + "', id_modelu = '" + mod + "', id_typu_pojazdu= '" + t + "', id_przeznaczenia = '" + prze + "', id_wyposazenia = '" + wypo + ");' WHERE id_pojazdu='"+ tbpoj.Rows[0][0] + "'";
                    MySqlCommand commandDatabase = new MySqlCommand(query, connect);
                    commandDatabase.ExecuteNonQuery();
                    //pobranie nr
                    MySqlConnection nrrej = null;
                    nrrej = wybor_pojazdu.connect();
                    MySqlCommand commandRej = new MySqlCommand("SELECT id_pojazdu FROM pojazd WHERE nr_rejestracyjny='" + nrRej.Text + "'", nrrej);
                    MySqlDataReader readerrej;
                    readerrej = commandRej.ExecuteReader();
                    readerrej.Read();
                    var poj = readerrej.GetString(0);
                    //dodanie opiekuna
                    MySqlConnection conopie = null;
                    conopie = wybor_pojazdu.connect();
                    string qopie = "UPDATE opiekun SET id_pracownika = '" + opie + "', id_pojazdu = '" + poj + "' WHERE id_opiekuna='" + idop + "'";
                    MySqlCommand comopie = new MySqlCommand(qopie, conopie);
                    comopie.ExecuteNonQuery();

                    string message = "Edytowano pojazd";
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
    }
}

