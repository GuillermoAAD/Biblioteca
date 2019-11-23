/*
 * Created by SharpDevelop.
 * User: TOSHIBA
 * Date: 09/05/2017
 * Time: 08:17 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Biblioteca
{
	partial class AgregarPrestamo
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
			this.dtaPrestamo = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textUsuario = new System.Windows.Forms.TextBox();
			this.textTitulo = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblFechaPre = new System.Windows.Forms.Label();
			this.lblFechaDev = new System.Windows.Forms.Label();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.textIDMat = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textAutores = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.lblFolio = new System.Windows.Forms.Label();
			this.btnAgrMat = new System.Windows.Forms.Button();
			this.btnBuscMat = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dtaPrestamo)).BeginInit();
			this.SuspendLayout();
			// 
			// dtaPrestamo
			// 
			this.dtaPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtaPrestamo.Location = new System.Drawing.Point(13, 160);
			this.dtaPrestamo.Name = "dtaPrestamo";
			this.dtaPrestamo.Size = new System.Drawing.Size(539, 206);
			this.dtaPrestamo.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(97, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 23);
			this.label1.TabIndex = 9;
			this.label1.Text = "Folio:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(97, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 23);
			this.label2.TabIndex = 10;
			this.label2.Text = "ID Usuario:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(98, 108);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 23);
			this.label3.TabIndex = 11;
			this.label3.Text = "Titulo:";
			// 
			// textUsuario
			// 
			this.textUsuario.Location = new System.Drawing.Point(161, 44);
			this.textUsuario.Name = "textUsuario";
			this.textUsuario.Size = new System.Drawing.Size(114, 20);
			this.textUsuario.TabIndex = 13;
			// 
			// textTitulo
			// 
			this.textTitulo.Location = new System.Drawing.Point(161, 105);
			this.textTitulo.Name = "textTitulo";
			this.textTitulo.Size = new System.Drawing.Size(114, 20);
			this.textTitulo.TabIndex = 14;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(345, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 15;
			this.label4.Text = "Fecha Prestamo:";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(345, 47);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 16;
			this.label5.Text = "Fecha Devolucion:";
			// 
			// lblFechaPre
			// 
			this.lblFechaPre.Location = new System.Drawing.Point(452, 20);
			this.lblFechaPre.Name = "lblFechaPre";
			this.lblFechaPre.Size = new System.Drawing.Size(100, 23);
			this.lblFechaPre.TabIndex = 17;
			this.lblFechaPre.Text = "0";
			// 
			// lblFechaDev
			// 
			this.lblFechaDev.Location = new System.Drawing.Point(452, 47);
			this.lblFechaDev.Name = "lblFechaDev";
			this.lblFechaDev.Size = new System.Drawing.Size(100, 23);
			this.lblFechaDev.TabIndex = 18;
			this.lblFechaDev.Text = "0";
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(204, 372);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(75, 23);
			this.btnAgregar.TabIndex = 19;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// btnRegresar
			// 
			this.btnRegresar.Location = new System.Drawing.Point(285, 372);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(75, 23);
			this.btnRegresar.TabIndex = 20;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = true;
			this.btnRegresar.Click += new System.EventHandler(this.BtnRegresarClick);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(98, 82);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(67, 23);
			this.label6.TabIndex = 21;
			this.label6.Text = "ID Material:";
			// 
			// textIDMat
			// 
			this.textIDMat.Location = new System.Drawing.Point(161, 79);
			this.textIDMat.Name = "textIDMat";
			this.textIDMat.Size = new System.Drawing.Size(114, 20);
			this.textIDMat.TabIndex = 22;
			this.textIDMat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textIDMatKeyPress);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(98, 134);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(57, 23);
			this.label7.TabIndex = 23;
			this.label7.Text = "Autor(es):";
			// 
			// textAutores
			// 
			this.textAutores.Location = new System.Drawing.Point(161, 131);
			this.textAutores.Name = "textAutores";
			this.textAutores.Size = new System.Drawing.Size(114, 20);
			this.textAutores.TabIndex = 24;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(345, 134);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 27;
			this.label9.Text = "Total de Libros:";
			// 
			// lblTotal
			// 
			this.lblTotal.Location = new System.Drawing.Point(451, 134);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(16, 23);
			this.lblTotal.TabIndex = 28;
			this.lblTotal.Text = "0";
			// 
			// lblFolio
			// 
			this.lblFolio.Location = new System.Drawing.Point(161, 20);
			this.lblFolio.Name = "lblFolio";
			this.lblFolio.Size = new System.Drawing.Size(46, 21);
			this.lblFolio.TabIndex = 29;
			this.lblFolio.Text = "0";
			// 
			// btnAgrMat
			// 
			this.btnAgrMat.Location = new System.Drawing.Point(345, 77);
			this.btnAgrMat.Name = "btnAgrMat";
			this.btnAgrMat.Size = new System.Drawing.Size(52, 23);
			this.btnAgrMat.TabIndex = 30;
			this.btnAgrMat.Text = "Agregar";
			this.btnAgrMat.UseVisualStyleBackColor = true;
			this.btnAgrMat.Click += new System.EventHandler(this.BtnAgrMatClick);
			// 
			// btnBuscMat
			// 
			this.btnBuscMat.Location = new System.Drawing.Point(285, 77);
			this.btnBuscMat.Name = "btnBuscMat";
			this.btnBuscMat.Size = new System.Drawing.Size(48, 23);
			this.btnBuscMat.TabIndex = 31;
			this.btnBuscMat.Text = "Buscar";
			this.btnBuscMat.UseVisualStyleBackColor = true;
			this.btnBuscMat.Click += new System.EventHandler(this.BtnBuscMatClick);
			// 
			// AgregarPrestamo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(564, 461);
			this.Controls.Add(this.btnBuscMat);
			this.Controls.Add(this.btnAgrMat);
			this.Controls.Add(this.lblFolio);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.textAutores);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textIDMat);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.lblFechaDev);
			this.Controls.Add(this.lblFechaPre);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textTitulo);
			this.Controls.Add(this.textUsuario);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dtaPrestamo);
			this.Name = "AgregarPrestamo";
			this.Text = "AgregarPrestamo";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AgregarPrestamoFormClosing);
			this.Load += new System.EventHandler(this.AgregarPrestamoLoad);
			((System.ComponentModel.ISupportInitialize)(this.dtaPrestamo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnBuscMat;
		private System.Windows.Forms.Button btnAgrMat;
		private System.Windows.Forms.Label lblFolio;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textAutores;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textIDMat;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnRegresar;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Label lblFechaDev;
		private System.Windows.Forms.Label lblFechaPre;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textTitulo;
		private System.Windows.Forms.TextBox textUsuario;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dtaPrestamo;
		
	}
}
