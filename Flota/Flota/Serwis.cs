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
    public partial class Serwis : Form
    {
        String login;
        public Serwis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu mn = new Menu();
            mn.user(login);
            mn.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void user(String user)
        {
            login = user;
            //zalogowany.Text = login;
        }

        private void Serwis_Load(object sender, EventArgs e)
        {
            zalogowany.Text = login;
        }

        private void historia_Click(object sender, EventArgs e)
        {
            this.Hide();
            historiaSerwis hs = new historiaSerwis();
            hs.user(login);
            hs.Show();
        }
    }
}
