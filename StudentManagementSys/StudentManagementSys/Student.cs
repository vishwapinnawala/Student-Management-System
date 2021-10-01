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
using System.IO;
using System.Text.RegularExpressions;

namespace StudentManagementSys
{
    public partial class Offstaff : Form
    {
        
        string genders;
        public Offstaff()
        {
            InitializeComponent();
        }

        private void minbtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void escbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        //////////////////////////////////////////////////////////////////////
        static string path = Path.GetFullPath(Environment.CurrentDirectory);
        static string databasename = "stuteadb.mdf";
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename="+path+@"\"+databasename+";Integrated Security=True");
        //////////////////////////////////////////////////////////////////////
        private void savebtn_Click(object sender, EventArgs e)
        {
             int i;
             if (!int.TryParse(stuid.Text, out i))
             {
                 error.Visible = true;
             }
             else if(fname.Text==""){
                 error.Visible = false;
                 ferror.Visible = true;
             }
             else if (lname.Text == "")
             {
                 ferror.Visible = false;
                 lerror.Visible = true;
             }
             else if(tel.TextLength<9){
                 lerror.Visible = false;
                 telerror.Visible = true;
             }
             else if(!Regex.IsMatch(email.Text, @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9_\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")){
                 telerror.Visible = false;
                 emailerror.Visible=true;
             }
                 
             else if ((!male.Checked) && (!female.Checked))
             {
                 emailerror.Visible = false;
                 generror.Visible = true;

             }
             
             else if (cmbbox.Text=="")
             {
                 generror.Visible = false;
                 ciderror.Visible = true;
             }


             else
             {

                 error.Visible = false;
                 ferror.Visible = false;
                 lerror.Visible = false;
                 telerror.Visible = false;
                 emailerror.Visible = false;
                 generror.Visible = false;
                 ciderror.Visible = false;
                 /* int stdid = int.Parse(stuid.Text);
                  string stdfname = fname.Text;
                  string stdlname = lname.Text;
                  string teli = tel.Text;
                  string mail = email.Text;
                  string grades = cmbbox.Text;*/

                 if (male.Checked)
                 {
                     genders = "Male";
                 }
                 else if (female.Checked)
                 {
                     genders = "Female";
                 }


                 string insertqry = "INSERT INTO Student VALUES(" + stuid.Text + ",'" + fname.Text + "','" + lname.Text + "','" + email.Text + "','" + tel.Text + "','" + genders + "','" + cmbbox.Text + "') ";
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

        private void delbtn_Click(object sender, EventArgs e)
        {
            int i;
            if (!int.TryParse(stuid.Text, out i))
            {
                error.Visible = true;  
            }
            else
            {
                error.Visible = false;

                string deleteqry = "DELETE FROM Student WHERE StdID=(" + stuid.Text + ")";
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

        private void updatebtn_Click(object sender, EventArgs e)
        {
            int i;
            if (!int.TryParse(stuid.Text, out i))
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
            else if (cmbbox.Text == "")
            {
                generror.Visible = false;
                ciderror.Visible = true;
            }


             else
             {
                 error.Visible = false;
                 ferror.Visible = false;
                 lerror.Visible = false;
                 telerror.Visible = false;
                 emailerror.Visible = false;
                 generror.Visible = false;
                 ciderror.Visible = false;

                 if (male.Checked)
                 {
                     genders = "Male";
                 }
                 else if (female.Checked)
                 {
                     genders = "Female";
                 }

                 string updateqry = "update student set StdID=" + stuid.Text + ",Fname='" + fname.Text + "',Lname='" + lname.Text + "',Email='" + email.Text + "',Tel='" + tel.Text + "',Gender='" + genders + "',Grade='" + cmbbox.Text + "' where StdID=" + stuid.Text + " ";
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

                    string searchqry = "Select * from student where StdID= '" + searchbox.Text + "' ";
                    SqlCommand cmd = new SqlCommand(searchqry, con);
                    con.Open();
                    SqlDataReader r = cmd.ExecuteReader();

                    while (r.Read())
                    {
                        stuid.Text = r[0].ToString();
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
                        // int i = Convert.ToInt32(r[6]);
                        // cmbbox.SelectedIndex = 2;
                        //cmbbox.Text = i.ToString();
                        cmbbox.Text = r[6].ToString();


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

        private void Student_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            StudentGrid obj = new StudentGrid();
            obj.Show();

            

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login obj = new Login();
            obj.Show();
            
        }

        private void label10_Click(object sender, EventArgs e)
        {
            About obj = new About();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*int i;
            if (!int.TryParse(stuid.Text, out i))
            {
                label11.Text = ("number only field");
            }
            else
            {

            }
            */


            
        }
           
            
        }
    }

