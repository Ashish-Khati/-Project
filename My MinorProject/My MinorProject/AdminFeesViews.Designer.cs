namespace My_MinorProject
{
    partial class AdminFeesViews
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
            this.dgvfees = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfees)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvfees
            // 
            this.dgvfees.BackgroundColor = System.Drawing.Color.White;
            this.dgvfees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfees.Location = new System.Drawing.Point(-1, 89);
            this.dgvfees.Name = "dgvfees";
            this.dgvfees.RowHeadersWidth = 51;
            this.dgvfees.RowTemplate.Height = 24;
            this.dgvfees.Size = new System.Drawing.Size(997, 548);
            this.dgvfees.TabIndex = 0;
            this.dgvfees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvfees_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fees Record";
            // 
            // AdminFeesViews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(997, 641);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvfees);
            this.Name = "AdminFeesViews";
            this.Text = "AdminFeesViews";
            this.Load += new System.EventHandler(this.AdminFeesViews_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvfees;
        private System.Windows.Forms.Label label1;
    }
}