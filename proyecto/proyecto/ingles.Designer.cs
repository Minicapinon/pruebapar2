/*
 * Created by SharpDevelop.
 * User: CC2-PC01
 * Date: 29/10/2024
 * Time: 07:32 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace proyecto
{
	partial class Ingles
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ingles));
			this.lbltemashow = new System.Windows.Forms.Label();
			this.lbltemanow = new System.Windows.Forms.Label();
			this.lblinfo = new System.Windows.Forms.Label();
			this.btnback = new System.Windows.Forms.Button();
			this.btnplayaudio = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblejemplos = new System.Windows.Forms.Label();
			this.lblejetext = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbltemashow
			// 
			this.lbltemashow.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbltemashow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
			this.lbltemashow.Location = new System.Drawing.Point(40, 30);
			this.lbltemashow.Name = "lbltemashow";
			this.lbltemashow.Size = new System.Drawing.Size(85, 25);
			this.lbltemashow.TabIndex = 0;
			this.lbltemashow.Text = "Tema:";
			// 
			// lbltemanow
			// 
			this.lbltemanow.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbltemanow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
			this.lbltemanow.Location = new System.Drawing.Point(130, 30);
			this.lbltemanow.Name = "lbltemanow";
			this.lbltemanow.Size = new System.Drawing.Size(85, 25);
			this.lbltemanow.TabIndex = 1;
			this.lbltemanow.Text = "Would";
			// 
			// lblinfo
			// 
			this.lblinfo.Location = new System.Drawing.Point(40, 90);
			this.lblinfo.Name = "lblinfo";
			this.lblinfo.Size = new System.Drawing.Size(339, 66);
			this.lblinfo.TabIndex = 2;
			this.lblinfo.Text = "Would es un verbo auxiliar en inglés que se usa para indicar acciones condicional" +
			"es, solicitudes educadas, deseos y hábitos del pasado.";
			this.lblinfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnback
			// 
			this.btnback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(143)))), ((int)(((byte)(161)))));
			this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
			this.btnback.Location = new System.Drawing.Point(550, 30);
			this.btnback.MaximumSize = new System.Drawing.Size(100, 50);
			this.btnback.MinimumSize = new System.Drawing.Size(100, 50);
			this.btnback.Name = "btnback";
			this.btnback.Size = new System.Drawing.Size(100, 50);
			this.btnback.TabIndex = 3;
			this.btnback.Text = "Regresar";
			this.btnback.UseVisualStyleBackColor = false;
			this.btnback.Click += new System.EventHandler(this.BtnbackClick);
			// 
			// btnplayaudio
			// 
			this.btnplayaudio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(143)))), ((int)(((byte)(161)))));
			this.btnplayaudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnplayaudio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
			this.btnplayaudio.Location = new System.Drawing.Point(550, 169);
			this.btnplayaudio.MaximumSize = new System.Drawing.Size(100, 50);
			this.btnplayaudio.MinimumSize = new System.Drawing.Size(100, 50);
			this.btnplayaudio.Name = "btnplayaudio";
			this.btnplayaudio.Size = new System.Drawing.Size(100, 50);
			this.btnplayaudio.TabIndex = 4;
			this.btnplayaudio.Text = "Reproducir audio";
			this.btnplayaudio.UseVisualStyleBackColor = false;
			this.btnplayaudio.Click += new System.EventHandler(this.BtnplayaudioClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
			this.label1.Location = new System.Drawing.Point(40, 194);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(175, 25);
			this.label1.TabIndex = 5;
			this.label1.Text = "Conjugación:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(40, 246);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(339, 94);
			this.label2.TabIndex = 6;
			this.label2.Text = "-I would (Yo)\r\n-You would (Tú/Usted)\r\n-He/She/It would (Él/Ella/Eso)\r\n-We would (" +
			"Nosotros)\r\n-They would (Ellos)";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblejemplos
			// 
			this.lblejemplos.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblejemplos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
			this.lblejemplos.Location = new System.Drawing.Point(40, 380);
			this.lblejemplos.Name = "lblejemplos";
			this.lblejemplos.Size = new System.Drawing.Size(175, 25);
			this.lblejemplos.TabIndex = 8;
			this.lblejemplos.Text = "Ejemplos:";
			// 
			// lblejetext
			// 
			this.lblejetext.Location = new System.Drawing.Point(40, 415);
			this.lblejetext.Name = "lblejetext";
			this.lblejetext.Size = new System.Drawing.Size(421, 200);
			this.lblejetext.TabIndex = 9;
			this.lblejetext.Text = resources.GetString("lblejetext.Text");
			this.lblejetext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Ingles
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
			this.ClientSize = new System.Drawing.Size(684, 661);
			this.Controls.Add(this.lblejetext);
			this.Controls.Add(this.lblejemplos);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnplayaudio);
			this.Controls.Add(this.btnback);
			this.Controls.Add(this.lblinfo);
			this.Controls.Add(this.lbltemanow);
			this.Controls.Add(this.lbltemashow);
			this.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MaximumSize = new System.Drawing.Size(700, 700);
			this.MinimumSize = new System.Drawing.Size(700, 700);
			this.Name = "Ingles";
			this.Text = "ingles";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lblejetext;
		private System.Windows.Forms.Label lblejemplos;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnplayaudio;
		private System.Windows.Forms.Button btnback;
		private System.Windows.Forms.Label lblinfo;
		private System.Windows.Forms.Label lbltemanow;
		private System.Windows.Forms.Label lbltemashow;
	}
}
