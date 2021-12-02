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
    public partial class Wybor_Pojazdu : Form
    {

        listaPojazdow lp = new listaPojazdow();
        public Wybor_Pojazdu()
        {
            InitializeComponent();
            lp.wyswietl(listaPoj);
        }
        private void listaPojazdow_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void powrotZarzadzaniePojazdem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Zarządzaj_pojazdem zp = new Zarządzaj_pojazdem();
            zp.Show();
        }

        private void Wybor_Pojazdu_Load(object sender, EventArgs e)
        {

        }
    }
}
