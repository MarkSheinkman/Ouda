/*
 * Created by SharpDevelop.
 * User: user
 * Date: 25-Sep-14
 * Time: 16:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;

namespace Ouda.Client.Domain
{
	public class PersonData
	{
		public Guid Id { get; set; }
		
		public DateTime Time { get; set; }
		public string Location { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }
		public Gender Gender { get; set; }
		public int Height { get; set; }
		public double Weight { get; set; }
		public double BodyFat { get; set; }
		public double BMI { get; set; }
		public double BloodPressureSys { get; set; }
		public double BloodPressureDia { get; set; }
		public double BloodSugar { get; set; }
		public HepBResult HepB { get; set; }
		public BloodType BloodType { get; set; }
		public string Comment { get; set; }
	}
	
	public enum HepBResult
	{
		Unspecified,
		Positive,
		Negative,
		Inconclusive,
		Vaccinated
	}
	
	public enum Gender
	{
		Unspecified,
		Male,
		Female,
		Other
	}    
	
	public enum BloodType
	{
		[Description("Unspecified")]
		Unspecified,
		[Description("O+")]
		O_Pos,
		[Description("O-")]
		O_Neg,
		[Description("A+")]
		A_Pos,
		[Description("A-")]
		A_Neg,
		[Description("B+")]
		B_Pos,
		[Description("B-")]
		B_Neg,
		[Description("AB+")]
		AB_Pos,
		[Description("AB-")]
		AB_Neg
	}
}
