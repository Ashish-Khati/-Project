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
    public partial class IndividualDetails : Form
    {
        public IndividualDetails()
        {
            InitializeComponent();
        }

        private void txtboxRegNo_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2KHOCF\MYSQLSERVER;Initial Catalog=MyMinorProject;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT *from newadmission where NAID=" + txtboxRegNo.Text + "", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if(ds.Tables[0].Rows.Count!=0)
            {
                lblsn.Text = ds.Tables[0].Rows[0][1].ToString();
                lblfn.Text = ds.Tables[0].Rows[0][2].ToString();
                lblmn.Text = ds.Tables[0].Rows[0][3].ToString();
                lblgen.Text = ds.Tables[0].Rows[0][4].ToString();
                lbldob.Text = ds.Tables[0].Rows[0][5].ToString();
                lblad.Text = ds.Tables[0].Rows[0][6].ToString();
                lblmno.Text = ds.Tables[0].Rows[0][7].ToString();
                lblsem.Text = ds.Tables[0].Rows[0][8].ToString();
                lblbranch.Text = ds.Tables[0].Rows[0][9].ToString();
                lbladd.Text = ds.Tables[0].Rows[0][10].ToString();
                lblemail.Text = ds.Tables[0].Rows[0][11].ToString();
            }

            else
            {
                MessageBox.Show("No record found", "No Match", MessageBoxButtons.OK,MessageBoxIcon.Error);

            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtboxRegNo.Text = "";
            lblsn.Text = "_______________";
            lblfn.Text = "_______________";
            lblmn.Text = "_______________";
            lblgen.Text = "_______________";
            lbldob.Text = "_______________";
            lblad.Text = "_______________";
            lblmno.Text = "_______________";
            lblsem.Text = "_______________";
            lblbranch.Text = "_______________";
            lbladd.Text = "_______________";
            lblemail.Text = "_______________";

        }
    }
}
        
    

