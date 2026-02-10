namespace UnityUniversityApp
{
	partial class HomeForm
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnRegister;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Button btnAbout;
		private System.Windows.Forms.Button btnContact;

		private void InitializeComponent()
		{
			this.btnRegister = new System.Windows.Forms.Button();
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnAbout = new System.Windows.Forms.Button();
			this.btnContact = new System.Windows.Forms.Button();
			this.SuspendLayout();

			// btnRegister
			this.btnRegister.Location = new System.Drawing.Point(100, 50);
			this.btnRegister.Size = new System.Drawing.Size(200, 40);
			this.btnRegister.Text = "Register";
			this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

			// btnLogin
			this.btnLogin.Location = new System.Drawing.Point(100, 110);
			this.btnLogin.Size = new System.Drawing.Size(200, 40);
			this.btnLogin.Text = "Login";
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

			// btnAbout
			this.btnAbout.Location = new System.Drawing.Point(100, 170);
			this.btnAbout.Size = new System.Drawing.Size(200, 40);
			this.btnAbout.Text = "About Us";
			this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);

			// btnContact
			this.btnContact.Location = new System.Drawing.Point(100, 230);
			this.btnContact.Size = new System.Drawing.Size(200, 40);
			this.btnContact.Text = "Contact Us";
			this.btnContact.Click += new System.EventHandler(this.btnContact_Click);

			// HomeForm
			this.ClientSize = new System.Drawing.Size(400, 350);
			this.Controls.Add(this.btnRegister);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.btnAbout);
			this.Controls.Add(this.btnContact);
			this.Text = "Home";
			this.ResumeLayout(false);
		}
	}
}
