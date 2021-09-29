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
    public partial class StudentDetailsformarks : Form
    {
        public StudentDetailsformarks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            string branch = lblBranch.Text;
            string semester = lblSem.Text;
            if(branch==lblBranch.Text&& semester=="1st Semester")
            {
                CSE_1st_Sem_Marks fsm = new CSE_1st_Sem_Marks();
                fsm.Show();
            }
            else if(branch==lblBranch.Text&& semester=="2nd Semester")
            {
                _2nd_sem_marks ssm = new _2nd_sem_marks();
                ssm.Show();
            }
            else
                if(branch=="Computer Science & Engineering"&& semester=="3rd Semester")
            {
                CSEthirdSemMarks cset = new CSEthirdSemMarks();
                cset.Show();
            }
            else
                if(branch=="Computer Science & Engineering"&& semester=="4th Semester")
            {
                CSEforthsemMarks csef = new CSEforthsemMarks();
                csef.Show();
            }
            else
                if(branch == "Computer Science & Engineering" && semester == "5th Semester")
                {
                CSEfifthsemMarks cseff = new CSEfifthsemMarks();
                cseff.Show();
                }
            else
                if (branch == "Computer Science & Engineering" && semester == "6th Semester")
                {
                CSESixthSemMarks cses = new CSESixthSemMarks();
                cses.Show();

                }
            else
                if(branch == "Information Technology" && semester == "3rd Semester")
            {
                ITthirdSemMarks itt = new ITthirdSemMarks();
                itt.Show();

            }
            else
                if(branch == "Information Technology" && semester == "4th Semester")
            {
                ITForthsemMarks itf = new ITForthsemMarks();
                itf.Show();
            }
            else
                if (branch == "Information Technology" && semester == "5th Semester")
            {
                ITfifthsemMarks itfi = new ITfifthsemMarks();
                itfi.Show();
            }
            else
                if (branch == "Information Technology" && semester == "6th Semester")
            {
                ITsixthSemMarks its = new ITsixthSemMarks();
                its.Show();
            }




        }

        private void txtboxReg_TextChanged(object sender, EventArgs e)
        {
            if (txtboxReg.Text != "")
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2KHOCF\MYSQLSERVER;Initial Catalog=MyMinorProject;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Branch,Semester from newadmission where NAID= " + txtboxReg.Text + "", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    lblBranch.Text = ds.Tables[0].Rows[0][0].ToString();
                    lblSem.Text = ds.Tables[0].Rows[0][1].ToString();
                   
                }
                else
                {

                    MessageBox.Show("No record found", "No Match", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                txtboxReg.Text = "";
                lblBranch.Text = "_______________";
                lblSem.Text = "_______________";
               
            }

        }
    }
}
