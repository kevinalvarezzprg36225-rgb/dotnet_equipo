/*
 * Created by SharpDevelop.
 * User: CC2_PC13
 * Date: 28/10/2026
 * Time: 07:54 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyecto_equipo
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnMainClick(object sender, EventArgs e)
		{
			MainForm f= new MainForm();
			f.Show();
			this.Hide();
		}
	}
}
