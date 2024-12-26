using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlacementPlus_
{
    public partial class AddStudent : Form
    {
        static string email;
		static int id;
        public AddStudent(string user, int Id = 0)
        {
            email = user;
			id = Id;
			InitializeComponent();
        }

		private void LoadStudent(int studentId)
		{
			// SQL query to fetch student details by Id
			string query = "SELECT * FROM students WHERE Id = @Id"; // Assuming "students" is the table name
			MySqlParameter[] parameters = { new MySqlParameter("@Id", studentId) };

			// Create an instance of the Database class
			Database db = new Database();

			// Execute the query
			var result = db.Execute(query, parameters);

			// Check if the query was successful and data was returned
			if (result.success && result.data != null && result.data.Rows.Count > 0)
			{
				// Get the first row from the result DataTable (assuming there's only one row for a given student Id)
				DataRow row = result.data.Rows[0];

				// Set form fields with the retrieved student data
				txtFullName.Text = row["StudentName"].ToString();
				txtDOB.Text = row["DOB"].ToString();
				txtEmail.Text = row["Email"].ToString();
				txtMobile.Text = row["Mobile"].ToString();
				txtAddress.Text = row["Address"].ToString();
				txtPincode.Text = row["Pincode"].ToString();
				txtEnrollment.Text = row["Enrollment"].ToString();
				txtCourse.Text = row["Course"].ToString();
				txtBatch.Text = row["Batch"].ToString();
				txtLastMark.Text = row["LastMark"].ToString();
				txtSkill.Text = row["Skills"].ToString();
				txtExperience.Text = row["Experience"].ToString();
				txtResume.Text = row["Resume"].ToString();
			}
			else
			{
				// Handle the case where the student data wasn't found
				MessageBox.Show("Student data not found.");
			}
		}


		private void button2_Click(object sender, EventArgs e)
		{
			// Capture values from the form fields
			string StudentName = txtFullName.Text ?? "";
			string DOB = txtDOB.Text ?? "";
			string Email = txtEmail.Text ?? "";
			string Mobile = txtMobile.Text ?? "";
			string Address = txtAddress.Text ?? "";
			string Pincode = txtPincode.Text ?? "";
			string Enrollment = txtEnrollment.Text ?? "";
			string Course = txtCourse.Text ?? "";
			string Batch = txtBatch.Text ?? "";
			string LastMark = txtLastMark.Text ?? "";
			string Skill = txtSkill.Text ?? "";
			string Experience = txtExperience.Text ?? "";
			string Resume = txtResume.Text ?? "";

			// Initialize query string
			string query = string.Empty;

			// Determine whether we're adding a new student or updating an existing student
			if (btnSubmit.Text == "Add Student")
			{
				query = "insert into students (StudentName, DOB, Enrollment, Course, Batch, Email, Mobile, Address, Pincode, LastMark, Skills, " +
						"Experience, Resume, Registered, Status, Modified_at) values (@StudentName, @DOB, @Enrollment, @Course, @Batch, @Email, " +
						"@Mobile, @Address, @Pincode, @LastMark, @Skills, @Experience, @Resume, 'Yes', 'Active', CURRENT_TIMESTAMP)";
			}
			else if (btnSubmit.Text == "Save Changes")
			{
				query = "update students set StudentName = @StudentName, DOB = @DOB, Enrollment = @Enrollment, Course = @Course, " +
						"Batch = @Batch, Email = @Email, Mobile = @Mobile, Address = @Address, Pincode = @Pincode, LastMark = @LastMark, Skills = @Skills, " +
						"Experience = @Experience, Resume = @Resume, Status = 'Active', Modified_at = CURRENT_TIMESTAMP where Id = @id"; // Assuming "Enrollment" is unique
			}
			else
			{
				MessageBox.Show("Error: Invalid button action.");
				return;
			}
			Submit sub = new Submit();

			// Create an array of parameters to prevent SQL injection
			MySqlParameter[] parameters = new MySqlParameter[]
			{
		new MySqlParameter("@Id", id),
		new MySqlParameter("@StudentName", StudentName),
		new MySqlParameter("@DOB", DOB),
		new MySqlParameter("@Enrollment", Enrollment),
		new MySqlParameter("@Course", Course),
		new MySqlParameter("@Batch", Batch),
		new MySqlParameter("@Email", Email),
		new MySqlParameter("@Mobile", Mobile),
		new MySqlParameter("@Address", Address),
		new MySqlParameter("@Pincode", Pincode),
		new MySqlParameter("@LastMark", LastMark),
		new MySqlParameter("@Skills", Skill),
		new MySqlParameter("@Experience", Experience),
		new MySqlParameter("@Resume", Resume)
			};

			// Call the AddStudent method
			bool success = sub.AddStudent(query, parameters);

			if (success)
			{
				MessageBox.Show("Student record saved successfully.");
				button4_Click(sender, e);
			}
			else
			{
				MessageBox.Show("Error: Failed to save student record.");
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.Hide();
			Student stud = new Student(email);
			stud.Show();
		}

		private void AddStudent_Load(object sender, EventArgs e)
		{
			if (id != 0)
			{
				LoadStudent(id);
				btnSubmit.Text = "Save Changes";
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			this.Hide();
			JobDrive jd = new JobDrive(email);
			jd.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Hide();
			Student st = new Student(email);
			st.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			Home h = new Home(email);
			h.Show();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Profile p = new Profile(email);
			p.Show(); this.Hide();
		}
	}
}
