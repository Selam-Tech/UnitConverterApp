namespace UnityUniversityApp
{
	partial class RegisterForm
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtFirst;
		private System.Windows.Forms.TextBox txtMiddle;
		private System.Windows.Forms.TextBox txtLast;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Button btnRegister;
		private System.Windows.Forms.Label lblFirst;
		private System.Windows.Forms.Label lblMiddle;
		private System.Windows.Forms.Label lblLast;
		private System.Windows.Forms.Label lblPassword;

		private void InitializeComponent()
		{
			this.txtFirst = new System.Windows.Forms.TextBox();
			this.txtMiddle = new System.Windows.Forms.TextBox();
			this.txtLast = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.btnRegister = new System.Windows.Forms.Button();
			this.lblFirst = new System.Windows.Forms.Label();
			this.lblMiddle = new System.Windows.Forms.Label();
			this.lblLast = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.SuspendLayout();

			// Labels
			this.lblFirst.Location = new System.Drawing.Point(50, 30);
			this.lblFirst.Text = "First Name:";
			this.lblMiddle.Location = new System.Drawing.Point(50, 70);
			this.lblMiddle.Text = "Middle Name:";
			this.lblLast.Location = new System.Drawing.Point(50, 110);
			this.lblLast.Text = "Last Name:";
			this.lblPassword.Location = new System.Drawing.Point(50, 150);
			this.lblPassword.Text = "Password:";

			// TextBoxes
			this.txtFirst.Location = new System.Drawing.Point(150, 30);
			this.txtMiddle.Location = new System.Drawing.Point(150, 70);
			this.txtLast.Location = new System.Drawing.Point(150, 110);
			this.txtPassword.Location = new System.Drawing.Point(150, 150);
			this.txtPassword.PasswordChar = '*';

			// Button
			this.btnRegister.Location = new System.Drawing.Point(120, 200);
			this.btnRegister.Size = new System.Drawing.Size(120, 35);
			this.btnRegister.Text = "Register";
			this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

			// RegisterForm
			this.ClientSize = new System.Drawing.Size(400, 270);
			this.Controls.Add(this.lblFirst);
			this.Controls.Add(this.lblMiddle);
			this.Controls.Add(this.lblLast);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.txtFirst);
			this.Controls.Add(this.txtMiddle);
			this.Controls.Add(this.txtLast);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.btnRegister);
			this.Text = "Register";
			this.ResumeLayout(false);
		}
	}
}
