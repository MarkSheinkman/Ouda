/*
 * Created by SharpDevelop.
 * User: user
 * Date: 25-Sep-14
 * Time: 18:04
 */

using System;
using System.ComponentModel;
using Ouda.Client.Domain;
using System.IO;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Ouda.Client.Logic
{
	[Serializable]
	public class Settings
	{
		public string DataFolder { get; set; }

		public string DataFilesPrefix { get; set; }

		public List<string> Locations { get; set; }

		[XmlIgnore]
		public TimeSpan LocationRevalidateInterval { get; set; }

		[Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
		public int LocationRevalidateIntervalSeconds 
		{ 
			get { return (int)LocationRevalidateInterval.TotalSeconds; } 
			set{ LocationRevalidateInterval = TimeSpan.FromSeconds (value);} 
		}

		public readonly string DataFileEtension = "odf";

		public static Settings GetDefault()
		{
			return new Settings() 
			{
				DataFolder = @"data/",
				DataFilesPrefix = "data",
				LocationRevalidateInterval = TimeSpan.FromHours(2)
			};
		}
		
		public Settings()
		{
			Locations = new List<string>();
		}
	}
}
