using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using Entity;
using System.Security.Cryptography;

namespace DAL
{
    public class Digital_library_dal
    {
        string connstring = @"Data Source=(localdb)\v11.0;Initial Catalog=Digital_library;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
        public bool Set_information(Digital_library_entity information)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connstring);

                connection.Open();
                string password = getSHA1Hasing(getSHA1Hasing(information.Password));

                SqlCommand cmd = new SqlCommand("INSERT INTO tbl_login VALUES('" + information.User_name + "' ,'" + password + "')", connection);
                cmd.ExecuteNonQuery();

                connection.Close();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }
        public string getSHA1Hasing(string passwordText)
        {
            SHA1CryptoServiceProvider sh = new SHA1CryptoServiceProvider();
            sh.ComputeHash(ASCIIEncoding.ASCII.GetBytes(passwordText));
            byte[] re = sh.Hash;
            StringBuilder sb = new StringBuilder();
            foreach (byte b in re)
            {
                sb.Append(b.ToString("x2"));
            }


            return sb.ToString();
        }
        public bool check_information(Digital_library_entity information)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connstring);

                connection.Open();
                string password = getSHA1Hasing( getSHA1Hasing(information.Password));
                string name = information.User_name;

                SqlCommand cmd = new SqlCommand("SELECT Password FROM tbl_login WHERE Name = '" + name + "'", connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string p = reader["Password"].ToString();
                    if( p == password)
                        return true;
                }
                reader.Close();
                connection.Close();
                return false;

               /* string type = null;
                for (int i = 0; reader.Read(); i++)
                {
                    type = reader[0].ToString();

                }*/
                
               
                //
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
           

        }
    }
}
