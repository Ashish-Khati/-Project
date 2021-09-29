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
    public partial class Teacher_Info : Form
    {
        public Teacher_Info()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gender = "";
            bool isChecked = rdobtnmale.Checked;
            if (isChecked)
            {
                gender = rdobtnmale.Text;
            }
            else
            {
                gender = rdobtnfemale.Text;
            }
            if (txtboxmn.Text.Length < 10)
            {
                MessageBox.Show("Invalid Mobile number", "Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2KHOCF\MYSQLSERVER;Initial Catalog=MyMinorProject;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into teacherinfo(Teacher_Name,Gender,DOJ,Qualification,Department,subject,mno,email,address) values ('" + txtboxtn.Text + "','" + gender + "','" + dateTimePickerDOJ.Text + "','" + txtboxq.Text + "','" + combodept.Text + "','" + txtboxsub.Text + "'," + txtboxmn.Text + ",'" + txtboxemail.Text + "','" + txtboxaddress.Text + "')", con);
                // SqlDataAdapter da = new SqlDataAdapter(cmd);
                //DataSet ds = new DataSet();
                //da.Fill(ds);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                this.Hide();

            }
        }

        private void txtboxemail_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z\.]*[a-zA-Z]$");
            if (txtboxemail.Text.Length > 0 && txtboxemail.Text.Trim().Length != 0)
            {
                if (!rEmail.IsMatch(txtboxemail.Text.Trim()))
                {
                    MessageBox.Show("Invalid email id format");
                    txtboxemail.SelectAll();
                    e.Cancel = true;
                }
            }
        }

        private void txtboxmn_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex ex = new System.Text.RegularExpressions.Regex("^[1-10]{10}");
            bool isvalid = ex.IsMatch(txtboxmn.Text);
            
            if (isvalid)
            {
                
                MessageBox.Show("Please enter valid mobile number");

            }
            else
            {

            }
        }

        private void txtboxsub_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerDOJ_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rdobtnfemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdobtnmale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void combodept_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtboxaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxmn_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxq_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtboxtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsLetter(ch))
            {
                e.Handled = false;
            }
            else if (ch == 8 || ch == 32 || ch == 46)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtboxq_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsLetter(ch))
            {
                e.Handled = false;
            }
            else if (ch == 8 || ch == 32 || ch == 46)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtboxsub_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtboxsub_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsLetter(ch))
            {
                e.Handled = false;
            }
            else if (ch == 8 || ch == 32 || ch == 46)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtboxmn_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsDigit(ch))
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            } 
        }

        private void Teacher_Info_Load(object sender, EventArgs e)
        {

        }
    }  
}
 