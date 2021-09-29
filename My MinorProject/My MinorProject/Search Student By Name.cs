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
    public partial class Search_Student_By_Name : Form
    {
        public Search_Student_By_Name()
        {
            InitializeComponent();
        }

        private void Search_Student_By_Name_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2KHOCF\MYSQLSERVER;Initial Catalog=MyMinorProject;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select newadmission.NAID as Student_ID,newadmission.Student_Name as Student_Name,newadmission.Father_Name as Father_Name,newadmission.Mother_Name as Mother_Name,newadmission.Gender as Gender,newadmission.DOB as Date_of_Birth,newadmission.Admission_Date as Admission_Date,newadmission.Mobile_Number,newadmission.Semester,newadmission.Branch,newadmission.Address,newadmission.Email_ID,fees.fees as Fees from newadmission inner join fees on newadmission.NAID = fees.NAID";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            MessageBox.Show("These student have diposited their fees");
            dgv2.DataSource = ds.Tables[0];
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2KHOCF\MYSQLSERVER;Initial Catalog=MyMinorProject;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
           
            cmd.CommandText = "Select * from newadmission where Student_Name = '"+ txtboxsearchname.Text + "'";
            if(txtboxsearchname.Text!="")
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgv2.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Please enter student name");
            }
                      
        }

        private void dgv2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
