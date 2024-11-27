using MySqlX.XDevAPI.Common;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PlacementPlus_
{
	public partial class JobDrive : Form
	{
		Database db = new Database();
		static string email;
		public JobDrive(string user)
		{
			email = user;
			InitializeComponent();
			LoadJobs(); // Load job data into the DataGridView when the form loads
		}

		private void LoadJobs()
		{
			string query = "SELECT Id, Company_Name, Job_Profile, CTC, Internship, Batch, Course, Due_Date FROM jobs"; // Select relevant columns
			var result = db.Execute(query);

			if (result.success && result.data != null)
			{
				dataGridView.DataSource = result.data;

				dataGridView.Columns["Id"].Visible = false; // Hide the ID column

				// Add "View Details" button column
				DataGridViewButtonColumn viewDetailsColumn = new DataGridViewButtonColumn
				{
					Name = "ViewDetails",
					HeaderText = "Action",
					Text = "View Details",
					UseColumnTextForButtonValue = true
				};
				dataGridView.Columns.Add(viewDetailsColumn);

				// Style the "View Details" button column
				dataGridView.Columns["ViewDetails"].DefaultCellStyle.BackColor = Color.LightBlue;
				dataGridView.Columns["ViewDetails"].DefaultCellStyle.ForeColor = Color.Black;

				// Add "Delete" button column
				DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn
				{
					Name = "Delete",
					HeaderText = "Action",
					Text = "Delete",
					UseColumnTextForButtonValue = true
				};
				dataGridView.Columns.Add(deleteColumn);

				// Style the "Delete" button column
				dataGridView.Columns["Delete"].DefaultCellStyle.BackColor = Color.LightCoral;
				dataGridView.Columns["Delete"].DefaultCellStyle.ForeColor = Color.Black;
			}
			else
			{
				MessageBox.Show("Failed to load job data.");
			}
		}

		private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			// Check if there are any rows in the DataGridView
			if (dataGridView.Rows.Count == 0)
			{
				MessageBox.Show("No job data available.");
			}
			else
			{
				// Check if the clicked column is the "View Details" button column
				if (e.RowIndex >= 0)
				{
					if (e.ColumnIndex == dataGridView.Columns["ViewDetails"].Index)
					{
						// Get the JobId from the clicked row
						int jobId = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["Id"].Value);
						// Create a new instance of the JobDetails form, passing the JobId
						JdDetails detailsForm = new JdDetails(email, jobId);
						this.Hide();
						// Show the details form as a dialog
						detailsForm.Show();
					}
					else if (e.ColumnIndex == dataGridView.Columns["Delete"].Index)
					{
						// Handle "Delete" button click
						int jobId = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["Id"].Value);
						// Add logic to delete the job
						// For example: db.Execute("DELETE FROM jobs WHERE Id = @JobId", new MySqlParameter("@JobId", jobId));
						db.Execute("delete from jobs where Id = " + jobId);
						MessageBox.Show($"Deleted Job Record, JobId: {jobId}");
						LoadJobs();
					}
				}
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Student student = new Student(email);
			student.Show();
			this.Hide();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			// No code inside the event handler
		}

		private void button6_Click(object sender, EventArgs e)
		{
			Request r = new Request(email);
			r.Show();
			this.Hide();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Profile p = new Profile(email);
			p.Show();
			this.Hide();
		}

		private void JobDrive_Load(object sender, EventArgs e)
		{
			// Any initialization code for the form load can go here
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			JdDetails jdDetails = new JdDetails(email, 0);
			jdDetails.Show();
			this.Hide();
		}
	}
}
