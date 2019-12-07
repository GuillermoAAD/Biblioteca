/*
 * Created by SharpDevelop.
 * User: TOSHIBA
 * Date: 09/05/2017
 * Time: 08:15 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Biblioteca
{
	partial class MostrarMaterial
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
			this.dgvMaterial = new System.Windows.Forms.DataGridView();
			this.btnActMat = new System.Windows.Forms.Button();
			this.btnRegMat = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvMaterial)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvMaterial
			// 
			this.dgvMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMaterial.Location = new System.Drawing.Point(13, 13);
			this.dgvMaterial.Name = "dgvMaterial";
			this.dgvMaterial.Size = new System.Drawing.Size(452, 247);
			this.dgvMaterial.TabIndex = 0;
			// 
			// btnActMat
			// 
			this.btnActMat.Location = new System.Drawing.Point(163, 283);
			this.btnActMat.Name = "btnActMat";
			this.btnActMat.Size = new System.Drawing.Size(75, 23);
			this.btnActMat.TabIndex = 1;
			this.btnActMat.Text = "Actualizar";
			this.btnActMat.UseVisualStyleBackColor = true;
			this.btnActMat.Click += new System.EventHandler(this.BtnActMatClick);
			// 
			// btnRegMat
			// 
			this.btnRegMat.Location = new System.Drawing.Point(245, 283);
			this.btnRegMat.Name = "btnRegMat";
			this.btnRegMat.Size = new System.Drawing.Size(75, 23);
			this.btnRegMat.TabIndex = 2;
			this.btnRegMat.Text = "Regresar";
			this.btnRegMat.UseVisualStyleBackColor = true;
			this.btnRegMat.Click += new System.EventHandler(this.BtnRegMatClick);
			// 
			// MostrarMaterial
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(476, 328);
			this.Controls.Add(this.btnRegMat);
			this.Controls.Add(this.btnActMat);
			this.Controls.Add(this.dgvMaterial);
			this.Name = "MostrarMaterial";
			this.Text = "MostrarMaterial";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MostrarMaterialFormClosing);
			this.Load += new System.EventHandler(this.MostrarMaterialLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgvMaterial)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnRegMat;
		private System.Windows.Forms.Button btnActMat;
		private System.Windows.Forms.DataGridView dgvMaterial;
	}
}
