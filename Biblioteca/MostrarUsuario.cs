/*
 * Created by SharpDevelop.
 * User: TOSHIBA
 * Date: 09/05/2017
 * Time: 08:13 p.m.
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
	/// Description of MostrarUsuario.
	/// </summary>
	public partial class MostrarUsuario : Form
	{
		public MostrarUsuario()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MostrarUsuarioLoad(object sender, EventArgs e)
		{
			DataTable memoria = new DataTable();
            	try
            	{

            	    NpgsqlConnection conexion = new NpgsqlConnection("Server=localhost;"
            	            + "Database=biblioteca;" +
            	        "User ID=Kevin;");
            	    NpgsqlDataAdapter datosConsulta = new NpgsqlDataAdapter("select idusuario,nombre,librosprestados from usuario", conexion);
            	    datosConsulta.Fill(memoria);
        
            	    dgvUsuario.DataSource = memoria.DefaultView;
            	}
            	catch (Exception msg)
            	{
            	    MessageBox.Show(msg.ToString());
            	}			
		}
		
		
		void BtnActUsClick(object sender, EventArgs e)
		{
			DataTable memoria = new DataTable();
            	try
            	{

            	    NpgsqlConnection conexion = new NpgsqlConnection("Server=localhost;"
            	            + "Database=biblioteca;" +
            	        "User ID=Kevin;");
            	    NpgsqlDataAdapter datosConsulta = new NpgsqlDataAdapter("select idusuario,nombre,librosprestados from usuario", conexion);
            	    datosConsulta.Fill(memoria);
        
            	    dgvUsuario.DataSource = memoria.DefaultView;
            	}
            	catch (Exception msg)
            	{
            	    MessageBox.Show(msg.ToString());
            	}		
		}
		
		void btnRegUsClick(object sender, EventArgs e)
		{
			this.Visible=false;
			MainForm x=new MainForm();
			x.Show();
		}
		
		void MostrarUsuarioFormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}
