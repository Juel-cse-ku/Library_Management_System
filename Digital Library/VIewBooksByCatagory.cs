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
using Entity;

namespace Digital_Library
{
    public partial class VIewBooksByCatagory : Form
    {
        string connstring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Juel\Desktop\Digital Library\Database\Digital_library.mdf;Integrated Security=True;Connect Timeout=30";
        
        public VIewBooksByCatagory()
        {
            InitializeComponent();
            
            fill_combobox1();
        }

        private void fill_combobox1()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connstring);
               // SqlDataAdapter MyDA = new SqlDataAdapter();
                SqlDataReader rd;
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT Category from tbl_Category ", connection);
                //cmd.CommandText = "SELECT prdtName FROM tbl_product";
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    string name = rd["Category"].ToString();
                    comboBox1.Items.Add(name);
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home_form home = new Home_form();
            home.Show();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string a = comboBox1.Text;
                //MessageBox.Show(a);
                SqlConnection connection = new SqlConnection(connstring);
                SqlDataAdapter MyDA = new SqlDataAdapter();
                SqlDataReader rd;
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT Book_ID,Book_Name,Author,Quantity,Arrival_Date from tbl_Entry_new_book", connection);
                //connection.CommandText = "SELECT Category FROM tbl_Entry_new_book where ";
                cmd.ExecuteNonQuery();

                SqlDataAdapter sAdapter = new SqlDataAdapter(cmd);
                SqlCommandBuilder sBuilder = new SqlCommandBuilder(sAdapter);
                DataSet sDs = new DataSet();
                sAdapter.Fill(sDs, "tbl_Due_Books");
                DataTable sTable = sDs.Tables["tbl_Due_Books"];
                connection.Close();
                dataGridView1.DataSource = sDs.Tables["tbl_Due_Books"];
                dataGridView1.ReadOnly = true;
                connection.Close();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void VIewBooksByCatagory_Load(object sender, EventArgs e)
        {

        }
    }
}
