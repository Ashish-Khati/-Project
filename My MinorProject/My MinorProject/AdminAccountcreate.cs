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
    public partial class AdminAccountcreate : Form
    {
        public AdminAccountcreate()
        {
            InitializeComponent();
        }

        private void btnCAccount_Click(object sender, EventArgs e)
        {
            string usertype = comboboxUsertype.Text;
            string password = txtboxPassword.Text;
            string comfirmpass = txtboxconfirmPass.Text;
            if(usertype=="Admin")
            {
                if(txtboxPassword.Text==txtboxconfirmPass.Text)
                {
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2KHOCF\MYSQLSERVER;Initial Catalog=MyMinorProject;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand("Insert into Adminlogin values('" + txtboxusername.Text + "','" + txtboxPassword.Text + "','" + txtboxconfirmPass.Text + "')", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    MessageBox.Show("Account created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Password does not match,try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
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
