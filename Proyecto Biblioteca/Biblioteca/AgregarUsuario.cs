/*
 * Created by SharpDevelop.
 * User: TOSHIBA
 * Date: 06/11/2019
 * Time: 08:12 p.m.
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
	/// Description of AgregarUsuario.
	/// </summary>
	public partial class AgregarUsuario : Form
	{
		public AgregarUsuario()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnAddUsClick(object sender, EventArgs e)
		{
			if(textNomUs.Text=="" || textIdUs.Text=="" || textContrUs.Text=="")
            {
                MessageBox.Show("Debes introducir todos los Datos...");
            }
			
            else{
            try
                {
                    
                    IDbConnection dbcon = new NpgsqlConnection("Server=localhost;" +"Database=biblioteca;" +"User ID=Kevin;");
                    dbcon.Open();
                    IDbCommand dbcmd = dbcon.CreateCommand();
                    dbcmd.CommandText = 
                        "insert into usuario values('" +textIdUs.Text + "','" +textNomUs.Text + "','" +textContrUs.Text + "')";
                    IDataReader reader = dbcmd.ExecuteReader();
                    dbcon.Close();
                    btnLimUs.PerformClick();
                    MessageBox.Show("Registro Guardado correctamente");
                }
                catch (Exception msg)
                {
                    MessageBox.Show("Error, base de datos desconectado.....\n\n" + msg.ToString());
                }
            }
		}
		
		void BtnLimUsClick(object sender, EventArgs e)
		{
			textIdUs.Clear();
			textNomUs.Clear();
		}
		
		
		void BtnBusUsClick(object sender, EventArgs e)
		{
			try
       		{
             
                int band = 0;
                IDbConnection dbcon = new NpgsqlConnection("Server=localhost;" +"Database=biblioteca;" +"User ID=Kevin;");
                dbcon.Open();
                IDbCommand dbcmd = dbcon.CreateCommand();
                dbcmd.CommandText = "select * from usuario where idusuario='" + textIdUs.Text + "'";
                
                IDataReader reader = dbcmd.ExecuteReader();
                if (reader.Read())
                {
                    textNomUs.Text = reader.GetString
                    	(reader.GetOrdinal("nombre"));
                    textNomUs.Text = reader.GetString
                    	(reader.GetOrdinal("contrasena"));
                    
                      /*
                    txtID.Text = Convert.ToString(reader.GetInt32
                        (reader.GetOrdinal("id")));*/
                    band = 1;
                }
                
                dbcon.Close();
                
                if (band == 0)
                {
                    MessageBox.Show("Usuario no encontrado...");
                    textIdUs.Enabled=true;
                    btnLimUs.PerformClick();
                    
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
            }			
		}
		
		void BtnSalUsClick(object sender, EventArgs e)
		{
			this.Visible=false;
			MainForm x=new MainForm();
			x.Show();
		}
		
		void AgregarUsuarioFormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}
