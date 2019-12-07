/*
 * Created by SharpDevelop.
 * User: TOSHIBA
 * Date: 09/05/2017
 * Time: 08:12 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Biblioteca
{
	partial class AgregarUsuario
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
			this.btnAddUs = new System.Windows.Forms.Button();
			this.btnLimUs = new System.Windows.Forms.Button();
			this.btnBusUs = new System.Windows.Forms.Button();
			this.btnSalUs = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textIdUs = new System.Windows.Forms.TextBox();
			this.textNomUs = new System.Windows.Forms.TextBox();
			this.textContrUs = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnAddUs
			// 
			this.btnAddUs.Location = new System.Drawing.Point(65, 128);
			this.btnAddUs.Name = "btnAddUs";
			this.btnAddUs.Size = new System.Drawing.Size(75, 23);
			this.btnAddUs.TabIndex = 0;
			this.btnAddUs.Text = "Agregar";
			this.btnAddUs.UseVisualStyleBackColor = true;
			this.btnAddUs.Click += new System.EventHandler(this.BtnAddUsClick);
			// 
			// btnLimUs
			// 
			this.btnLimUs.Location = new System.Drawing.Point(156, 128);
			this.btnLimUs.Name = "btnLimUs";
			this.btnLimUs.Size = new System.Drawing.Size(75, 23);
			this.btnLimUs.TabIndex = 1;
			this.btnLimUs.Text = "Limpiar";
			this.btnLimUs.UseVisualStyleBackColor = true;
			this.btnLimUs.Click += new System.EventHandler(this.BtnLimUsClick);
			// 
			// btnBusUs
			// 
			this.btnBusUs.Location = new System.Drawing.Point(65, 163);
			this.btnBusUs.Name = "btnBusUs";
			this.btnBusUs.Size = new System.Drawing.Size(75, 23);
			this.btnBusUs.TabIndex = 3;
			this.btnBusUs.Text = "Buscar";
			this.btnBusUs.UseVisualStyleBackColor = true;
			this.btnBusUs.Click += new System.EventHandler(this.BtnBusUsClick);
			// 
			// btnSalUs
			// 
			this.btnSalUs.Location = new System.Drawing.Point(156, 163);
			this.btnSalUs.Name = "btnSalUs";
			this.btnSalUs.Size = new System.Drawing.Size(75, 23);
			this.btnSalUs.TabIndex = 4;
			this.btnSalUs.Text = "Regresar";
			this.btnSalUs.UseVisualStyleBackColor = true;
			this.btnSalUs.Click += new System.EventHandler(this.BtnSalUsClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(31, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(23, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "ID:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(31, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "Nombre:";
			// 
			// textIdUs
			// 
			this.textIdUs.Location = new System.Drawing.Point(98, 34);
			this.textIdUs.Name = "textIdUs";
			this.textIdUs.Size = new System.Drawing.Size(142, 20);
			this.textIdUs.TabIndex = 7;
			// 
			// textNomUs
			// 
			this.textNomUs.Location = new System.Drawing.Point(98, 60);
			this.textNomUs.Name = "textNomUs";
			this.textNomUs.Size = new System.Drawing.Size(142, 20);
			this.textNomUs.TabIndex = 8;
			// 
			// textContrUs
			// 
			this.textContrUs.Location = new System.Drawing.Point(98, 86);
			this.textContrUs.Name = "textContrUs";
			this.textContrUs.Size = new System.Drawing.Size(142, 20);
			this.textContrUs.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(31, 86);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 23);
			this.label3.TabIndex = 10;
			this.label3.Text = "Contraseña";
			// 
			// AgregarUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(291, 208);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textContrUs);
			this.Controls.Add(this.textNomUs);
			this.Controls.Add(this.textIdUs);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSalUs);
			this.Controls.Add(this.btnBusUs);
			this.Controls.Add(this.btnLimUs);
			this.Controls.Add(this.btnAddUs);
			this.Name = "AgregarUsuario";
			this.Text = "AgregarUsuario";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AgregarUsuarioFormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.TextBox textNomUs;
		private System.Windows.Forms.TextBox textIdUs;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSalUs;
		private System.Windows.Forms.Button btnBusUs;
		private System.Windows.Forms.Button btnLimUs;
		private System.Windows.Forms.Button btnAddUs;
		private System.Windows.Forms.TextBox textContrUs;
		private System.Windows.Forms.Label label3;
		
	}
}
