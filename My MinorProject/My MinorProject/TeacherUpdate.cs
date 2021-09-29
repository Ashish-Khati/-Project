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
    public partial class TeacherUpdate : Form
    {
        public TeacherUpdate()
        {
            InitializeComponent();
        }

        private void TeacherUpdate_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2KHOCF\MYSQLSERVER;Initial Catalog=MyMinorProject;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select *from teacherinfo", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgv.DataSource = ds.Tables[0];
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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

                SqlCommand cmd = new SqlCommand("update teacherinfo set  Teacher_Name='" + txtboxtn.Text + "', Gender='" + gender + "', DOJ='" + dateTimePickerDOJ.Text + "', Qualification='" + txtboxq.Text + "',Department='" + combodept.Text + "', subject='" + txtboxsub.Text + "', mno=" + txtboxmn.Text + ", email='" + txtboxemail.Text + "', address='" + txtboxaddress.Text + "' where tid=" + textBox1.Text + "", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                MessageBox.Show("Data updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
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
    }
}
