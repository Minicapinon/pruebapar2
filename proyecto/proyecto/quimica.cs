/*
 * Created by SharpDevelop.
 * User: CC2_PC02
 * Date: 31/10/2024
 * Time: 07:18 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyecto
{
	/// <summary>
	/// Description of quimica.
	/// </summary>
	public partial class quimica : Form
	{
		public quimica()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		//RESPUESTAS 1
		void BtnHomo1Click(object sender, EventArgs e)
		{
			MessageBox.Show("¡CORRECTO! \n \n El café con leche es una mezcla homogénea " +
			                "porque sus componentes se distribuyen uniformemente. " +
							"No podrás ver los ingredientes separados a simple vista.");
		}
		void BtnHetero1Click(object sender, EventArgs e)
		{
			MessageBox.Show("INCORRECTO");
		}
		
		
		//RESPUESTAS 2
		void BtnHomo2Click(object sender, EventArgs e)
		{
			MessageBox.Show("INCORRECTO");
		}
		void BtnHetero2Click(object sender, EventArgs e)
		{
			MessageBox.Show("¡CORRECTO! \n \n El agua con arena es una mezcla heterogénea" +
							" porque puedes ver y separar fácilmente sus componentes. " +
							"La arena no se disuelve en el agua, creando una distinción clara.");
		}
		
		
		//RESPUESTAS 3
		void BtnPerfClick(object sender, EventArgs e)
		{
			MessageBox.Show("INCORRECTO \n \n El perfume es una mezcla homogenea " +
			                "porque sus componentes se mezclan uniformemente. " +
			                "No puedes separar sus partes a simple vista.");
		}
		void BtnAceYaguClick(object sender, EventArgs e)
		{
			MessageBox.Show("¡CORRECTO! \n \n El agua con el aceite no son homogéneos " +
			                "porque no se mezclan uniformemente. El aceite flota sobre el agua.");
		}
		void BtnGasoClick(object sender, EventArgs e)
		{
			MessageBox.Show("INCORRECTO \n \n La gasolina es una mezcla homogenea " +
			                "porque sus componentes se mezclan uniformemente. " +
			                "No puedes separar sus partes a simple vista.");
		}
		
		
		//RESGRESAR AL MENÚ
		void BtnMenClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
