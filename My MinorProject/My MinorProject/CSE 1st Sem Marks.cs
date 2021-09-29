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
    public partial class CSE_1st_Sem_Marks : Form
    {
        public CSE_1st_Sem_Marks()
        {
            InitializeComponent();
        }

        private void CSE_1st_Sem_Marks_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2KHOCF\MYSQLSERVER;Initial Catalog=MyMinorProject;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into firstsemmarks values(" + txtboxReg.Text + ",'" + lblsname.Text + "','" + lblBranch.Text + "','" + lblSemester.Text + "'," + txtboxEnglish.Text + "," + txtboxMaths.Text + "," + txtboxPhysics.Text + "," + txtboxChemistry.Text + ","+txtboxBIT.Text+"," + txtboxED.Text + "," + txtboxSnl.Text + ",'" + txtboxResult.Text + "')", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (MessageBox.Show("Marks uploaded successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
            {
                txtboxReg.Text = "";

                lblsname.Text = "_______________";
                lblBranch.Text = "_______________";
                lblSemester.Text = "_______________";
                txtboxEnglish.Text = "";
                txtboxBIT.Text = "";
                txtboxChemistry.Text = "";
                txtboxED.Text = "";
                txtboxMaths.Text = "";
                txtboxPhysics.Text = "";
                 txtboxResult.Text = "";
                txtboxSnl.Text = "";

            }

            else
            {
                MessageBox.Show("Marks already uploaded");

            }

        }

        private void txtboxReg_TextChanged(object sender, EventArgs e)
        {
            if (txtboxReg.Text != "")
            {
                
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2KHOCF\MYSQLSERVER;Initial Catalog=MyMinorProject;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT student_name, Branch,Semester from newadmission where NAID= " + txtboxReg.Text + "", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
               
                
                    if (ds.Tables[0].Rows.Count != 0)
                    {
                        lblsname.Text = ds.Tables[0].Rows[0][0].ToString();
                        lblBranch.Text = ds.Tables[0].Rows[0][1].ToString();
                        lblSemester.Text = ds.Tables[0].Rows[0][2].ToString();
                    if(lblSemester.Text!="1st Semester")
                    {
                        MessageBox.Show("This student not from 1st Semester", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        CSE_1st_Sem_Marks cfsm = new CSE_1st_Sem_Marks();
                        //  Application.Exit();
                        cfsm.Visible=true;
                    }


                    }
                    else
                    {

                        MessageBox.Show("No record found", "No Match", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
            else
                {
                    txtboxReg.Text = "";
                    lblsname.Text = "__________";
                    lblBranch.Text = "_______________";
                    lblSemester.Text = "_______________";

                }
            }
             
        }
    }

    

