/*
 * Created by SharpDevelop.
 * User: user
 * Date: 25-Sep-14
 * Time: 21:15
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using Ouda.Client.Logic;

namespace Ouda.Client.Controls
{
	/// <summary>
	/// Description of SettingsEditorForm.
	/// </summary>
	public partial class SettingsEditorForm : Form
	{
		private SettingsManager m_SettingsManager;
		
		public SettingsEditorForm()
		{
			InitializeComponent();
		}
		
		public void Setup(SettingsManager settingsManager)
		{
			m_SettingsManager = settingsManager;
			propertyGrid1.SelectedObject = m_SettingsManager.GetSettings();
		}
		
		void Btn_defaultsClick(object sender, EventArgs e)
		{
			propertyGrid1.SelectedObject = m_SettingsManager.GetDefaultSettings();
		}
		void Btn_okClick(object sender, EventArgs e)
		{
			m_SettingsManager.SaveSettings((Settings)propertyGrid1.SelectedObject);
			Close();
		}
		void Btn_cancelClick(object sender, EventArgs e)
		{
			Close();
		}
		
	}
}
