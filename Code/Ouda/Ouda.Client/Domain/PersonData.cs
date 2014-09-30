/*
 * Created by SharpDevelop.
 * User: user
 * Date: 25-Sep-14
 * Time: 16:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ouda.Client.Domain
{
	public class PersonData
	{
		public Guid Id { get; set; }
		
		public DateTime Time { get; set; }
		public string Location {get;set;}
		public string Name {get;set;}
		public int Age { get; set; }
		public Gender Gender { get;set; }
		public int Height {get; set;}
		public double Weight { get; set; }
		public double BodyFat { get; set; }
		public double BMI { get; set; }
		public double BloodPressureSys { get; set; }
		public double BloodPressureDia { get; set; }
		public double BloodSugar { get; set; }
		public HepBResult HepB { get; set; }
		public string Comment { get; set; }
	}
	
	public enum HepBResult{Positive, Negative, Inconclusive, Vaccinated}
	
	public enum Gender {Unspecified, Male, Female, Other}
}
