using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AdvancedUnitConverter
{
	public partial class MainForm : Form
	{
		private bool darkMode = false;

		private Dictionary<string, Dictionary<string, double>> units =
			new Dictionary<string, Dictionary<string, double>>();

		private Dictionary<string, double> densities =
			new Dictionary<string, double>();

		public MainForm()
		{
			InitializeComponent();
			LoadData();

			// ✅ WIRE ALL EVENTS (CRITICAL)
			cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
			btnConvert.Click += btnConvert_Click;
			btnReset.Click += btnReset_Click;
			btnExit.Click += btnExit_Click;
			btnHistory.Click += btnHistory_Click;
			chkThemeToggle.CheckedChanged += btnTheme_Click;

			ApplyLightTheme();
		}

		private void LoadData()
		{
			cmbCategory.Items.AddRange(new[]
			{
				"Length","Weight","Temperature",
				"Time","Area","Volume","Currency"
			});

			units["Length"] = new Dictionary<string, double>
			{
				{"Meter",1},{"Kilometer",1000},{"Centimeter",0.01}
			};

			units["Weight"] = new Dictionary<string, double>
			{
				{"Gram",1},{"Kilogram",1000},{"Pound",453.592}
			};

			units["Time"] = new Dictionary<string, double>
			{
				{"Second",1},{"Minute",60},{"Hour",3600}
			};

			units["Area"] = new Dictionary<string, double>
			{
				{"Square Meter",1},{"Square Kilometer",1_000_000},{"Square Foot",0.092903}
			};

			units["Volume"] = new Dictionary<string, double>
			{
				{"Milliliter",1},{"Liter",1000},{"Cup",240}
			};

			units["Currency"] = new Dictionary<string, double>
			{
				{"ETB",1},{"EUR",0.92},{"USD",56}
			};

			densities["Water"] = 1.0;
			densities["Honey"] = 1.42;
			densities["Milk"] = 1.03;

			cmbSubstance.Items.AddRange(new[] { "Water", "Honey", "Milk" });
		}

		private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
		{
			cmbFrom.Items.Clear();
			cmbTo.Items.Clear();
			cmbSubstance.Visible = false;

			string category = cmbCategory.Text;

			if (category == "Temperature")
			{
				string[] t = { "Celsius", "Fahrenheit", "Kelvin" };
				cmbFrom.Items.AddRange(t);
				cmbTo.Items.AddRange(t);
				return;
			}

			if (!units.ContainsKey(category)) return;

			foreach (var u in units[category].Keys)
			{
				cmbFrom.Items.Add(u);
				cmbTo.Items.Add(u);
			}

			if (category == "Volume")
			{
				cmbTo.Items.Add("Gram");
				cmbSubstance.Visible = true;
			}
		}

		private void btnConvert_Click(object sender, EventArgs e)
		{
			if (!double.TryParse(txtValue.Text, out double value))
			{
				MessageBox.Show("Enter a valid number");
				return;
			}

			if (cmbCategory.SelectedIndex == -1 ||
				cmbFrom.SelectedIndex == -1 ||
				cmbTo.SelectedIndex == -1)
			{
				MessageBox.Show("Select category and units");
				return;
			}

			double result = ConvertValue(value);
			lblResult.Text = $"Result: {result:F4}";

			lstHistory.Items.Insert(0,
				$"{value} {cmbFrom.Text} → {result:F4} {cmbTo.Text}");
		}

		private double ConvertValue(double v)
		{
			string cat = cmbCategory.Text;
			string from = cmbFrom.Text;
			string to = cmbTo.Text;

			if (cat == "Temperature")
			{
				if (from == to) return v;
				if (from == "Celsius" && to == "Fahrenheit") return v * 9 / 5 + 32;
				if (from == "Fahrenheit" && to == "Celsius") return (v - 32) * 5 / 9;
				if (from == "Celsius" && to == "Kelvin") return v + 273.15;
				if (from == "Kelvin" && to == "Celsius") return v - 273.15;
			}

			if (cat == "Volume" && to == "Gram")
			{
				if (cmbSubstance.SelectedIndex == -1)
				{
					MessageBox.Show("Select substance");
					return 0;
				}

				double ml = v * units["Volume"][from];
				return ml * densities[cmbSubstance.Text];
			}

			return v * units[cat][from] / units[cat][to];
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			txtValue.Clear();
			lblResult.Text = "Result:";
			cmbFrom.SelectedIndex = -1;
			cmbTo.SelectedIndex = -1;
		}

		private void btnTheme_Click(object sender, EventArgs e)
		{
			darkMode = chkThemeToggle.Checked;
			if (darkMode) ApplyDarkTheme();
			else ApplyLightTheme();
		}

		private void ApplyDarkTheme()
		{
			BackColor = Color.FromArgb(30, 30, 45);
			pnlMain.BackColor = Color.FromArgb(45, 45, 65);
			StyleButtons(Color.FromArgb(90, 90, 140), Color.White);
		}

		private void ApplyLightTheme()
		{
			BackColor = Color.FromArgb(240, 242, 245);
			pnlMain.BackColor = Color.White;
			StyleButtons(Color.FromArgb(52, 152, 219), Color.White);
		}

		private void StyleButtons(Color back, Color fore)
		{
			foreach (Control c in pnlMain.Controls)
			{
				if (c is Button b)
				{
					b.BackColor = back;
					b.ForeColor = fore;
					b.FlatStyle = FlatStyle.Flat;
					b.FlatAppearance.BorderSize = 0;
				}
			}
		}

		private void btnHistory_Click(object sender, EventArgs e)
		{
			pnlHistory.Visible = !pnlHistory.Visible;
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
