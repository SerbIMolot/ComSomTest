/*
 * Created by SharpDevelop.
 * User: Серб
 * Date: 12.07.2021
 * Time: 15:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text;
using System.Management;
using System.Text.RegularExpressions;
namespace ComForm
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	
	public partial class MainForm : Form
	{
		SerialPort port;
		public delegate void AddDataDelegate(String myString, Color color);
		public AddDataDelegate myDelegate;
		public Array SortComPorts(){
			string[] Ports = SerialPort.GetPortNames();
			if(Ports.Length<=0) return(new string[0]);
			
			List<int> sortedNumbers = new List<int>();
			
			for(int i=0;i<Ports.Length;i++) {
				if(Ports[i].Contains("COM") ) {
					int num = int.Parse(Ports[i].Replace("COM",""));
					if(num == 0) continue;
					sortedNumbers.Add(num);
				}
			}
			
			if(sortedNumbers.Count<=0) return(new string[0]);
			
			sortedNumbers.Sort();
			
			string[] SortPorts = new string[sortedNumbers.Count];
			
			for(int i=0;i<SortPorts.Length;i++) {
				if(sortedNumbers[i] == 0) continue; //TODO: REPLACE OR UNCOMMENT
				SortPorts[i] = "COM" + sortedNumbers[i];
			}

			return(SortPorts);
		}
		public MainForm()
		{
			InitializeComponent();
            
			List<string> ports = new List<string>();
			List<int> int_ports = new List<int>();
			try
                {
                    ManagementObjectSearcher searcher =
                        new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity");


	                foreach ( ManagementObject currentObject in searcher . Get ( ) )
				    {
			                    	
				    	string caption = null;
					      	if ( currentObject != null )
					      	{
					        	object currentObjectCaption = currentObject [ "Caption" ];
					        	if ( currentObjectCaption != null )
					        	{
					          		caption = currentObjectCaption . ToString ( );
					          		if ( caption . Contains ( "(COM" ) )
					          		{
					          			int maches = Regex.Matches(caption, @"\(COM").Count;
					          			if(maches > 1) {
					          				for(int i = 0; i < maches; i++) {
						          				int index = caption.LastIndexOf("(COM" );
						          				
						          				string com = caption.Substring(index). Replace ("(",string.Empty).Replace(")", string.Empty );
						          				
						          				caption.Remove(index,4);
						          				
						          				ports.Add(  com );
						          		
						          				int_ports.Add( int.Parse(Regex.Replace(com, "[^0-9.]", "")));
					          				}

					          			} else {
						          			string com = caption.Substring(caption.LastIndexOf("(COM" )). Replace ("(",string.Empty).Replace(")", string.Empty );
					          				ports.Add(  com );
					          		
					          				int_ports.Add( int.Parse(Regex.Replace(com, "[^0-9.]", "")));	
					          			}
					          			
				         		 	}
				        		}
				      		}
      				}
                }
			
			
                catch (ManagementException e)
                {
                    MessageBox.Show("An error occurred while querying for WMI data: " + e.Message);
                }
                int_ports.Sort();
                
			for(int i = 0; i < int_ports.Count; i++) {
                	
                	this.portsBox.Items.Add("COM"+int_ports[i].ToString() );
			}
                Array test = SortComPorts();
			for(int i = 0; i < test.Length; i++) {
                	
                	this.testPortBox.Items.Add(test.GetValue(i).ToString() );
			}   
             
                
			if(ports.Count!= 0) {
				this.portsBox.SelectedIndex = 0;
				this.testPortBox.SelectedIndex = 0;
			}
			this.myDelegate = new AddDataDelegate(writeToError);
			
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
			this.baudrateBox.SelectedIndex = 0;


			this.handhakeBox.Items.AddRange(Enum.GetNames(typeof(Handshake)));
			this.parityBox.Items.AddRange(Enum.GetNames(typeof(System.IO.Ports.Parity)));
			
			this.handhakeBox.SelectedIndex = 0;
			this.parityBox.SelectedIndex = 0;
			string[] stopBits = Enum.GetNames(typeof(StopBits));
			
			List<string> tmp = new List<string>(stopBits);
			tmp.RemoveAt(0);
			stopBits = tmp.ToArray();
			
			this.stopBitsBox.Items.AddRange( stopBits );
			this.stopBitsBox.SelectedIndex = 0;
			
		}
		void onComErrorReceived(object sender, SerialErrorReceivedEventArgs e)
{
			
			this.ErrorLable.Invoke(this.myDelegate, new Object[] {"Received error: type-" + e.EventType + "name- " + e.EventType.ToString()} );

}
		       static int indexOf(byte[] array, byte[] value)
        {
            int found = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[ i ] == value[found])
                {
                    if (++found == value.Length)
                    {
                        return i - found + 1;
                    }
                }
                else
                {
                    found = 0;
                }
                        }
            return -1;
        }

		string receivedData = "";
		void onComDataReceived(object sender, SerialDataReceivedEventArgs e){
			SerialPort sPort = (SerialPort) sender;
			
			//sPort.Read(buff,0, buff.Length);
	    
			string str = "";
			
			byte[] chunk = new byte[sPort.BytesToRead];

            	sPort.Read(chunk, 0, chunk.Length);
            	str += BitConverter.ToString(chunk);
            	
            	byte[] find = new byte[]{0x55};
            	int index = indexOf(chunk,find);

            	
            	
            	if(index == -1) {
            		
            		this.richTextBox1.Invoke(this.myDelegate, new Object[] {"Error:\nStart of message not found", Color.Red} );
					return;
            	}
            	
            	byte[] buff = new Byte[chunk.Length - (index+2)];
				
            	for(int i = index; i < chunk.Length-2; i++ ) {
            		buff[i - index] = chunk[i];
            	}
            	
            	byte[] KS = new byte[]{ chunk[chunk.Length -2], chunk[chunk.Length-1] };
            	byte[] testcrc = CRC16.GetBytes(buff);
            	
            	if(KS[0] != testcrc[0] && KS[1] != testcrc[1]  ) {
					this.richTextBox1.Invoke(this.myDelegate, new Object[] {"Error\nControl sum is wrong", Color.Red} );
            		
            	}
            	
            	Prefix pref = new Prefix(buff[0],buff[1],buff[2],buff[3]);
            	
            	int threadNum = buff[4];
            	
            	float tekRashod = BitConverter.ToSingle(buff,5);
            	
            	float StartOfDayRashod = BitConverter.ToSingle(buff,9);
            	float PrevDayRashod = BitConverter.ToSingle(buff,13);
            	float fromStart = BitConverter.ToSingle(buff,17);
            	
				this.richTextBox1.Invoke(this.myDelegate, new Object[] {"Received hex:\n " + str, Color.Green} );
//				this.richTextBox1.Invoke(this.myDelegate, new Object[] {"Received: \n" + BitConverter.ToString(buff), Color.Fuchsia} );
//				this.richTextBox1.Invoke(this.myDelegate, new Object[] {"Received: \n" + BitConverter.ToString(buff), Color.Fuchsia} );

		}
		
//		public void writeToError(string text) {
//			this.richTextBox1.AppendText(text+"\n");
//		}

		public void writeToError(string text, Color color) {
		this.richTextBox1.SelectionStart = this.richTextBox1.TextLength;
        this.richTextBox1.SelectionLength = 0;

        this.richTextBox1.SelectionColor = color;
        this.richTextBox1.AppendText(text + "\n");
        this.richTextBox1.SelectionColor = this.richTextBox1.ForeColor;
		//this.richTextBox1.AppendText(text+"\n", color);
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
					
       				port.DataReceived -= onComDataReceived;
					this.port.Close();
				}
			}
			stopBits = (StopBits)Enum.Parse(typeof(StopBits),stopBitsBox.SelectedItem.ToString());
			parity = (Parity)Enum.Parse(typeof(Parity),parityBox.SelectedItem.ToString() );

			handshake = (Handshake)Enum.Parse(typeof(Handshake),handhakeBox.SelectedItem.ToString() );
	
			port.BaudRate =  int.Parse(this.baudrateBox.SelectedItem.ToString());
        	port.Parity   = parity;
        	port.StopBits = StopBits.One;
        	port.DataBits = int.Parse(this.dataBitsNum.Text);
       		port.Handshake = handshake;
       		port.DataReceived += onComDataReceived;
			port.ReadTimeout = int.Parse(this.readTimeoutNum.Text);
        	port.WriteTimeout = int.Parse(this.writeTimeoutNum.Text);
        	port.DtrEnable = checkBox1.Checked;
        	port.RtsEnable = checkBox2.Checked;
        	port.ReceivedBytesThreshold = int.Parse(reveivedBytestrash.Text);
        	
        	
        		
//55 01 17 86 01 6E 04 B7 45 C7 24 24 47 6E 46 CE 45 52 B6 06 46 3A 0A
//55-01-17-86-01-6E-04-B7-45-63-86-24-47-6E-46-CE-45-C2-3C-08-46-49-34
//55-01-17-86-01-6E-04-B7-45-6F-6E-26-47-6E-46-CE-45-F1-DC-0F-46-89-CF
//55 01 17 86 01 6E 04 B7 45 D9 00 27 47 6E 46 CE 45 99 26 12 46 6D D4
//55-01-17-86-01-6E-04-B7-45-16-B8-28-47-6E-46-CE-45-91-03-19-46-22-88


    		try
			{
				this.port.Open();
				this.button1.Text = "Reopen";
				this.ErrorLable.Text = "Port "+ portName.ToString() +" has opened";				
        		
			} catch (Exception ex) {
				this.ErrorLable.Text = "Error opening port" + ex.Message;
				//listBox1.Text += "Error opening port" + ex.Message+ "/n";
				
			}
			
		}
		public static string ByteArrayToString(byte[] ba)
		{
  			StringBuilder hex = new StringBuilder(ba.Length * 2);
  			foreach (byte b in ba)
    			hex.AppendFormat("{0:x2}", b);
  			return hex.ToString();
		}
		
		void SendButtonClick(object sender, EventArgs e)
		{
			if(this.port != null && this.port.IsOpen) {
				
				string testText2 = this.textBox1.Text;
				string testText = "1701761";
				string[] splitted = testText2.Split(' ');
				
				string msg = "";
				
				byte[] msgBytes = Encoding.ASCII.GetBytes(testText.ToCharArray());
				byte[] newByte = new byte[splitted.Length];
				
				
				for(int i = 0; i < newByte.Length; i++ ) {
					byte[] arr = BitConverter.GetBytes(int.Parse(splitted[i]));
					newByte[i] = arr[0];	
				}
				msg += BitConverter.ToString(newByte);

				byte[] testcrc = CRC16.GetBytes(newByte);//new Byte[] {0xAA, 0x01, 0x07, 0x06, 0x01});
		
				
				int messageLenght = newByte.Length + testcrc.Length;
				int startLenght = 10 - messageLenght;
				int arraySize = (newByte.Length + testcrc.Length) <= 10 ? 10 : (newByte.Length + testcrc.Length);
				
				byte[] testFull = new byte[arraySize];
				
				for( int i = 0; i < testFull.Length; i++ ) {
					testFull[i] = 0xFF;
				}
				
			    Array.Copy(newByte, 0, testFull, startLenght, newByte.Length);
			    
				Array.Copy(testcrc, 0, testFull, startLenght + newByte.Length, testcrc.Length );
				
				this.port.Write(testFull,0, testFull.Length);
				
				writeToError("Sending:\n " + BitConverter.ToString(testFull), Color.Blue);
				
			}
			
		}

		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void Label9Click(object sender, EventArgs e)
		{
			
		}
		
		void RichTextBox1TextChanged(object sender, EventArgs e)
		{
		}
		
		void CloseButtonClick(object sender, EventArgs e)
		{
			if( port != null && port.IsOpen ) {
				
       			port.DataReceived -= onComDataReceived;
				port.Close();
				this.button1.Text = "Open";
			}
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			string[] ports = SerialPort.GetPortNames();
			
			this.portsBox.Items.Clear();
			for(int i = 0; i < ports.Length; i++) {
				this.portsBox.Items.Add(ports[i]);
			}
			if(ports.Length!= 0) {
				this.portsBox.SelectedIndex = 0;
			}
		}
	}
}
