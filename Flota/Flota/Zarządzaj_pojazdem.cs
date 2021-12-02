using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flota
{
    public partial class Zarządzaj_pojazdem : Form
    {
        public Zarządzaj_pojazdem()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void edytujPojazd_Click(object sender, EventArgs e)
        {
            this.Hide();
            Wybor_Pojazdu wp = new Wybor_Pojazdu();
            wp.Show();
        }

        private void usunPojazd_Click(object sender, EventArgs e)
        {
            this.Hide();
            Wybor_Pojazdu wp = new Wybor_Pojazdu();
            wp.Show();
        }

        private void dodajPojazd_Click(object sender, EventArgs e)
        {
            this.Hide();
            formularzPojazdu fp = new formularzPojazdu();
            fp.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void powrotMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
