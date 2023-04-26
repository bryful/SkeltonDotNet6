namespace SkeltonDotNet6
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			textBox1 = new TextBox();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			textBox1.BackColor = Color.FromArgb(64, 64, 64);
			textBox1.BorderStyle = BorderStyle.FixedSingle;
			textBox1.ForeColor = Color.FromArgb(230, 230, 230);
			textBox1.Location = new Point(12, 47);
			textBox1.Multiline = true;
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(863, 374);
			textBox1.TabIndex = 0;
			// 
			// MainForm
			// 
			AllowDrop = true;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(896, 442);
			Controls.Add(textBox1);
			Name = "MainForm";
			Text = "MainForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
	}
}