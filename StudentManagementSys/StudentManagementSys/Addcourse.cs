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

namespace StudentManagementSys
{
    public partial class Addcourse : Form
    {

        //////////////////////////////////////////////////////////////////////
        static string path = Path.GetFullPath(Environment.CurrentDirectory);
        static string databasename = "stuteadb.mdf";
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + path + @"\" + databasename + ";Integrated Security=True");
        //////////////////////////////////////////////////////////////////////
        

        public Addcourse()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Addcoursegrid obj = new Addcoursegrid();
            obj.Show();
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

                    string searchqry = "Select * from Course where Courseid= '" + searchbox.Text + "' ";
                    SqlCommand cmd = new SqlCommand(searchqry, con);
                    con.Open();
                    SqlDataReader r = cmd.ExecuteReader();

                    while (r.Read())
                    {
                        cid.Text = r[0].ToString();
                        cname.Text = r[1].ToString();
                        cdep.Text = r[2].ToString();



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

        private void savebtn_Click(object sender, EventArgs e)
        {
            int i;
            if (!int.TryParse(cid.Text, out i))
            {
                error.Visible = true;
            }
            else if (cname.Text == "")
            {
                error.Visible = false;
                ferror.Visible = true;
            }
            else if (cdep.Text == "")
            {
                ferror.Visible = false;
                lerror.Visible = true;
            }

            else
            {
                error.Visible = false;
                ferror.Visible = false;
                lerror.Visible = false;
                string insertqry = "INSERT INTO Course VALUES(" + cid.Text + ",'" + cname.Text + "','" + cdep.Text + "') ";
                SqlCommand cmd = new SqlCommand(insertqry, con);
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
            if (!int.TryParse(cid.Text, out i))
            {
                error.Visible = true;
            }
            else if (cname.Text == "")
            {
                error.Visible = false;
                ferror.Visible = true;
            }
            else if (cdep.Text == "")
            {
                ferror.Visible = false;
                lerror.Visible = true;
            }

            else
            {
                error.Visible = false;
                ferror.Visible = false;
                lerror.Visible = false;
                string updateqry = "update Course set Courseid=" + cid.Text + ",Coursename='" + cname.Text + "',CourseDesc='" + cdep.Text + "' where Courseid=" + cid.Text + " ";
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
            if (!int.TryParse(cid.Text, out i))
            {
                error.Visible = true;
            }
            else
            {
                error.Visible = false;
                string deleteqry = "DELETE FROM Course WHERE Courseid=(" + cid.Text + ")";
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

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adminselect obj = new Adminselect();
            obj.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            About obj = new About();
            obj.Show();
        }
    }
}
