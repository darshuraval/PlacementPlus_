using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PlacementPlus_
{
	public class Submit
	{
		private static Database db = new Database();
		public string userEmail;
		public void Register(string email, string password)
		{
			// Hash the password before storing it
			string hashedPassword = HashPassword(password);

			string query = "INSERT INTO Users (Usertype, Email, Password) VALUES ('Admin', @Email, @Password)";
			var parameters = new[]
			{
				new MySqlParameter("@Email", email),
				new MySqlParameter("@Password", hashedPassword)
			};

			int affectedRows = db.Execute(query, parameters).affectedRows;

			if (affectedRows > 0)
			{
				Register register = new Register();
				Login login = new Login();
				register.Hide();
				login.Show();
				userEmail = email;
				MessageBox.Show("Registered!");
			}
			else
			{
				MessageBox.Show("Registration Error!");
			}
		}

		public bool Login(string email, string password)
		{
			string query = "SELECT * FROM Users WHERE Email = @Email";
			var parameters = new[]
			{
				new MySqlParameter("@Email", email)
			};

			DataTable user = db.Execute(query, parameters).data;

			if (user != null && user.Rows.Count > 0)
			{
				// Assuming the password is stored in the fourth column (index 3)
				if (VerifyPassword(password, user.Rows[0][3].ToString()))
				{
					return true;
				}
				else
				{
					MessageBox.Show("Wrong Password");
					return false;
				}
			}
			else
			{
				MessageBox.Show("Wrong User/Email");
				return false;
			}
		}

		private string HashPassword(string password)
		{
			// Implement your password hashing here (e.g., using SHA256, bcrypt, etc.)
			return password; // Replace this with actual hashing logic
		}

		private bool VerifyPassword(string password, string hashedPassword)
		{
			// Implement password verification logic here
			return password == hashedPassword; // Replace this with actual verification logic
		}

		public bool AddJob(string operation, string companyName, string companyURL, string jobProfile, string CTC, string internship,
					   string stipend, string jobLocation, string batch, string course, string driveDate, string driveLocation,
					   string dueDate, string personName, string personMobile)
		{
			string query = string.Empty;

			// Prepare the SQL query based on the operation type (add or update)
			if (operation == "add")
			{
				query = "INSERT INTO jobs (Company_Name, Company_URL, Job_Profile, CTC, Internship, Stipend, Job_Location, Batch, Course, " +
						"Drive_Date, Drive_Location, Due_Date, PersonName, PersonNumber) " +
						"VALUES (@CompanyName, @CompanyURL, @JobProfile, @CTC, @Internship, @Stipend, @JobLocation, @Batch, @Course, " +
						"@DriveDate, @DriveLocation, @DueDate, @PersonName, @PersonMobile)";
			}
			else if (operation == "update")
			{
				// Example of an update query based on Company_Name (or another unique identifier)
				query = "UPDATE jobs SET Company_URL = @CompanyURL, Job_Profile = @JobProfile, CTC = @CTC, Internship = @Internship, " +
						"Stipend = @Stipend, Job_Location = @JobLocation, Batch = @Batch, Course = @Course, Drive_Date = @DriveDate, " +
						"Drive_Location = @DriveLocation, Due_Date = @DueDate, PersonName = @PersonName, PersonNumber = @PersonMobile " +
						"WHERE Company_Name = @CompanyName"; // Adjust the WHERE clause if needed based on the unique identifier
			}
			else
			{
				return false; // Invalid operation
			}

			// Define the parameters for the query
			MySqlParameter[] parameters = new MySqlParameter[]
			{
			new MySqlParameter("@CompanyName", companyName),
			new MySqlParameter("@CompanyURL", companyURL),
			new MySqlParameter("@JobProfile", jobProfile),
			new MySqlParameter("@CTC", CTC),
			new MySqlParameter("@Internship", internship),
			new MySqlParameter("@Stipend", stipend),
			new MySqlParameter("@JobLocation", jobLocation),
			new MySqlParameter("@Batch", batch),
			new MySqlParameter("@Course", course),
			new MySqlParameter("@DriveDate", driveDate),
			new MySqlParameter("@DriveLocation", driveLocation),
			new MySqlParameter("@DueDate", dueDate),
			new MySqlParameter("@PersonName", personName),
			new MySqlParameter("@PersonMobile", personMobile)
			};

			// Execute the query using the Database class' Execute method
			var result = db.Execute(query, parameters);

			// Return success status based on whether the query executed successfully
			return result.success;
		}

	}
}
