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
    public partial class Student_interface : Form
    {
        public Student_interface()
        {
            InitializeComponent();
        }

        private void admissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fees f = new Fees();
            f.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void studentDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IndividualDetails id = new IndividualDetails();
            id.Show();
                

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usertype ut = new Usertype();
            ut.Show();
            this.Hide();
        }
    }
}
