/*
 * Created by SharpDevelop.
 * User: user
 * Date: 25-Sep-14
 * Time: 16:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Ouda.Client.Logic;
using System.IO;
using Ouda.Client.Controls;

namespace Ouda.Client
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private DataManager m_DataManager;
		private SettingsManager m_SettingsManager;
		
		private bool m_NeedLocationSetup;
		private DateTime m_LastInputTime;
		
		private const string SettingsFileName = "settings.xml";
		
		public MainForm()
		{
			InitializeComponent();
			
			m_SettingsManager = new SettingsManager();
			m_DataManager = new DataManager(m_SettingsManager);
				
			personInput.Setup("test location");	
		}
		
		void Btn_nextClick(object sender, EventArgs e)
		{
			personInput.Enabled = false;
			var personData = personInput.GetNewPersonData();
			m_DataManager.SaveToFile(personData);
			m_LastInputTime = DateTime.Now;
			personInput.Reset();
			personInput.Setup(personData.Location);
			personInput.Enabled = true;
			personInput.Focus();
		}
		
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			var dialogResult = MessageBox.Show(
				this, 
				"Exit Ouda?",
				"Exit Ouda?",
				MessageBoxButtons.OKCancel,
				MessageBoxIcon.Asterisk);
			
			e.Cancel = dialogResult != DialogResult.OK;
		}
		
		#region TSMI events
		
		void SettingsToolStripMenuItemClick(object sender, EventArgs e)
		{
			var settingsEditor = new SettingsEditorForm();
			settingsEditor.Setup(m_SettingsManager);
			settingsEditor.ShowDialog(this);
		}
		
		void PersonInputEnter(object sender, EventArgs e)
		{
			var ss = m_SettingsManager.GetSettings();
			
			if(m_LastInputTime < DateTime.Now - ss.LocationRevalidateInterval) m_NeedLocationSetup = true;
			
			if(m_NeedLocationSetup)
			{
				var locForm = new SpecifyLocationForm();
				locForm.Setup(m_SettingsManager);
				if(locForm.ShowDialog(this) == DialogResult.OK)
				{
					personInput.Setup(locForm.GetSelectedLocation());
					m_NeedLocationSetup = false;
					m_LastInputTime = DateTime.Now;
				} 
				else 
				{
					SelectNextControl(personInput, true, true, false, true);
				}
			}
		}
		
		void CreateSpreadsheetsToolStripMenuItemClick(object sender, EventArgs e)
		{
			var form = new SpreadsheetCreatorForm();
			form.Setup(m_SettingsManager, m_DataManager);
			form.Show();
		}
		
		
		#endregion
	}
}