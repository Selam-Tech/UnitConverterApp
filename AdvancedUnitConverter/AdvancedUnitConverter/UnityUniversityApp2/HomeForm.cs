using System;
using System.Windows.Forms;

namespace UnityUniversityApp
{
	public partial class HomeForm : Form
	{
		public HomeForm()
		{
			InitializeComponent();
		}

		private void btnRegister_Click(object sender, EventArgs e)
		{
			new RegisterForm().Show();
			this.Hide();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			new LoginForm().Show();
			this.Hide();
		}

		private void btnAbout_Click(object sender, EventArgs e)
		{
			new AboutForm().Show();
			this.Hide();
		}

		private void btnContact_Click(object sender, EventArgs e)
		{
			new ContactForm().Show();
			this.Hide();
		}
	}
}
