using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSys
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void escbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();

            }

        private void minbtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
       
        private void teacherbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teacher tea = new Teacher();
            tea.Show();
           
        }

        private void studentbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Offstaff stu = new Offstaff();
            stu.Show();

            //var newobj = new Student();
           // newobj.Show();

            //Student newobj = new();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Staff obj = new Staff();
            this.Hide();
            obj.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            About obj = new About();
            obj.Show();
        }
    }
}
