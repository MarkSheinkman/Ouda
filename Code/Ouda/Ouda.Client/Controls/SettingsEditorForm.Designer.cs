/*
 * Created by SharpDevelop.
 * User: user
 * Date: 25-Sep-14
 * Time: 21:15
 */
namespace Ouda.Client.Controls
{
	partial class SettingsEditorForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PropertyGrid propertyGrid1;
		private System.Windows.Forms.Button btn_cancel;
		private System.Windows.Forms.Button btn_ok;
		private System.Windows.Forms.Button btn_defaults;
		
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
			this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.btn_ok = new System.Windows.Forms.Button();
			this.btn_defaults = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// propertyGrid1
			// 
			this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.propertyGrid1.Location = new System.Drawing.Point(12, 12);
			this.propertyGrid1.Name = "propertyGrid1";
			this.propertyGrid1.Size = new System.Drawing.Size(537, 389);
			this.propertyGrid1.TabIndex = 0;
			// 
			// btn_cancel
			// 
			this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btn_cancel.Location = new System.Drawing.Point(474, 407);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.Size = new System.Drawing.Size(75, 23);
			this.btn_cancel.TabIndex = 1;
			this.btn_cancel.Text = "Cancel";
			this.btn_cancel.UseVisualStyleBackColor = true;
			this.btn_cancel.Click += new System.EventHandler(this.Btn_cancelClick);
			// 
			// btn_ok
			// 
			this.btn_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_ok.Location = new System.Drawing.Point(393, 407);
			this.btn_ok.Name = "btn_ok";
			this.btn_ok.Size = new System.Drawing.Size(75, 23);
			this.btn_ok.TabIndex = 2;
			this.btn_ok.Text = "Ok";
			this.btn_ok.UseVisualStyleBackColor = true;
			this.btn_ok.Click += new System.EventHandler(this.Btn_okClick);
			// 
			// btn_defaults
			// 
			this.btn_defaults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_defaults.Location = new System.Drawing.Point(12, 407);
			this.btn_defaults.Name = "btn_defaults";
			this.btn_defaults.Size = new System.Drawing.Size(75, 23);
			this.btn_defaults.TabIndex = 3;
			this.btn_defaults.Text = "Defaults";
			this.btn_defaults.UseVisualStyleBackColor = true;
			this.btn_defaults.Click += new System.EventHandler(this.Btn_defaultsClick);
			// 
			// SettingsEditorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btn_cancel;
			this.ClientSize = new System.Drawing.Size(561, 442);
			this.Controls.Add(this.btn_defaults);
			this.Controls.Add(this.btn_ok);
			this.Controls.Add(this.btn_cancel);
			this.Controls.Add(this.propertyGrid1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingsEditorForm";
			this.Text = "SettingsEditorForm";
			this.ResumeLayout(false);

		}
	}
}
