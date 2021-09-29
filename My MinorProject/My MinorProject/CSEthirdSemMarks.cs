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
    public partial class CSEthirdSemMarks : Form
    {
        public CSEthirdSemMarks()
        {
            InitializeComponent();
        }

        private void txtboxReg2_TextChanged(object sender, EventArgs e)
        {
            if (txtboxReg2.Text != "")
            {

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2KHOCF\MYSQLSERVER;Initial Catalog=MyMinorProject;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT student_name, Branch,Semester from newadmission where NAID= " + txtboxReg2.Text + "", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);


                if (ds.Tables[0].Rows.Count != 0)
                {
                    lblsname2.Text = ds.Tables[0].Rows[0][0].ToString();
                    lblBranch2.Text = ds.Tables[0].Rows[0][1].ToString();
                    lblSemester2.Text = ds.Tables[0].Rows[0][2].ToString();
                    if (lblSemester2.Text != "3rd Semester")
                    {
                        MessageBox.Show("This student not from 3rd Semester", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                txtboxReg2.Text = "";
                lblsname2.Text = "__________";
                lblBranch2.Text = "_______________";
                lblSemester2.Text = "_______________";

            }
        }

        private void btnupdate1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2KHOCF\MYSQLSERVER;Initial Catalog=MyMinorProject;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into thirdsemmarksCSE values(" + txtboxReg2.Text + ",'" + lblsname2.Text + "','" + lblBranch2.Text + "','" + lblSemester2.Text + "'," + txtboxPIC.Text + "," + txtboxBEEE.Text + "," + txtboxOOC.Text + "," + txtboxCSP.Text + "," + txtboxDDC.Text + "," + txtboxOS.Text + "," + txtboxSnl2.Text + ",'" + txtboxResult2.Text + "')", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (MessageBox.Show("Marks uploaded successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
            {
                txtboxReg2.Text = "";

                lblsname2.Text = "_______________";
                lblBranch2.Text = "_______________";
                lblSemester2.Text = "_______________";
                txtboxBEEE.Text = "";
                txtboxCSP.Text = "";
                txtboxDDC.Text = "";
                txtboxOOC.Text = "";
                txtboxOS.Text = "";
                txtboxPIC.Text = "";
                txtboxSnl2.Text = "";
                txtboxResult2.Text = "";

            }

            else
            {
                MessageBox.Show("Marks already uploaded");

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtboxOS_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxResult2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxSnl2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxDDC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxCSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxOOC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxBEEE_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxPIC_TextChanged(object sender, EventArgs e)
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
   
