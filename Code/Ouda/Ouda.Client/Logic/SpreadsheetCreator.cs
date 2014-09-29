/*
 * Created by SharpDevelop.
 * User: user
 * Date: 26-Sep-14
 * Time: 16:45
 */
using System;
using System.Collections;
using Ouda.Client.Domain;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Ouda.Client.Logic
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class SpreadsheetCreator
	{
		private SettingsManager m_SettingsManager;
		
		public SpreadsheetCreator(SettingsManager settingsManager)
		{
			m_SettingsManager = settingsManager;
		}
		
		public void Create(
			string targetFileName,
			PersonData[] data)
		{
			var props = typeof(PersonData).GetProperties().ToList();
			
			using(var fileStream = File.OpenWrite(targetFileName))
			using(var writer = new StreamWriter(fileStream))
			{
				foreach (var prop in props) writer.Write("{0},", prop.Name);
				writer.WriteLine();
				
				foreach (var person in data)
                 {
					foreach (var prop in props) writer.Write("{0},", prop.GetValue(person, null));
					writer.WriteLine();
                 }
			}
		}
	}
}
