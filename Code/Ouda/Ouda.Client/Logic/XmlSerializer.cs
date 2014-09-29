/*
 * Created by SharpDevelop.
 * User: user
 * Date: 25-Sep-14
 * Time: 19:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Xml.Serialization;
using System.IO;
using System.Text;

namespace Ouda.Client.Logic
{
	/// <summary>
	/// Description of XmlSerializer.
	/// </summary>
	public class XmlSerializer : IOudaSerializer
	{
		public XmlSerializer()
		{
		}
		
		public string Serialize<T>(T obj)
		{
			var  fact = new XmlSerializerFactory();
			var ser = fact.CreateSerializer(typeof(T));
			
			var writer = new StringWriter();
			ser.Serialize(writer, obj);
			
			return writer.ToString();
		}
		
		public T[] Deserialize<T>(string source)
			where T: new()
		{
			var  fact = new XmlSerializerFactory();
			var ser = fact.CreateSerializer(typeof(T));
			
			var reader = new StringReader(source);
			return new T[]{(T)ser.Deserialize(reader)};
		}
		
	}
}
