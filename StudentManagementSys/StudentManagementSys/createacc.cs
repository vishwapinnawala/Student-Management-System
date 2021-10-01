using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;//to md5 hash use this 
using System.Data.SqlClient;//to use sql commands use this
using System.IO;//to use get the file path use this

namespace StudentManagementSys
{
    public partial class createacc : Form
    {
        
        ///////////////////////////////////////////////////////////////////////////
        static string path = Path.GetFullPath(Environment.CurrentDirectory);
        static string databasename = "stuteadb.mdf";
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + path + @"\" + databasename + ";Integrated Security=True");
        /////////////////////////////////////////////////////////////////////////////

        static string Encrypt(string value)//encrypting function
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }


        public createacc()
        {
            InitializeComponent();
        }

        private void createacc_Load(object sender, EventArgs e)
        {
            password.PasswordChar = '*';
        }

        private void escbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void storebtn_Click(object sender, EventArgs e)
        {
            string encpwd = Encrypt(password.Text);//hashing the input2 text

            string qry = "INSERT INTO login VALUES(" + userid.Text + ",'" + encpwd + "')";
            SqlCommand cmd = new SqlCommand(qry, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Successfully!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error Occured" + ex.ToString());
            }
            finally
            {
                con.Close();
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adminselect obj = new Adminselect();
            obj.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            About obj = new About();
            obj.Show();
        }
    }
}
