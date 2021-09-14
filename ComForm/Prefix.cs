/*
 * Created by SharpDevelop.
 * User: Серб
 * Date: 16.07.2021
 * Time: 9:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ComForm
{
	/// <summary>
	/// Description of Prefix.
	/// </summary>
	public class Prefix
	{
		public int syncByte;
		public int adress;
		public int lenght;
		public int functionCode;
		
		public Prefix(int syncByte, int adress, int lenght, int functionCode)
		{
			this.syncByte = syncByte;
			this.adress = adress;
			this.lenght = lenght;
			this.functionCode = functionCode;
		}
		
		public Prefix(byte syncByte, byte adress, byte lenght, byte functionCode)
		{
			this.syncByte = Convert.ToInt32(syncByte);
			this.adress =  Convert.ToInt32(adress);
			this.lenght = Convert.ToInt32(lenght);
			this.functionCode = Convert.ToInt32(functionCode);
		}
	}
}
