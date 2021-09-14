/*
 * Created by SharpDevelop.
 * User: Серб
 * Date: 12.07.2021
 * Time: 15:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Management;
using System.IO.Ports;


namespace ComSender
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			SerialPort port = new SerialPort("COM1");
			port.BaudRate = 9600;
        	port.Parity = Parity.None;
        	port.StopBits = StopBits.One;
        	port.DataBits = 8;
       		port.Handshake = Handshake.None;
       		
			port.ReadTimeout = 500;
        	port.WriteTimeout = 500;
        		
			try
			{
				port.Open();

        		
			} catch (Exception ex) {
				
				Console.WriteLine(ex.Message);
				
			}
			
			port.WriteLine("Byte");
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}