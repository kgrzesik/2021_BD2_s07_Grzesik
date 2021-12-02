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
        public zarzadzajBazaDanych()
        {
            InitializeComponent();
        }

        private void powrotMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
