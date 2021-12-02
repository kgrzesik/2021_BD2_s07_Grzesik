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
    public partial class formularzPojazdu : Form
    {
        public formularzPojazdu()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void formularzPojazdu_Load(object sender, EventArgs e)
        {

        }

        private void powrotZarzadzajPojazdem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Zarządzaj_pojazdem zp = new Zarządzaj_pojazdem();
            zp.Show();
        }
    }
}
