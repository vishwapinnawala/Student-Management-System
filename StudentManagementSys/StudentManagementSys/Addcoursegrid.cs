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

namespace StudentManagementSys
{
    public partial class Addcoursegrid : Form
    {
        public Addcoursegrid()
        {
            InitializeComponent();
        }

        private void Addcoursegrid_Load(object sender, EventArgs e)
        {
            string qry = "select * from Course";

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(qry, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Course");
                dgv1.DataSource = ds.Tables["Course"];
            }
            catch (SqlException Ex)
            {
                MessageBox.Show("Error Occured" + Ex.ToString());
            }
        }
        ///////////////////////////////////////////////////////////////////////////
        static string path = Path.GetFullPath(Environment.CurrentDirectory);
        static string databasename = "stuteadb.mdf";
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + path + @"\" + databasename + ";Integrated Security=True");

        /////////////////////////////////////////////////////////////////////////////
        
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
