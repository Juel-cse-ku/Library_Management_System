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
    public partial class Register_form : Form
    {
        public Register_form()
        {
            InitializeComponent();
        }

        private void Register_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (User_name_textBox.Text != "" && Password_textBox.Text != "")
                {
                    Digital_library_entity information = new Digital_library_entity();

                    information.User_name = User_name_textBox.Text;
                    information.Password = Password_textBox.Text;

                    Digital_library_bl LibraryBL = new Digital_library_bl();

                    if (LibraryBL.setinformation(information))
                    {
                        MessageBox.Show("Entry Successfull");
                        Login_form login = new Login_form();
                        login.Show();
                        this.Hide();
                        // clear();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Entry!!");
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            Login_form login = new Login_form();
            login.Show();
            this.Hide();
        }
    }
}
