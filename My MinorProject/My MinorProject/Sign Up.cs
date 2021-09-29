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
    public partial class Sign_Up : Form
    {
        public Sign_Up()
        {
            InitializeComponent();
        }

        private void btnCAccount_Click(object sender, EventArgs e)
        {
            string usertype = comboboxUsertype.Text;
            string password = txtboxPassword.Text;
            string comfirmpass = txtboxconfirmPass.Text;
           /* if(usertype=="Admin")
            {
                if(txtboxPassword.Text==txtboxconfirmPass.Text)
                {
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2KHOCF\MYSQLSERVER;Initial Catalog=MyMinorProject;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand("Insert into Adminlogin values('" + txtboxusername.Text + "','" + txtboxPassword.Text + "','" + txtboxconfirmPass.Text + "')", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    MessageBox.Show("Account created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Password does not match,try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
            else
                if(usertype=="Teacher")
            {
                if (txtboxPassword.Text == txtboxconfirmPass.Text)
                {
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2KHOCF\MYSQLSERVER;Initial Catalog=MyMinorProject;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand("Insert into Teacherlogin values('" + txtboxusername.Text + "','" + txtboxPassword.Text + "','" + txtboxconfirmPass.Text + "')", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    MessageBox.Show("Account created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Password does not match,try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else*/
                 if (usertype == "Student")
            {
                if (txtboxPassword.Text == txtboxconfirmPass.Text)
                {
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2KHOCF\MYSQLSERVER;Initial Catalog=MyMinorProject;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand("Insert into Studentlogin values('" + txtboxusername.Text + "','" + txtboxPassword.Text + "','" + txtboxconfirmPass.Text + "')", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    MessageBox.Show("Account created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Admission_Form af = new Admission_Form();
                    af.Show();
              

                }
                else
                {
                    MessageBox.Show("Password does not match,try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtboxusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtboxconfirmPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboboxUsertype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtboxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxUseridSignup_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if(checkbxShowPass.Checked)
            {
                txtboxPassword.PasswordChar = '\0';
                txtboxconfirmPass.PasswordChar = '\0';
            }
                else
            {
                txtboxPassword.PasswordChar = '*';
                txtboxconfirmPass.PasswordChar = '*';
            }
        }

        private void Sign_Up_Load(object sender, EventArgs e)
        {

        }
    }
}
