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
        String login;
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
    }
}
