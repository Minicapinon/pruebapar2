using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using Microsoft.DirectX.AudioVideoPlayback;

namespace proyecto
{
	public partial class Ingles : Form
    {
        private Audio audio;

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
            string rutau = "audio/would.mp3";
            
            Task.Run(() => ReproducirAudio(rutau));
        }

        void ReproducirAudio(string ruta)
        {
            string rutcomp = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ruta);
            
            audio = new Audio(rutcomp);
            audio.Play();
        }
    }
}