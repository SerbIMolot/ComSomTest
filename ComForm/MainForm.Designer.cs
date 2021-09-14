/*
 * Created by SharpDevelop.
 * User: Серб
 * Date: 12.07.2021
 * Time: 15:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ComForm
{
	partial class MainForm
	{

		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.portsBox = new System.Windows.Forms.ComboBox();
			this.baudrateBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.readTimeoutNum = new System.Windows.Forms.NumericUpDown();
			this.writeTimeoutNum = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.parityBox = new System.Windows.Forms.ComboBox();
			this.stopBitsBox = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.dataBitsNum = new System.Windows.Forms.NumericUpDown();
			this.handhakeBox = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.ErrorLable = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.reveivedBytestrash = new System.Windows.Forms.NumericUpDown();
			this.label10 = new System.Windows.Forms.Label();
			this.closeButton = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.testPortBox = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.readTimeoutNum)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.writeTimeoutNum)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataBitsNum)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.reveivedBytestrash)).BeginInit();
			this.SuspendLayout();
			// 
			// portsBox
			// 
			this.portsBox.FormattingEnabled = true;
			this.portsBox.Location = new System.Drawing.Point(45, 105);
			this.portsBox.Name = "portsBox";
			this.portsBox.Size = new System.Drawing.Size(121, 21);
			this.portsBox.TabIndex = 0;
			// 
			// baudrateBox
			// 
			this.baudrateBox.FormattingEnabled = true;
			this.baudrateBox.Location = new System.Drawing.Point(188, 106);
			this.baudrateBox.Name = "baudrateBox";
			this.baudrateBox.Size = new System.Drawing.Size(121, 21);
			this.baudrateBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(45, 76);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "COM ports";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(188, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Baudrate";
			// 
			// readTimeoutNum
			// 
			this.readTimeoutNum.Location = new System.Drawing.Point(45, 168);
			this.readTimeoutNum.Maximum = new decimal(new int[] {
									10000,
									0,
									0,
									0});
			this.readTimeoutNum.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									-2147483648});
			this.readTimeoutNum.Name = "readTimeoutNum";
			this.readTimeoutNum.Size = new System.Drawing.Size(120, 20);
			this.readTimeoutNum.TabIndex = 4;
			this.readTimeoutNum.Value = new decimal(new int[] {
									2000,
									0,
									0,
									0});
			this.readTimeoutNum.ValueChanged += new System.EventHandler(this.ReadTimeoutNumValueChanged);
			// 
			// writeTimeoutNum
			// 
			this.writeTimeoutNum.Location = new System.Drawing.Point(188, 169);
			this.writeTimeoutNum.Maximum = new decimal(new int[] {
									10000,
									0,
									0,
									0});
			this.writeTimeoutNum.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									-2147483648});
			this.writeTimeoutNum.Name = "writeTimeoutNum";
			this.writeTimeoutNum.Size = new System.Drawing.Size(120, 20);
			this.writeTimeoutNum.TabIndex = 5;
			this.writeTimeoutNum.Value = new decimal(new int[] {
									1000,
									0,
									0,
									0});
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(45, 139);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Receive timeout";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(188, 140);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "Send timeout";
			// 
			// parityBox
			// 
			this.parityBox.FormattingEnabled = true;
			this.parityBox.Location = new System.Drawing.Point(45, 228);
			this.parityBox.Name = "parityBox";
			this.parityBox.Size = new System.Drawing.Size(121, 21);
			this.parityBox.TabIndex = 8;
			// 
			// stopBitsBox
			// 
			this.stopBitsBox.FormattingEnabled = true;
			this.stopBitsBox.Location = new System.Drawing.Point(188, 229);
			this.stopBitsBox.Name = "stopBitsBox";
			this.stopBitsBox.Size = new System.Drawing.Size(121, 21);
			this.stopBitsBox.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(45, 202);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 10;
			this.label5.Text = "Parity";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(188, 203);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 11;
			this.label6.Text = "Stop bits";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(70, 368);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 12;
			this.button1.Text = "Open";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// dataBitsNum
			// 
			this.dataBitsNum.Location = new System.Drawing.Point(45, 287);
			this.dataBitsNum.Maximum = new decimal(new int[] {
									8,
									0,
									0,
									0});
			this.dataBitsNum.Minimum = new decimal(new int[] {
									5,
									0,
									0,
									0});
			this.dataBitsNum.Name = "dataBitsNum";
			this.dataBitsNum.Size = new System.Drawing.Size(120, 20);
			this.dataBitsNum.TabIndex = 13;
			this.dataBitsNum.Value = new decimal(new int[] {
									8,
									0,
									0,
									0});
			// 
			// handhakeBox
			// 
			this.handhakeBox.FormattingEnabled = true;
			this.handhakeBox.Location = new System.Drawing.Point(188, 286);
			this.handhakeBox.Name = "handhakeBox";
			this.handhakeBox.Size = new System.Drawing.Size(121, 21);
			this.handhakeBox.TabIndex = 14;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(188, 260);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 15;
			this.label7.Text = "Handshake ";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(45, 261);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 16;
			this.label8.Text = "Data bits";
			// 
			// ErrorLable
			// 
			this.ErrorLable.Location = new System.Drawing.Point(151, 21);
			this.ErrorLable.Name = "ErrorLable";
			this.ErrorLable.Size = new System.Drawing.Size(132, 55);
			this.ErrorLable.TabIndex = 17;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(306, 368);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 18;
			this.button2.Text = "Send byte";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.SendButtonClick);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(45, 330);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(346, 20);
			this.textBox1.TabIndex = 19;
			this.textBox1.Text = "170 1 ";
			this.textBox1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(188, 314);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(52, 13);
			this.label9.TabIndex = 20;
			this.label9.Text = "Message";
			this.label9.Click += new System.EventHandler(this.Label9Click);
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(398, 287);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(59, 24);
			this.checkBox1.TabIndex = 21;
			this.checkBox1.Text = "drt";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			this.checkBox2.Location = new System.Drawing.Point(397, 309);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(104, 24);
			this.checkBox2.TabIndex = 22;
			this.checkBox2.Text = "rts";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(28, 419);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(409, 178);
			this.richTextBox1.TabIndex = 23;
			this.richTextBox1.Text = "";
			this.richTextBox1.TextChanged += new System.EventHandler(this.RichTextBox1TextChanged);
			// 
			// reveivedBytestrash
			// 
			this.reveivedBytestrash.Location = new System.Drawing.Point(337, 106);
			this.reveivedBytestrash.Name = "reveivedBytestrash";
			this.reveivedBytestrash.Size = new System.Drawing.Size(120, 20);
			this.reveivedBytestrash.TabIndex = 24;
			this.reveivedBytestrash.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(337, 80);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(132, 23);
			this.label10.TabIndex = 25;
			this.label10.Text = "Received bytes trashhold";
			// 
			// closeButton
			// 
			this.closeButton.Location = new System.Drawing.Point(188, 368);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(75, 23);
			this.closeButton.TabIndex = 26;
			this.closeButton.Text = "Close";
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.CloseButtonClick);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(12, 103);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(26, 23);
			this.button3.TabIndex = 27;
			this.button3.Text = "R";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// testPortBox
			// 
			this.testPortBox.FormattingEnabled = true;
			this.testPortBox.Location = new System.Drawing.Point(45, 41);
			this.testPortBox.Name = "testPortBox";
			this.testPortBox.Size = new System.Drawing.Size(121, 21);
			this.testPortBox.TabIndex = 28;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(475, 630);
			this.Controls.Add(this.testPortBox);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.reveivedBytestrash);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.ErrorLable);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.handhakeBox);
			this.Controls.Add(this.dataBitsNum);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.stopBitsBox);
			this.Controls.Add(this.parityBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.writeTimeoutNum);
			this.Controls.Add(this.readTimeoutNum);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.baudrateBox);
			this.Controls.Add(this.portsBox);
			this.Name = "MainForm";
			this.Text = "ComForm";
			((System.ComponentModel.ISupportInitialize)(this.readTimeoutNum)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.writeTimeoutNum)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataBitsNum)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.reveivedBytestrash)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ComboBox testPortBox;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.NumericUpDown reveivedBytestrash;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label ErrorLable;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox handhakeBox;
		private System.Windows.Forms.NumericUpDown dataBitsNum;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox stopBitsBox;
		private System.Windows.Forms.ComboBox parityBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown writeTimeoutNum;
		private System.Windows.Forms.NumericUpDown readTimeoutNum;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox baudrateBox;
		private System.Windows.Forms.ComboBox portsBox;
		
		
		void ReadTimeoutNumValueChanged(object sender, System.EventArgs e)
		{
			
		}
	}
}
