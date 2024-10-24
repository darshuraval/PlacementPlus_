using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PlacementPlus_
{
	public partial class Profile : Form
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		Database db = new Database();
		static string UserEmail = "admin@gmail.com";
		private string currentImageFileName;
		private Timer refreshTimer;
		public Profile()
		{
			InitializeComponent();
			LoadUserProfile(); // Load the user profile when the form initializes
		}
		private void auto_refresh()
		{
			refreshTimer = new Timer();
			refreshTimer.Interval = 1000; // Set interval to 5000 ms (5 seconds)
			refreshTimer.Tick += RefreshTimer_Tick;
			refreshTimer.Start(); // Start the timer
		}
		private void RefreshTimer_Tick(object sender, EventArgs e)
		{
			LoadUserProfile(); // Refresh the user profile
		}
		private void LoadUserProfile()
		{
			string querySelect = "SELECT * FROM Profile WHERE User_Email = @UserEmail";
			var parametersSelect = new[] { new MySqlParameter("@UserEmail", UserEmail) };
			var existingProfile = db.Execute(querySelect, parametersSelect).data;

			if (existingProfile != null && existingProfile.Rows.Count > 0)
			{
				var row = existingProfile.Rows[0];

				// Load values into text boxes
				txtCollageName.Text = row["Collage_Name"].ToString();
				txtContactInformation.Text = row["Contact_Information"].ToString();
				txtBranchCourse.Text = row["Branches"].ToString();
				txtAddress.Text = row["Address"].ToString();
				txtReference.Text = row["Reference"].ToString();
				txtEstablished.Text = row["Established"].ToString();
				txtAchievement.Text = row["Achievement"].ToString();

				// Load the existing image
				currentImageFileName = row["Image"].ToString();
				string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
				string saveDirectory = Path.Combine(projectDirectory, "Images", "Profile");
				string imagePath = Path.Combine(saveDirectory, currentImageFileName);

				if (File.Exists(imagePath))
				{
					pictureBox2.Image = new Bitmap(imagePath); // Load the existing image
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string filePath = openFileDialog.FileName;
				try
				{
					using (Image img = Image.FromFile(filePath))
					{
						pictureBox2.Image?.Dispose(); // Dispose of the previous image if any
						pictureBox2.Image = new Bitmap(img); // Set the new image

						string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
						string saveDirectory = Path.Combine(projectDirectory, "Images", "Profile");
						Directory.CreateDirectory(saveDirectory);
						string fileName = Path.GetFileName(filePath);
						string destinationPath = Path.Combine(saveDirectory, fileName);

						// Handle potential file name collisions
						if (File.Exists(destinationPath))
						{
							string newFileName = Path.GetFileNameWithoutExtension(fileName) + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + Path.GetExtension(fileName);
							destinationPath = Path.Combine(saveDirectory, newFileName);
						}

						// Save the image to disk
						img.Save(destinationPath);
						currentImageFileName = Path.GetFileName(destinationPath); // Store the current image file name
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show($"An error occurred while uploading the image: {ex.Message}");
				}
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			// Check if the profile exists
			string queryCheck = "SELECT COUNT(*) FROM Profile WHERE User_Email = @UserEmail";
			var parametersCheck = new[] { new MySqlParameter("@UserEmail", UserEmail) };
			var existsResult = db.Execute(queryCheck, parametersCheck);

			if (existsResult.data != null && existsResult.data.Rows.Count > 0)
			{
				// Use Convert.ToInt32 or Convert.ToInt64 based on your database schema
				int count = Convert.ToInt32(existsResult.data.Rows[0][0]);
				if (count > 0)
				{
					// Profile exists, update it
					UpdateProfile();
				}
				else
				{
					// Profile does not exist, insert a new one
					InsertProfile();
				}
			}
			else
			{
				MessageBox.Show("Error checking for profile existence.");
			}
		}


		private void UpdateProfile()
		{
			string imageNameToSave = currentImageFileName ?? string.Empty;

			string queryUpdate = @"
                UPDATE Profile 
                SET 
                    Image = @ImageName,
                    Collage_Name = @CollageName,
                    Contact_Information = @ContactInfo,
                    Branches = @Branches,
                    Address = @Address,
                    Reference = @Reference,
                    Established = @Established,
                    Achievement = @Achievement
                WHERE User_Email = @UserEmail";

			var parametersUpdate = new[]
			{
				new MySqlParameter("@ImageName", imageNameToSave),
				new MySqlParameter("@CollageName", txtCollageName.Text),
				new MySqlParameter("@ContactInfo", txtContactInformation.Text),
				new MySqlParameter("@Branches", txtBranchCourse.Text),
				new MySqlParameter("@Address", txtAddress.Text),
				new MySqlParameter("@Reference", txtReference.Text),
				new MySqlParameter("@Established", txtEstablished.Text),
				new MySqlParameter("@Achievement", txtAchievement.Text),
				new MySqlParameter("@UserEmail", UserEmail)
			};

			var resultUpdate = db.Execute(queryUpdate, parametersUpdate);

			if (resultUpdate.success)
			{
				MessageBox.Show("Profile updated successfully.");
			}
			else
			{
				MessageBox.Show("Failed to update profile in the database.");
			}
		}

		private void InsertProfile()
		{
			string queryInsert = @"
                INSERT INTO Profile (User_Email, Image, Collage_Name, Contact_Information, Branches, Address, Reference, Established, Achievement) 
                VALUES (@UserEmail, @ImageName, @CollageName, @ContactInfo, @Branches, @Address, @Reference, @Established, @Achievement)";

			var parametersInsert = new[]
			{
				new MySqlParameter("@UserEmail", UserEmail),
				new MySqlParameter("@ImageName", currentImageFileName),
				new MySqlParameter("@CollageName", txtCollageName.Text),
				new MySqlParameter("@ContactInfo", txtContactInformation.Text),
				new MySqlParameter("@Branches", txtBranchCourse.Text),
				new MySqlParameter("@Address", txtAddress.Text),
				new MySqlParameter("@Reference", txtReference.Text),
				new MySqlParameter("@Established", txtEstablished.Text),
				new MySqlParameter("@Achievement", txtAchievement.Text)
			};

			var resultInsert = db.Execute(queryInsert, parametersInsert);

			if (resultInsert.success)
			{
				MessageBox.Show("Profile created successfully.");
			}
			else
			{
				MessageBox.Show("Failed to save profile in the database.");
			}
		}

		private void btnProfile_Click(object sender, EventArgs e)
		{
			LoadUserProfile();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			JobDrive jobDrive = new JobDrive();
			this.Hide();
			jobDrive.Show();
		}
	}
}
