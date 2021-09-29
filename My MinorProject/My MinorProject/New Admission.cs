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
    public partial class Admission_Form : Form
    {
        public Admission_Form()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string sname = txtboxStudentname.Text;
            string fname = txtboxFathername.Text;
            string mname = txtboxMothername.Text;
            string gender = "";
            bool isChecked = radioButtonMale.Checked;
            if(isChecked)
            {
                gender = radioButtonMale.Text;

            }
            else
            {
                gender = radioButtonFemale.Text;
            }
            string dob = dateTimePickerDOB.Text;
            string ad = dateTimePickerAD.Text;
            string mnumber = txtboxMobileno.Text;
          
            string sem = txtSemester.Text;
            string branch = txtBranch.Text;
            string address = txtAddress.Text;
            string email = txtboxEmail.Text;

            if (txtboxMobileno.Text.Length < 10)
            {
                MessageBox.Show("Invalid Mobile number","Data",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            { 

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2KHOCF\MYSQLSERVER;Initial Catalog=MyMinorProject;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO newadmission (Student_Name,Father_Name,Mother_Name,Gender,DOB,Admission_Date,Mobile_Number,Semester,Branch,Address,Email_ID)values('" + sname + "','" + fname + "','" + mname + "','" + gender + "','" + dob + "','" + ad + "','" + mnumber + "','" + sem + "','" + branch + "','" + address + "','" + email + "')", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                MessageBox.Show("Data inserted successfully", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            }
          
            

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtboxStudentname.Clear();
            txtboxFathername.Clear();
            txtboxMothername.Clear();
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;


            txtboxMobileno.Clear();
            txtSemester.ResetText();
            txtBranch.ResetText();
            txtAddress.Clear();
            txtboxEmail.Clear();

        }

        private void Admission_Form_Load(object sender, EventArgs e)
        {
           
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtboxEmail_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z\.]*[a-zA-Z]$");
            if(txtboxEmail.Text.Length>0&& txtboxEmail.Text.Trim().Length!=0)
            {
                if(!rEmail.IsMatch(txtboxEmail.Text.Trim()))
                {
                    MessageBox.Show("Invalid email id format");
                    txtboxEmail.SelectAll();
                    e.Cancel = true;
                }
            }
        }

        private void txtboxMobileno_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex ex = new System.Text.RegularExpressions.Regex("^[1-10]<{10}");
            bool isvalid = ex.IsMatch(txtboxMobileno.Text);
            if(isvalid)
            {
                MessageBox.Show("Please enter valid mobile number");

            }
            else
            {

            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerAD_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtBranch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSemester_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerDOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtboxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxMobileno_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtboxMothername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxFathername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxStudentname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
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

        private void txtboxStudentname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(Char.IsLetter(ch))
            {
                e.Handled = false;
            }
            else if(ch==8 || ch==32|| ch==46)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtboxFathername_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsLetter(ch))
            {
                e.Handled = false;
            }
            else if (ch == 8 || ch==32||ch==46)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtboxMothername_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsLetter(ch))
            {
                e.Handled = false;
            }
            else if (ch == 8|| ch==32||ch==46)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtboxMobileno_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtboxMobileno_Validated(object sender, EventArgs e)
        {

        }
    }
}
