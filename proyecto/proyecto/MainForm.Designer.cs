/*
 * Created by SharpDevelop.
 * User: CC2_PC02
 * Date: 29/10/2024
 * Time: 07:11 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace proyecto
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.programaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.materiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quimicaIIIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.ecosistemasIIIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.pensamientoMatematicoIIIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.inglesIIIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.fisicaIIIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(143)))), ((int)(((byte)(161)))));
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.programaToolStripMenuItem,
									this.materiasToolStripMenuItem,
									this.acercaDeToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
			this.menuStrip1.Size = new System.Drawing.Size(389, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// programaToolStripMenuItem
			// 
			this.programaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.salirToolStripMenuItem});
			this.programaToolStripMenuItem.Name = "programaToolStripMenuItem";
			this.programaToolStripMenuItem.Size = new System.Drawing.Size(71, 22);
			this.programaToolStripMenuItem.Text = "Programa";
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
			this.salirToolStripMenuItem.Text = "Salir";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItemClick);
			// 
			// materiasToolStripMenuItem
			// 
			this.materiasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.quimicaIIIToolStripMenuItem,
									this.toolStripSeparator1,
									this.ecosistemasIIIToolStripMenuItem,
									this.toolStripSeparator2,
									this.pensamientoMatematicoIIIToolStripMenuItem,
									this.toolStripSeparator3,
									this.inglesIIIToolStripMenuItem,
									this.toolStripSeparator4,
									this.fisicaIIIToolStripMenuItem,
									this.toolStripSeparator5});
			this.materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
			this.materiasToolStripMenuItem.Size = new System.Drawing.Size(64, 22);
			this.materiasToolStripMenuItem.Text = "Materias";
			// 
			// quimicaIIIToolStripMenuItem
			// 
			this.quimicaIIIToolStripMenuItem.Name = "quimicaIIIToolStripMenuItem";
			this.quimicaIIIToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
			this.quimicaIIIToolStripMenuItem.Text = "Quimica III";
			this.quimicaIIIToolStripMenuItem.Click += new System.EventHandler(this.QuimicaIIIToolStripMenuItemClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(219, 6);
			// 
			// ecosistemasIIIToolStripMenuItem
			// 
			this.ecosistemasIIIToolStripMenuItem.Name = "ecosistemasIIIToolStripMenuItem";
			this.ecosistemasIIIToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
			this.ecosistemasIIIToolStripMenuItem.Text = "Ecosistemas III";
			this.ecosistemasIIIToolStripMenuItem.Click += new System.EventHandler(this.EcosistemasIIIToolStripMenuItemClick);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(219, 6);
			// 
			// pensamientoMatematicoIIIToolStripMenuItem
			// 
			this.pensamientoMatematicoIIIToolStripMenuItem.Name = "pensamientoMatematicoIIIToolStripMenuItem";
			this.pensamientoMatematicoIIIToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
			this.pensamientoMatematicoIIIToolStripMenuItem.Text = "Pensamiento Matematico III";
			this.pensamientoMatematicoIIIToolStripMenuItem.Click += new System.EventHandler(this.PensamientoMatematicoIIIToolStripMenuItemClick);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(219, 6);
			// 
			// inglesIIIToolStripMenuItem
			// 
			this.inglesIIIToolStripMenuItem.Name = "inglesIIIToolStripMenuItem";
			this.inglesIIIToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
			this.inglesIIIToolStripMenuItem.Text = "Ingles III";
			this.inglesIIIToolStripMenuItem.Click += new System.EventHandler(this.InglesIIIToolStripMenuItemClick);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(219, 6);
			// 
			// fisicaIIIToolStripMenuItem
			// 
			this.fisicaIIIToolStripMenuItem.Name = "fisicaIIIToolStripMenuItem";
			this.fisicaIIIToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
			this.fisicaIIIToolStripMenuItem.Text = "Fisica III";
			this.fisicaIIIToolStripMenuItem.Click += new System.EventHandler(this.FisicaIIIToolStripMenuItemClick);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(219, 6);
			// 
			// acercaDeToolStripMenuItem
			// 
			this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.infoToolStripMenuItem});
			this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
			this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 22);
			this.acercaDeToolStripMenuItem.Text = "Acerca de";
			// 
			// infoToolStripMenuItem
			// 
			this.infoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("infoToolStripMenuItem.Image")));
			this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
			this.infoToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
			this.infoToolStripMenuItem.Text = "Info";
			this.infoToolStripMenuItem.Click += new System.EventHandler(this.InfoToolStripMenuItemClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(79, 66);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(256, 256);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
			this.ClientSize = new System.Drawing.Size(389, 365);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximumSize = new System.Drawing.Size(405, 404);
			this.MinimumSize = new System.Drawing.Size(405, 404);
			this.Name = "MainForm";
			this.Text = "Menu";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem fisicaIIIToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem inglesIIIToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem pensamientoMatematicoIIIToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem ecosistemasIIIToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem quimicaIIIToolStripMenuItem;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem materiasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem programaToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
