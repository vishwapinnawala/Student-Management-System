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
    public partial class Adminselect : Form
    {
        public Adminselect()
        {
            InitializeComponent();
        }

        private void teacherbtn_Click(object sender, EventArgs e)
        {
            createacc obj = new createacc();
            this.Hide();
            obj.Show();
        }

        private void studentbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Addcourse obj = new Addcourse();
            obj.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Studentlogin obj = new Studentlogin();
            obj.Show();
        }

        private void escbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            About obj = new About();
            obj.Show();
        }
    }
}
