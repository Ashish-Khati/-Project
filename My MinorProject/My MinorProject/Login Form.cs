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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            menuStrip1.Visible = true;

        }

    /*    private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if(username=="Ashish"&&password=="123")
            {
                menuStrip1.Visible = true;
                panel1.Visible = false;

            }
            else
            {
                MessageBox.Show("Invalid username or password,plese enter valid username or password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                

            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You want to Exit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)==DialogResult.OK)
            {

                Application.Exit();
            }
            else
            {
                panel1.Visible = true;
            }
        }*/

        private void newAdmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sign_Up su = new Sign_Up();
            su.Show();

          //  Admission_Form na = new Admission_Form();
            //na.Show();
        }

        private void upgradeSemesterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Upgrade_Sem us = new Upgrade_Sem();
            us.Show();
        }

        private void feesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminFeesViews afv = new AdminFeesViews();
            afv.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show("You want to Exit", "@", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void byRegistrationNoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search_Student ssr = new Search_Student();
            ssr.Show();
        }

        private void byNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search_Student_By_Name ssbn = new Search_Student_By_Name();
            ssbn.Show();
        }

        private void bySemesterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search_By_Semester sbs = new Search_By_Semester();
            sbs.Show();
        }

        private void byBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search_by_Branch sbb = new Search_by_Branch();
            sbb.Show();
        }

        private void individualDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IndividualDetails id = new IndividualDetails();
            id.Show();
        }

        private void addTeacherInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teachersignup tsu = new Teachersignup();
            tsu.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void byTeacherIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teacher_Search ts = new Teacher_Search();
            ts.Show();
        }

        private void byNameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Search_Teacher_By_Name stbn = new Search_Teacher_By_Name();
            stbn.Show();
        }

        private void byBranchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Search_Teacher_By_Branch stbb = new Search_Teacher_By_Branch();
            stbb.Show();
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentDetailsformarks sdfm = new StudentDetailsformarks();
            sdfm.Show();
        }

        private void panelinfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usertype ut = new Usertype();
            ut.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void byRegistrationNoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Remove rmv = new Remove();
            rmv.Show();
        }

        private void studentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Remove rmv = new Remove();
            rmv.Show();
        }

        private void byRegistrationNoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Search_Student ss = new Search_Student();
            ss.Show();
        }

        private void byNameToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Search_Student_By_Name ssbn=new Search_Student_By_Name();
        }

        private void bySemesterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Search_By_Semester sbs = new Search_By_Semester();
            sbs.Show();
        }

        private void byBranchToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Search_by_Branch sbb = new Search_by_Branch();
            sbb.Show();
        }

        private void byTeacherIDToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Teacher_Search st = new Teacher_Search();
            st.Show();
        }

        private void byNameToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Search_Teacher_By_Name stbn = new Search_Teacher_By_Name();
            stbn.Show();
        }

        private void byBranchToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Search_Teacher_By_Branch stbb = new Search_Teacher_By_Branch();
            stbb.Show();
        }

        private void teacherToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Remove_Teacher rt = new Remove_Teacher();
            rt.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Studentupdate su = new Studentupdate();
            su.Show();
        }

        private void teacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherUpdate tu = new TeacherUpdate();
            tu.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Usertype ut = new Usertype();
            ut.Show();
            this.Hide();
        }
    }
}
