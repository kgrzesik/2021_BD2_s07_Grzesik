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
    class listaPojazdow
    {
        bazaDanych wybor_pojazdu = new bazaDanych();
        MySqlConnection connect = null;
        DataTable lista;

        public void wyswietl(ListBox listaWyswietlana)
        {
            try
            {
                connect = wybor_pojazdu.connect();
                string query = "SELECT * FROM pojazd";
                List<string> listaW = new List<string>();
                MySqlCommand commandDatabase = new MySqlCommand(query, connect);
                MySqlDataAdapter adapter = new MySqlDataAdapter(commandDatabase);
                lista = new DataTable();
                adapter.Fill(lista);

                foreach (DataRow row in lista.Rows)
                {
                    listaW.Add(row["nr_rejestracyjny"].ToString());
                }
                for(int i=0;i<listaW.Count;i++)
                {
                    listaWyswietlana.Items.Insert(i, listaW[i].ToString());
                }

            }
            catch(MySqlException sqlEX)
            {
                MessageBox.Show(sqlEX.ToString());
            }
            connect.Close();
        }
    }
}
