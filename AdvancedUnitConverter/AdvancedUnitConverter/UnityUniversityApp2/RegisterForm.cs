using System;
using System.Windows.Forms;

namespace UnityUniversityApp
{
	public partial class RegisterForm : Form
	{
		public RegisterForm()
		{
			InitializeComponent();
		}

		private void btnRegister_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtFirst.Text) ||
				string.IsNullOrWhiteSpace(txtLast.Text) ||
				string.IsNullOrWhiteSpace(txtPassword.Text))
			{
				MessageBox.Show("First name, Last name, and Password are required!");
				return;
			}

			using (var con = DatabaseHelper.GetConnection())
			{
				con.Open();
				var cmd = new System.Data.SQLite.SQLiteCommand(
					"INSERT INTO Users (FirstName, MiddleName, LastName, Password) VALUES (@f,@m,@l,@p)", con);
				cmd.Parameters.AddWithValue("@f", txtFirst.Text.Trim());
				cmd.Parameters.AddWithValue("@m", txtMiddle.Text.Trim());
				cmd.Parameters.AddWithValue("@l", txtLast.Text.Trim());
				cmd.Parameters.AddWithValue("@p", txtPassword.Text.Trim());

				cmd.ExecuteNonQuery();
			}

			MessageBox.Show("Registration successful!");
			new LoginForm().Show();
			this.Hide();
		}
	}
}
