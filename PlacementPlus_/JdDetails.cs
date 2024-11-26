using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace PlacementPlus_
{
	public partial class JdDetails : Form
	{
		private int jobId;
		static string email;
		// Constructor to pass JobId
		public JdDetails(string user, int JobId)
		{
			InitializeComponent();
			email = user;
			this.jobId = JobId;
		}

		// On Form Load, populate the job details
		private void JdDetails_Load(object sender, EventArgs e)
		{
			lblJobId.Text = jobId.ToString();
			if(jobId == 0)
			{
				btnSave.Text = "Add Job";
			}
			else
			{
				btnSave.Text = "Save Changes";
			}
		}
		// Method to load job details from the database and populate labels
		private void LoadJobDetails()
		{
			string query = "SELECT * FROM jobs WHERE Id = " + this.jobId;

			Database db = new Database();

			try
			{
				// Use the parameterized query with the JobId parameter
				var result = db.Execute(query);

				if (result.success && result.data != null && result.data.Rows.Count > 0)
				{
					DataRow row = result.data.Rows[0];  // Assuming only one record is fetched

					// Populate the labels with data from the fetched record
					txtCompanyName.Text = row["Company_Name"]?.ToString() ?? "N/A";
					txtCompanyURL.Text = row["Company_URL"]?.ToString() ?? "N/A";
					txtJobProfile.Text = row["Job_Profile"]?.ToString() ?? "N/A";
					txtCTC.Text = row["CTC"]?.ToString() ?? "N/A";
					txtInternship.Text = row["Internship"]?.ToString() ?? "N/A";
					txtStipend.Text = row["Stipend"]?.ToString() ?? "N/A";
					txtJobLocation.Text = row["Job_Location"]?.ToString() ?? "N/A";
					txtBatch.Text = row["Batch"]?.ToString() ?? "N/A";
					txtBranch.Text = row["Course"]?.ToString() ?? "N/A";
					txtDriveDate.Text = row["Drive_Date"]?.ToString() ?? "N/A";
					txtDriveLocation.Text = row["Drive_Location"]?.ToString() ?? "N/A";
					txtDueDate.Text = row["Due_Date"]?.ToString() ?? "N/A";
					txtPersonName.Text = row["PersonName"]?.ToString() ?? "N/A";
					txtPersonMobile.Text = row["PersonNumber"]?.ToString() ?? "N/A";
				}
				else
				{
					MessageBox.Show("No data found for the specified job. Job ID : " + this.jobId);
				}
			}
			catch (Exception ex)
			{
				// Handle any potential exceptions (like database connection issues)
				MessageBox.Show($"An error occurred while fetching job details: {ex.Message}");
			}
		}


		// Clean up any empty methods if not needed
		private void textBox10_TextChanged(object sender, EventArgs e)
		{
			// Empty method. Remove if not required.
		}

		private void label12_Click(object sender, EventArgs e)
		{
			// Empty method. Remove if not required.
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{
			// Empty method. Remove if not required.
		}

		private void button2_Click(object sender, EventArgs e)
		{
			JobDrive jd = new JobDrive(email);
			jd.Show();
			this.Hide();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{

		}
	}
}
