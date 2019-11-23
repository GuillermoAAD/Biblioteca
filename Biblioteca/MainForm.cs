/*
 * Created by SharpDevelop.
 * User: TOSHIBA
 * Date: 09/05/2017
 * Time: 07:29 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Npgsql;
using System.Windows.Forms;
using System.Diagnostics;

namespace Biblioteca
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
		
		void UsuarioToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Visible=false;
			AgregarUsuario x=new AgregarUsuario();
			x.Show();
		}
		
		void MaterialToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Visible=false;
			MostrarUsuario xx=new MostrarUsuario();
			xx.Show();
		}
		
		void UsuarioToolStripMenuItem1Click(object sender, EventArgs e)
		{
			this.Visible=false;
			AgregarMaterial y=new AgregarMaterial();
			y.Show();
		}
		
		void MaterialToolStripMenuItem1Click(object sender, EventArgs e)
		{
			this.Visible=false;
			MostrarMaterial yy=new MostrarMaterial();
			yy.Show();
		}
		
		void PrestamoToolStripMenuItem2Click(object sender, EventArgs e)
		{
			this.Visible=false;
			AgregarPrestamo z=new AgregarPrestamo();
			z.Show();
		}
		
		void BuscarToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Visible=false;
			BuscarPrestamo zz=new BuscarPrestamo();
			zz.Show();
		}
		
		void SalirToolStripMenuItem2Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		void Label1Click(object sender, EventArgs e)
		{
	
		}
	}
}
