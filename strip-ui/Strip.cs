/*
 * Author: Gabor Imre
 */
using System;
using System.IO;
using System.IO.Ports;
using System.Text;

namespace strip_ui
{
	/// <summary>
	/// An instance represents the led strip hardware.
	/// </summary>
	public class Strip
	{
		private readonly string portName;
		
		private readonly int ledcount;
		
		private readonly SerialPort port;
		
		public Strip(string portName, int ledcount)
		{
			this.portName = portName;
			this.ledcount = ledcount;
			this.port = openPort(portName);
		}
		
		public Strip(string portName) {
			this.portName = portName;
			this.ledcount = probePort(portName);
			this.port = openPort(portName);
		}
		
		
		public void close() {
			this.port.Close();
		}
		
		public void sendReal(double [][] rgb) {
			StringBuilder b = new StringBuilder();
			b.Append('@');
			for (int i = 0; i < rgb.Length && i < this.ledcount; i++ ) {
				for (int j = 0; j < 3; j++) {
					double v = rgb[i][j];
					int k;
					if (v <= 0) {
						k = 0;
					} else if (v>= 1.0) {
						k = 255;
					} else {
						k = (int) Math.Round(255 * v);
					}
					string h = k.ToString("X");
					if (h.Length == 1) {
						b.Append('0');
					}
					b.Append(h);
				}
			}
			b.Append(';');
			port.WriteLine(b.ToString());
			port.ReadLine();
       
		}
		public void sendInt(int [,] rgb) {
			StringBuilder b = new StringBuilder();
			b.Append('@');
			for (int i = 0; i < rgb.GetLength(0) && i < this.ledcount; i++ ) {
				for (int j = 0; j < 3; j++) {
					int v = rgb[i,j];
					int k;
					if (v <= 0) {
						k = 0;
					} else if (v>= 255) {
						k = 255;
					} else {
						k = v;
					}
					string h = k.ToString("X");
					if (h.Length == 1) {
						b.Append('0');
					}
					b.Append(h);
				}
			}
			b.Append(';');
			port.WriteLine(b.ToString());
			port.ReadLine();
       
		}
		
		
		static SerialPort openPort(string portName) {
			SerialPort p = new SerialPort();
			p.PortName = portName;
			p.BaudRate = 115200;
			p.Parity = Parity.None;
			p.DataBits = 8;
			p.StopBits = StopBits.One;
			p.Handshake = Handshake.None;
			p.ReadTimeout = 50;
			p.WriteTimeout = 50;
			p.NewLine = "\n";
			p.Open();
			return p;
		}
		
		/// <summary>
		/// Probe a given serial port to read strip info.
		/// </summary>
		/// <param name="portName">Serial port name</param>
		/// <returns>Number of leds</returns>
		/// 
		public static int probePort(string portName) {
			SerialPort port = openPort(portName);
			try {
				port.DiscardInBuffer();
				port.Write(";?;");
				string resp = port.ReadLine();
				
				
				int numPixels = -1;
				string [] info = resp.Split(' ');
				foreach(string s in info) {
					if (s.StartsWith("numPixels:")) {
						numPixels = int.Parse(s.Split(':')[1]);
					}
				}
				if (numPixels == -1) {
					throw new IOException("No pixel count returned in \"" + resp + "\"");
				}
				return numPixels;
			} finally {
				port.Close();	
			}			
		}
	}
}
