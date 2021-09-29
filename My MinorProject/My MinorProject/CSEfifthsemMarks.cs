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
    public partial class CSEfifthsemMarks : Form
    {
        public CSEfifthsemMarks()
        {
            InitializeComponent();
        }

        private void txtboxReg4_TextChanged(object sender, EventArgs e)
        {
            if (txtboxReg4.Text != "")
            {

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2KHOCF\MYSQLSERVER;Initial Catalog=MyMinorProject;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT student_name, Branch,Semester from newadmission where NAID= " + txtboxReg4.Text + "", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);


                if (ds.Tables[0].Rows.Count != 0)
                {
                    lblsname4.Text = ds.Tables[0].Rows[0][0].ToString();
                    lblBranch4.Text = ds.Tables[0].Rows[0][1].ToString();
                    lblSemester4.Text = ds.Tables[0].Rows[0][2].ToString();
                    if (lblSemester4.Text != "5th Semester")
                    {
                        MessageBox.Show("This student not from 5th Semester", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                txtboxReg4.Text = "";
                lblsname4.Text = "__________";
                lblBranch4.Text = "_______________";
                lblSemester4.Text = "_______________";

            }
        }

        private void btnupdate2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2KHOCF\MYSQLSERVER;Initial Catalog=MyMinorProject;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into fifthsemmarksCSE values(" + txtboxReg4.Text + ",'" + lblsname4.Text + "','" + lblBranch4.Text + "','" + lblSemester4.Text + "'," + txtboxMP.Text + "," + txtboxCNS.Text + "," + txtboxCNT.Text + "," + txtboxVPCS.Text + "," + txtboxSQT.Text + "," + txtboxMIP.Text + ","+txtboxDBP.Text+"," + txtboxSnl4.Text + ",'" + txtboxResult4.Text + "')", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (MessageBox.Show("Marks uploaded successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
            {
                txtboxReg4.Text = "";

                lblsname4.Text = "_______________";
                lblBranch4.Text = "_______________";
                lblSemester4.Text = "_______________";
                txtboxCNS.Text = "";
                txtboxCNT.Text = "";
                txtboxDBP.Text = "";
                txtboxMIP.Text = "";
               txtboxMP.Text = "";
                txtboxResult4.Text = "";
                txtboxSnl4.Text = "";
                txtboxSQT.Text = "";
                txtboxVPCS.Text="";
                

            }

            else
            {
                MessageBox.Show("Marks already uploaded");

            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtboxDBP_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtboxMIP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxResult4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxSnl4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxSQT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxVPCS_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxCNT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxCNS_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxMP_TextChanged(object sender, EventArgs e)
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
