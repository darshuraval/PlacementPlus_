using System;
using System.Windows.Forms;

namespace PlacementPlus_
{
	internal static class Program
	{
		// This variable should hold the login status
		public static bool Is_Login = true; // Default to not logged in
		public static Database db = new Database();
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			// Check if the user is logged in
			if (!Is_Login)
			{
				Application.Run(new Login()); // Show the registration form
			}
			else
			{
				Application.Run(new Profile()); // Show the main form for logged-in users
			}
		}
	}
}
