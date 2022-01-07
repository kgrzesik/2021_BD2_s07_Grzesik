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
        String login;
        public Zarządzaj_pojazdem()
        {
            InitializeComponent();
        }

     
        private void usunPojazd_Click(object sender, EventArgs e)
        {
            this.Hide();
            Wybor_Pojazdu wp = new Wybor_Pojazdu();
            wp.user(login);
            wp.Show();
        }

        private void dodajPojazd_Click(object sender, EventArgs e)
        {
            this.Hide();
            formularzPojazdu fp = new formularzPojazdu();
            fp.user(login);
            fp.Show();
        }

        private void powrotMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.user(login);
            menu.Show();
        }
        public void user(String user)
        {
            login = user;
        }

        private void Zarządzaj_pojazdem_Load(object sender, EventArgs e)
        {
            zalogowany.Text = login;
        }
    }
}
