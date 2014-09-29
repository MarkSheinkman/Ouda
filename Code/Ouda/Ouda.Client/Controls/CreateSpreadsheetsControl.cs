/*
 * Created by SharpDevelop.
 * User: user
 * Date: 26-Sep-14
 * Time: 16:35
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Ouda.Client.Logic;
using Ouda.Client.Domain;
using System.Linq;
using System.Collections.Generic;

namespace Ouda.Client.Controls
{
	/// <summary>
	/// Description of CreateSpreadsheetsControl.
	/// </summary>
	public partial class CreateSpreadsheetsControl : UserControl
	{
		private PersonData[] m_AllPeople;
		private PersonData[] m_FilteredPeople;
		
		SettingsManager m_SettingsManager;
		DataManager m_DataManager;
		
		public CreateSpreadsheetsControl()
		{
			InitializeComponent();
		}
		
		public void Setup(SettingsManager settingsManager, DataManager dataManager)
		{
			m_SettingsManager = settingsManager;
			m_DataManager = dataManager;
			
			m_AllPeople = dataManager.GetAllPeopleData();
			m_FilteredPeople = m_AllPeople.ToArray();
			
			chls_locFilter.Items.AddRange(m_AllPeople.Select(p=>p.Location).Distinct().ToArray());
			
			UpdateFilters();
		}

		private HashSet<string> GetLocationFilter()
		{
			if(!chbx_locFilter.Checked) return null;
			var items = new List<string>();
			foreach (var item in chls_locFilter.SelectedItems) items.Add(item.ToString());
			return new HashSet<string>(items);
		}
		
		private DateTime? GetFromTime()
		{
			if(!chbx_timeFilter.Checked) return null;
			return timepick_from.Value;
		}
		
		private DateTime? GetToTime()
		{
			if(!chbx_timeFilter.Checked) return null;
			return timepick_to.Value;
		}
		
		private void UpdateFilters()
		{
			IEnumerable<PersonData> query = m_AllPeople;
			
			var locFilter = GetLocationFilter();
			var fromTime = GetFromTime();
			var toTime = GetToTime();
			
			if(locFilter != null) query = query.Where(q=>locFilter.Contains(q.Location));
			if(fromTime != null) query = query.Where(q=>q.Time >= fromTime);
			if(toTime != null) query = query.Where(q=>q.Time <= toTime);

			m_FilteredPeople = query.ToArray();
			
			lbl_numEntries.Text = m_FilteredPeople.Count() + " Entries";
		}
		
		#region gui events
		
		void Chbx_locFilterCheckedChanged(object sender, EventArgs e)
		{
			gb_locFilter.Enabled = chbx_locFilter.Checked;
		}
		
		void Chbx_timeFilterCheckedChanged(object sender, EventArgs e)
		{
			gb_timeFilter.Enabled = chbx_timeFilter.Checked;
		}
		
		void Btn_generateClick(object sender, EventArgs e)
		{
			var creator = new SpreadsheetCreator(m_SettingsManager);
			
			using (var dialog = new SaveFileDialog()) 
			{
				if(dialog.ShowDialog() == DialogResult.OK)
				{
					creator.Create(dialog.FileName, m_FilteredPeople);
				}
			}
		}
		
		#endregion
	}
}
