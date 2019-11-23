/*
 * Created by SharpDevelop.
 * User: TOSHIBA
 * Date: 09/05/2017
 * Time: 08:18 p.m.
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
	/// Description of BuscarPrestamo.
	/// </summary>
	public partial class BuscarPrestamo : Form
	{
		public BuscarPrestamo()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		DataTable x = new DataTable();
		int i;
		
		void BtnBuscarClick(object sender, EventArgs e)
		{
			if(textIDPrestamo.Text=="")
			{
				MessageBox.Show("Debes introducir un folio a buscar....");
				textIDPrestamo.Focus();
			}
			
			else
			{
				try
				{
					x.Rows.Clear();
					int band=0;
					int totalibros=0;
					bool devuelto;
					
					IDbConnection dbcon = new NpgsqlConnection
                	("Server=localhost;"+"Database=biblioteca;"+"User ID=Kevin;");
                	dbcon.Open();
                	IDbCommand dbcmd = dbcon.CreateCommand();
                	dbcmd.CommandText = "select * from prestamo where folio=" + textIDPrestamo.Text + "";
                
                	IDataReader reader = dbcmd.ExecuteReader();
                	
                	if (reader.Read())
                	{
                		lblFolio.Text = textIDPrestamo.Text;
                		//lblIDUsuario.Text = Convert.ToString(reader.GetInt32
                		//(reader.GetOrdinal("idusuario")));
                    	lblFechaPre.Text = Convert.ToString(reader.GetDateTime
                		(reader.GetOrdinal("fechaprestamo")));
                    	lblFechaDev.Text = Convert.ToString(reader.GetDateTime
                		(reader.GetOrdinal("fechadevolucion")));
                    	lblStatus.Text = Convert.ToString(reader.GetBoolean
                    	(reader.GetOrdinal("status")));
                    	band = 1;
                	}
                
                	reader.Close();
                
                	if (band == 1)
                	{
                		IDbCommand comandoDetallePrestamo = dbcon.CreateCommand();
                		comandoDetallePrestamo.CommandText = "select * from detalleprestamo where foliopre=" +Convert.ToInt16(lblFolio.Text) + "";
                		IDataReader readerDetallePrestamo = comandoDetallePrestamo.ExecuteReader();
                		i=0;
                	
                		while(readerDetallePrestamo.Read())
                		{
                		x.Rows.Add();
                		dtaBuscPrestamo.Rows[i].Cells[0].Value =readerDetallePrestamo.GetInt32(readerDetallePrestamo.GetOrdinal("foliopre"));
                		dtaBuscPrestamo.Rows[i].Cells[1].Value =readerDetallePrestamo.GetInt32(readerDetallePrestamo.GetOrdinal("idmat"));
                		i++;
                		}
                		
                		readerDetallePrestamo.Close();
                
                		int contador=0;
                		IDbCommand comandoConsultaProducto = dbcon.CreateCommand();
						if (comandoConsultaProducto == null)
							return;
                
                		while(contador != i)
                		{
                			comandoConsultaProducto.CommandText = "select titulo, autores from material where idmaterial=" +Convert.ToInt32(dtaBuscPrestamo.Rows[contador].Cells[1].Value) + "";
                			IDataReader readerProducto = comandoConsultaProducto.ExecuteReader();
                		
                			if(readerProducto.Read())
                			{
                				
                				dtaBuscPrestamo.Rows[contador].Cells[2].Value =readerProducto.GetString(readerProducto.GetOrdinal("titulo"));
                				dtaBuscPrestamo.Rows[contador].Cells[3].Value =readerProducto.GetString(readerProducto.GetOrdinal("autores"));
                				dtaBuscPrestamo.Rows[contador].Cells[4].Value =Convert.ToString(1);
                				
								totalibros = totalibros + Convert.ToInt16(dtaBuscPrestamo.Rows[contador].Cells[4].Value);
                	    		contador++;
                	    		
                	    		readerProducto.Close();
                			}
                	
                		}
                
                		lblTotal.Text = Convert.ToString(totalibros);
                	
                	}
                	
                	//Esto es para verificar si el prestamo ha sido devuelto
                    IDbCommand dbcmddd = dbcon.CreateCommand();
                    dbcmddd.CommandText = "select status from prestamo where folio="+ textIDPrestamo.Text +"";
                    IDataReader reader4 = dbcmddd.ExecuteReader();
                    reader4.Read();
                    devuelto = reader4.GetBoolean
                    (reader4.GetOrdinal("status")) ;
                        
                    //si los tiene aparecera este mensaje	
                    if (devuelto == false)
                    {
                      		
                        if (MessageBox.Show("El prestamo sera devuelto?", "Confirmación", 
        	                MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == 
        	                System.Windows.Forms.DialogResult.Yes)
            		 	{
                    		NpgsqlConnection dbconn = new NpgsqlConnection("Server=localhost;" +
                        	"Database=biblioteca;" +
                        	"User ID=Kevin;" );
                    		dbconn.Open();
                    		IDbCommand dbcmdddd = dbconn.CreateCommand();
                    		dbcmdddd.CommandText = "update prestamo set status = true where folio="+ lblFolio.Text +"";
                    		IDataReader reader5 = dbcmdddd.ExecuteReader();
                    		reader5.Read();
                    		
                    		int n, contador=0, existnew;
                      		while (i != contador)
                        	{
                            	n =
                            	Convert.ToInt32
                            	(dtaBuscPrestamo.Rows[contador].Cells[1].Value);
                            
                            	existnew = 
                            	Convert.ToInt32(dtaBuscPrestamo.Rows[contador].Cells[4].Value);
                            	string queryUppMaterial = 
                            	"update material set existencia=existencia+" + existnew +
                            	" where idmaterial=" + n + "";
                            	
                            	NpgsqlCommand cmdUppMaterial = 
                            	new NpgsqlCommand(queryUppMaterial, dbconn);
                            	cmdUppMaterial.ExecuteNonQuery();
                            	
                            	string queryUppUsuario = 
                            	"update usuario set librosprestados=librosprestados-" + existnew +
                            	" where idusuario=" + lblIDUsuario.Text + "";
                            	
                            	NpgsqlCommand cmdUppUsuario = 
                            	new NpgsqlCommand(queryUppUsuario, dbconn);
                            	cmdUppUsuario.ExecuteNonQuery();
                            	contador++;
                        	}
                      		
                      		IDbCommand dbcmd90 = dbcon.CreateCommand();
                			dbcmd90.CommandText = "select status from prestamo where folio=" + lblFolio.Text + "";
                			IDataReader reader90 = dbcmd90.ExecuteReader();
                			reader90.Read();
                      		lblStatus.Text = Convert.ToString(reader.GetBoolean
                    		(reader.GetOrdinal("status")));
                      		MessageBox.Show("Devolucion Exitosa.");
                      	}
                     	
                    }
                        
                    //si ya esta devuelto aparece un mensaje
                    else
                    {
                       MessageBox.Show("Este prestamo ya ha sido devuelto");
                    }
                        
                	dbcon.Close();
                        
                        
                	if (band == 0)
                	{
                    	MessageBox.Show("Prestamo No Encontrado...");
                	}
					
				}
				
				catch (Exception msg)
                {
                	MessageBox.Show(msg.ToString());
                	MessageBox.Show("Fallo la conversion");
                }
				
				textIDPrestamo.Clear();
				textIDPrestamo.Focus();		 
			}
		}
		
		void BtnRegresarClick(object sender, EventArgs e)
		{
			this.Visible=false;
			MainForm x=new MainForm();
			x.Show();
		}
		
		void BuscarPrestamoLoad(object sender, EventArgs e)
		{
			x.Columns.Add("Folio");
			x.Columns.Add("ID Material");
            x.Columns.Add("Titulo");
            x.Columns.Add("Autor");
            x.Columns.Add("Cantidad");
            dtaBuscPrestamo.DataSource = x.DefaultView;
		}
		
		void BuscarPrestamoFormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}
