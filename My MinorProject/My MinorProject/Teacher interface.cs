using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_MinorProject
{
    public partial class Teacher_interface : Form
    {
        public Teacher_interface()
        {
            InitializeComponent();
          
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You want to Exit", "@", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void newAdmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sign_Up su = new Sign_Up();
            su.Show();
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

        private void studentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
            Search_Student_By_Name ssbna = new Search_Student_By_Name();
            ssbna.Show();
        }

        private void byBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search_by_Branch sbba = new Search_by_Branch();
            sbba.Show();
        }

        private void bySemesterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search_By_Semester sbsa = new Search_By_Semester();
            sbsa.Show();
        }

        private void individualSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IndividualDetails ida = new IndividualDetails();
            ida.Show();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Remove rma = new Remove();
            rma.Show();

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Studentupdate su = new Studentupdate();
            su.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usertype ut = new Usertype();
            ut.Show();
            this.Hide();
        }

        private void Teacher_interface_Load(object sender, EventArgs e)
        {

        }
    }
}
