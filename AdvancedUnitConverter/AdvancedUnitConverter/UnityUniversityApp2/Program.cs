using System;
using System.Windows.Forms;

namespace UnityUniversityApp
{
	static class Program
	{
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			DatabaseHelper.InitializeDatabase(); // initialize DB

			// TESTING: show CheckUserForm
			Application.Run(new HomeForm());
		}
	}
}
