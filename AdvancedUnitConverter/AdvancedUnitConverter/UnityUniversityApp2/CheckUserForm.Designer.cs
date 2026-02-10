namespace UnityUniversityApp
{
	partial class CheckUserForm
	{
		private System.ComponentModel.IContainer components = null;

		private System.Windows.Forms.Label lblFirst;
		private System.Windows.Forms.TextBox txtFirst;
		private System.Windows.Forms.Label lblLast;
		private System.Windows.Forms.TextBox txtLast;
		private System.Windows.Forms.Button btnCheck;
		private System.Windows.Forms.Label lblResult;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		private void InitializeComponent()
		{
			this.lblFirst = new System.Windows.Forms.Label();
			this.txtFirst = new System.Windows.Forms.TextBox();
			this.lblLast = new System.Windows.Forms.Label();
			this.txtLast = new System.Windows.Forms.TextBox();
			this.btnCheck = new System.Windows.Forms.Button();
			this.lblResult = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblFirst
			// 
			this.lblFirst.AutoSize = true;
			this.lblFirst.Location = new System.Drawing.Point(30, 30);
			this.lblFirst.Name = "lblFirst";
			this.lblFirst.Size = new System.Drawing.Size(60, 13);
			this.lblFirst.TabIndex = 0;
			this.lblFirst.Text = "First Name:";
			// 
			// txtFirst
			// 
			this.txtFirst.Location = new System.Drawing.Point(150, 27);
			this.txtFirst.Name = "txtFirst";
			this.txtFirst.Size = new System.Drawing.Size(200, 20);
			this.txtFirst.TabIndex = 1;
			// 
			// lblLast
			// 
			this.lblLast.AutoSize = true;
			this.lblLast.Location = new System.Drawing.Point(30, 70);
			this.lblLast.Name = "lblLast";
			this.lblLast.Size = new System.Drawing.Size(61, 13);
			this.lblLast.TabIndex = 2;
			this.lblLast.Text = "Last Name:";
			// 
			// txtLast
			// 
			this.txtLast.Location = new System.Drawing.Point(150, 67);
			this.txtLast.Name = "txtLast";
			this.txtLast.Size = new System.Drawing.Size(200, 20);
			this.txtLast.TabIndex = 3;
			// 
			// btnCheck
			// 
			this.btnCheck.Location = new System.Drawing.Point(150, 110);
			this.btnCheck.Name = "btnCheck";
			this.btnCheck.Size = new System.Drawing.Size(150, 30);
			this.btnCheck.TabIndex = 4;
			this.btnCheck.Text = "Check Registration";
			this.btnCheck.UseVisualStyleBackColor = true;
			this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
			// 
			// lblResult
			// 
			this.lblResult.Location = new System.Drawing.Point(30, 160);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(350, 30);
			this.lblResult.TabIndex = 5;
			this.lblResult.Text = "";
			// 
			// CheckUserForm
			// 
			this.ClientSize = new System.Drawing.Size(400, 250);
			this.Controls.Add(this.lblResult);
			this.Controls.Add(this.btnCheck);
			this.Controls.Add(this.txtLast);
			this.Controls.Add(this.lblLast);
			this.Controls.Add(this.txtFirst);
			this.Controls.Add(this.lblFirst);
			this.Name = "CheckUserForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Check User Registration";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion
	}
}
