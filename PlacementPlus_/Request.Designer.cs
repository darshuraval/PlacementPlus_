namespace PlacementPlus_
{
    partial class Request
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
			this.button1 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.Logo = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Requestid = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.StudentEnrollment = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RequestDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.StudentEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.StudentMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Details = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Orange;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(748, 26);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(77, 46);
			this.button1.TabIndex = 20;
			this.button1.Text = "Home";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.Orange;
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(983, 25);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(112, 46);
			this.button5.TabIndex = 22;
			this.button5.Text = "Job Drive";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// Logo
			// 
			this.Logo.AutoSize = true;
			this.Logo.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Logo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Logo.Location = new System.Drawing.Point(19, 27);
			this.Logo.Name = "Logo";
			this.Logo.Size = new System.Drawing.Size(255, 45);
			this.Logo.TabIndex = 19;
			this.Logo.Text = "Placement Plus";
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Orange;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(861, 26);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(87, 46);
			this.button3.TabIndex = 21;
			this.button3.Text = "Student";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.Orange;
			this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.Location = new System.Drawing.Point(1124, 24);
			this.button6.Name = "button6";
			this.button6.Padding = new System.Windows.Forms.Padding(2, 5, 8, 5);
			this.button6.Size = new System.Drawing.Size(112, 46);
			this.button6.TabIndex = 23;
			this.button6.Text = "Request";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.Logo);
			this.panel1.Controls.Add(this.button5);
			this.panel1.Location = new System.Drawing.Point(3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1408, 91);
			this.panel1.TabIndex = 25;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::PlacementPlus_.Properties.Resources.images__5_;
			this.pictureBox1.Location = new System.Drawing.Point(1339, 24);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(57, 45);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 24;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Requestid,
            this.StudentName,
            this.StudentEnrollment,
            this.Department,
            this.RequestDate,
            this.StudentEmail,
            this.StudentMobile,
            this.Details});
			this.dataGridView1.Location = new System.Drawing.Point(163, 241);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1055, 368);
			this.dataGridView1.TabIndex = 26;
			// 
			// Requestid
			// 
			this.Requestid.HeaderText = "Requestid";
			this.Requestid.MinimumWidth = 6;
			this.Requestid.Name = "Requestid";
			this.Requestid.Width = 125;
			// 
			// StudentName
			// 
			this.StudentName.HeaderText = "StudentName";
			this.StudentName.MinimumWidth = 6;
			this.StudentName.Name = "StudentName";
			this.StudentName.Width = 125;
			// 
			// StudentEnrollment
			// 
			this.StudentEnrollment.HeaderText = "Student Enrollment";
			this.StudentEnrollment.MinimumWidth = 6;
			this.StudentEnrollment.Name = "StudentEnrollment";
			this.StudentEnrollment.Width = 125;
			// 
			// Department
			// 
			this.Department.HeaderText = "Department ";
			this.Department.MinimumWidth = 6;
			this.Department.Name = "Department";
			this.Department.Width = 125;
			// 
			// RequestDate
			// 
			this.RequestDate.HeaderText = "Request Date";
			this.RequestDate.MinimumWidth = 6;
			this.RequestDate.Name = "RequestDate";
			this.RequestDate.Width = 125;
			// 
			// StudentEmail
			// 
			this.StudentEmail.HeaderText = "Student Email";
			this.StudentEmail.MinimumWidth = 6;
			this.StudentEmail.Name = "StudentEmail";
			this.StudentEmail.Width = 125;
			// 
			// StudentMobile
			// 
			this.StudentMobile.HeaderText = "Student Mobile";
			this.StudentMobile.MinimumWidth = 6;
			this.StudentMobile.Name = "StudentMobile";
			this.StudentMobile.Width = 125;
			// 
			// Details
			// 
			this.Details.HeaderText = "Details";
			this.Details.MinimumWidth = 6;
			this.Details.Name = "Details";
			this.Details.Width = 125;
			// 
			// Request
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1414, 776);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.panel1);
			this.Name = "Request";
			this.Text = "Request";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label Logo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Requestid;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentEnrollment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Details;
    }
}