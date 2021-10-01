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
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.IO;

namespace StudentManagementSys
{
    public partial class Studentlogin : Form
    {
        public Studentlogin()
        {
            InitializeComponent();
        }


        ///////////////////////////////////////////////////////////////////////////
        string newpwd;
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


        private void loginbtn_Click(object sender, EventArgs e)
        {
           /* if (username.Text == "vishwa" && password.Text == "vishwa")
            {
                //MessageBox.Show("vishwa");
                this.Hide();
                Login log = new Login();
                log.Show();
            }
            else if (username.Text == "" || password.Text == "")
            {
                labelerror.Text = ("Username or Password is Missing");
            }
            else
            {
                labelerror.Text = ("Username or Password is Incorrect");
            }*/
            try
            {
                string encpwd = Encrypt(password.Text);//hashing input2 text


                string searchqry = "Select * from login where userid= " + userid.Text + " ";
                SqlCommand cmd = new SqlCommand(searchqry, con);
                con.Open();
                SqlDataReader r = cmd.ExecuteReader();


                while (r.Read())
                {
                    newpwd = r[1].ToString();
                }

                


                newpwd = Regex.Replace(newpwd, @"\s", "");


                if (encpwd == newpwd)
                {
                    //password.Text = newpwd; 
                    this.Hide();
                    Login log = new Login();
                    log.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }

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

        private void escbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minbtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Studentlogin_Load(object sender, EventArgs e)
        {
            password.PasswordChar = '*';
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (userid.Text == "admin" && password.Text == "admin")
            {
                //MessageBox.Show("vishwa");
                this.Hide();
                Adminselect asel = new Adminselect();
                asel.Show();
            }
            else if (userid.Text == "" || password.Text == "")
            {
                labelerror.Text = ("Master Username or Password is Missing");
            }
            else
            {
                labelerror.Text = (" Master Username or Password is Incorrect");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            About obj = new About();
            
            obj.Show();
        }
    }
}
