/*
 * Created by SharpDevelop.
 * User: user
 * Date: 25-Sep-14
 * Time: 19:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ouda.Client.Logic
{
	/// <summary>
	/// Description of IOudaSerializer.
	/// </summary>
	public interface IOudaSerializer
	{
		string Serialize<T>(T obj);
		T[] Deserialize<T>(string source) where T: new();
	}
}
