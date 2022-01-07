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
    public partial class zarzadzajBazaDanych : Form
    {
        String login;
        public zarzadzajBazaDanych()
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
        public void user(String user)
        {
            login = user;
            //zalogowany.Text = login;
        }

        private void zarzadzajBazaDanych_Load(object sender, EventArgs e)
        {
            zalogowany.Text = login;
        }
    }
}
