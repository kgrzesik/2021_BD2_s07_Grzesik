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
    public partial class Eksploatacja : Form
    {
        String login;
        public Eksploatacja()
        {
            InitializeComponent();
        }

        private void Eksploatacja_Load(object sender, EventArgs e)
        {
            zalogowany.Text = login;
        }

        private void powrotButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu mn = new Menu();
            mn.user(login);
            mn.Show();
        }
        public void user(String user)
        {
            login = user;
            //zalogowany.Text = login;
        }

        private void historia_Click(object sender, EventArgs e)
        {
            this.Hide();
            historiaEksploatacja he = new historiaEksploatacja();
            he.user(login);
            he.Show();
        }
    }
}
