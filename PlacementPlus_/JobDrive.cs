using MySqlX.XDevAPI.Common;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PlacementPlus_
{
	public partial class JobDrive : Form
	{
		Database db = new Database();

		public JobDrive()
		{
			InitializeComponent();
			LoadJobs();
		}

		private void LoadJobs()
		{
			string query = "SELECT Id, Company_Name, Job_Profile, CTC, Internship, Stipend, Batch, Course, Due_Date FROM jobs"; // Select relevant columns
			var result = db.Execute(query);

			if (result.success && result.data != null)
			{
				dataGridView.DataSource = result.data;

				// Optionally hide the Id column
				dataGridView.Columns["Id"].Visible = false;

				// Add button column for "View Details"
				DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
				{
					Name = "Action", // Set the name of the button column
					HeaderText = "Action",
					Text = "View Details",
					UseColumnTextForButtonValue = true
				};
				dataGridView.Columns.Add(buttonColumn);


				// Set default cell style for button column
				dataGridView.Columns["Action"].DefaultCellStyle.BackColor = Color.LightBlue; // Change color
				dataGridView.Columns["Action"].DefaultCellStyle.ForeColor = Color.Black; // Change text color
			}
			else
			{
				MessageBox.Show("Failed to load job data.");
			}
		}
		private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			// Check if there are any jobs
			if (dataGridView.Rows.Count == 0)
			{
				// Display message for no data
				MessageBox.Show("No job data available.");
			}
			else
			{
				// Check if the click was on the button column
				if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView.Columns["Action"].Index)
				{
					int jobId = (int)dataGridView.Rows[e.RowIndex].Cells["Id"].Value; // Get the job ID
					JdDetails detailsForm = new JdDetails(jobId);
					detailsForm.ShowDialog(); // Show details form as a dialog
				}
			}
		}
	}
}
