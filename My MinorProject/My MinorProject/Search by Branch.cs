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
    public partial class Search_by_Branch : Form
    {
        public Search_by_Branch()
        {
            InitializeComponent();
        }

        private void Search_by_Branch_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2KHOCF\MYSQLSERVER;Initial Catalog=MyMinorProject;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select newadmission.NAID as Student_ID,newadmission.Student_Name as Student_Name,newadmission.Father_Name as Father_Name,newadmission.Mother_Name as Mother_Name,newadmission.Gender as Gender,newadmission.DOB as Date_of_Birth,newadmission.Admission_Date as Admission_Date,newadmission.Mobile_Number,newadmission.Semester,newadmission.Branch,newadmission.Address,newadmission.Email_ID,fees.fees as Fees from newadmission inner join fees on newadmission.NAID = fees.NAID";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            MessageBox.Show("These student have diposited their fees");
            dgv4.DataSource = ds.Tables[0];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new System.Data.SqlClient.SqlConnection(@"Data Source=DESKTOP-B2KHOCF\MYSQLSERVER;Initial Catalog=MyMinorProject;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Select * from newadmission where Branch = '" + comboBranch.Text + "'";
            if (comboBranch.Text != "")
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgv4.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Please enter branch");
            }
        }
    }
}
