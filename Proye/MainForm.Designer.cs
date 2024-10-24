/*
 * Created by SharpDevelop.
 * User: CC2-PC01
 * Date: 24/10/2024
 * Time: 07:43 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Proye
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
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnnn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnnn
			// 
			this.btnnn.Location = new System.Drawing.Point(119, 127);
			this.btnnn.Name = "btnnn";
			this.btnnn.Size = new System.Drawing.Size(75, 23);
			this.btnnn.TabIndex = 0;
			this.btnnn.Text = "Buton";
			this.btnnn.UseVisualStyleBackColor = true;
			this.btnnn.Click += new System.EventHandler(this.BtnnnClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(583, 327);
			this.Controls.Add(this.btnnn);
			this.Name = "MainForm";
			this.Text = "Proye";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnnn;
	}
}
