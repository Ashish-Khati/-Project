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
    public partial class ITForthsemMarks : Form
    {
        public ITForthsemMarks()
        {
            InitializeComponent();
        }

        private void txtboxRegIT4_TextChanged(object sender, EventArgs e)
        {
            if (txtboxRegIT4.Text != "")
            {

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2KHOCF\MYSQLSERVER;Initial Catalog=MyMinorProject;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT student_name, Branch,Semester from newadmission where NAID= " + txtboxRegIT4.Text + "", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);


                if (ds.Tables[0].Rows.Count != 0)
                {
                    lblsname4.Text = ds.Tables[0].Rows[0][0].ToString();
                    lblBranch4.Text = ds.Tables[0].Rows[0][1].ToString();
                    lblSemester4.Text = ds.Tables[0].Rows[0][2].ToString();
                    if (lblSemester4.Text != "6th Semester")
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
                txtboxRegIT4.Text = "";
                lblsname4.Text = "__________";
                lblBranch4.Text = "_______________";
                lblSemester4.Text = "_______________";

            }

        }

        private void btnupdate3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2KHOCF\MYSQLSERVER;Initial Catalog=MyMinorProject;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into sixthsemmarksCSE values(" + txtboxRegIT4.Text + ",'" + lblsname4.Text + "','" + lblBranch4.Text + "','" + lblSemester4.Text + "'," + txtboxDSUC.Text + "," + txtboxOOPCPP.Text + "," + txtboxCOM.Text + "," + txtboxIWT.Text + "," + txtboxSSE.Text + "," + txtboxDCN.Text + "," + txtboxSnl4.Text + ",'" + txtboxresult3.Text + "')", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (MessageBox.Show("Marks uploaded successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
            {
                txtboxRegIT4.Text = "";
                
                lblsname4.Text = "_______________";
                lblBranch4.Text = "_______________";
                lblSemester4.Text = "_______________";
                txtboxDSUC.Text = "";
                txtboxCOM.Text = "";
                txtboxDCN.Text = "";
                txtboxIWT.Text = "";
                txtboxOOPCPP.Text = "";
                txtboxSSE.Text = "";
                txtboxSnl4.Text = "";
                txtboxresult3.Text = "";

            }
        
            else
            {
                MessageBox.Show("Marks already uploaded");
                
            }
    
        }
    }
}
