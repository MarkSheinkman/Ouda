/*
 * Created by SharpDevelop.
 * User: user
 * Date: 25-Sep-14
 * Time: 18:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Text;
using System.Collections.Generic;
using System.Reflection;

namespace Ouda.Client.Logic
{
	/// <summary>
	/// VERY basic json serializer, just for now.
	/// TODO: use some 3rd party serializer
	/// </summary>
	public class JsonSerializer
	{
		public JsonSerializer()
		{
		}
		
		public string Serialize<T>(T obj)
		{
			var sb = new StringBuilder();
			Action br = ()=>sb.Append(Environment.NewLine);
			
			var props = typeof(T).GetProperties();
			
			sb.Append("{");
			br();
			
			foreach (var prop in props) {
				sb.AppendFormat("\"{0}\": {1}", 
				                prop.Name, 
				                ConvertPrimitiveValueToString(prop.GetValue(obj, null)));
				br();
			}
			
			sb.Append("}");
			br();
			
			return sb.ToString();
		}
		
		public T[] Deserialize<T>(string str) 
			where T : class, new()
		{
			throw new NotImplementedException();
		}
		
		private string ConvertPrimitiveValueToString(object value)
		{
			if(value is DateTime) return ConvertPrimitiveValueToString(((DateTime)value).ToString("O"));
			if(value is string) return "\"" + value + "\"";
			return value.ToString();
		}
		
		private object ConvertStringToPrimitiveValue(string str, Type type)
		{
			if(type == typeof(int)) return int.Parse(str);
			if(type == typeof(double)) return double.Parse(str);
			if(type == typeof(bool)) return bool.Parse(str);
			if(type == typeof(string)) return str.Substring(1, str.Length-2);
			if(type.IsEnum) return Enum.Parse(type, str);
			if(type == typeof(DateTime)) return DateTime.ParseExact((string)ConvertStringToPrimitiveValue(str, typeof(string)), "O", null);
			throw new Exception("Unexpected type " + type.Name + " with value '" + str +"'");
		}
		
		private Dictionary<string, PropertyInfo> GetPropsDict<T>()
		{
			var props = typeof(T).GetProperties();
			var dict = new Dictionary<string, PropertyInfo>();
			foreach (var prop in props) {
				dict.Add(prop.Name, prop);
			}
			return dict;
		}
	}
}
