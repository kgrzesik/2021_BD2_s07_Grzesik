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
    public partial class formularzPojazdu : Form
    {
        String login;
        MySqlConnection connect = null;
        bazaDanych wybor_pojazdu = new bazaDanych();
        MySqlConnection czytaj = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        // MySqlDataAdapter adapter2;
        MySqlDataAdapter adapter3;
        MySqlDataAdapter adapter4;
        MySqlDataAdapter adapter5;
        MySqlDataAdapter adapter6;
        DataTable table = new DataTable();
        // DataTable table2 = new DataTable();
        DataTable table3 = new DataTable();
        DataTable table4 = new DataTable();
        DataTable table5 = new DataTable();
        DataTable table6 = new DataTable();

        public formularzPojazdu()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void formularzPojazdu_Load(object sender, EventArgs e)
        {
            zalogowany.Text = login;
            string query = "SELECT * FROM flota.marka";
            fillCombo(marka, query, "nazwa_marki", "id_marki");
            adapter3 = new MySqlDataAdapter("SELECT * FROM flota.typ_pojazdu", czytaj);
            adapter3.Fill(table3);
            typ.DataSource = table3;
            typ.DisplayMember = "nazwa_typu";
            typ.ValueMember = "id_typu_pojazdu";
            typ.Text = "--Wybierz--";
            adapter4 = new MySqlDataAdapter("SELECT * FROM flota.przeznaczenie", czytaj);
            adapter4.Fill(table4);
            przeznaczenie1.DataSource = table4;
            przeznaczenie1.DisplayMember = "nazwa_przeznaczenia";
            przeznaczenie1.ValueMember = "id_przeznaczenia";
            przeznaczenie1.Text = "--Wybierz--";
            adapter5 = new MySqlDataAdapter("SELECT * FROM flota.element_wyposazenia", czytaj);
            adapter5.Fill(table5);
            wyposazenie.DataSource = table5;
            wyposazenie.DisplayMember = "nazwa_wypozazenia";
            wyposazenie.ValueMember = "id_wyposazenia";
            wyposazenie.Text = "--Wybierz--";
            adapter6 = new MySqlDataAdapter("SELECT * FROM flota.pracownik WHERE id_stanowiska=4", czytaj);
            adapter6.Fill(table6);
            opiekun.DataSource = table6;
            opiekun.DisplayMember = "login";
            opiekun.ValueMember = "id_pracownika";
            opiekun.Text = "--Wybierz--";


        }
        public void user(String user)
        {
            login = user;
            //zalogowany.Text = login;
        }
        public void fillCombo(ComboBox combo, string query, string displayMember, string valueMember)
        {
            command = new MySqlCommand(query, czytaj);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            combo.DataSource = table;
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;
            combo.Text = "--Wybierz--";
        }
        private void model_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void powrotZarzadzajPojazdem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Zarzadzaj_pojazdem zp = new Zarzadzaj_pojazdem();
            zp.user(login);
            zp.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void marka_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(marka.SelectedValue.ToString(), out val);
            string query = "SELECT * FROM flota.model WHERE id_marki=" + val;
            fillCombo(model, query, "nazwa_modelu", "id_modelu");
        }


        private void potwierdz(object sender, EventArgs e)
        {
            try
            {
                bazaDanych pobieraniedanych = new bazaDanych();
                string nr_rejestracyjny = (string)textBox1.Text;
                string vin = (string)textBox2.Text;
                string rok = (string)comboBox1.Text;
                string przebieg = (string)textBox3.Text;
                string txtmod = (string)model.Text;
                MySqlConnection pobieranie = null;
                pobieranie = pobieraniedanych.connect();
                MySqlCommand commandmod = new MySqlCommand("SELECT id_modelu FROM model WHERE nazwa_modelu='" + txtmod + "'", pobieranie);
                MySqlDataReader readermod;
                readermod = commandmod.ExecuteReader();
                string mod="";
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
                if (nr_rejestracyjny != "" && vin != "" && rok != "" && przebieg != "" && opie != "")
                {
                    //dodanie pojazdu
                    connect = wybor_pojazdu.connect();
                    string query = "INSERT INTO pojazd (nr_rejestracyjny, vin,  rok_produkcji, przebieg, id_modelu, id_typu_pojazdu, id_przeznaczenia, id_wyposazenia) VALUES ('" + nr_rejestracyjny + "', '" + vin + "','" + rok + "', '" + przebieg + "'," + mod + "," + t + "," + prze + "," + wypo + ");";
                    MySqlCommand commandDatabase = new MySqlCommand(query, connect);
                   commandDatabase.ExecuteNonQuery();
                    //pobranie nr
                    MySqlConnection nrrej = null;
                    nrrej = wybor_pojazdu.connect();
                    MySqlCommand commandRej = new MySqlCommand("SELECT id_pojazdu FROM pojazd WHERE nr_rejestracyjny='" + textBox1.Text + "'", nrrej);
                    MySqlDataReader readerrej;
                    readerrej = commandRej.ExecuteReader();
                    readerrej.Read();
                    var poj = readerrej.GetString(0);
                    //dodanie opiekuna
                    MySqlConnection conopie = null;
                    conopie = wybor_pojazdu.connect();
                    string qopie = "INSERT INTO opiekun (id_pracownika, id_pojazdu) VALUES ("+opie+", "+poj+")";
                    MySqlCommand comopie = new MySqlCommand(qopie, conopie);
                    comopie.ExecuteNonQuery();

                    string message = "Dodano pojazd";
                    string caption = "Sukces";
                    DialogResult result;
                    result = MessageBox.Show(message, caption);

                    connect.Close();
                    marka.Text = "--Wybierz--";
                    model.Text = "--Wybierz--";
                    typ.Text = "--Wybierz--";
                    przeznaczenie1.Text = "--Wybierz--";
                    wyposazenie.Text = "--Wybierz--";
                    opiekun.Text = "--Wybierz--";
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    comboBox1.Text = "";
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

        private void pomoc_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file://C:/Users/Piotrek/Desktop/Flota/manual/manual.chm");
        }
    }
}
