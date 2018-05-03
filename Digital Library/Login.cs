using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BL;
using System.IO;

namespace Digital_Library
{
    public partial class Login_form : Form
    {
        public Login_form()
        {
            InitializeComponent();
        }

        private void Register_button_Click(object sender, EventArgs e)
        {
            Register_form register = new Register_form();
            register.Show();
            this.Hide();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (User_name_textBox.Text != "" && Password_textBox.Text != "")
                {
                    Digital_library_entity information = new Digital_library_entity();

                    information.User_name = User_name_textBox.Text;
                    information.Password = Password_textBox.Text;

                    Digital_library_bl LibraryBL = new Digital_library_bl();

                    if (LibraryBL.checkinformation(information))
                    {
                        MessageBox.Show("Entry Successfull");
                        Home_form home = new Home_form();
                        home.Show();
                        this.Hide();
                        // clear();
                    }
                    else
                    {
                        MessageBox.Show("Invalid user name or password!!");
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
