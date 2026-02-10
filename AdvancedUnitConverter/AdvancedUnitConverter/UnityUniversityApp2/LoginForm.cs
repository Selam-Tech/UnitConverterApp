using System;
using System.Windows.Forms;

namespace AdvancedUnitConverter
{
	public class LoginForm : Form
	{
		private TextBox txtUser, txtPass;
		private Button btnLogin;

		public LoginForm()
		{
			this.Text = "Login";
			this.ClientSize = new System.Drawing.Size(300, 180);
			this.FormBorderStyle = FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;

			Label lblUser = new Label { Text = "Username", Left = 20, Top = 20 };
			Label lblPass = new Label { Text = "Password", Left = 20, Top = 60 };

			txtUser = new TextBox { Left = 100, Top = 20, Width = 160 };
			txtPass = new TextBox { Left = 100, Top = 60, Width = 160, PasswordChar = '*' };

			btnLogin = new Button { Text = "Login", Left = 100, Top = 100, Width = 160 };
			btnLogin.Click += BtnLogin_Click;

			this.Controls.AddRange(new Control[]
			{
				lblUser, lblPass, txtUser, txtPass, btnLogin
			});
		}

		private void BtnLogin_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(txtUser.Text))
			{
				this.Hide();
				new MainForm().Show();
			}
			else
			{
				MessageBox.Show("Enter username");
			}
		}
	}
}
