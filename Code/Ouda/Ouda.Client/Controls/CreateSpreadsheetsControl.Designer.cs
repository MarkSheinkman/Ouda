/*
 * Created by SharpDevelop.
 * User: user
 * Date: 26-Sep-14
 * Time: 16:35
 */
namespace Ouda.Client.Controls
{
	partial class CreateSpreadsheetsControl
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.CheckedListBox chls_locFilter;
		private System.Windows.Forms.DateTimePicker timepick_from;
		private System.Windows.Forms.DateTimePicker timepick_to;
		private System.Windows.Forms.CheckBox chbx_locFilter;
		private System.Windows.Forms.CheckBox chbx_timeFilter;
		private System.Windows.Forms.GroupBox gb_locFilter;
		private System.Windows.Forms.GroupBox gb_timeFilter;
		private System.Windows.Forms.Button btn_generate;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbl_numEntries;
		
		/// <summary>
		/// Disposes resources used by the control.
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
			this.chls_locFilter = new System.Windows.Forms.CheckedListBox();
			this.timepick_from = new System.Windows.Forms.DateTimePicker();
			this.timepick_to = new System.Windows.Forms.DateTimePicker();
			this.chbx_locFilter = new System.Windows.Forms.CheckBox();
			this.chbx_timeFilter = new System.Windows.Forms.CheckBox();
			this.gb_locFilter = new System.Windows.Forms.GroupBox();
			this.gb_timeFilter = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_generate = new System.Windows.Forms.Button();
			this.lbl_numEntries = new System.Windows.Forms.Label();
			this.gb_locFilter.SuspendLayout();
			this.gb_timeFilter.SuspendLayout();
			this.SuspendLayout();
			// 
			// chls_locFilter
			// 
			this.chls_locFilter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chls_locFilter.FormattingEnabled = true;
			this.chls_locFilter.Location = new System.Drawing.Point(3, 16);
			this.chls_locFilter.Name = "chls_locFilter";
			this.chls_locFilter.Size = new System.Drawing.Size(257, 150);
			this.chls_locFilter.TabIndex = 0;
			// 
			// timepick_from
			// 
			this.timepick_from.Location = new System.Drawing.Point(55, 19);
			this.timepick_from.Name = "timepick_from";
			this.timepick_from.Size = new System.Drawing.Size(200, 20);
			this.timepick_from.TabIndex = 1;
			// 
			// timepick_to
			// 
			this.timepick_to.Location = new System.Drawing.Point(55, 45);
			this.timepick_to.Name = "timepick_to";
			this.timepick_to.Size = new System.Drawing.Size(200, 20);
			this.timepick_to.TabIndex = 1;
			// 
			// chbx_locFilter
			// 
			this.chbx_locFilter.Location = new System.Drawing.Point(3, 3);
			this.chbx_locFilter.Name = "chbx_locFilter";
			this.chbx_locFilter.Size = new System.Drawing.Size(104, 24);
			this.chbx_locFilter.TabIndex = 0;
			this.chbx_locFilter.Text = "Filter by location";
			this.chbx_locFilter.UseVisualStyleBackColor = true;
			this.chbx_locFilter.CheckedChanged += new System.EventHandler(this.Chbx_locFilterCheckedChanged);
			// 
			// chbx_timeFilter
			// 
			this.chbx_timeFilter.Location = new System.Drawing.Point(6, 208);
			this.chbx_timeFilter.Name = "chbx_timeFilter";
			this.chbx_timeFilter.Size = new System.Drawing.Size(104, 24);
			this.chbx_timeFilter.TabIndex = 0;
			this.chbx_timeFilter.Text = "Filter by time";
			this.chbx_timeFilter.UseVisualStyleBackColor = true;
			this.chbx_timeFilter.CheckedChanged += new System.EventHandler(this.Chbx_timeFilterCheckedChanged);
			// 
			// gb_locFilter
			// 
			this.gb_locFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.gb_locFilter.Controls.Add(this.chls_locFilter);
			this.gb_locFilter.Enabled = false;
			this.gb_locFilter.Location = new System.Drawing.Point(3, 33);
			this.gb_locFilter.Name = "gb_locFilter";
			this.gb_locFilter.Size = new System.Drawing.Size(263, 169);
			this.gb_locFilter.TabIndex = 3;
			this.gb_locFilter.TabStop = false;
			this.gb_locFilter.Text = "Location filter";
			// 
			// gb_timeFilter
			// 
			this.gb_timeFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.gb_timeFilter.Controls.Add(this.label2);
			this.gb_timeFilter.Controls.Add(this.label1);
			this.gb_timeFilter.Controls.Add(this.timepick_from);
			this.gb_timeFilter.Controls.Add(this.timepick_to);
			this.gb_timeFilter.Enabled = false;
			this.gb_timeFilter.Location = new System.Drawing.Point(6, 238);
			this.gb_timeFilter.Name = "gb_timeFilter";
			this.gb_timeFilter.Size = new System.Drawing.Size(260, 73);
			this.gb_timeFilter.TabIndex = 3;
			this.gb_timeFilter.TabStop = false;
			this.gb_timeFilter.Text = "Time filter";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(6, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "To:";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "From:";
			// 
			// btn_generate
			// 
			this.btn_generate.Location = new System.Drawing.Point(3, 340);
			this.btn_generate.Name = "btn_generate";
			this.btn_generate.Size = new System.Drawing.Size(75, 23);
			this.btn_generate.TabIndex = 4;
			this.btn_generate.Text = "Generate";
			this.btn_generate.UseVisualStyleBackColor = true;
			this.btn_generate.Click += new System.EventHandler(this.Btn_generateClick);
			// 
			// lbl_numEntries
			// 
			this.lbl_numEntries.Location = new System.Drawing.Point(6, 314);
			this.lbl_numEntries.Name = "lbl_numEntries";
			this.lbl_numEntries.Size = new System.Drawing.Size(260, 23);
			this.lbl_numEntries.TabIndex = 5;
			this.lbl_numEntries.Text = "label3";
			// 
			// CreateSpreadsheetsControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lbl_numEntries);
			this.Controls.Add(this.btn_generate);
			this.Controls.Add(this.gb_timeFilter);
			this.Controls.Add(this.gb_locFilter);
			this.Controls.Add(this.chbx_timeFilter);
			this.Controls.Add(this.chbx_locFilter);
			this.Name = "CreateSpreadsheetsControl";
			this.Size = new System.Drawing.Size(274, 367);
			this.gb_locFilter.ResumeLayout(false);
			this.gb_timeFilter.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
