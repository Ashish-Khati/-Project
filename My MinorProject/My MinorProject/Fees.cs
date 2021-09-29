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
    public partial class Fees : Form
    {
        public Fees()
        {
            InitializeComponent();
        }

        private void txtboxRegistration_TextChanged(object sender, EventArgs e)
        {
           



            if (txtboxRegistration.Text!="")
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2KHOCF\MYSQLSERVER;Initial Catalog=MyMinorProject;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Student_Name,Father_Name,Mother_Name,Semester from newadmission where NAID= "+ txtboxRegistration.Text + "", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if(ds.Tables[0].Rows.Count!=0)
                {
                    snameLabel.Text = ds.Tables[0].Rows[0][0].ToString();
                    fnameLabel.Text = ds.Tables[0].Rows[0][1].ToString();
                    mnameLabel.Text = ds.Tables[0].Rows[0][2].ToString();
                    semLabel.Text = ds.Tables[0].Rows[0][3].ToString();
                }
                else
                {
                    snameLabel.Text = "_______________";
                    fnameLabel.Text = "_______________";
                    mnameLabel.Text = "_______________";
                    semLabel.Text = "_______________";
                }

            }
            else
            {
                txtboxRegistration.Text = "";
                txtboxFees.Text = "";
                snameLabel.Text = "_______________";
                fnameLabel.Text = "_______________";
                mnameLabel.Text = "_______________";
                semLabel.Text = "_______________";
            }
               
            }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2KHOCF\MYSQLSERVER;Initial Catalog=MyMinorProject;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT *from fees where NAID=" + txtboxRegistration.Text + "", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if(ds.Tables[0].Rows.Count==0)
            {

                SqlConnection con1 = new SqlConnection(@"Data Source=DESKTOP-B2KHOCF\MYSQLSERVER;Initial Catalog=MyMinorProject;Integrated Security=True");
                con1.Open();
                SqlCommand cmd1 = new SqlCommand("insert into fees(NAID,fees)values(" + txtboxRegistration.Text + "," + txtboxFees.Text + ")", con1);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                if (MessageBox.Show("Fess Submition Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
                {
                    txtboxRegistration.Text = "";
                    txtboxFees.Text = "";
                    snameLabel.Text = "_______________";
                    fnameLabel.Text = "_______________";
                    mnameLabel.Text = "_______________";
                    semLabel.Text = "_______________";
                }
            }
            else
            {
                MessageBox.Show("Fees is already Submitted");
                txtboxRegistration.Text = "";
                txtboxFees.Text = "";
                snameLabel.Text = "_______________";
                fnameLabel.Text = "_______________";
                mnameLabel.Text = "_______________";
                semLabel.Text = "_______________";
            }





        }

        private void txtboxFees_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
