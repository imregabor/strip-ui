/*
 * Created by SharpDevelop.
 * User: imreg
 * Date: 2/14/2015
 * Time: 3:05 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace strip_ui
{
	partial class SerialSettingsForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox portCombo;
		private System.Windows.Forms.LinkLabel refreshPorts;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Button testButton;
		
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
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.portCombo = new System.Windows.Forms.ComboBox();
			this.refreshPorts = new System.Windows.Forms.LinkLabel();
			this.okButton = new System.Windows.Forms.Button();
			this.testButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Port to use:";
			// 
			// portCombo
			// 
			this.portCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.portCombo.FormattingEnabled = true;
			this.portCombo.Location = new System.Drawing.Point(86, 12);
			this.portCombo.Name = "portCombo";
			this.portCombo.Size = new System.Drawing.Size(126, 21);
			this.portCombo.TabIndex = 1;
			// 
			// refreshPorts
			// 
			this.refreshPorts.Location = new System.Drawing.Point(218, 15);
			this.refreshPorts.Name = "refreshPorts";
			this.refreshPorts.Size = new System.Drawing.Size(50, 23);
			this.refreshPorts.TabIndex = 2;
			this.refreshPorts.TabStop = true;
			this.refreshPorts.Text = "Refresh";
			this.refreshPorts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RefreshPortsLinkClicked);
			// 
			// okButton
			// 
			this.okButton.Location = new System.Drawing.Point(193, 130);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 3;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.OkButtonClick);
			// 
			// testButton
			// 
			this.testButton.Location = new System.Drawing.Point(112, 130);
			this.testButton.Name = "testButton";
			this.testButton.Size = new System.Drawing.Size(75, 23);
			this.testButton.TabIndex = 4;
			this.testButton.Text = "Test";
			this.testButton.UseVisualStyleBackColor = true;
			this.testButton.Click += new System.EventHandler(this.TestButtonClick);
			// 
			// SerialSettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(274, 165);
			this.Controls.Add(this.testButton);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.refreshPorts);
			this.Controls.Add(this.portCombo);
			this.Controls.Add(this.label1);
			this.Name = "SerialSettingsForm";
			this.Text = "Serial port settings";
			this.ResumeLayout(false);

		}
	}
}
