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
    public partial class Teachersignup : Form
    {
        public Teachersignup()
        {
            InitializeComponent();
        }

        private void btnCAccount_Click(object sender, EventArgs e)
        {
            string usertype = comboboxUsertype.Text;

            if (usertype == "Teacher")
            {
                if (txtboxPassword.Text == txtboxconfirmPass.Text)
                {
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2KHOCF\MYSQLSERVER;Initial Catalog=MyMinorProject;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand("Insert into Teacherlogin values('" + txtboxusername.Text + "','" + txtboxPassword.Text + "','" + txtboxconfirmPass.Text + "')", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    MessageBox.Show("Account created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Teacher_Info ti = new Teacher_Info();
                    ti.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Password does not match,try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void checkbxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(checkbxShowPassword.Checked)
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
    }
}
