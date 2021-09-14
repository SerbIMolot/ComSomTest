/*
 * Created by SharpDevelop.
 * User: Серб
 * Date: 13.07.2021
 * Time: 8:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace comReceive
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
	this.writeTimeoutNow = new System.Windows.Forms.NumericUpDown();
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
	((System.ComponentModel.ISupportInitialize)(this.readTimeoutNum)).BeginInit();
	((System.ComponentModel.ISupportInitialize)(this.writeTimeoutNow)).BeginInit();
	((System.ComponentModel.ISupportInitialize)(this.dataBitsNum)).BeginInit();
	this.SuspendLayout();
	// 
	// portsBox
	// 
	this.portsBox.FormattingEnabled = true;
	this.portsBox.Location = new System.Drawing.Point(51, 60);
	this.portsBox.Name = "portsBox";
	this.portsBox.Size = new System.Drawing.Size(121, 21);
	this.portsBox.TabIndex = 0;
	// 
	// baudrateBox
	// 
	this.baudrateBox.FormattingEnabled = true;
	this.baudrateBox.Location = new System.Drawing.Point(277, 60);
	this.baudrateBox.Name = "baudrateBox";
	this.baudrateBox.Size = new System.Drawing.Size(121, 21);
	this.baudrateBox.TabIndex = 1;
	// 
	// label1
	// 
	this.label1.Location = new System.Drawing.Point(51, 31);
	this.label1.Name = "label1";
	this.label1.Size = new System.Drawing.Size(100, 23);
	this.label1.TabIndex = 2;
	this.label1.Text = "COM ports";
	// 
	// label2
	// 
	this.label2.Location = new System.Drawing.Point(277, 31);
	this.label2.Name = "label2";
	this.label2.Size = new System.Drawing.Size(100, 23);
	this.label2.TabIndex = 3;
	this.label2.Text = "Baudrate";
	// 
	// readTimeoutNum
	// 
	this.readTimeoutNum.Location = new System.Drawing.Point(51, 123);
	this.readTimeoutNum.Maximum = new decimal(new int[] {
			10000,
			0,
			0,
			0});
	this.readTimeoutNum.Name = "readTimeoutNum";
	this.readTimeoutNum.Size = new System.Drawing.Size(120, 20);
	this.readTimeoutNum.TabIndex = 4;
	// 
	// writeTimeoutNow
	// 
	this.writeTimeoutNow.Location = new System.Drawing.Point(277, 123);
	this.writeTimeoutNow.Maximum = new decimal(new int[] {
			10000,
			0,
			0,
			0});
	this.writeTimeoutNow.Name = "writeTimeoutNow";
	this.writeTimeoutNow.Size = new System.Drawing.Size(120, 20);
	this.writeTimeoutNow.TabIndex = 5;
	// 
	// label3
	// 
	this.label3.Location = new System.Drawing.Point(51, 94);
	this.label3.Name = "label3";
	this.label3.Size = new System.Drawing.Size(100, 23);
	this.label3.TabIndex = 6;
	this.label3.Text = "Receive timeout";
	// 
	// label4
	// 
	this.label4.Location = new System.Drawing.Point(277, 94);
	this.label4.Name = "label4";
	this.label4.Size = new System.Drawing.Size(100, 23);
	this.label4.TabIndex = 7;
	this.label4.Text = "Send timeout";
	// 
	// parityBox
	// 
	this.parityBox.FormattingEnabled = true;
	this.parityBox.Location = new System.Drawing.Point(51, 183);
	this.parityBox.Name = "parityBox";
	this.parityBox.Size = new System.Drawing.Size(121, 21);
	this.parityBox.TabIndex = 8;
	// 
	// stopBitsBox
	// 
	this.stopBitsBox.FormattingEnabled = true;
	this.stopBitsBox.Location = new System.Drawing.Point(277, 183);
	this.stopBitsBox.Name = "stopBitsBox";
	this.stopBitsBox.Size = new System.Drawing.Size(121, 21);
	this.stopBitsBox.TabIndex = 9;
	// 
	// label5
	// 
	this.label5.Location = new System.Drawing.Point(51, 157);
	this.label5.Name = "label5";
	this.label5.Size = new System.Drawing.Size(100, 23);
	this.label5.TabIndex = 10;
	this.label5.Text = "Parity";
	// 
	// label6
	// 
	this.label6.Location = new System.Drawing.Point(277, 157);
	this.label6.Name = "label6";
	this.label6.Size = new System.Drawing.Size(100, 23);
	this.label6.TabIndex = 11;
	this.label6.Text = "Stop bits";
	// 
	// button1
	// 
	this.button1.Location = new System.Drawing.Point(187, 323);
	this.button1.Name = "button1";
	this.button1.Size = new System.Drawing.Size(75, 23);
	this.button1.TabIndex = 12;
	this.button1.Text = "Open";
	this.button1.UseVisualStyleBackColor = true;
	this.button1.Click += new System.EventHandler(this.Button1Click);
	// 
	// dataBitsNum
	// 
	this.dataBitsNum.Location = new System.Drawing.Point(51, 242);
	this.dataBitsNum.Name = "dataBitsNum";
	this.dataBitsNum.Size = new System.Drawing.Size(120, 20);
	this.dataBitsNum.TabIndex = 13;
	// 
	// handhakeBox
	// 
	this.handhakeBox.FormattingEnabled = true;
	this.handhakeBox.Location = new System.Drawing.Point(277, 240);
	this.handhakeBox.Name = "handhakeBox";
	this.handhakeBox.Size = new System.Drawing.Size(121, 21);
	this.handhakeBox.TabIndex = 14;
	// 
	// label7
	// 
	this.label7.Location = new System.Drawing.Point(277, 214);
	this.label7.Name = "label7";
	this.label7.Size = new System.Drawing.Size(100, 23);
	this.label7.TabIndex = 15;
	this.label7.Text = "Handshake ";
	// 
	// label8
	// 
	this.label8.Location = new System.Drawing.Point(51, 216);
	this.label8.Name = "label8";
	this.label8.Size = new System.Drawing.Size(100, 23);
	this.label8.TabIndex = 16;
	this.label8.Text = "Data bits";
	// 
	// ErrorLable
	// 
	this.ErrorLable.Location = new System.Drawing.Point(141, 9);
	this.ErrorLable.Name = "ErrorLable";
	this.ErrorLable.Size = new System.Drawing.Size(154, 23);
	this.ErrorLable.TabIndex = 17;
	// 
	// MainForm
	// 
	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	this.ClientSize = new System.Drawing.Size(475, 358);
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
	this.Controls.Add(this.writeTimeoutNow);
	this.Controls.Add(this.readTimeoutNum);
	this.Controls.Add(this.label2);
	this.Controls.Add(this.label1);
	this.Controls.Add(this.baudrateBox);
	this.Controls.Add(this.portsBox);
	this.Name = "MainForm";
	this.Text = "ComForm";
	((System.ComponentModel.ISupportInitialize)(this.readTimeoutNum)).EndInit();
	((System.ComponentModel.ISupportInitialize)(this.writeTimeoutNow)).EndInit();
	((System.ComponentModel.ISupportInitialize)(this.dataBitsNum)).EndInit();
	this.ResumeLayout(false);
		}
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
		private System.Windows.Forms.NumericUpDown writeTimeoutNow;
		private System.Windows.Forms.NumericUpDown readTimeoutNum;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox baudrateBox;
		private System.Windows.Forms.ComboBox portsBox;
	}
}
