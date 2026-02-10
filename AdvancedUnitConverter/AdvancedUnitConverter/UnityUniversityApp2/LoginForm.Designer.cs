namespace UnityUniversityApp
{
	partial class LoginForm
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtFirst;
		private System.Windows.Forms.TextBox txtLast;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Label lblFirst;
		private System.Windows.Forms.Label lblLast;
		private System.Windows.Forms.Label lblPassword;

		private void InitializeComponent()
		{
			this.txtFirst = new System.Windows.Forms.TextBox();
			this.txtLast = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.lblFirst = new System.Windows.Forms.Label();
			this.lblLast = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.SuspendLayout();

			// Labels
			this.lblFirst.Location = new System.Drawing.Point(50, 30);
			this.lblFirst.Text = "First Name:";
			this.lblLast.Location = new System.Drawing.Point(50, 70);
			this.lblLast.Text = "Last Name:";
			this.lblPassword.Location = new System.Drawing.Point(50, 110);
			this.lblPassword.Text = "Password:";

			// TextBoxes
			this.txtFirst.Location = new System.Drawing.Point(150, 30);
			this.txtLast.Location = new System.Drawing.Point(150, 70);
			this.txtPassword.Location = new System.Drawing.Point(150, 110);
			this.txtPassword.PasswordChar = '*';

			// Button
			this.btnLogin.Location = new System.Drawing.Point(120, 160);
			this.btnLogin.Size = new System.Drawing.Size(120, 35);
			this.btnLogin.Text = "Login";
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

			// LoginForm
			this.ClientSize = new System.Drawing.Size(400, 220);
			this.Controls.Add(this.lblFirst);
			this.Controls.Add(this.lblLast);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.txtFirst);
			this.Controls.Add(this.txtLast);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.btnLogin);
			this.Text = "Login";
			this.ResumeLayout(false);
		}
	}
}
