using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Library
{
    public partial class Home_form : Form
    {
        public Home_form()
        {
            InitializeComponent();
        }
        private void Logout(object sender, MouseEventArgs e)
        {
            Login_form h = new Login_form();
            h.Show();
            this.Hide();

        }
    }
}
