﻿/*
 * Created by SharpDevelop.
 * User: CC2_PC02
 * Date: 29/10/2024
 * Time: 07:11 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace proyecto
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void SalirToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void InfoToolStripMenuItemClick(object sender, EventArgs e)
		{
			acercade info = new acercade();
			info.Show();
		}
	}
}
