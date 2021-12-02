using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Flota
{
    class bazaDanych
    {
         public MySqlConnection connect()
        {
            MySqlConnection connectionString = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=flota;");
            try
            {
                connectionString.Open();
            }
            catch (MySqlException sqlEx)
            {
                MessageBox.Show(sqlEx.ToString());
            }
            return connectionString;
        }
    }
}
