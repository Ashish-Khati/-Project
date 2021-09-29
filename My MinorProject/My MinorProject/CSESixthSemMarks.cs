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
    public partial class CSESixthSemMarks : Form
    {
        public CSESixthSemMarks()
        {
            InitializeComponent();
        }

        private void txtboxReg5_TextChanged(object sender, EventArgs e)
        {

            if (txtboxReg5.Text != "")
            {

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2KHOCF\MYSQLSERVER;Initial Catalog=MyMinorProject;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT student_name, Branch,Semester from newadmission where NAID= " + txtboxReg5.Text + "", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);


                if (ds.Tables[0].Rows.Count != 0)
                {
                    lblsname5.Text = ds.Tables[0].Rows[0][0].ToString();
                    lblBranch5.Text = ds.Tables[0].Rows[0][1].ToString();
                    lblSemester5.Text = ds.Tables[0].Rows[0][2].ToString();
                    if (lblSemester5.Text != "6th Semester")
                    {
                        MessageBox.Show("This student not from 6th Semester", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                txtboxReg5.Text = "";
                lblsname5.Text = "__________";
                lblBranch5.Text = "_______________";
                lblSemester5.Text = "_______________";

            }
        }

        private void btnupdate3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2KHOCF\MYSQLSERVER;Initial Catalog=MyMinorProject;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into sixthsemmarksCSE values(" + txtboxReg5.Text + ",'" + lblsname5.Text + "','" + lblBranch5.Text + "','" + lblSemester5.Text + "'," + txtboxOOPUJ.Text + "," + txtboxCG.Text + "," + txtboxDWM.Text + "," + txtboxOST.Text + "," + txtboxMC.Text + "," + txtboxEDM.Text + "," + txtboxMJP.Text + "," + txtboxSnl5.Text + ",'" + txtboxResult5.Text + "')", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (MessageBox.Show("Marks uploaded successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
            {
                txtboxReg5.Text = "";

                lblsname5.Text = "_______________";
                lblBranch5.Text = "_______________";
                lblSemester5.Text = "_______________";
               txtboxCG.Text = "";
                txtboxDWM.Text = "";
                txtboxEDM.Text = "";
                 txtboxMC.Text = "";
                 txtboxMJP.Text = "";
                txtboxOOPUJ.Text = "";
                txtboxOST.Text = "";
                txtboxResult5.Text = "";
                txtboxSnl5.Text = "";
                

            }

            else
            {
                MessageBox.Show("Marks already uploaded");

            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtboxMJP_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtboxMC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxResult5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxSnl5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxEDM_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxOST_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxDWM_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxCG_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxOOPUJ_TextChanged(object sender, EventArgs e)
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
