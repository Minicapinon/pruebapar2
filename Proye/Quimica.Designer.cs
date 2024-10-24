/*
 * Created by SharpDevelop.
 * User: CC2-CP03
 * Date: 24/10/2024
 * Time: 04:07 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Proye
{
	partial class Quimica
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
			this.label1 = new System.Windows.Forms.Label();
			this.btnEnter = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(113, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(118, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Quimica III";
			// 
			// btnEnter
			// 
			this.btnEnter.Location = new System.Drawing.Point(133, 120);
			this.btnEnter.Name = "btnEnter";
			this.btnEnter.Size = new System.Drawing.Size(75, 23);
			this.btnEnter.TabIndex = 1;
			this.btnEnter.Text = "Enter";
			this.btnEnter.UseVisualStyleBackColor = true;
			this.btnEnter.Click += new System.EventHandler(this.Button1Click);
			// 
			// Quimica
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(347, 167);
			this.Controls.Add(this.btnEnter);
			this.Controls.Add(this.label1);
			this.Name = "Quimica";
			this.Text = "Quimica";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnEnter;
		private System.Windows.Forms.Label label1;
	}
}
