namespace My_MinorProject
{
    partial class TeacherUpdate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtboxsub = new System.Windows.Forms.TextBox();
            this.dateTimePickerDOJ = new System.Windows.Forms.DateTimePicker();
            this.rdobtnfemale = new System.Windows.Forms.RadioButton();
            this.rdobtnmale = new System.Windows.Forms.RadioButton();
            this.combodept = new System.Windows.Forms.ComboBox();
            this.txtboxaddress = new System.Windows.Forms.RichTextBox();
            this.txtboxemail = new System.Windows.Forms.TextBox();
            this.txtboxmn = new System.Windows.Forms.TextBox();
            this.txtboxq = new System.Windows.Forms.TextBox();
            this.txtboxtn = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxsub
            // 
            this.txtboxsub.Location = new System.Drawing.Point(216, 475);
            this.txtboxsub.Name = "txtboxsub";
            this.txtboxsub.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtboxsub.Size = new System.Drawing.Size(279, 22);
            this.txtboxsub.TabIndex = 45;
            this.txtboxsub.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxsub_KeyPress);
            // 
            // dateTimePickerDOJ
            // 
            this.dateTimePickerDOJ.Location = new System.Drawing.Point(216, 318);
            this.dateTimePickerDOJ.Name = "dateTimePickerDOJ";
            this.dateTimePickerDOJ.Size = new System.Drawing.Size(267, 22);
            this.dateTimePickerDOJ.TabIndex = 43;
            // 
            // rdobtnfemale
            // 
            this.rdobtnfemale.AutoSize = true;
            this.rdobtnfemale.Location = new System.Drawing.Point(366, 262);
            this.rdobtnfemale.Name = "rdobtnfemale";
            this.rdobtnfemale.Size = new System.Drawing.Size(75, 21);
            this.rdobtnfemale.TabIndex = 42;
            this.rdobtnfemale.TabStop = true;
            this.rdobtnfemale.Text = "Female";
            this.rdobtnfemale.UseVisualStyleBackColor = true;
            // 
            // rdobtnmale
            // 
            this.rdobtnmale.AutoSize = true;
            this.rdobtnmale.Location = new System.Drawing.Point(229, 260);
            this.rdobtnmale.Name = "rdobtnmale";
            this.rdobtnmale.Size = new System.Drawing.Size(59, 21);
            this.rdobtnmale.TabIndex = 41;
            this.rdobtnmale.TabStop = true;
            this.rdobtnmale.Text = "Male";
            this.rdobtnmale.UseVisualStyleBackColor = true;
            // 
            // combodept
            // 
            this.combodept.FormattingEnabled = true;
            this.combodept.Items.AddRange(new object[] {
            "Computer Science & Engineering",
            "Information Technology",
            "Machanical Engineering",
            "Civil Engineering",
            "AutoMobile Engineering",
            "Electronic Engineering",
            "Electrical Engineering",
            "Parmacy"});
            this.combodept.Location = new System.Drawing.Point(216, 429);
            this.combodept.Name = "combodept";
            this.combodept.Size = new System.Drawing.Size(267, 24);
            this.combodept.TabIndex = 40;
            this.combodept.Text = "--Select--";
            // 
            // txtboxaddress
            // 
            this.txtboxaddress.Location = new System.Drawing.Point(671, 268);
            this.txtboxaddress.Name = "txtboxaddress";
            this.txtboxaddress.Size = new System.Drawing.Size(279, 72);
            this.txtboxaddress.TabIndex = 39;
            this.txtboxaddress.Text = "";
            // 
            // txtboxemail
            // 
            this.txtboxemail.Location = new System.Drawing.Point(671, 205);
            this.txtboxemail.Name = "txtboxemail";
            this.txtboxemail.Size = new System.Drawing.Size(279, 22);
            this.txtboxemail.TabIndex = 38;
            this.txtboxemail.Validating += new System.ComponentModel.CancelEventHandler(this.txtboxemail_Validating);
            // 
            // txtboxmn
            // 
            this.txtboxmn.Location = new System.Drawing.Point(216, 541);
            this.txtboxmn.MaxLength = 10;
            this.txtboxmn.Name = "txtboxmn";
            this.txtboxmn.Size = new System.Drawing.Size(279, 22);
            this.txtboxmn.TabIndex = 37;
            this.txtboxmn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxmn_KeyPress);
            // 
            // txtboxq
            // 
            this.txtboxq.Location = new System.Drawing.Point(216, 367);
            this.txtboxq.Name = "txtboxq";
            this.txtboxq.Size = new System.Drawing.Size(267, 22);
            this.txtboxq.TabIndex = 36;
            this.txtboxq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxq_KeyPress);
            // 
            // txtboxtn
            // 
            this.txtboxtn.Location = new System.Drawing.Point(229, 203);
            this.txtboxtn.Name = "txtboxtn";
            this.txtboxtn.Size = new System.Drawing.Size(254, 22);
            this.txtboxtn.TabIndex = 35;
            this.txtboxtn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxtn_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Yellow;
            this.label10.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(34, 481);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 29);
            this.label10.TabIndex = 34;
            this.label10.Text = "Subject";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Yellow;
            this.label9.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(511, 266);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 29);
            this.label9.TabIndex = 33;
            this.label9.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Yellow;
            this.label8.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 431);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 29);
            this.label8.TabIndex = 32;
            this.label8.Text = "Department";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Yellow;
            this.label7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 369);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 29);
            this.label7.TabIndex = 31;
            this.label7.Text = "Oualification";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Yellow;
            this.label6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(511, 204);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 29);
            this.label6.TabIndex = 30;
            this.label6.Text = "Email ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Yellow;
            this.label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 540);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 29);
            this.label5.TabIndex = 29;
            this.label5.Text = "Mobile No.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 317);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 29);
            this.label4.TabIndex = 28;
            this.label4.Text = "D.O.J";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 261);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 29);
            this.label3.TabIndex = 27;
            this.label3.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 202);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 29);
            this.label2.TabIndex = 26;
            this.label2.Text = "Teacher Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkBlue;
            this.label13.Location = new System.Drawing.Point(399, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(436, 53);
            this.label13.TabIndex = 57;
            this.label13.Text = "Update Teacher Details";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(423, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 22);
            this.textBox1.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 29);
            this.label1.TabIndex = 58;
            this.label1.Text = "Teacher ID";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(583, 654);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 36);
            this.btnUpdate.TabIndex = 60;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(956, 90);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(511, 610);
            this.dgv.TabIndex = 62;
            // 
            // TeacherUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1479, 744);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtboxsub);
            this.Controls.Add(this.dateTimePickerDOJ);
            this.Controls.Add(this.rdobtnfemale);
            this.Controls.Add(this.rdobtnmale);
            this.Controls.Add(this.combodept);
            this.Controls.Add(this.txtboxaddress);
            this.Controls.Add(this.txtboxemail);
            this.Controls.Add(this.txtboxmn);
            this.Controls.Add(this.txtboxq);
            this.Controls.Add(this.txtboxtn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "TeacherUpdate";
            this.Text = "TeacherUpdate";
            this.Load += new System.EventHandler(this.TeacherUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxsub;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOJ;
        private System.Windows.Forms.RadioButton rdobtnfemale;
        private System.Windows.Forms.RadioButton rdobtnmale;
        private System.Windows.Forms.ComboBox combodept;
        private System.Windows.Forms.RichTextBox txtboxaddress;
        private System.Windows.Forms.TextBox txtboxemail;
        private System.Windows.Forms.TextBox txtboxmn;
        private System.Windows.Forms.TextBox txtboxq;
        private System.Windows.Forms.TextBox txtboxtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgv;
    }
}