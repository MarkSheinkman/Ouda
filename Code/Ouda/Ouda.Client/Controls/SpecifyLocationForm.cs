/*
 * Created by SharpDevelop.
 * User: user
 * Date: 26-Sep-14
 * Time: 07:17
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using Ouda.Client.Logic;

namespace Ouda.Client.Controls
{
	/// <summary>
	/// Description of SpecifyLocationForm.
	/// </summary>
	public partial class SpecifyLocationForm : Form
	{
		SettingsManager m_SettingsManager;

		public SpecifyLocationForm()
		{
			InitializeComponent();
			combo_location.Focus();
		}
		
		public void Setup(SettingsManager settingsManager)
		{
			m_SettingsManager = settingsManager;
			
			var ss = m_SettingsManager.GetSettings();
			combo_location.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			var autocomplete = new AutoCompleteStringCollection();
			autocomplete.AddRange(ss.Locations.ToArray());
			
			combo_location.AutoCompleteCustomSource = autocomplete;
			combo_location.DataSource = ss.Locations;
		}
		
		
		public string GetSelectedLocation()
		{
			return combo_location.Text;
		}
		
		void Btn_okClick(object sender, EventArgs e)
		{
			var ss = m_SettingsManager.GetSettings();
			ss.Locations.Add(GetSelectedLocation());
			m_SettingsManager.SaveSettings(ss);
			
			this.DialogResult = DialogResult.OK;
			this.Close();
		}
	}
}
