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
    public partial class ITthirdSemMarks : Form
    {
        public ITthirdSemMarks()
        {
            InitializeComponent();
        }

        private void txtboxRegIT3_TextChanged(object sender, EventArgs e)
        {
            if (txtboxRegIT3.Text != "")
            {

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2KHOCF\MYSQLSERVER;Initial Catalog=MyMinorProject;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT student_name, Branch,Semester from newadmission where NAID= " + txtboxRegIT3.Text + "", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);


                if (ds.Tables[0].Rows.Count != 0)
                {
                    lblsname3.Text = ds.Tables[0].Rows[0][0].ToString();
                    lblBranch3.Text = ds.Tables[0].Rows[0][1].ToString();
                    lblSemester3.Text = ds.Tables[0].Rows[0][2].ToString();
                    if (lblSemester3.Text != "3rd Semester")
                    {
                        MessageBox.Show("This student not from 3rd Semester", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }


                }
                else
                {

                    MessageBox.Show("No record found", "No Match", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                txtboxRegIT3.Text = "";
                lblsname3.Text = "__________";
                lblBranch3.Text = "_______________";
                lblSemester3.Text = "_______________";

            }

        }

        private void btnupdate3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2KHOCF\MYSQLSERVER;Initial Catalog=MyMinorProject;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into sixthsemmarksCSE values(" + txtboxRegIT3.Text + ",'" + lblsname3.Text + "','" + lblBranch3.Text + "','" + lblSemester3.Text + "'," + txtboxPIC.Text + "," + txtboxBEEE.Text + "," + txtboxCW.Text + "," + txtboxCSP.Text + "," + txtboxCA.Text + "," + txtboxOS.Text + "," + txtboxSnl3.Text + ",'" + txtboxresult3.Text + "')", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (MessageBox.Show("Marks uploaded successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
            {
                txtboxRegIT3.Text = "";

                lblsname3.Text = "_______________";
                lblBranch3.Text = "_______________";
                lblSemester3.Text = "_______________";
               
              
              

            }

            else
            {
                MessageBox.Show("Marks already uploaded");

            }
        }
    }
}
