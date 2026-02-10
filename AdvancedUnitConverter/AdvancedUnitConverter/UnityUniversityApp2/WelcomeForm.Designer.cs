namespace UnityUniversityApp
{
	partial class WelcomeForm
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblWelcome;

		private void InitializeComponent()
		{
			this.lblWelcome = new System.Windows.Forms.Label();
			this.SuspendLayout();

			// lblWelcome
			this.lblWelcome.Location = new System.Drawing.Point(50, 50);
			this.lblWelcome.Size = new System.Drawing.Size(300, 40);
			this.lblWelcome.Text = "Welcome to Unity University";
			this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

			// WelcomeForm
			this.ClientSize = new System.Drawing.Size(400, 200);
			this.Controls.Add(this.lblWelcome);
			this.Text = "Welcome";
			this.ResumeLayout(false);
		}
	}
}
