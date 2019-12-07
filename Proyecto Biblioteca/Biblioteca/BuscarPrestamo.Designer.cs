/*
 * Created by SharpDevelop.
 * User: TOSHIBA
 * Date: 09/05/2017
 * Time: 08:18 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Biblioteca
{
	partial class BuscarPrestamo
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.textIDPrestamo = new System.Windows.Forms.TextBox();
			this.dtaBuscPrestamo = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblFechaPre = new System.Windows.Forms.Label();
			this.lblFechaDev = new System.Windows.Forms.Label();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.lblStatus = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblFolio = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lblIDUsuario = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dtaBuscPrestamo)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(37, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Folio Prestamo:";
			// 
			// textIDPrestamo
			// 
			this.textIDPrestamo.Location = new System.Drawing.Point(143, 28);
			this.textIDPrestamo.Name = "textIDPrestamo";
			this.textIDPrestamo.Size = new System.Drawing.Size(170, 20);
			this.textIDPrestamo.TabIndex = 1;
			// 
			// dtaBuscPrestamo
			// 
			this.dtaBuscPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtaBuscPrestamo.Location = new System.Drawing.Point(12, 113);
			this.dtaBuscPrestamo.Name = "dtaBuscPrestamo";
			this.dtaBuscPrestamo.Size = new System.Drawing.Size(579, 153);
			this.dtaBuscPrestamo.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(379, 17);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Fecha de Prestamo:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(379, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(115, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Fecha de Devolucion:";
			// 
			// lblFechaPre
			// 
			this.lblFechaPre.Location = new System.Drawing.Point(500, 17);
			this.lblFechaPre.Name = "lblFechaPre";
			this.lblFechaPre.Size = new System.Drawing.Size(91, 23);
			this.lblFechaPre.TabIndex = 5;
			this.lblFechaPre.Text = "0";
			// 
			// lblFechaDev
			// 
			this.lblFechaDev.Location = new System.Drawing.Point(500, 40);
			this.lblFechaDev.Name = "lblFechaDev";
			this.lblFechaDev.Size = new System.Drawing.Size(91, 23);
			this.lblFechaDev.TabIndex = 6;
			this.lblFechaDev.Text = "0";
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(222, 287);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(75, 23);
			this.btnBuscar.TabIndex = 7;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.BtnBuscarClick);
			// 
			// btnRegresar
			// 
			this.btnRegresar.Location = new System.Drawing.Point(304, 287);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(75, 23);
			this.btnRegresar.TabIndex = 8;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = true;
			this.btnRegresar.Click += new System.EventHandler(this.BtnRegresarClick);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(379, 87);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(54, 23);
			this.label6.TabIndex = 11;
			this.label6.Text = "Devuelto:";
			// 
			// lblStatus
			// 
			this.lblStatus.Location = new System.Drawing.Point(500, 87);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(91, 14);
			this.lblStatus.TabIndex = 12;
			this.lblStatus.Text = "???";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(379, 63);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 13;
			this.label4.Text = "Total Libros:";
			// 
			// lblTotal
			// 
			this.lblTotal.Location = new System.Drawing.Point(500, 63);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(91, 21);
			this.lblTotal.TabIndex = 14;
			this.lblTotal.Text = "0";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(37, 58);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(43, 23);
			this.label5.TabIndex = 15;
			this.label5.Text = "Folio:";
			// 
			// lblFolio
			// 
			this.lblFolio.Location = new System.Drawing.Point(143, 58);
			this.lblFolio.Name = "lblFolio";
			this.lblFolio.Size = new System.Drawing.Size(100, 23);
			this.lblFolio.TabIndex = 16;
			this.lblFolio.Text = "0";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(37, 81);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 17;
			this.label7.Text = "ID Usuario:";
			// 
			// lblIDUsuario
			// 
			this.lblIDUsuario.Location = new System.Drawing.Point(143, 81);
			this.lblIDUsuario.Name = "lblIDUsuario";
			this.lblIDUsuario.Size = new System.Drawing.Size(100, 23);
			this.lblIDUsuario.TabIndex = 18;
			this.lblIDUsuario.Text = "0";
			// 
			// BuscarPrestamo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(603, 332);
			this.Controls.Add(this.lblIDUsuario);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.lblFolio);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.lblFechaDev);
			this.Controls.Add(this.lblFechaPre);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dtaBuscPrestamo);
			this.Controls.Add(this.textIDPrestamo);
			this.Controls.Add(this.label1);
			this.Name = "BuscarPrestamo";
			this.Text = "BuscarPrestamo";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BuscarPrestamoFormClosing);
			this.Load += new System.EventHandler(this.BuscarPrestamoLoad);
			((System.ComponentModel.ISupportInitialize)(this.dtaBuscPrestamo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.Label lblIDUsuario;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lblFolio;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnRegresar;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Label lblFechaDev;
		private System.Windows.Forms.Label lblFechaPre;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dtaBuscPrestamo;
		private System.Windows.Forms.TextBox textIDPrestamo;
		private System.Windows.Forms.Label label1;
	}
}
