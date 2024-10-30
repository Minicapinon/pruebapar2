/*
 * Archivo creado por: CapinonM
 * Created by personas.exe y un flan.rar
 * Date: 29/10/2024
 * Time: 07:11 a. m.
 */
using System.Threading.Tasks;
using System.IO;
using System;
using System.Drawing;
using Microsoft.DirectX.AudioVideoPlayback;
using System.Collections.Generic;
using System.Windows.Forms;

namespace proyecto
{
	/// <summary>
	/// Description of ingles.
	/// </summary>
	public partial class Ingles : Form
	{
		public Ingles()
		{
			InitializeComponent();
		}
		
		void BtnbackClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void BtnplayaudioClick(object sender, EventArgs e)
		{
		    try
		    {
		        Task.Run(() =>
		        {
		            string audioFilePath = @"C:\Users\CC2_PC11\Documents\OwO\pruebapar2\audio\would.mp3";
		            if (System.IO.File.Exists(audioFilePath))
		            {
		                using (Audio aud = new Audio(audioFilePath))
		                {
		                    aud.Play();
		                    while (aud.Playing)
		                    {
		                        System.Threading.Thread.Sleep(100);
		                    }
		                }
		            }
		            else
		            {
		                MessageBox.Show("Audio file not found at: " + audioFilePath);
		            }
		        });
		    }
		    catch (Exception ex)
		    {
		        MessageBox.Show("An error occurred: " + ex.Message);
		    }
}
	}
}
