/*
 * Created by SharpDevelop.
 * User: user
 * Date: 25-Sep-14
 * Time: 16:04
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Linq;
using Ouda.Client.Domain;

namespace Ouda.Client.Controls
{
	/// <summary>
	/// Description of InputNewPersonControl.
	/// </summary>
	public partial class InputNewPersonControl : UserControl
	{
		public InputNewPersonControl()
		{
			InitializeComponent();
			
			combo_hepB.DataSource = Enum.GetValues(typeof(HepBResult));
			combo_hepB.SelectedItem = HepBResult.Inconclusive;
		}


		#region gui event handlers
		
		void InputFieldKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				e.Handled = true;
				if(!SelectNextControl((Control)sender, true, true,true, false))
				{
					Parent.SelectNextControl(this, true, true, true, true);
				}
			}
		}
		
		void NumericUpDown_Enter(object sender, EventArgs e)
		{
			var num = (NumericUpDown)sender;
			SelectTextOfNumUpDown(num);
		}
		
		void Combo_hepBEnter(object sender, EventArgs e)
		{
			combo_hepB.DroppedDown = true;
		}
		
		void Combo_hepBKeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = TrySelectIndex(combo_hepB, e.KeyChar);
		}
		
		#endregion
		
		#region utils
		
		void SelectTextOfNumUpDown(NumericUpDown num)
		{
			var tb = FindTextbox(num);
			tb.SelectAll();
			num.Validate();
		}
		
		TextBoxBase FindTextbox(Control control)
		{
			TextBoxBase tb = control as TextBoxBase;
			if(tb != null) return tb;
			foreach (var childControl in control.Controls)
			{
				tb = FindTextbox(childControl as Control);
				if(tb != null) return tb;
			}
			return null;
		}
		
		bool TrySelectIndex(ComboBox cb, char ch)
		{
			int index;
			if(int.TryParse(ch.ToString(), out index))
			{
				if(1 <= index && index <= cb.Items.Count)
				{
					cb.SelectedIndex = index-1;
					return true;
				}
			}
			
			return false;
		}
		
		#endregion
		
		public void Setup(string location)
		{
			lbl_location.Text = location;
		}
		
		public void Reset()
		{
			lbl_time.Text = "";
			lbl_location.Text = "";
			tb_name.Text = "";
			num_age.Value = 0;
			num_height.Value = 0;
			num_weight.Value = 0;
			num_bodyFat.Value = 0;
			num_bmi.Value = 0;
			num_bpSys.Value = 0;
			num_bpDia.Value = 0;
			num_bodyFat.Value = 0;
			combo_hepB.SelectedItem = HepBResult.Inconclusive;
			tb_comment.Text = "";
		}
		
		public PersonData GetNewPersonData()
		{
			var person =  new PersonData()
			{
				Id = Guid.NewGuid(),
				Time = DateTime.Now,
				Location = lbl_location.Text,
				Name = tb_name.Text,
				Age = (int)num_age.Value,
				Height = (int)num_height.Value,
				Weight = (double)num_weight.Value,
				BodyFat = (double)num_bodyFat.Value,
				BMI = (double)num_bmi.Value,
				BloodPressureSys = (double)num_bpSys.Value,
				BloodPressureDia = (double)num_bpDia.Value,
				BloodSugar = (double)num_bodyFat.Value,
				HepB = (HepBResult)Enum.Parse(typeof(HepBResult), combo_hepB.SelectedItem.ToString()),
				Comment = tb_comment.Text,
			};
			
			return person;
		}
	}
}
