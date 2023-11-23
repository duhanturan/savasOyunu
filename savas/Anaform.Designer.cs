namespace savas
{
	partial class Anaform
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anaform));
			this.bilgiAlaniPanel = new System.Windows.Forms.Panel();
			this.ucaksavarPanel = new System.Windows.Forms.Panel();
			this.sureLabel = new System.Windows.Forms.Panel();
			this.bilgiLabel = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.bilgiAlaniPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// bilgiAlaniPanel
			// 
			this.bilgiAlaniPanel.BackColor = System.Drawing.Color.SteelBlue;
			this.bilgiAlaniPanel.Controls.Add(this.label2);
			this.bilgiAlaniPanel.Controls.Add(this.bilgiLabel);
			this.bilgiAlaniPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.bilgiAlaniPanel.Location = new System.Drawing.Point(0, 0);
			this.bilgiAlaniPanel.Name = "bilgiAlaniPanel";
			this.bilgiAlaniPanel.Size = new System.Drawing.Size(1203, 115);
			this.bilgiAlaniPanel.TabIndex = 0;
			// 
			// ucaksavarPanel
			// 
			this.ucaksavarPanel.BackColor = System.Drawing.Color.Teal;
			this.ucaksavarPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.ucaksavarPanel.Location = new System.Drawing.Point(0, 678);
			this.ucaksavarPanel.Name = "ucaksavarPanel";
			this.ucaksavarPanel.Size = new System.Drawing.Size(1203, 50);
			this.ucaksavarPanel.TabIndex = 1;
			// 
			// sureLabel
			// 
			this.sureLabel.BackColor = System.Drawing.Color.DarkOliveGreen;
			this.sureLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sureLabel.Location = new System.Drawing.Point(0, 115);
			this.sureLabel.Name = "sureLabel";
			this.sureLabel.Size = new System.Drawing.Size(1203, 563);
			this.sureLabel.TabIndex = 2;
			// 
			// bilgiLabel
			// 
			this.bilgiLabel.AutoSize = true;
			this.bilgiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.bilgiLabel.ForeColor = System.Drawing.Color.White;
			this.bilgiLabel.Location = new System.Drawing.Point(12, 9);
			this.bilgiLabel.Name = "bilgiLabel";
			this.bilgiLabel.Size = new System.Drawing.Size(743, 93);
			this.bilgiLabel.TabIndex = 0;
			this.bilgiLabel.Text = "Oyunu başlatmak için ENTER tuşuna basınız.\r\nUçaksavarı hareket ettirmek için Sağ/" +
    "Sol yön tuşlarına basın.\r\nAteş etmek için BOŞLUK tuşuna basın.\r\n";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(963, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(217, 66);
			this.label2.TabIndex = 1;
			this.label2.Text = "0:00";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Anaform
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1203, 728);
			this.Controls.Add(this.sureLabel);
			this.Controls.Add(this.ucaksavarPanel);
			this.Controls.Add(this.bilgiAlaniPanel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Anaform";
			this.Text = "Savaş Oyunu";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Anaform_KeyDown);
			this.bilgiAlaniPanel.ResumeLayout(false);
			this.bilgiAlaniPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel bilgiAlaniPanel;
		private System.Windows.Forms.Panel ucaksavarPanel;
		private System.Windows.Forms.Panel sureLabel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label bilgiLabel;
	}
}

