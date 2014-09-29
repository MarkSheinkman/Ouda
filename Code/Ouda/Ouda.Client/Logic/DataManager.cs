/*
 * Created by SharpDevelop.
 * User: user
 * Date: 25-Sep-14
 * Time: 18:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Ouda.Client.Domain;
using System.IO;
using System.Linq;


namespace Ouda.Client.Logic
{
	/// <summary>
	/// Description of DataManager.
	/// </summary>
	public class DataManager
	{
		SettingsManager m_SettingsManager;
		IOudaSerializer m_Serializer;
		
		public DataManager(SettingsManager settingsManager)
		{
			m_SettingsManager = settingsManager;
			m_Serializer = new XmlSerializer();
		}
		
		public void SaveToFile(PersonData person)
		{
			var ss = m_SettingsManager.GetSettings();
			
			if(!Directory.Exists(ss.DataFolder)) Directory.CreateDirectory(ss.DataFolder);
			
			var fileName = Path.Combine(ss.DataFolder, GetDataFileNameForPerson(person));
			File.AppendAllText(fileName, m_Serializer.Serialize(person));
			File.AppendAllText(fileName, Environment.NewLine);
		}
		
		public void SendEverythingToServer()
		{
			throw new NotImplementedException();
		}
		
		public PersonData[] GetAllPeopleData()
		{
			var ss = m_SettingsManager.GetSettings();
			if(!Directory.Exists(ss.DataFolder)) return new PersonData[0];
			
			var files = Directory.GetFiles(ss.DataFolder, "*."+ss.DataFileEtension);
			
			return files.SelectMany(f=>SafeReadPersonData(f)).Where(d=>d!=null).ToArray();
		}

		private PersonData[] SafeReadPersonData(string filePath)
		{
			try {
				return m_Serializer.Deserialize<PersonData>(File.ReadAllText(filePath));
			} catch {
				return new PersonData[0];
			}
		}
		
		
		#region utils
		
		private string GetPersonCsv(PersonData person)
		{
			return 
				person.Location + "," + 
				person.Time.ToString("O") + ", ";
		}
		
		private string GetDataFileNameForPerson(PersonData person)
		{
			var ss = m_SettingsManager.GetSettings();
			return 
				ss.DataFilesPrefix +
				"_" + GetTimeTag(person.Time) + 
				"." + ss.DataFileEtension;
		}
		
		private string GetTimeTag(DateTime time)
		{
			return time.ToString("yyyyMMddTHHmmssfff");
		}
		
		#endregion
		
	}
}
