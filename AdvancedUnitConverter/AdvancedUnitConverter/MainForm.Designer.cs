namespace AdvancedUnitConverter
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel pnlMain, pnlHistory;
		private System.Windows.Forms.ComboBox cmbCategory, cmbFrom, cmbTo, cmbSubstance;
		private System.Windows.Forms.TextBox txtValue;
		private System.Windows.Forms.Label lblTitle, lblResult, lblFrom, lblTo;
		private System.Windows.Forms.Label lblFromUnit, lblToUnit;
		private System.Windows.Forms.Button btnConvert, btnReset, btnExit, btnHistory;
		private System.Windows.Forms.ListBox lstHistory;
		private System.Windows.Forms.CheckBox chkThemeToggle;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
				components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.pnlMain = new System.Windows.Forms.Panel();
			this.pnlHistory = new System.Windows.Forms.Panel();
			this.cmbCategory = new System.Windows.Forms.ComboBox();
			this.cmbFrom = new System.Windows.Forms.ComboBox();
			this.cmbTo = new System.Windows.Forms.ComboBox();
			this.cmbSubstance = new System.Windows.Forms.ComboBox();
			this.txtValue = new System.Windows.Forms.TextBox();
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblResult = new System.Windows.Forms.Label();
			this.lblFrom = new System.Windows.Forms.Label();
			this.lblTo = new System.Windows.Forms.Label();
			this.lblFromUnit = new System.Windows.Forms.Label();
			this.lblToUnit = new System.Windows.Forms.Label();
			this.btnConvert = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnHistory = new System.Windows.Forms.Button();
			this.lstHistory = new System.Windows.Forms.ListBox();
			this.chkThemeToggle = new System.Windows.Forms.CheckBox();

			// Main panel
			this.pnlMain.SetBounds(20, 20, 420, 420);
			this.pnlMain.BackColor = System.Drawing.Color.White;

			// History panel
			this.pnlHistory.SetBounds(460, 60, 240, 380);
			this.pnlHistory.BackColor = System.Drawing.Color.White;
			this.pnlHistory.Visible = false;

			// Title
			this.lblTitle.Text = "Unit Converter";
			this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
			this.lblTitle.Location = new System.Drawing.Point(15, 13);
			this.lblTitle.AutoSize = true;

			// Category
			this.cmbCategory.SetBounds(20, 60, 180, 30);
			this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

			// From label
			this.lblFrom.Text = "From";
			this.lblFrom.SetBounds(20, 90, 50, 20);

			// From combo
			this.cmbFrom.SetBounds(20, 110, 180, 30);
			this.cmbFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

			// From unit label
			this.lblFromUnit.SetBounds(20, 145, 180, 18);
			this.lblFromUnit.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.lblFromUnit.ForeColor = System.Drawing.Color.Gray;

			// To label
			this.lblTo.Text = "To";
			this.lblTo.SetBounds(220, 90, 50, 20);

			// To combo
			this.cmbTo.SetBounds(220, 110, 180, 30);
			this.cmbTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

			// To unit label
			this.lblToUnit.SetBounds(220, 145, 180, 18);
			this.lblToUnit.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.lblToUnit.ForeColor = System.Drawing.Color.Gray;

			// Substance
			this.cmbSubstance.SetBounds(20, 150, 180, 30);
			this.cmbSubstance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSubstance.Visible = false;

			// Value
			this.txtValue.SetBounds(20, 190, 180, 30);

			// Convert
			this.btnConvert.SetBounds(20, 230, 180, 35);
			this.btnConvert.Text = "Convert";

			// Reset
			this.btnReset.SetBounds(220, 230, 180, 35);
			this.btnReset.Text = "Reset";

			// Result
			this.lblResult.SetBounds(20, 280, 380, 30);
			this.lblResult.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);

			// Theme toggle
			this.chkThemeToggle.SetBounds(20, 330, 140, 35);
			this.chkThemeToggle.Appearance = System.Windows.Forms.Appearance.Button;
			this.chkThemeToggle.Text = "Light / Dark";
			this.chkThemeToggle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

			// Exit
			this.btnExit.SetBounds(220, 330, 180, 35);
			this.btnExit.Text = "Exit";

			// History button
			this.btnHistory.SetBounds(680, 10, 40, 40);
			this.btnHistory.Text = "📜";

			// History list
			this.lstHistory.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlHistory.Controls.Add(this.lstHistory);

			// Events to update unit labels
			this.cmbFrom.SelectedIndexChanged += (s, e) =>
				this.lblFromUnit.Text = this.cmbFrom.SelectedItem?.ToString();

			this.cmbTo.SelectedIndexChanged += (s, e) =>
				this.lblToUnit.Text = this.cmbTo.SelectedItem?.ToString();

			// Add controls
			this.pnlMain.Controls.AddRange(new System.Windows.Forms.Control[]
			{
				this.lblTitle,
				this.cmbCategory,
				this.lblFrom,
				this.cmbFrom,
				this.lblFromUnit,
				this.lblTo,
				this.cmbTo,
				this.lblToUnit,
				this.cmbSubstance,
				this.txtValue,
				this.btnConvert,
				this.btnReset,
				this.lblResult,
				this.chkThemeToggle,
				this.btnExit
			});

			this.Controls.AddRange(new System.Windows.Forms.Control[]
			{
				this.pnlMain,
				this.pnlHistory,
				this.btnHistory
			});

			// Form
			this.Text = "Advanced Unit Converter";
			this.ClientSize = new System.Drawing.Size(740, 480);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
		}
	}
}
