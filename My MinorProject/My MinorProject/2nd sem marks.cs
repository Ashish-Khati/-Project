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
    public partial class _2nd_sem_marks : Form
    {
        public _2nd_sem_marks()
        {
            InitializeComponent();
        }

        private void txtboxReg_TextChanged(object sender, EventArgs e)
        {
            if (txtboxReg1.Text != "")
            {

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2KHOCF\MYSQLSERVER;Initial Catalog=MyMinorProject;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT student_name, Branch,Semester from newadmission where NAID= " + txtboxReg1.Text + "", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);


                if (ds.Tables[0].Rows.Count != 0)
                {
                    lblsname1.Text = ds.Tables[0].Rows[0][0].ToString();
                    lblBranch1.Text = ds.Tables[0].Rows[0][1].ToString();
                    lblSemester1.Text = ds.Tables[0].Rows[0][2].ToString();
                    if (lblSemester1.Text != "2nd Semester")
                    {
                        MessageBox.Show("This student not from 2nd Semester", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        StudentDetailsformarks sdfm = new StudentDetailsformarks();
                        sdfm.Show();
                      
                      
                    }


                }
                else
                {

                    MessageBox.Show("No record found", "No Match", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                txtboxReg1.Text = "";
                lblsname1.Text = "__________";
                lblBranch1.Text = "_______________";
                lblSemester1.Text = "_______________";

            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2KHOCF\MYSQLSERVER;Initial Catalog=MyMinorProject;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into secondsemmarks values(" + txtboxReg1.Text + ",'" + lblsname1.Text + "','" + lblBranch1.Text + "','" + lblSemester1.Text + "'," + txtboxEnglish1.Text + "," + txtboxMaths1.Text + "," + txtboxPhysics1.Text + "," + txtboxChemistry1.Text + "," + txtboxEs.Text + "," + txtboxED1.Text + "," + txtboxSnl1.Text + ",'" + txtboxResult1.Text + "')", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (MessageBox.Show("Marks uploaded successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
            {
                txtboxReg1.Text = "";

                lblsname1.Text = "_______________";
                lblBranch1.Text = "_______________";
                lblSemester1.Text = "_______________";
                txtboxChemistry1.Text = "";
                txtboxED1.Text = "";
                txtboxEnglish1.Text = "";
                txtboxEs.Text = "";
                txtboxMaths1.Text = "";
                txtboxPhysics1.Text = "";
                txtboxSnl1.Text = "";
                txtboxResult1.Text = "";

            }

            else
            {
                MessageBox.Show("Marks already uploaded");

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtboxEs_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxResult1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxSnl1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxED1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxChemistry1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxPhysics1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxMaths1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxEnglish1_TextChanged(object sender, EventArgs e)
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
