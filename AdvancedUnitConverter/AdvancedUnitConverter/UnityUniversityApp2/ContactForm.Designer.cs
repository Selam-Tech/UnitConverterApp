namespace UnityUniversityApp
{
	partial class ContactForm
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblContact;

		private void InitializeComponent()
		{
			this.lblContact = new System.Windows.Forms.Label();
			this.SuspendLayout();

			// lblContact
			this.lblContact.Location = new System.Drawing.Point(30, 30);
			this.lblContact.Size = new System.Drawing.Size(340, 60);
			this.lblContact.Text = "Phone: 0962382506\nTelegram: @Redyth";

			// ContactForm
			this.ClientSize = new System.Drawing.Size(400, 120);
			this.Controls.Add(this.lblContact);
			this.Text = "Contact Us";
			this.ResumeLayout(false);
		}
	}
}
