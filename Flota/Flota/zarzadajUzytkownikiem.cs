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
    public partial class zarzadajUzytkownikiem : Form
    {
        String login;
        public zarzadajUzytkownikiem()
        {
            InitializeComponent();
        }

        private void powrotMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.user(login);
            menu.Show();
        }

        private void usunUzytkownika_Click(object sender, EventArgs e)
        {

            this.Hide();
            WyborUzytkownika eu = new WyborUzytkownika();
            eu.user(login);
            eu.Show();
        }

        private void dodajUzytkownika_Click(object sender, EventArgs e)
        {
            this.Hide();
            DodajUzytkownika du = new DodajUzytkownika();
            du.user(login);
            du.Show();
        }

        private void zarzadajUzytkownikiem_Load(object sender, EventArgs e)
        {
            zalogowany.Text = login;
        }
        public void user(String user)
        {
            login = user;
            //zalogowany.Text = login;
        }
    }
}
