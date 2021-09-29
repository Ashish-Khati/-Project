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
    public partial class ITfifthsemMarks : Form
    {
        public ITfifthsemMarks()
        {
            InitializeComponent();
        }

        private void txtboxRegIT5_TextChanged(object sender, EventArgs e)
        {
            if (txtboxRegIT5.Text != "")
            {

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2KHOCF\MYSQLSERVER;Initial Catalog=MyMinorProject;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT student_name, Branch,Semester from newadmission where NAID= " + txtboxRegIT5.Text + "", con);
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

                    }


                }
                else
                {

                    MessageBox.Show("No record found", "No Match", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                txtboxRegIT5.Text = "";
                lblsname5.Text = "__________";
                lblBranch5.Text = "_______________";
                lblSemester5.Text = "_______________";

            }

        }

        private void btnupdate3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2KHOCF\MYSQLSERVER;Initial Catalog=MyMinorProject;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into sixthsemmarksCSE values(" + txtboxRegIT5.Text + ",'" + lblsname5.Text + "','" + lblBranch5.Text + "','" + lblSemester5.Text + "'," + txtboxRDBMS.Text + "," + txtboxJP.Text + "," + txtboxEC.Text + "," + txtboxCNS.Text + "," + txtboxSQT.Text + "," + txtboxEDM.Text + "," + txtboxSnl5.Text + ",'" + txtboxresult2.Text + "')", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (MessageBox.Show("Marks uploaded successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
            {
                txtboxRegIT5.Text = "";

                lblsname5.Text = "_______________";
                lblBranch5.Text = "_______________";
                lblSemester5.Text = "_______________";
                txtboxCNS.Text = "";
                txtboxEC.Text = "";
                txtboxEDM.Text = "";
                txtboxJP.Text = "";
                txtboxMIP.Text = "";
                txtboxRDBMS.Text = "";
                txtboxSnl5.Text = "";
                txtboxresult2.Text = "";
                txtboxSQT.Text = "";
               

            }

            else
            {
                MessageBox.Show("Marks already uploaded");

            }

        }
    }
}
