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
    public partial class TeacherGrid : Form
    {
        public TeacherGrid()
        {
            InitializeComponent();
        }
        ///////////////////////////////////////////////////////////////////////////
        static string path = Path.GetFullPath(Environment.CurrentDirectory);
        static string databasename = "stuteadb.mdf";
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + path + @"\" + databasename + ";Integrated Security=True");
        /////////////////////////////////////////////////////////////////////////////
        
        private void TeacherGrid_Load(object sender, EventArgs e)
        {
            string qry = "SELECT * FROM Teacher";

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(qry, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Teacher");
                dgtv1.DataSource = ds.Tables["Teacher"];
            }
            catch (SqlException Ex)
            {
                MessageBox.Show("Error Occured" + Ex.ToString());
            }
        }

        private void escbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            About obj = new About();
            obj.Show();
        }
    }
}
