namespace PlacementPlus_
{
    partial class JobDrive
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
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.JobDriveid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Internship = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Workmode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyBond = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IndustryType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Orange;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(1088, 23);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(2, 5, 8, 5);
            this.button6.Size = new System.Drawing.Size(122, 49);
            this.button6.TabIndex = 11;
            this.button6.Text = "Request";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Orange;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(947, 24);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 49);
            this.button5.TabIndex = 10;
            this.button5.Text = "Job Drive";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Orange;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(825, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 49);
            this.button3.TabIndex = 9;
            this.button3.Text = "Student";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(712, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 49);
            this.button1.TabIndex = 8;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Logo
            // 
            this.Logo.AutoSize = true;
            this.Logo.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Logo.Location = new System.Drawing.Point(10, 26);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(255, 45);
            this.Logo.TabIndex = 7;
            this.Logo.Text = "Placement Plus";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1415, 93);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Beige;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(2, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1415, 577);
            this.panel2.TabIndex = 13;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JobDriveid,
            this.CompanyName,
            this.Internship,
            this.Workmode,
            this.JobRole,
            this.JobDescription,
            this.CTC,
            this.CompanyBond,
            this.IndustryType,
            this.Details});
            this.dataGridView1.Location = new System.Drawing.Point(61, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1306, 358);
            this.dataGridView1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PlacementPlus_.Properties.Resources.images__5_;
            this.pictureBox1.Location = new System.Drawing.Point(1322, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // JobDriveid
            // 
            this.JobDriveid.HeaderText = "Job Drive ID";
            this.JobDriveid.MinimumWidth = 6;
            this.JobDriveid.Name = "JobDriveid";
            this.JobDriveid.Width = 125;
            // 
            // CompanyName
            // 
            this.CompanyName.HeaderText = "Company Name";
            this.CompanyName.MinimumWidth = 6;
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Width = 125;
            // 
            // Internship
            // 
            this.Internship.HeaderText = "Internship";
            this.Internship.MinimumWidth = 6;
            this.Internship.Name = "Internship";
            this.Internship.Width = 125;
            // 
            // Workmode
            // 
            this.Workmode.HeaderText = "Workmode";
            this.Workmode.MinimumWidth = 6;
            this.Workmode.Name = "Workmode";
            this.Workmode.Width = 125;
            // 
            // JobRole
            // 
            this.JobRole.HeaderText = "Job Role/Position";
            this.JobRole.MinimumWidth = 6;
            this.JobRole.Name = "JobRole";
            this.JobRole.Width = 125;
            // 
            // JobDescription
            // 
            this.JobDescription.HeaderText = "Job Description";
            this.JobDescription.MinimumWidth = 6;
            this.JobDescription.Name = "JobDescription";
            this.JobDescription.Width = 125;
            // 
            // CTC
            // 
            this.CTC.HeaderText = "CTC";
            this.CTC.MinimumWidth = 6;
            this.CTC.Name = "CTC";
            this.CTC.Width = 125;
            // 
            // CompanyBond
            // 
            this.CompanyBond.HeaderText = "CompanyBond";
            this.CompanyBond.MinimumWidth = 6;
            this.CompanyBond.Name = "CompanyBond";
            this.CompanyBond.Width = 125;
            // 
            // IndustryType
            // 
            this.IndustryType.HeaderText = "IndustryType";
            this.IndustryType.MinimumWidth = 6;
            this.IndustryType.Name = "IndustryType";
            this.IndustryType.Width = 125;
            // 
            // Details
            // 
            this.Details.HeaderText = "Details";
            this.Details.MinimumWidth = 6;
            this.Details.Name = "Details";
            this.Details.Width = 125;
            // 
            // JobDrive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 775);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "JobDrive";
            this.Text = "JobDrive";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobDriveid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Internship;
        private System.Windows.Forms.DataGridViewTextBoxColumn Workmode;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyBond;
        private System.Windows.Forms.DataGridViewTextBoxColumn IndustryType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Details;
    }
}