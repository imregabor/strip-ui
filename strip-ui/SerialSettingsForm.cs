/*
 * Created by SharpDevelop.
 * User: imreg
 * Date: 2/14/2015
 * Time: 3:05 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace strip_ui
{
	/// <summary>
	/// Description of SerialSettingsForm.
	/// </summary>
	public partial class SerialSettingsForm : Form
	{
		public SerialSettingsForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			refreshAvailablePorts();
		}
		
		public string portName() {
			return portCombo.SelectedItem.ToString();
		}
		
		void refreshAvailablePorts() {
			portCombo.BeginUpdate();
			portCombo.Items.Clear();
			portCombo.Items.AddRange(SerialPort.GetPortNames());
			portCombo.EndUpdate();
		}
		void OkButtonClick(object sender, EventArgs e) {
			
			this.Close();
		}
		void RefreshPortsLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			refreshAvailablePorts();
		}
		void TestButtonClick(object sender, EventArgs e)
		{
			if (portCombo.SelectedItem == null) {
				MessageBox.Show("No port selected", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			
			
			
			try {
				int numPixels = Strip.probePort(portCombo.SelectedItem.ToString());
				MessageBox.Show("Strip found; numPixels: " + numPixels, "Success" , MessageBoxButtons.OK, MessageBoxIcon.Information);
			} catch (Exception ex) {
				MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}
		
	}
}
