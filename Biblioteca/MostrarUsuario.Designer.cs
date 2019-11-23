/*
 * Created by SharpDevelop.
 * User: TOSHIBA
 * Date: 09/05/2017
 * Time: 08:13 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Biblioteca
{
	partial class MostrarUsuario
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
			this.dgvUsuario = new System.Windows.Forms.DataGridView();
			this.btnActUs = new System.Windows.Forms.Button();
			this.btnRegUs = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvUsuario
			// 
			this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUsuario.Location = new System.Drawing.Point(12, 12);
			this.dgvUsuario.Name = "dgvUsuario";
			this.dgvUsuario.Size = new System.Drawing.Size(452, 247);
			this.dgvUsuario.TabIndex = 0;
			// 
			// btnActUs
			// 
			this.btnActUs.Location = new System.Drawing.Point(163, 283);
			this.btnActUs.Name = "btnActUs";
			this.btnActUs.Size = new System.Drawing.Size(75, 23);
			this.btnActUs.TabIndex = 1;
			this.btnActUs.Text = "Actualizar";
			this.btnActUs.UseVisualStyleBackColor = true;
			this.btnActUs.Click += new System.EventHandler(this.BtnActUsClick);
			// 
			// btnRegUs
			// 
			this.btnRegUs.Location = new System.Drawing.Point(245, 283);
			this.btnRegUs.Name = "btnRegUs";
			this.btnRegUs.Size = new System.Drawing.Size(75, 23);
			this.btnRegUs.TabIndex = 2;
			this.btnRegUs.Text = "Regresar";
			this.btnRegUs.UseVisualStyleBackColor = true;
			this.btnRegUs.Click += new System.EventHandler(this.btnRegUsClick);
			// 
			// MostrarUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(476, 328);
			this.Controls.Add(this.btnRegUs);
			this.Controls.Add(this.btnActUs);
			this.Controls.Add(this.dgvUsuario);
			this.Name = "MostrarUsuario";
			this.Text = "MostrarUsuario";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MostrarUsuarioFormClosing);
			this.Load += new System.EventHandler(this.MostrarUsuarioLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnRegUs;
		private System.Windows.Forms.Button btnActUs;
		private System.Windows.Forms.DataGridView dgvUsuario;
	}
}
