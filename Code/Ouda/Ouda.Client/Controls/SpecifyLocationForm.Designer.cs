/*
 * Created by SharpDevelop.
 * User: user
 * Date: 26-Sep-14
 * Time: 07:17
 */
namespace Ouda.Client.Controls
{
	partial class SpecifyLocationForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btn_ok;
		private System.Windows.Forms.ComboBox combo_location;
		private System.Windows.Forms.Label label1;
		
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
			this.btn_ok = new System.Windows.Forms.Button();
			this.combo_location = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btn_ok
			// 
			this.btn_ok.Location = new System.Drawing.Point(110, 62);
			this.btn_ok.Name = "btn_ok";
			this.btn_ok.Size = new System.Drawing.Size(75, 23);
			this.btn_ok.TabIndex = 1;
			this.btn_ok.Text = "Ok";
			this.btn_ok.UseVisualStyleBackColor = true;
			this.btn_ok.Click += new System.EventHandler(this.Btn_okClick);
			// 
			// combo_location
			// 
			this.combo_location.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.combo_location.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.combo_location.FormattingEnabled = true;
			this.combo_location.Location = new System.Drawing.Point(12, 35);
			this.combo_location.Name = "combo_location";
			this.combo_location.Size = new System.Drawing.Size(173, 21);
			this.combo_location.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(173, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Ok, so where are we today?";
			// 
			// SpecifyLocationForm
			// 
			this.AcceptButton = this.btn_ok;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(191, 92);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.combo_location);
			this.Controls.Add(this.btn_ok);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SpecifyLocationForm";
			this.Text = "Select Location";
			this.ResumeLayout(false);

		}
	}
}
