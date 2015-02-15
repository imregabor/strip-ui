/*
 * Created by SharpDevelop.
 * User: imreg
 * Date: 2/14/2015
 * Time: 2:51 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace strip_ui
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			SerialSettingsForm ssf = new SerialSettingsForm();
			ssf.ShowDialog();
			Program.strip = new Strip(ssf.portName());
		}
		void RSliderScroll(object sender, ScrollEventArgs e)
		{
			updateRgb();
		}
		void GSliderScroll(object sender, ScrollEventArgs e)
		{
			updateRgb();
		}
		void BSliderScroll(object sender, ScrollEventArgs e)
		{
			updateRgb();
		}
		void updateRgb() {
			int [,] v = new int[Program.strip.getSize(), 3];
			for (int i = 0; i < v.GetLength(0); i++) {
				v[i,0] = rSlider.Value;
				v[i,1] = gSlider.Value;
				v[i,2] = bSlider.Value;
			}
			Program.strip.sendInt(v);
		}
		void MainFormFormClosed(object sender, FormClosedEventArgs e)
		{
			Program.strip.close();	
		}
	}
}
