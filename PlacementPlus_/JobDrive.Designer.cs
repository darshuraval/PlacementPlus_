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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.button2 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
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
			this.button6.Click += new System.EventHandler(this.button6_Click);
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
			this.button5.Click += new System.EventHandler(this.button5_Click);
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
			this.button3.Click += new System.EventHandler(this.button3_Click);
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
			// pictureBox1
			// 
			this.pictureBox1.Image = global::PlacementPlus_.Properties.Resources.images__5_;
			this.pictureBox1.Location = new System.Drawing.Point(1322, 23);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(67, 48);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 12;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Beige;
			this.panel2.Controls.Add(this.button2);
			this.panel2.Controls.Add(this.dataGridView);
			this.panel2.Location = new System.Drawing.Point(2, 125);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1415, 577);
			this.panel2.TabIndex = 13;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			// 
			// dataGridView
			// 
			this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(61, 102);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowHeadersWidth = 51;
			this.dataGridView.RowTemplate.Height = 24;
			this.dataGridView.Size = new System.Drawing.Size(1306, 358);
			this.dataGridView.TabIndex = 0;
			this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.PaleGreen;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(99, 33);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(166, 49);
			this.button2.TabIndex = 13;
			this.button2.Text = "Add Job Drive";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
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
			this.Load += new System.EventHandler(this.JobDrive_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Button button2;
	}
}