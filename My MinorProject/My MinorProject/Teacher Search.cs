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

namespace My_MinorProject
{
    public partial class Teacher_Search : Form
    {
        public Teacher_Search()
        {
            InitializeComponent();
        }

        private void Teacher_Search_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2KHOCF\MYSQLSERVER;Initial Catalog=MyMinorProject;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select *from Teacherinfo",con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgv.DataSource = ds.Tables[0];
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2KHOCF\MYSQLSERVER;Initial Catalog=MyMinorProject;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select *from Teacherinfo where tid="+txtboxReg.Text+"", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgv.DataSource = ds.Tables[0];

        }
    }
}
