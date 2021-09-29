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
    public partial class Usertype : Form
    {
        public Usertype()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBoxusertype.Text=="Admin")
            {
                First_Login_Form flf = new First_Login_Form();
                    flf.Show();
                this.Hide();
            }
            else
                if(comboBoxusertype.Text=="Student"||comboBoxusertype.Text=="Teacher")
            {
                StudentTeacherloginform stlf = new StudentTeacherloginform();
                stlf.Show();
                this.Hide();
            }
        }
    }
}
