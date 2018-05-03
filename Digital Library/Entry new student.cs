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
    public partial class Entry_new_student : Form
    {
        public Entry_new_student()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home_form home = new Home_form();
            home.Show();
            this.Hide();
        }

        private void Reset_button_Click(object sender, EventArgs e)
        {
            textBox_student_ID.Clear();
            textBox1_name.Clear();
            textBox2_disciplene.Clear();
            textBox3_batch.Clear();
            textBox4_contact_no.Clear();
            textBox5_homeDistrict.Clear();
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            try
            {
                if ( textBox_student_ID.Text!= "" && textBox1_name.Text!= "" &&textBox2_disciplene.Text!= "" &&textBox3_batch.Text!= "" &&textBox4_contact_no.Text!= "" &&textBox5_homeDistrict.Text!= "" )
                {

                    Digital_library_entity information = new Digital_library_entity();

                    information.Discipline = textBox2_disciplene.Text;
                    information.Student_ID = textBox_student_ID.Text;
                    information.Batch = textBox3_batch.Text;
                    information.Student_name = textBox1_name.Text;
                    information.Contact_no = textBox4_contact_no.Text;
                    information.home_district = textBox5_homeDistrict.Text;

                    Digital_library_bl LibraryBL = new Digital_library_bl();

                    if (LibraryBL.Entry_student(information))
                    {
                        MessageBox.Show("Entry Successfull");
                        Home_form home = new Home_form();
                        home.Show();
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
    }
}
