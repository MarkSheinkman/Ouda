/*
 * Created by SharpDevelop.
 * User: user
 * Date: 28-Sep-14
 * Time: 12:55
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using Ouda.Client.Logic;

namespace Ouda.Client.Controls
{
	/// <summary>
	/// Description of SpreadsheetCreatorForm.
	/// </summary>
	public partial class SpreadsheetCreatorForm : Form
	{
		public SpreadsheetCreatorForm()
		{
			InitializeComponent();
		}
		
		public void Setup(SettingsManager settingsManager, DataManager dataManager)
		{
			createSpreadsheetsControl1.Setup(settingsManager, dataManager);
		}
	}
}
