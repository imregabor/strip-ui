/*
 * Created by SharpDevelop.
 * User: imreg
 * Date: 2/14/2015
 * Time: 2:51 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace strip_ui
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.HScrollBar rSlider;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.HScrollBar gSlider;
		private System.Windows.Forms.HScrollBar bSlider;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		
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
			this.rSlider = new System.Windows.Forms.HScrollBar();
			this.label1 = new System.Windows.Forms.Label();
			this.gSlider = new System.Windows.Forms.HScrollBar();
			this.bSlider = new System.Windows.Forms.HScrollBar();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// rSlider
			// 
			this.rSlider.Location = new System.Drawing.Point(62, 9);
			this.rSlider.Maximum = 255;
			this.rSlider.Name = "rSlider";
			this.rSlider.Size = new System.Drawing.Size(431, 17);
			this.rSlider.TabIndex = 0;
			this.rSlider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.RSliderScroll);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "label1";
			// 
			// gSlider
			// 
			this.gSlider.Location = new System.Drawing.Point(62, 26);
			this.gSlider.Maximum = 255;
			this.gSlider.Name = "gSlider";
			this.gSlider.Size = new System.Drawing.Size(431, 17);
			this.gSlider.TabIndex = 2;
			this.gSlider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.GSliderScroll);
			// 
			// bSlider
			// 
			this.bSlider.Location = new System.Drawing.Point(62, 43);
			this.bSlider.Maximum = 255;
			this.bSlider.Name = "bSlider";
			this.bSlider.Size = new System.Drawing.Size(431, 17);
			this.bSlider.TabIndex = 3;
			this.bSlider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.BSliderScroll);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "label2";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 43);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "label3";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(746, 374);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.bSlider);
			this.Controls.Add(this.gSlider);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.rSlider);
			this.Name = "MainForm";
			this.Text = "strip-ui";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormFormClosed);
			this.ResumeLayout(false);

		}
	}
}
