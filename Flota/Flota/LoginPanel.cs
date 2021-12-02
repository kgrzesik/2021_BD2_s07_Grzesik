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
    public partial class LoginPanel : Form
    {
        sprawdzenieLogowania sp = new sprawdzenieLogowania();
        String query;
        public LoginPanel()
        {
            InitializeComponent();
        }
        //String connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=flota;";

        public String getQuery() 
        {
            return query;
        }
        public void setQuery()
        {
             query = "SELECT * FROM pracownik WHERE login='" + loginLabel.Text + "' AND haslo='" + passwordLabel.Text + "'";
        }
        
        public void ukryj(bool czy)
        {
            if (czy == true)
            {
                this.Hide();
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void zaloguj_Click(object sender, EventArgs e)
        {
            setQuery();
            bool czy=sp.login(getQuery());
            ukryj(czy);
        }

        private void passwordLabel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                setQuery();
                bool czy=sp.login(getQuery());
                ukryj(czy);
            }
        }

        private void loginLabel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                setQuery();
                bool czy=sp.login(getQuery());
                ukryj(czy);
            }
        }

        private void loginLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
