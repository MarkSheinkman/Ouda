/*
 * Created by SharpDevelop.
 * User: user
 * Date: 25-Sep-14
 * Time: 16:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Ouda.Client
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private Ouda.Client.Controls.InputNewPersonControl personInput;
		private System.Windows.Forms.Button btn_next;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem createSpreadsheetsToolStripMenuItem;
		
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
			this.btn_next = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.createSpreadsheetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.personInput = new Ouda.Client.Controls.InputNewPersonControl();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_next
			// 
			this.btn_next.Location = new System.Drawing.Point(192, 453);
			this.btn_next.Name = "btn_next";
			this.btn_next.Size = new System.Drawing.Size(75, 23);
			this.btn_next.TabIndex = 1;
			this.btn_next.Text = "Next";
			this.btn_next.UseVisualStyleBackColor = true;
			this.btn_next.Click += new System.EventHandler(this.Btn_nextClick);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.fileToolStripMenuItem,
			this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(274, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.settingsToolStripMenuItem,
			this.createSpreadsheetsToolStripMenuItem,
			this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
			this.settingsToolStripMenuItem.Text = "Settings";
			this.settingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItemClick);
			// 
			// createSpreadsheetsToolStripMenuItem
			// 
			this.createSpreadsheetsToolStripMenuItem.Name = "createSpreadsheetsToolStripMenuItem";
			this.createSpreadsheetsToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
			this.createSpreadsheetsToolStripMenuItem.Text = "Create spreadsheets";
			this.createSpreadsheetsToolStripMenuItem.Click += new System.EventHandler(this.CreateSpreadsheetsToolStripMenuItemClick);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// personInput
			// 
			this.personInput.Location = new System.Drawing.Point(12, 27);
			this.personInput.Name = "personInput";
			this.personInput.Size = new System.Drawing.Size(255, 420);
			this.personInput.TabIndex = 3;
			this.personInput.Submit += new System.EventHandler(this.PersonInputSubmit);
			this.personInput.Enter += new System.EventHandler(this.PersonInputEnter);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(274, 479);
			this.Controls.Add(this.personInput);
			this.Controls.Add(this.btn_next);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Ouda.Client";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
