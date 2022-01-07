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
    public partial class historiaEksploatacja : Form
    {
        String login;
        public historiaEksploatacja()
        {
            InitializeComponent();
        }

        private void powrot_Click(object sender, EventArgs e)
        {
            this.Hide();
            Eksploatacja us = new Eksploatacja();
            us.user(login);
            us.Show();
        }

        private void historiaEksploatacja_Load(object sender, EventArgs e)
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
