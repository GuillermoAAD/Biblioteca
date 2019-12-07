/*
 * Created by SharpDevelop.
 * User: X-Zone
 * Date: 06/12/2019
 * Time: 12:45 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using Npgsql;
using System.Diagnostics;

namespace Biblioteca
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
		void AgregarToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Visible=false;
			AgregarUsuario x=new AgregarUsuario();
			x.Show();
		}
		void MostrarToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Visible=false;
			MostrarUsuario xx=new MostrarUsuario();
			xx.Show();
		}
		void AgregarToolStripMenuItem1Click(object sender, EventArgs e)
		{
			this.Visible=false;
			AgregarMaterial y=new AgregarMaterial();
			y.Show();
		}
		void MostrarToolStripMenuItem1Click(object sender, EventArgs e)
		{
			this.Visible=false;
			MostrarMaterial yy=new MostrarMaterial();
			yy.Show();
		}
		void AgregarToolStripMenuItem2Click(object sender, EventArgs e)
		{
			this.Visible=false;
			AgregarPrestamo z=new AgregarPrestamo();
			z.Show();
		}
		void MostrarToolStripMenuItem2Click(object sender, EventArgs e)
		{
			this.Visible=false;
			BuscarPrestamo zz=new BuscarPrestamo();
			zz.Show();
		}
		void SalirToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}

	}
}
