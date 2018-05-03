using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Entity;

namespace Digital_Library
{
    public partial class All_Students : Form
    {
        string connstring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Juel\Desktop\Digital Library\Database\Digital_library.mdf;Integrated Security=True;Connect Timeout=30";
       
        public All_Students()
        {
            InitializeComponent();
            this.AllStudentsinfo();
        }
        public void AllStudentsinfo()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connstring);
                SqlDataAdapter MyDA = new SqlDataAdapter();
                connection.Open();

                SqlCommand cmd = new SqlCommand("SELECT * from tbl_Student_Information ", connection);
                cmd.ExecuteNonQuery();

                SqlDataAdapter sAdapter = new SqlDataAdapter(cmd);
                SqlCommandBuilder sBuilder = new SqlCommandBuilder(sAdapter);
                DataSet sDs = new DataSet();
                sAdapter.Fill(sDs, "tbl_Student_Information");
                DataTable sTable = sDs.Tables["tbl_Student_Information"];
                connection.Close();
                dataGridView1.DataSource = sDs.Tables["tbl_Student_Information"];
                dataGridView1.ReadOnly = true;
                //save_btn.Enabled = false;
                //dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


                // connection.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home_form home = new Home_form();
            home.Show();
            this.Hide();
        }
    }
}
