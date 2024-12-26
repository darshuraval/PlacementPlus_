using System;
using System.Windows.Forms;

namespace PlacementPlus_
{
	internal static class Program
	{
		public static bool Is_Login = false; // Default to not logged in
		public static Database db = new Database();
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			if (!Is_Login)
			{
				Application.Run(new Login());
			}
			else
			{
				Application.Run(new Home("yash@gmail.com"));
			}
		}
	}
}
