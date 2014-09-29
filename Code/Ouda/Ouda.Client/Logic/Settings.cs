/*
 * Created by SharpDevelop.
 * User: user
 * Date: 25-Sep-14
 * Time: 18:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using Ouda.Client.Domain;
using System.IO;
using System.Collections.Generic;

namespace Ouda.Client.Logic
{
	[Serializable]
	public class Settings
	{
		public string DataFolder {
			get;
			set;
		}

		public string DataFilesPrefix {
			get;
			set;
		}

		public List<string> Locations {
			get;
			set;
		}

		public TimeSpan LocationRevalidateInterval {
			get{return TimeSpan.FromSeconds(LocationRevalidateIntervalSeconds);}
			set{LocationRevalidateIntervalSeconds = (int)value.TotalSeconds;}
		}
		
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int LocationRevalidateIntervalSeconds{
			get;
			set;
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


