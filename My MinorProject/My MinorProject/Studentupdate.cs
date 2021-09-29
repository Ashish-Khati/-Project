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
    public partial class Studentupdate : Form
    {
        public Studentupdate()
        {
            InitializeComponent();
        }

        private void Studentupdate_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2KHOCF\MYSQLSERVER;Initial Catalog=MyMinorProject;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select *from newadmission",con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgv.DataSource = ds.Tables[0];
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sname = txtboxStudentname.Text;
            string fname = txtboxFathername.Text;
            string mname = txtboxMothername.Text;
            string gender = "";
            bool isChecked = radioButtonMale.Checked;
            if (isChecked)
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
                MessageBox.Show("Invalid Mobile number", "Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

            


            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2KHOCF\MYSQLSERVER;Initial Catalog=MyMinorProject;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update  newadmission set Student_Name='" + sname + "',Father_Name='" + fname + "',Mother_Name='" + mname + "',Gender='" + gender + "', DOB='" + dob + "', Admission_Date='" + ad + "', Mobile_Number='" + mnumber + "', Semester='" + sem + "', Branch='" + branch + "', Address='" + address + "', Email_ID='" + email + "' where NAID=" + txtbox.Text + "", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            MessageBox.Show("Data updated successfully", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtboxStudentname_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtboxStudentname_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtboxFathername_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtboxMothername_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
