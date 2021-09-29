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
    public partial class ITsixthSemMarks : Form
    {
        public ITsixthSemMarks()
        {
            InitializeComponent();
        }

        private void txtboxRegIT6_TextChanged(object sender, EventArgs e)
        {
            if (txtboxRegIT6.Text != "")
            {

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2KHOCF\MYSQLSERVER;Initial Catalog=MyMinorProject;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT student_name, Branch,Semester from newadmission where NAID= " + txtboxRegIT6.Text + "", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);


                if (ds.Tables[0].Rows.Count != 0)
                {
                    lblsname6.Text = ds.Tables[0].Rows[0][0].ToString();
                    lblBranch6.Text = ds.Tables[0].Rows[0][1].ToString();
                    lblSemester6.Text = ds.Tables[0].Rows[0][2].ToString();
                    if (lblSemester6.Text != "6th Semester")
                    {
                        MessageBox.Show("This student not from 6th Semester", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       
                    }


                }
                else
                {

                    MessageBox.Show("No record found", "No Match", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                txtboxRegIT6.Text = "";
                lblsname6.Text = "__________";
                lblBranch6.Text = "_______________";
                lblSemester6.Text = "_______________";

            }

        }

        private void btnupdate3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2KHOCF\MYSQLSERVER;Initial Catalog=MyMinorProject;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into sixthsemmarksCSE values(" + txtboxRegIT6.Text + ",'" + lblsname6.Text + "','" + lblBranch6.Text + "','" + lblSemester6.Text + "'," + txtboxDNP.Text + "," + txtboxMMA.Text + "," + txtboxDWM1.Text + "," + txtboxAWP.Text + "," + txtboxMC1.Text + "," + txtboxMJP1.Text + "," + txtboxSnl6.Text + ",'" + txtboxresult1.Text + "')", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (MessageBox.Show("Marks uploaded successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
            {
                txtboxRegIT6.Text = "";

                lblsname6.Text = "_______________";
                lblBranch6.Text = "_______________";
                lblSemester6.Text = "_______________";
                txtboxAWP.Text = "";
                txtboxDNP.Text = "";
                txtboxDWM1.Text = "";
                txtboxMC1.Text = "";
                txtboxMJP1.Text = "";
                txtboxMMA.Text = "";
                txtboxresult1.Text = "";
                txtboxSnl6.Text = "";

            }

            else
            {
                MessageBox.Show("Marks already uploaded");

            }

        }
    }
}
    

