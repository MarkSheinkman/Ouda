/*
 * Created by SharpDevelop.
 * User: user
 * Date: 25-Sep-14
 * Time: 16:04
 */
using System;
using System.Collections.Generic;
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
		public event EventHandler Submit;
		protected virtual void OnSubmit()
		{
			var handler = Submit;
			if (handler != null)
				handler(this, new EventArgs());
		}
		
		public InputNewPersonControl()
		{
			InitializeComponent();
			
			combo_gender.DataSource = Enum.GetValues(typeof(Gender));
			combo_gender.SelectedItem = Gender.Unspecified;
			
			combo_hepB.DataSource = Enum.GetValues(typeof(HepBResult));
			combo_hepB.SelectedItem = HepBResult.Negative;
			
//			combo_bloodType.DataSource = Enum.GetValues(typeof(BloodType));
//			combo_bloodType.SelectedItem = BloodType.Unspecified;
			
			PopulateComboBox(combo_bloodType, BloodType.Unspecified);
		}
		
		private void PopulateComboBox<TEnum>(ComboBox combo, TEnum defaultValue)
		{
			var values = Enum
				.GetValues(typeof(TEnum))
				.Cast<TEnum>()
				.Select(v=>new Tuple<TEnum, string>(
				        	v,
				        	(Attribute.GetCustomAttribute(
				        		v.GetType().GetField(v.ToString()), 
				        		typeof(DescriptionAttribute)) 
				        		as DescriptionAttribute)
				        		.Description
				))
				.ToList();
			
			combo.DataSource = values;
			combo.ValueMember = "Item1";
			combo.DisplayMember = "Item2";
			
			combo.SelectedValue = defaultValue;
		}

		#region gui event handlers
		
		void InputFieldKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) {
				e.Handled = true;
				if (!SelectNextControl((Control)sender, true, true, true, false)) {
					Parent.SelectNextControl(this, true, true, true, true);
				}
			}
		}
		
		void NumericUpDown_Enter(object sender, EventArgs e)
		{
			var num = (NumericUpDown)sender;
			SelectTextOfNumUpDown(num);
		}
		
		void Combo_Enter(object sender, EventArgs e)
		{
			((ComboBox)sender).DroppedDown = true;
		}
		
		void Combo_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = TrySelectIndex((ComboBox)sender, e.KeyChar);
		}
		void BloodType_KeyDown(object sender, KeyEventArgs e)
		{
			BloodType currentType = (BloodType)combo_bloodType.SelectedValue;
			BloodType? newType = BloodType.Unspecified;

			var As = new HashSet<BloodType>(new BloodType[]{ BloodType.A_Pos, BloodType.A_Neg, BloodType.AB_Pos, BloodType.AB_Neg });
			var Bs = new HashSet<BloodType>(new BloodType[]{ BloodType.B_Pos, BloodType.B_Neg, BloodType.AB_Pos, BloodType.AB_Neg });
			var Ps = new HashSet<BloodType>(new BloodType[]{ BloodType.A_Pos, BloodType.B_Pos, BloodType.AB_Pos, BloodType.O_Pos });

			var descs = Enum
				.GetValues(typeof(BloodType))
				.Cast<BloodType>()
				.Select(t => new 
					{
						Type = t,
						A = As.Contains(t), 
						B = Bs.Contains(t), 
						Pos = Ps.Contains(t),
						Un = t == BloodType.Unspecified
					})
				.ToDictionary(t => t.Type, t => t);

			var currentDesc = descs[currentType];

			switch (e.KeyCode)
			{
				case Keys.A:
					newType = descs.Values
						.Where(t=>!t.Un)
						.Where(t => t.A == !currentDesc.A
							&& t.B == currentDesc.B
							&& t.Pos == currentDesc.Pos)
						.First()
						.Type;
					break;
				case Keys.B:
					newType = descs.Values
						.Where(t=>!t.Un)
						.Where(t => t.A == currentDesc.A
							&& t.B == !currentDesc.B
							&& t.Pos == currentDesc.Pos)
						.First()
						.Type;
					break;
				case Keys.O:
					newType = descs.Values
						.Where(t=>!t.Un)
						.Where(t => t.Pos == currentDesc.Pos
							&& !t.A
							&& !t.B)
						.First()
						.Type;
					break;
				case Keys.Add:
					newType = descs.Values
						.Where(t=>!t.Un)
						.Where(t => t.A == currentDesc.A
							&& t.B == currentDesc.B
							&& t.Pos == true)
						.First()
						.Type;
					break;
				case Keys.Subtract:
				case Keys.OemMinus:
					newType = descs.Values
						.Where(t=>!t.Un)
						.Where(t => t.A == currentDesc.A
							&& t.B == currentDesc.B
							&& t.Pos == false)
						.First()
						.Type;
					break;
				default:
					newType = null;
					break;
			}

			if (newType == null)
				InputFieldKeyDown(sender, e);
			else
			{
				combo_bloodType.SelectedIndex = 
					combo_bloodType
					.Items
					.Cast<Tuple<BloodType, string>>()
					.Select((t, i) => new{t,i})
					.First(t => t.t.Item1 == newType)
					.i;
				e.Handled = true;
				e.SuppressKeyPress = true;
			}
		}
		
		void InputNewPersonControlKeyDown(object sender, KeyEventArgs e)
		{
			if (e.Control && e.KeyCode == Keys.Enter) {
				OnSubmit();
			}
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
			if (tb != null)
				return tb;
			foreach (var childControl in control.Controls) {
				tb = FindTextbox(childControl as Control);
				if (tb != null)
					return tb;
			}
			return null;
		}
		
		bool TrySelectIndex(ComboBox cb, char ch)
		{
			int index;
			if (int.TryParse(ch.ToString(), out index)) {
				if (1 <= index && index <= cb.Items.Count) {
					cb.SelectedIndex = index - 1;
					return true;
				}
			}
			
			return false;
		}
		
		#endregion
		
		public void Setup(string location)
		{
			tb_location.Text = location;
		}
		
		public void Reset()
		{
			tb_location.Text = "";
			tb_name.Text = "";
			num_age.Value = 0;
			combo_gender.SelectedItem = Gender.Unspecified;
			num_height.Value = 0;
			num_weight.Value = 0;
			num_bodyFat.Value = 0;
			num_bmi.Value = 0;
			num_bpSys.Value = 0;
			num_bpDia.Value = 0;
			num_bodyFat.Value = 0;
			combo_hepB.SelectedItem = HepBResult.Negative;
			num_bloodSugar.Value = 0;
			tb_comment.Text = "";
		}
		
		public PersonData GetNewPersonData()
		{
			var person = new PersonData() {
				Id = Guid.NewGuid(),
				Time = DateTime.Now,
				Location = tb_location.Text,
				Name = tb_name.Text,
				Age = (int)num_age.Value,
				Gender = ReadEnumValue<Gender>(combo_gender),
				Height = (int)num_height.Value,
				Weight = (double)num_weight.Value,
				BodyFat = (double)num_bodyFat.Value,
				BMI = (double)num_bmi.Value,
				BloodPressureSys = (double)num_bpSys.Value,
				BloodPressureDia = (double)num_bpDia.Value,
				BloodSugar = (double)num_bodyFat.Value,
				HepB = ReadEnumValue<HepBResult>(combo_hepB),
				Comment = tb_comment.Text,
			};
			
			return person;
		}
		
		private T ReadEnumValue<T>(ComboBox comboBox)
		{
			return (T)Enum.Parse(typeof(T), comboBox.SelectedItem.ToString());
		}
	}
}
