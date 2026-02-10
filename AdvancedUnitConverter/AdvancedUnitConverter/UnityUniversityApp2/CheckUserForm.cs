using System;
using System.Drawing;
using System.Windows.Forms;

namespace UnityUniversityApp
{
	public partial class CheckUserForm : Form
	{
		public CheckUserForm()
		{
			InitializeComponent();
		}

		private void btnCheck_Click(object sender, EventArgs e)
		{
			string first = txtFirst.Text.Trim();
			string last = txtLast.Text.Trim();

			if (string.IsNullOrWhiteSpace(first) || string.IsNullOrWhiteSpace(last))
			{
				MessageBox.Show("Please enter both first and last names!");
				return;
			}

			bool isRegistered = DatabaseHelper.IsUserRegistered(first, last);

			if (isRegistered)
			{
				lblResult.Text = $"User {first} {last} IS registered!";
				lblResult.ForeColor = Color.Green;
			}
			else
			{
				lblResult.Text = $"User {first} {last} is NOT registered!";
				lblResult.ForeColor = Color.Red;
			}
		}
	}
}
