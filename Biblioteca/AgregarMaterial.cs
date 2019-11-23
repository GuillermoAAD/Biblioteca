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
	/// Description of AgregarMaterial.
	/// </summary>
	public partial class AgregarMaterial : Form
	{
		public AgregarMaterial()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

		
		void BtnAddMatClick(object sender, EventArgs e)
		{
			if(textIDMat.Text=="" || textTitMat.Text=="" || textAutMat.Text=="" || textExiMat.Text=="")
            {
                MessageBox.Show("Debes introducir los datos...");
            }
			
            else{
            try
                {
                    
                    IDbConnection dbcon = new NpgsqlConnection
                        ("Server=localhost;" +
                    "Database=biblioteca;" +
                    "User ID=Kevin;");
                    dbcon.Open();
                    IDbCommand dbcmd = dbcon.CreateCommand();
                    dbcmd.CommandText = 
                        "insert into material values('" +textIDMat.Text + "','" +textTitMat.Text + "','" +textAutMat.Text + "','" +textExiMat.Text + "')";
                    IDataReader reader = dbcmd.ExecuteReader();
                    dbcon.Close();
                    btnLimMat.PerformClick();
                    MessageBox.Show("Registro Guardado correctamente");
                }
                catch (Exception msg)
                {
                    MessageBox.Show("Error, base de datos desconectado.....\n\n" + msg.ToString());
                }
            }
		}
		
		void BtnLimMatClick(object sender, EventArgs e)
		{
			textIDMat.Clear();
			textTitMat.Clear();
			textAutMat.Clear();
			textExiMat.Clear();
		}
		
		void BtnBusMatClick(object sender, EventArgs e)
		{
			try
                {
             
                int band = 0;
                IDbConnection dbcon = new NpgsqlConnection("Server=localhost;" +
                                                           "Database=biblioteca;" +
                                                           "User ID=Kevin;");
                dbcon.Open();
                IDbCommand dbcmd = dbcon.CreateCommand();
                dbcmd.CommandText = "select * from material where idmaterial='" + textIDMat.Text + "'";
                
                IDataReader reader = dbcmd.ExecuteReader();
                if (reader.Read())
                {
                    textTitMat.Text = reader.GetString
                    	(reader.GetOrdinal("titulo"));
                    textAutMat.Text = reader.GetString
                    	(reader.GetOrdinal("autores"));
                    textExiMat.Text = Convert.ToString(reader.GetInt32
                    	(reader.GetOrdinal("existencia")));
                    
                      /*
                    txtID.Text = Convert.ToString(reader.GetInt32
                        (reader.GetOrdinal("id")));*/
                    band = 1;
                }
                dbcon.Close();
                if (band == 0)
                {
                    MessageBox.Show("Material no encontrado...");
                    btnLimMat.PerformClick();
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
            }			
		}
		
		void BtnSalMatClick(object sender, EventArgs e)
		{
			this.Visible=false;
			MainForm x=new MainForm();
			x.Show();
		}
		
		void AgregarMaterialFormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}
