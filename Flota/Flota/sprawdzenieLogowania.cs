using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Flota
{
    class sprawdzenieLogowania
    {
        bazaDanych wybor_pojazdu = new bazaDanych();
        MySqlConnection connect = null;
        public bool login(string query, string user)
        {
            bool czy_zamknac = false;
            try
            {
                connect = wybor_pojazdu.connect();
                MySqlCommand commandDatabase = new MySqlCommand(query, connect);
                //MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlDataReader reader;
                try
                {
                    //databaseConnection.Open();
                    reader = commandDatabase.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Menu menu = new Menu();
                            menu.wyswietlenieUzytkowanika(user);
                            menu.Show();
                            czy_zamknac = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Błędny login lub hasło") ;
                        czy_zamknac = false;
                    }
                    connect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (MySqlException sqlEX)
            {
                MessageBox.Show(sqlEX.ToString());
            }
            connect.Close();
            return czy_zamknac;
        }
    }
}
