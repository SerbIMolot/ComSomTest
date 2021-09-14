/*
 * Created by SharpDevelop.
 * User: Серб
 * Date: 13.07.2021
 * Time: 8:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;

namespace comReceive
{
	// Another meaningless comment
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public SerialPort port;
		public MainForm()
		{
			InitializeComponent();
			string[] ports = SerialPort.GetPortNames();
			SerialPort prt = new SerialPort("COM18" );
			for(int i = 0; i < ports.Length; i++) {
				this.portsBox.Items.Add(ports[i]);
			}
			
			this.baudrateBox.Items.Add(300);
			this.baudrateBox.Items.Add(600);
			this.baudrateBox.Items.Add(1200);
			this.baudrateBox.Items.Add(2400);
			this.baudrateBox.Items.Add(9600);
			this.baudrateBox.Items.Add(14400);
			this.baudrateBox.Items.Add(19200);
			this.baudrateBox.Items.Add(38400);
			this.baudrateBox.Items.Add(57600);
			this.baudrateBox.Items.Add(115200);
			this.baudrateBox.Items.ToString();

			this.handhakeBox.Items.AddRange(Enum.GetNames(typeof(Handshake)));
			this.parityBox.Items.AddRange(Enum.GetNames(typeof(Parity)));
			
			string[] stopBits = Enum.GetNames(typeof(StopBits));
			
			List<string> tmp = new List<string>(stopBits);
			tmp.RemoveAt(0);
			stopBits = tmp.ToArray();
			
			this.stopBitsBox.Items.AddRange( stopBits );
			

		}
		void onComDataReceived(object sender, 
                                   SerialDataReceivedEventArgs e)
        {
            SerialPort spL = (SerialPort) sender; 
            const int bufSize = 12;
            Byte[] buf = new Byte[bufSize];
            this.ErrorLable.Text = "received from" + spL.PortName +": " + spL.Read(buf, 0, bufSize).ToString();
            Console.WriteLine("Data received");
			
		}
		void Button1Click(object sender, EventArgs e)
		{

			Parity parity;
			StopBits stopBits;
			Handshake handshake;
			
			if(this.stopBitsBox.SelectedItem == null || this.parityBox.SelectedItem == null
			   || this.handhakeBox.SelectedItem == null || this.portsBox.SelectedItem == null 
			   || this.baudrateBox.SelectedItem == null ) {
			
				return;
			}
			object portName = this.portsBox.SelectedItem;
			if(this.port == null ) {
				this.port = new SerialPort(portName.ToString() );
			} else {
				if(this.port.IsOpen ){
					this.port.Close();
				}
			}
			stopBits = (StopBits)Enum.Parse(typeof(StopBits),stopBitsBox.SelectedItem.ToString());
			parity = (Parity)Enum.Parse(typeof(Parity),parityBox.SelectedItem.ToString() );

			handshake = (Handshake)Enum.Parse(typeof(Handshake),handhakeBox.SelectedItem.ToString() );
	
			port.BaudRate = int.Parse(this.baudrateBox.SelectedItem.ToString());
        	port.Parity = parity;
        	port.StopBits = stopBits;
        	port.DataBits = int.Parse(this.dataBitsNum.Text);
       		port.Handshake = handshake;
       		port.DataReceived += onComDataReceived;
			port.ReadTimeout = int.Parse(this.readTimeoutNum.Text);
        	port.WriteTimeout = int.Parse(this.writeTimeoutNow.Text);
        		
			try
			{
				this.port.Open();
				this.button1.Text = "Reopen";
				this.ErrorLable.Text = "Port"+ portName.ToString() +"open";					
				
        		
			} catch (Exception ex) {
				this.ErrorLable.Text = "Error opening port: " + ex.Message;
				
			}
        
		}
	}
}
