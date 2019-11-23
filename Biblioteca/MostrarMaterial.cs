/*
 * Created by SharpDevelop.
 * User: TOSHIBA
 * Date: 09/05/2017
 * Time: 08:15 p.m.
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
	/// Description of MostrarMaterial.
	/// </summary>
	public partial class MostrarMaterial : Form
	{
		public MostrarMaterial()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MostrarMaterialLoad(object sender, EventArgs e)
		{
			DataTable memoria = new DataTable();
            	try
            	{

            	    NpgsqlConnection conexion = new NpgsqlConnection("Server=localhost;"
            	            + "Database=biblioteca;" +
            	        "User ID=Kevin;");
            	    NpgsqlDataAdapter datosConsulta = new NpgsqlDataAdapter("select idmaterial,titulo,autores,existencia from material", conexion);
            	    datosConsulta.Fill(memoria);
        
            	    dgvMaterial.DataSource = memoria.DefaultView;
            	}
            	catch (Exception msg)
            	{
            	    MessageBox.Show(msg.ToString());
            	}			
		}
		
		
		void BtnActMatClick(object sender, EventArgs e)
		{
			DataTable memoria = new DataTable();
            	try
            	{

            	    NpgsqlConnection conexion = new NpgsqlConnection("Server=localhost;"
            	            + "Database=biblioteca;" +
            	        "User ID=Kevin;");
            	    NpgsqlDataAdapter datosConsulta = new NpgsqlDataAdapter("select idmaterial,titulo,autores,existencia from material", conexion);
            	    datosConsulta.Fill(memoria);
        
            	    dgvMaterial.DataSource = memoria.DefaultView;
            	}
            	catch (Exception msg)
            	{
            	    MessageBox.Show(msg.ToString());
            	}			
		}
		
		void BtnRegMatClick(object sender, EventArgs e)
		{
			this.Visible=false;
			MainForm x=new MainForm();
			x.Show();
		}
		
		void MostrarMaterialFormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}
