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
    public partial class First_Login_Form : Form
    {
        public First_Login_Form()
        {
            InitializeComponent();
            int i = 1;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
             string Userid =txtboxUserid.Text ;
            string password = txtboxPassword.Text;
            string usertype = comboboxUsertype.Text;
           

            if(usertype=="Admin")
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2KHOCF\MYSQLSERVER;Initial Catalog=MyMinorProject;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("Select Login_Id,Password ,Confirm_Password from Adminlogin where login_Id=" + txtboxUserid.Text + "", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    if (Userid == ds.Tables[0].Rows[0][0].ToString()&&password==ds.Tables[0].Rows[0][1].ToString())
                    {
                        Form1 f1 = new Form1();
                        f1.Show();
                        this.Hide();
                    }
                    else
                        if(password!=ds.Tables[0].Rows[0][2].ToString())
                    {
                        MessageBox.Show("Incorrect password!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                  
                }
                else
                {
                    MessageBox.Show("This userid don't exist ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
              
           
            if (usertype=="Teacher")
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
            if(usertype=="Student")
            {
                SqlConnection con2 = new SqlConnection(@"Data Source=DESKTOP-B2KHOCF\MYSQLSERVER;Initial Catalog=MyMinorProject;Integrated Security=True");
                SqlCommand cmd2 = new SqlCommand("Select Login_Id,Password ,Confirm_Password from teacherlogin where login_Id=" + txtboxUserid.Text + "", con2);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataSet ds2 = new DataSet();
                da2.Fill(ds2);
                if (ds2.Tables[0].Rows.Count != 0)
                {
                    if (Userid == ds2.Tables[0].Rows[0][0].ToString() && password == ds2.Tables[0].Rows[0][1].ToString())
                    {
                        Student_interface Si = new Student_interface();
                        Si.Show();
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

        private void lblCreateAccount_Click(object sender, EventArgs e)
        {
            AdminAccountcreate aac = new AdminAccountcreate();
            aac.Show();
        }

        private void First_Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtboxUserid.Clear();
            txtboxPassword.Clear();
            comboboxUsertype.ResetText();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtboxUserid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboboxUsertype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
} 
