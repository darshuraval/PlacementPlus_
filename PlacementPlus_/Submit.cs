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

		public void Login(string email, string password)
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
					Login login = new Login();
					Profile profile = new Profile(email);
					login.Hide();
					profile.Show();
					MessageBox.Show("Logged In");
				}
				else
				{
					MessageBox.Show("Wrong Password");
				}
			}
			else
			{
				MessageBox.Show("Wrong User/Email");
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
	}
}
