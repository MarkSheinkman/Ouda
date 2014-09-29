/*
 * Created by SharpDevelop.
 * User: user
 * Date: 28-Sep-14
 * Time: 12:55
 */
namespace Ouda.Client.Controls
{
	partial class SpreadsheetCreatorForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private Ouda.Client.Controls.CreateSpreadsheetsControl createSpreadsheetsControl1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.createSpreadsheetsControl1 = new Ouda.Client.Controls.CreateSpreadsheetsControl();
			this.SuspendLayout();
			// 
			// createSpreadsheetsControl1
			// 
			this.createSpreadsheetsControl1.Location = new System.Drawing.Point(12, 12);
			this.createSpreadsheetsControl1.Name = "createSpreadsheetsControl1";
			this.createSpreadsheetsControl1.Size = new System.Drawing.Size(274, 367);
			this.createSpreadsheetsControl1.TabIndex = 0;
			// 
			// SpreadsheetCreatorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(290, 384);
			this.Controls.Add(this.createSpreadsheetsControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "SpreadsheetCreatorForm";
			this.Text = "SpreadsheetCreatorForm";
			this.ResumeLayout(false);

		}
	}
}
