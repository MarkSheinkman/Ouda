/*
 * Created by SharpDevelop.
 * User: user
 * Date: 25-Sep-14
 * Time: 20:50
 */
using System;
using Ouda.Client.Logic;
using System.IO;
using System.Linq;

namespace Ouda.Client.Logic
{
	/// <summary>
	/// Description of SettingsManager.
	/// </summary>
	public class SettingsManager
	{
		private Settings m_Settings;

		const string SettingsFileName = "Settings.xml";
		
		public SettingsManager()
		{
			LoadSettings();
		}
		
		public void LoadSettings()
		{
			if(!File.Exists(SettingsFileName))
			{
				m_Settings =  GetDefaultSettings();
			}
			else 
			{
				try
				{
					var ser = new XmlSerializer();
					m_Settings = ser.Deserialize<Settings>(File.ReadAllText(SettingsFileName))[0];
				} 
				catch
				{
					m_Settings =  GetDefaultSettings();
				}
			}
		}
		
		public void SaveSettings(Settings settings)
		{
			m_Settings = CloneSettings(settings);
			m_Settings.Locations = m_Settings.Locations.Distinct().ToList();
			var ser = new XmlSerializer();
			File.WriteAllText(SettingsFileName, ser.Serialize(m_Settings));
		}

		public Settings GetSettings()
		{
			return CloneSettings(m_Settings);
		}
		
		public Settings GetDefaultSettings()
		{
			return Settings.GetDefault();
		}
		
		private Settings CloneSettings(Settings settings)
		{
			var ser = new XmlSerializer();
			return ser.Deserialize<Settings>(ser.Serialize(settings))[0];
		}
	}
}
