/*
 * Created by SharpDevelop.
 * User: TOSHIBA
 * Date: 06/11/2019
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
		
		/*private NpgsqlConnection conn;
		string	connstring = string.Format("Server={0};Port={1};" +
		                                       "User Id={2};Password={3};Database={4};",
		                                       "localhost", "5432", "Kevin", "", "biblioteca");
		                                       //new NpgsqlConnection("localhost;"+ "Database=biblioteca;" +"User ID=Kevin;");
		private NpgsqlCommand cmd;
		private string sql = null;*/
		
		
		
		void Button1Click(object sender, EventArgs e)
		{
			try
			{
				NpgsqlConnection conn = new NpgsqlConnection ("User Id=Kevin;Host=localhost;Database=biblioteca;");
				NpgsqlDataAdapter adp = new NpgsqlDataAdapter("select * from usuario where nombre='"+textBoxNom.Text+"'and contrasena='"+textBoxCon.Text+"'",conn);
				DataTable dt = new DataTable();
				adp.Fill(dt);
				if (dt.Rows[0][0].ToString()=="1")
				{
					this.Hide();
					Form1 z = new Form1();
					z.Show();
				}else
				{
					MessageBox.Show("Verifique su usuario y contraseña");
				}
				/*//NpgsqlDataAdapter loginConsulta = new NpgsqlDataAdapter("Select nombre, ", conexion); //Esta parte de codigo era antiguo metodo de login y ya no sirve
				conn.Open();
				sql = @"select * from usuario(:_nombre, :_contrasena)";
				cmd = new NpgsqlCommand(sql, conn);
				
				cmd.Parameters.Add("_nombre",textBoxNom.Text);
				cmd.Parameters.Add("_contrasena",textBoxCon.Text);
				
				int result = (int)cmd.ExecuteScalar();
				
				
				conn.Close();
				
				if (result == 1)//sesion exitosa
				{
					this.Hide();
					Form1 z = new Form1();
					//new Form1(textBoxNom.Text).Show();
					z.Show();
				}else
				{
					MessageBox.Show("Usuario o contraseña incorrectos", "No se pudo conectar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}*/
			}
			
			catch (Exception msg)
			{
           		MessageBox.Show(msg.ToString());
            }

		}
		
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
		
		/*private void MainFormLoad(object sender, EventArgs e)//Parte del codigo del antiguo metodo de login tampoco sirve, no con esta version de postgresql
		{
			conn = new NpgsqlConnection(connstring);
		}*/

	}
}
