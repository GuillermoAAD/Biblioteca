/*
 * Created by SharpDevelop.
 * User: TOSHIBA
 * Date: 09/05/2017
 * Time: 08:17 p.m.
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
	/// Description of AgregarPrestamo.
	/// </summary>
	public partial class AgregarPrestamo : Form
	{
		public AgregarPrestamo()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		int n,i,exist,totalibros;
        DataTable x = new DataTable();
        
		public void Genera()
        {
            try
            {
                int sigue;
                 NpgsqlConnection dbcon = new NpgsqlConnection("Server=localhost;" +
                        "Database=biblioteca;" +
                        "User ID=Kevin;");
                dbcon.Open();
                IDbCommand dbcmd = dbcon.CreateCommand();
                dbcmd.CommandText = 
                	"select folio from prestamo order by folio desc limit 1";
                IDataReader reader = dbcmd.ExecuteReader();
                if (reader.Read())
                {

                    sigue = 
                    	Convert.ToInt32
                    	(reader.GetInt32(reader.GetOrdinal("folio")) + 1);
                    lblFolio.Text=Convert.ToString(sigue);
                    dbcon.Close();
                }
                else
                {
                    lblFolio.Text = "1";
                }
  
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
            }
           
        }
        
        
		void BtnRegresarClick(object sender, EventArgs e)
		{
			this.Visible=false;
			MainForm x=new MainForm();
			x.Show();
		}
		
		//No existe
		/*void textIDMatKeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
            {
                if (textIDMat.Text == "")
                {
                    MessageBox.Show("DEBES INTRODUCIR EL ID " +
                	                "DEL PRODUCTO....");
                    textIDMat.Focus();
                }
                else
                {
                    try
                    {
                        IDbConnection dbcon = new 
                        	NpgsqlConnection("Server=localhost;" +
                     "Database=biblioteca;" +
                     "User ID=Kevin;");
                        dbcon.Open();
                         n = Convert.ToInt32(textIDMat.Text);
                        IDbCommand dbcmd = dbcon.CreateCommand();
                       
                        dbcmd.CommandText = "select * from " +
                        	"material where idmaterial=" + n + "";
                        IDataReader reader = dbcmd.ExecuteReader();
                        if (reader.Read())
                        {
                            textTitulo.Text = 
                            	reader.GetString
                            	(reader.GetOrdinal("titulo"));
                            textAutores.Text = 
                            	reader.GetString
                            	 (reader.GetOrdinal("autores"));
                            exist = reader.GetInt32
                            	(reader.GetOrdinal("existencia"));
                            dbcon.Close();
                            //textCantidad.Focus();
                        }
                        else
                        {
                        	textIDMat.Clear() ;
                        	textTitulo.Clear();
                        	textAutores.Clear();
                            MessageBox.Show
                            	("Producto no encontrado");
                        }
                    }
                    catch (Exception msg)
                    {
                        MessageBox.Show(msg.ToString());
                    }
                }
			}
		}*/
		
		int banderas,cuenta;
		public void BuscarEnGrid()
		{
		 cuenta=0;
		 banderas=0;
			do
			{
				int h= Convert.ToInt16(dtaPrestamo.Rows[cuenta].Cells[0].Value);
				if(h==n)
				{
					banderas=1;
					break;
					
				}
				cuenta++;
			}
			while(cuenta<i);
		}
		
		void textIDMatKeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
            {
				if (textIDMat.Text == "")
                {
                    MessageBox.Show("Debes introducir el ID del material bibliografico....");
                    textIDMat.Focus();
                }
                else
                {
                    try
                    {
                    	IDbConnection dbcon = new 
                        NpgsqlConnection("Server=localhost;" +
                    	"Database=biblioteca;" +
                    	"User ID=Kevin;");
                        dbcon.Open();
                        n = Convert.ToInt32(textIDMat.Text);
                        IDbCommand dbcmd = dbcon.CreateCommand();
                        
                        dbcmd.CommandText = "select * from " +
                        "material where idmaterial=" + n + "";
                        IDataReader reader = dbcmd.ExecuteReader();
                        
                        if (reader.Read())
                        {
                        	textTitulo.Text = 
                            reader.GetString
                            (reader.GetOrdinal("titulo"));
                            textAutores.Text = 
                            reader.GetString
                            (reader.GetOrdinal("autores"));
                            exist = reader.GetInt32
                            (reader.GetOrdinal("existencia"));
                            dbcon.Close();
                        }
                        
                        else
                        {
                        	textIDMat.Clear() ;
                        	textTitulo.Clear();
                        	textAutores.Clear();
                            MessageBox.Show("Material bibliografico no encontrado");
                        }
                        
                    }
                    
                    catch (Exception msg)
                    {
                        MessageBox.Show(msg.ToString());
                    }
                }
			}
		}
		
		void textCantidadKeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
            {
			 	//if(textCantidad.Text=="")
			 	//{
			 	//	MessageBox.Show("DEBES INTRODUCIR UNA CANTIDAD....");
			 	//	textCantidad.Focus();
			 	//}
			 	
			 	//else{
			 			//if (Convert.ToInt16( textCantidad.Text ) <=0 )
             	   		//	{
                  		//		MessageBox.Show("Debes retirar al menos 1 ejemplar....");
                    			//textCantidad.Clear();
                    			//textCantidad.Focus();
                		//	}
			 			//else if (Convert.ToInt16( textCantidad.Text ) >1 )
			 			//	{
                  		//		MessageBox.Show("Solo puedes retirar 1 ejemplar....");
                    			//textCantidad.Clear();
                    			//textCantidad.Focus();
                		//	}
                		//if //else
                	//{
                			BuscarEnGrid();
                		
                			if (1 <= exist)
                    		{
							
                        		if (MessageBox.Show("Deseas agregar el material bibliografico al prestamo?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        		{
                        		
                        			if(banderas==1)
                        			{
                        				if((Convert.ToDouble(dtaPrestamo.Rows[cuenta].Cells[2].Value)+1)>exist)
                        				{
                        				MessageBox.Show("Excedes la existencia de ejemplares..");
                        				}
                        				else
                        				{
                        					totalibros=totalibros-1;
                        					dtaPrestamo.Rows[cuenta].Cells[3].Value = Convert.ToInt16(dtaPrestamo.Rows[cuenta].Cells[3].Value)+
                        					1;
                       						
                            	    		
											totalibros = totalibros 
                            				+ Convert.ToInt16
                            				(dtaPrestamo.Rows[cuenta].Cells[3].Value);								
                        				}
                        			}
                        			
                        			else
                        			{
                            			x.Rows.Add();
                            			dtaPrestamo.Rows[i].Cells[0].Value = n;
                            			dtaPrestamo.Rows[i].Cells[1].Value = 
                            			textTitulo.Text;
                            			dtaPrestamo.Rows[i].Cells[2].Value = 
                            			textAutores.Text;
                            			dtaPrestamo.Rows[i].Cells[3].Value = 1;
                            			//textCantidad.Text;
                            
                            			totalibros = totalibros
                            			+ Convert.ToInt16
                            			(dtaPrestamo.Rows[i].Cells[3].Value);
                            			dtaPrestamo.Refresh();
                            			//textCantidad.Text = "";
                            			textTitulo.Text = "";
                            			textAutores.Text = "";
                            			textIDMat.Focus();
                            			i++;
                        			}
                     
                            	lblTotal.Text = Convert.ToString(totalibros);
                            	
      							}
	                        textTitulo.Clear();
                        	textAutores.Clear();
                        	textIDMat.Focus();
                        	textIDMat.Clear();
        					}
                			
                    		else
                   			{
                        		MessageBox.Show("Excedes la existencia de ejemplares, la disponibilidad es de " + exist + " Ejemplares");
                        		//textCantidad.Text = "";
                        		//textCantidad.Focus();
                    		}
			
 			}
        }
			 
		
		void AgregarPrestamoLoad(object sender, EventArgs e)
		{
			x.Columns.Add("ID");
            x.Columns.Add("Titulo");
            x.Columns.Add("Autor");
            x.Columns.Add("Cantidad");
            dtaPrestamo.DataSource = x.DefaultView;
            Genera();
            lblFechaPre.Text=DateTime.Now.ToString("dd/MM/yyyy");
            lblFechaDev.Text=DateTime.Now.AddDays(30).ToString("dd/MM/yyyy");
            textIDMat.Focus();
		}
		
		void BtnAgregarClick(object sender, EventArgs e)
		{
			
			if (MessageBox.Show("Desea guardar el prestamo?", "Confirmación", 
        	                    MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == 
        	                    System.Windows.Forms.DialogResult.Yes)
            {
				if (textUsuario.Text == "")
				{
					MessageBox.Show("Debes agregar El ID de Usuario");
					textUsuario.Focus();
				}
				
				else
				{
				
                	if (i > 0)
                	{
                    	try
                    	{
                        	int contador = 0, existnew, saldoalumno;
                        	NpgsqlConnection dbcon = new NpgsqlConnection("Server=localhost;" +
                        	"Database=biblioteca;" +
                        	"User ID=Kevin;" );
                        	dbcon.Open();
                        
                        	//Esto es para verificar si el usuario tiene mas de 5 libros prestados
                        	IDbCommand dbcmdd = dbcon.CreateCommand();
                        	dbcmdd.CommandText
                        	= "select librosprestados from usuario where idusuario="+ textUsuario.Text +"";
                        	IDataReader reader3 = dbcmdd.ExecuteReader();
                        	reader3.Read();
                        	saldoalumno = reader3.GetInt32
                        	(reader3.GetOrdinal("librosprestados")) ;
                        
                        	//si los tiene aparecera este mensaje	
                      		if (saldoalumno >= 5)
                        	{
                        		MessageBox.Show("Este Usuario ha excedido el numero de prestamos permitidos");
                        	}
                        
                      		//si no los tiene se prosigue con el prestamo
                        	else
                        	{
                            
                        		while (i != contador)
                        		{
                            		n =
                            		Convert.ToInt32
                            		(dtaPrestamo.Rows[contador].Cells[0].Value);
                            
                            		existnew = 
                            		Convert.ToInt32(dtaPrestamo.Rows[contador].Cells[3].Value);
                            		string queryUpMaterial = 
                            		"update material set existencia=existencia-" + existnew +
                            		" where idmaterial=" + n + "";
                            		NpgsqlCommand cmdUpMaterial = 
                            		new NpgsqlCommand(queryUpMaterial, dbcon);
                            		cmdUpMaterial.ExecuteNonQuery();
                            		string queryUpUsuario = 
                            		"update usuario set librosprestados=librosprestados+" + existnew +
                            		" where idusuario=" + textUsuario.Text + "";
                            		NpgsqlCommand cmdUpUsuario = 
                            		new NpgsqlCommand(queryUpUsuario, dbcon);
                            		cmdUpUsuario.ExecuteNonQuery();
                            		contador++;
                        		}
                    
                     
								IDbCommand dbcmdVenta =dbcon.CreateCommand();
                    			dbcmdVenta.CommandText = 
                    			"insert into prestamo values("+ Convert.ToInt16(lblFolio.Text)+",'" + lblFechaPre.Text + "','" + lblFechaDev.Text + "','" + textUsuario.Text+"')";
                     			IDataReader readerr = dbcmdVenta.ExecuteReader();
                     			MessageBox.Show("El prestamo se ha realizado...");
                     			textIDMat.Focus();
                     			dbcon.Close();
                     			contador = 0;
                     	
                     			while (i != contador)
                     			{
                        			IDbConnection dbconDetalle = new NpgsqlConnection
                        			("Server=localhost;" +
                    				"Database=biblioteca;" +
                    				"User ID=Kevin;");
                    				dbconDetalle.Open();   
                    				IDbCommand dbcmdDetalleVenta =dbconDetalle.CreateCommand();
                   					dbcmdDetalleVenta.CommandText = 
                    				"insert into detalleprestamo values("+ Convert.ToInt16(lblFolio.Text)+"," + Convert.ToInt32(dtaPrestamo.Rows[contador].Cells[0].Value) + ")";
                     				IDataReader reader2 = dbcmdDetalleVenta.ExecuteReader();
                        			contador++;
                        		}
                     	
                     	
                     	
                    			Genera();
       			 				i = 0;
                 				lblTotal.Text = "";
				 				totalibros = 0;
				 				x.Rows.Clear();              
				 		
                        	}
                    	}
  					
                    	catch (Exception msg)
                    	{
                        	MessageBox.Show(msg.ToString());
                    	}
                
					}
                
                	else
                	{
                    	MessageBox.Show("Primero debes registrar material bibliografico.");
                	}
                
				}
			}
		}
		
		void AgregarPrestamoFormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
		
		void BtnBuscMatClick(object sender, EventArgs e)
		{
			
                if (textIDMat.Text == "")
                {
                    MessageBox.Show("Debes introducir el ID del material bibliografico....");
                    textIDMat.Focus();
                }
                else
                {
                    try
                    {
                    	IDbConnection dbcon = new 
                        NpgsqlConnection("Server=localhost;" +
                    	"Database=biblioteca;" +
                    	"User ID=Kevin;");
                        dbcon.Open();
                        n = Convert.ToInt32(textIDMat.Text);
                        IDbCommand dbcmd = dbcon.CreateCommand();
                        
                        dbcmd.CommandText = "select * from " +
                        "material where idmaterial=" + n + "";
                        IDataReader reader = dbcmd.ExecuteReader();
                        
                        if (reader.Read())
                        {
                        	textTitulo.Text = 
                            reader.GetString
                            (reader.GetOrdinal("titulo"));
                            textAutores.Text = 
                            reader.GetString
                            (reader.GetOrdinal("autores"));
                            exist = reader.GetInt32
                            (reader.GetOrdinal("existencia"));
                            dbcon.Close();
                        }
                        
                        else
                        {
                        	textIDMat.Clear() ;
                        	textTitulo.Clear();
                        	textAutores.Clear();
                            MessageBox.Show("Material bibliografico no encontrado");
                        }
                        
                    }
                    
                    catch (Exception msg)
                    {
                        MessageBox.Show(msg.ToString());
                    }
                }
			
		}
		
		void BtnAgrMatClick(object sender, EventArgs e)
		{
            	BuscarEnGrid();
                		
                if (1 <= exist)
                {
							
                	if (MessageBox.Show("Deseas agregar el material bibliografico al prestamo?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                		if (totalibros <= 4)
                		{
                			
                    		if(banderas==1)
                        	{
                        		if((Convert.ToDouble(dtaPrestamo.Rows[cuenta].Cells[2].Value)+1)>exist)
                        		{
                        			MessageBox.Show("Excedes la existencia de ejemplares..");
                        		}
                        	
                        		else
                        		{
                        			totalibros=totalibros-1;
                        			dtaPrestamo.Rows[cuenta].Cells[3].Value = Convert.ToInt16(dtaPrestamo.Rows[cuenta].Cells[3].Value)+
                        			1;
											 		
									totalibros = totalibros 
                            		+ Convert.ToInt16
                            		(dtaPrestamo.Rows[cuenta].Cells[3].Value);							
                        		}
                        	
                        	}
                    	
                        	else
                        	{
                        		x.Rows.Add();
                            	dtaPrestamo.Rows[i].Cells[0].Value = n;
                            	dtaPrestamo.Rows[i].Cells[1].Value = 
                            	textTitulo.Text;
                            	dtaPrestamo.Rows[i].Cells[2].Value = 
                            	textAutores.Text;
                            	dtaPrestamo.Rows[i].Cells[3].Value = 1;
                            
                            	totalibros = totalibros
                            	+ Convert.ToInt16
                            	(dtaPrestamo.Rows[i].Cells[3].Value);
                            	dtaPrestamo.Refresh();
                            	textTitulo.Text = "";
                            	textAutores.Text = "";
                            	textIDMat.Text = "";
                            	textIDMat.Focus();
                            	i++;
                        	}
                        
                		}
                		
                		else
                		{
                			MessageBox.Show("Solo puedes agregar 5 libros");
                		}
                		
                	}
                	
                     	
                    lblTotal.Text = Convert.ToString(totalibros);
                            	
      				
                	
	                textTitulo.Clear();
                    textAutores.Clear();
                    textIDMat.Focus();
                    
        		}
                	
                
                else
                {
                	MessageBox.Show("Excedes la existencia, la disponibilidad es de " + exist + " Ejemplares");
                }

		}
	}
	
}
