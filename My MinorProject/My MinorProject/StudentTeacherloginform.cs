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
    public partial class StudentTeacherloginform : Form
    {
        public StudentTeacherloginform()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Userid = txtboxUserid.Text;
            string password = txtboxPassword.Text;
            string usertype = comboboxUsertype.Text;
            if (usertype == "Teacher")
            {
                SqlConnection con1 = new SqlConnection(@"Data Source=DESKTOP-B2KHOCF\MYSQLSERVER;Initial Catalog=MyMinorProject;Integrated Security=True");
                SqlCommand cmd1 = new SqlCommand("Select Login_Id,Password ,Confirm_Password from teacherlogin where login_Id=" + txtboxUserid.Text + "", con1);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                if (ds1.Tables[0].Rows.Count != 0)
                {
                    if (Userid == ds1.Tables[0].Rows[0][0].ToString() && password == ds1.Tables[0].Rows[0][1].ToString())
                    {
                        Teacher_interface ti = new Teacher_interface();
                        ti.Show();
                        this.Hide();
                    }
                    else
                        if (password != ds1.Tables[0].Rows[0][2].ToString())
                    {
                        MessageBox.Show("Incorrect password!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("This userid don't exist ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (usertype == "Student")
            {
                SqlConnection con2 = new SqlConnection(@"Data Source=DESKTOP-B2KHOCF\MYSQLSERVER;Initial Catalog=MyMinorProject;Integrated Security=True");
                SqlCommand cmd2 = new SqlCommand("Select Login_Id,Password ,Confirm_Password from studentlogin where login_Id=" + txtboxUserid.Text + "", con2);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataSet ds2 = new DataSet();
                da2.Fill(ds2);
                if (ds2.Tables[0].Rows.Count != 0)
                {
                    if (Userid == ds2.Tables[0].Rows[0][0].ToString() && password == ds2.Tables[0].Rows[0][1].ToString())
                    {
                        Student_interface Si = new Student_interface();
                        Si.Show();
                        this.Hide();
                    }
                    else
                        if (password != ds2.Tables[0].Rows[0][2].ToString())
                    {
                        MessageBox.Show("Incorrect password!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("This userid don't exist ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string Userid = txtboxUserid.Text;
            string password = txtboxPassword.Text;
            string usertype = comboboxUsertype.Text;
            if (usertype == "Teacher")
            {
                SqlConnection con1 = new SqlConnection(@"Data Source=DESKTOP-B2KHOCF\MYSQLSERVER;Initial Catalog=MyMinorProject;Integrated Security=True");
                SqlCommand cmd1 = new SqlCommand("Select Login_Id,Password ,Confirm_Password from teacherlogin where login_Id='" + txtboxUserid.Text + "'", con1);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                if (ds1.Tables[0].Rows.Count != 0)
                {
                    if (Userid == ds1.Tables[0].Rows[0][0].ToString() && password == ds1.Tables[0].Rows[0][1].ToString())
                    {
                        Teacher_interface ti = new Teacher_interface();
                        ti.Show();
                    }
                    else
                        if (password != ds1.Tables[0].Rows[0][2].ToString())
                    {
                        MessageBox.Show("Incorrect password!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("This userid don't exist ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (usertype == "Student")
            {
                SqlConnection con2 = new SqlConnection(@"Data Source=DESKTOP-B2KHOCF\MYSQLSERVER;Initial Catalog=MyMinorProject;Integrated Security=True");
                SqlCommand cmd2 = new SqlCommand("Select Login_Id,Password ,Confirm_Password from studentlogin where login_Id=" + txtboxUserid.Text + "", con2);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataSet ds2 = new DataSet();
                da2.Fill(ds2);
                if (ds2.Tables[0].Rows.Count != 0)
                {
                    if (Userid == ds2.Tables[0].Rows[0][0].ToString() && password == ds2.Tables[0].Rows[0][1].ToString())
                    {
                        Student_interface Si = new Student_interface();
                        Si.Show();
                        this.Hide();
                    }
                    else
                        if (password != ds2.Tables[0].Rows[0][2].ToString())
                    {
                        MessageBox.Show("Incorrect password!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("This userid don't exist ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtboxUserid_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtboxUserid.Clear();
            txtboxPassword.Clear();
            comboboxUsertype.ResetText();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                txtboxPassword.PasswordChar = '\0';
            }
            else
            {
                txtboxPassword.PasswordChar = '*';
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
