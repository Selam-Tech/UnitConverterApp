namespace UnityUniversityApp
{
	partial class AboutForm
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblAbout;

		private void InitializeComponent()
		{
			this.lblAbout = new System.Windows.Forms.Label();
			this.SuspendLayout();

			// lblAbout
			this.lblAbout.Location = new System.Drawing.Point(30, 30);
			this.lblAbout.Size = new System.Drawing.Size(340, 100);
			this.lblAbout.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. You can customize this text.";

			// AboutForm
			this.ClientSize = new System.Drawing.Size(400, 150);
			this.Controls.Add(this.lblAbout);
			this.Text = "About Us";
			this.ResumeLayout(false);
		}
	}
}
