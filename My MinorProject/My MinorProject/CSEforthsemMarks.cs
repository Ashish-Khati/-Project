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
    public partial class CSEforthsemMarks : Form
    {
        public CSEforthsemMarks()
        {
            InitializeComponent();
        }

        private void txtboxReg3_TextChanged(object sender, EventArgs e)
        {
            if (txtboxReg3.Text != "")
            {

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2KHOCF\MYSQLSERVER;Initial Catalog=MyMinorProject;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT student_name, Branch,Semester from newadmission where NAID= " + txtboxReg3.Text + "", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);


                if (ds.Tables[0].Rows.Count != 0)
                {
                    lblsname3.Text = ds.Tables[0].Rows[0][0].ToString();
                    lblBranch3.Text = ds.Tables[0].Rows[0][1].ToString();
                    lblSemester3.Text = ds.Tables[0].Rows[0][2].ToString();
                    if (lblSemester3.Text != "4th Semester")
                    {
                        MessageBox.Show("This student not from 4th Semester", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        CSEthirdSemMarks cset = new CSEthirdSemMarks();
                        cset.Visible = true;
                    }


                }
                else
                {

                    MessageBox.Show("No record found", "No Match", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                txtboxReg3.Text = "";
                lblsname3.Text = "__________";
                lblBranch3.Text = "_______________";
                lblSemester3.Text = "_______________";

            }
        }

        private void btnupdate2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2KHOCF\MYSQLSERVER;Initial Catalog=MyMinorProject;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into forthsemmarksCSE values(" + txtboxReg3.Text + ",'" + lblsname3.Text + "','" + lblBranch3.Text + "','" + lblSemester3.Text + "'," + txtboxDSC.Text + "," + txtboxWT.Text + "," + txtboxCOA.Text + "," + txtboxDBMS.Text + "," + txtboxSSE.Text + "," + txtboxCN.Text + "," + txtboxSnl3.Text + ",'" + txtboxResult3.Text + "')", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (MessageBox.Show("Marks uploaded successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
            {
                txtboxReg3.Text = "";

                lblsname3.Text = "_______________";
                lblBranch3.Text = "_______________";
                lblSemester3.Text = "_______________";
                txtboxCN.Text = "";
                 txtboxCOA.Text = "";
                txtboxDBMS.Text = "";
                txtboxDSC.Text = "";
                txtboxResult3.Text = "";
                txtboxSnl3.Text = "";
                txtboxSSE.Text = "";
                txtboxWT.Text = "";
                

            }

            else
            {
                MessageBox.Show("Marks already uploaded");

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtboxCN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxResult3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxSnl3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxSSE_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxDBMS_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxCOA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxWT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxDSC_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
