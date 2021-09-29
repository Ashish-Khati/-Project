namespace My_MinorProject
{
    partial class Sign_Up
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboboxUsertype = new System.Windows.Forms.ComboBox();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.txtboxUseridSignup = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxconfirmPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCAccount = new System.Windows.Forms.Button();
            this.txtboxusername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkbxShowPass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Font = new System.Drawing.Font("MV Boli", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SpringGreen;
            this.label1.Location = new System.Drawing.Point(190, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(605, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = " Create student account";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboboxUsertype
            // 
            this.comboboxUsertype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboboxUsertype.FormattingEnabled = true;
            this.comboboxUsertype.Items.AddRange(new object[] {
            "Student"});
            this.comboboxUsertype.Location = new System.Drawing.Point(309, 152);
            this.comboboxUsertype.Name = "comboboxUsertype";
            this.comboboxUsertype.Size = new System.Drawing.Size(192, 30);
            this.comboboxUsertype.TabIndex = 1;
            this.comboboxUsertype.SelectedIndexChanged += new System.EventHandler(this.comboboxUsertype_SelectedIndexChanged);
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxPassword.Location = new System.Drawing.Point(310, 348);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.PasswordChar = '*';
            this.txtboxPassword.Size = new System.Drawing.Size(192, 28);
            this.txtboxPassword.TabIndex = 4;
            this.txtboxPassword.TextChanged += new System.EventHandler(this.txtboxPassword_TextChanged);
            // 
            // txtboxUseridSignup
            // 
            this.txtboxUseridSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxUseridSignup.Location = new System.Drawing.Point(310, 217);
            this.txtboxUseridSignup.Name = "txtboxUseridSignup";
            this.txtboxUseridSignup.Size = new System.Drawing.Size(192, 28);
            this.txtboxUseridSignup.TabIndex = 2;
            this.txtboxUseridSignup.TextChanged += new System.EventHandler(this.txtboxUseridSignup_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "User Type";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "UserID";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtboxconfirmPass
            // 
            this.txtboxconfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxconfirmPass.Location = new System.Drawing.Point(310, 416);
            this.txtboxconfirmPass.Name = "txtboxconfirmPass";
            this.txtboxconfirmPass.PasswordChar = '*';
            this.txtboxconfirmPass.Size = new System.Drawing.Size(192, 28);
            this.txtboxconfirmPass.TabIndex = 5;
            this.txtboxconfirmPass.TextChanged += new System.EventHandler(this.txtboxconfirmPass_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-6, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(293, 31);
            this.label5.TabIndex = 13;
            this.label5.Text = "Confirm Password";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnCAccount
            // 
            this.btnCAccount.BackColor = System.Drawing.Color.LightCoral;
            this.btnCAccount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCAccount.Location = new System.Drawing.Point(658, 525);
            this.btnCAccount.Name = "btnCAccount";
            this.btnCAccount.Size = new System.Drawing.Size(351, 43);
            this.btnCAccount.TabIndex = 8;
            this.btnCAccount.Text = "CREATE ACCOUNT";
            this.btnCAccount.UseVisualStyleBackColor = false;
            this.btnCAccount.Click += new System.EventHandler(this.btnCAccount_Click);
            // 
            // txtboxusername
            // 
            this.txtboxusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxusername.Location = new System.Drawing.Point(305, 279);
            this.txtboxusername.Name = "txtboxusername";
            this.txtboxusername.Size = new System.Drawing.Size(192, 28);
            this.txtboxusername.TabIndex = 3;
            this.txtboxusername.TextChanged += new System.EventHandler(this.txtboxusername_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 31);
            this.label6.TabIndex = 16;
            this.label6.Text = "Username";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // checkbxShowPass
            // 
            this.checkbxShowPass.AutoSize = true;
            this.checkbxShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkbxShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkbxShowPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbxShowPass.Location = new System.Drawing.Point(432, 462);
            this.checkbxShowPass.Name = "checkbxShowPass";
            this.checkbxShowPass.Size = new System.Drawing.Size(138, 21);
            this.checkbxShowPass.TabIndex = 21;
            this.checkbxShowPass.Text = "Show Password";
            this.checkbxShowPass.UseVisualStyleBackColor = true;
            this.checkbxShowPass.CheckedChanged += new System.EventHandler(this.checkbxShowPass_CheckedChanged);
            // 
            // Sign_Up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1033, 580);
            this.Controls.Add(this.checkbxShowPass);
            this.Controls.Add(this.txtboxusername);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCAccount);
            this.Controls.Add(this.txtboxconfirmPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboboxUsertype);
            this.Controls.Add(this.txtboxPassword);
            this.Controls.Add(this.txtboxUseridSignup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sign_Up";
            this.Text = "Sign_Up";
            this.Load += new System.EventHandler(this.Sign_Up_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboboxUsertype;
        private System.Windows.Forms.TextBox txtboxPassword;
        private System.Windows.Forms.TextBox txtboxUseridSignup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxconfirmPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCAccount;
        private System.Windows.Forms.TextBox txtboxusername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkbxShowPass;
    }
}