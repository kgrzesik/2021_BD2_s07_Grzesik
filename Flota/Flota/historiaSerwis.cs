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
    public partial class historiaSerwis : Form
    {
        String login;
        public historiaSerwis()
        {
            InitializeComponent();
        }

        private void historiaSerwis_Load(object sender, EventArgs e)
        {
            zalogowany.Text = login;
        }

        private void powrot_Click(object sender, EventArgs e)
        {
            this.Hide();
            Serwis sr = new Serwis();
            sr.user(login);
            sr.Show();
        }
        public void user(String user)
        {
            login = user;
            //zalogowany.Text = login;
        }

    }
}
