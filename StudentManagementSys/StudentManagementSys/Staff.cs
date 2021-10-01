using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Text.RegularExpressions;


namespace StudentManagementSys
{
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        string genders;
        ///////////////////////////////////////////////////////////////////////////
        static string path = Path.GetFullPath(Environment.CurrentDirectory);
        static string databasename = "stuteadb.mdf";
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + path + @"\" + databasename + ";Integrated Security=True");
        /////////////////////////////////////////////////////////////////////////////
        private void Staff_Load(object sender, EventArgs e)
        {

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            /*  int stdid = int.Parse(teaid.Text);
              string stdfname = fname.Text;
              string stdlname = lname.Text;
              string teli = tel.Text;
              string mail = email.Text;
              */

            //string grades = cmbbox.Text;

             int i;
            if (!int.TryParse(staffid.Text, out i))
            {
                error.Visible = true;
            }
            else if (fname.Text == "")
            {
                error.Visible = false;
                ferror.Visible = true;
            }
            else if (lname.Text == "")
            {
                ferror.Visible = false;
                lerror.Visible = true;
            }
            else if (tel.TextLength <9)
            {
                lerror.Visible = false;
                telerror.Visible = true;
            }
            else if (!Regex.IsMatch(email.Text, @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9_\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
            {
                telerror.Visible = false;
                emailerror.Visible = true;
            }
            else if ((!male.Checked) && (!female.Checked))
            {
                emailerror.Visible = false;
                generror.Visible = true;

            }
            


            else
            {
                error.Visible = false;
                ferror.Visible = false;
                lerror.Visible = false;
                telerror.Visible = false;
                emailerror.Visible = false;
                generror.Visible = false;


                if (male.Checked)
                {
                    genders = "Male";
                }
                else if (female.Checked)
                {
                    genders = "Female";
                }


                string qry = "INSERT INTO Staff VALUES(" + staffid.Text + ",'" + fname.Text + "','" + lname.Text + "','" + email.Text + "','" + tel.Text + "','" + genders + "') ";
                SqlCommand cmd = new SqlCommand(qry, con);
                //con.Open();
                //cmd.ExecuteNonQuery();
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
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
             int i;
            if (!int.TryParse(staffid.Text, out i))
            {
                error.Visible = true;
            }
            else if (fname.Text == "")
            {
                error.Visible = false;
                ferror.Visible = true;
            }
            else if (lname.Text == "")
            {
                ferror.Visible = false;
                lerror.Visible = true;
            }
            else if (tel.TextLength <9)
            {
                lerror.Visible = false;
                telerror.Visible = true;
            }
            else if (!Regex.IsMatch(email.Text, @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9_\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
            {
                telerror.Visible = false;
                emailerror.Visible = true;
            }
            else if ((!male.Checked) && (!female.Checked))
            {
                emailerror.Visible = false;
                generror.Visible = true;

            }



            else
            {
                error.Visible = false;
                ferror.Visible = false;
                lerror.Visible = false;
                telerror.Visible = false;
                emailerror.Visible = false;
                generror.Visible = false;

                if (male.Checked)
                {
                    genders = "Male";
                }
                else if (female.Checked)
                {
                    genders = "Female";
                }

                string updateqry = "update Staff set staffid=" + staffid.Text + ",Fname='" + fname.Text + "',Lname='" + lname.Text + "',Email='" + email.Text + "',Tel='" + tel.Text + "',Gender='" + genders + "' where staffid=" + staffid.Text + " ";
                SqlCommand cmd = new SqlCommand(updateqry, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Update Successful!");
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
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            int i;
            if (!int.TryParse(staffid.Text, out i))
            {
                error.Visible = true;
            }
            else
            {
                error.Visible = false;
                string deleteqry = "DELETE FROM Staff WHERE staffid=(" + staffid.Text + ")";
                SqlCommand cmd = new SqlCommand(deleteqry, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Deletion Successful!");
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
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            int i;
            if (!int.TryParse(searchbox.Text, out i))
            {
                error2.Visible = true;
            }
            else
            {
                error2.Visible = false;
                try
                {

                    string searchqry = "Select * from Staff where staffid= '" + searchbox.Text + "' ";
                    SqlCommand cmd = new SqlCommand(searchqry, con);
                    con.Open();
                    SqlDataReader r = cmd.ExecuteReader();

                    while (r.Read())
                    {
                        staffid.Text = r[0].ToString();
                        fname.Text = r[1].ToString();
                        lname.Text = r[2].ToString();
                        email.Text = r[3].ToString();
                        tel.Text = r[4].ToString();
                        string gen = r[5].ToString();
                        if (gen != "")
                        {
                            male.Checked = true;
                        }
                        else if (gen != "")
                        {
                            female.Checked = true;
                        }

                        //int i = int.Parse(r[6]); not working dunno why
                        //int i = Convert.ToInt32(r[6]);
                        //cmbbox.SelectedIndex = i;
                        //cmbbox.Text = i.ToString();
                        // cmbbox.Text = r[6].ToString();

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
        }

        private void escbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            this.Hide();
            obj.Show();
        }

        private void minbtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Staffgrid obj = new Staffgrid();
            obj.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            About obj = new About();
            obj.Show();
        }
    }
}
