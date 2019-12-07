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
	partial class AgregarMaterial
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
			this.btnSalMat = new System.Windows.Forms.Button();
			this.btnBusMat = new System.Windows.Forms.Button();
			this.btnLimMat = new System.Windows.Forms.Button();
			this.btnAddMat = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textIDMat = new System.Windows.Forms.TextBox();
			this.textTitMat = new System.Windows.Forms.TextBox();
			this.textAutMat = new System.Windows.Forms.TextBox();
			this.textExiMat = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnSalMat
			// 
			this.btnSalMat.Location = new System.Drawing.Point(164, 184);
			this.btnSalMat.Name = "btnSalMat";
			this.btnSalMat.Size = new System.Drawing.Size(75, 23);
			this.btnSalMat.TabIndex = 8;
			this.btnSalMat.Text = "Regresar";
			this.btnSalMat.UseVisualStyleBackColor = true;
			this.btnSalMat.Click += new System.EventHandler(this.BtnSalMatClick);
			// 
			// btnBusMat
			// 
			this.btnBusMat.Location = new System.Drawing.Point(73, 184);
			this.btnBusMat.Name = "btnBusMat";
			this.btnBusMat.Size = new System.Drawing.Size(75, 23);
			this.btnBusMat.TabIndex = 7;
			this.btnBusMat.Text = "Buscar";
			this.btnBusMat.UseVisualStyleBackColor = true;
			this.btnBusMat.Click += new System.EventHandler(this.BtnBusMatClick);
			// 
			// btnLimMat
			// 
			this.btnLimMat.Location = new System.Drawing.Point(164, 149);
			this.btnLimMat.Name = "btnLimMat";
			this.btnLimMat.Size = new System.Drawing.Size(75, 23);
			this.btnLimMat.TabIndex = 6;
			this.btnLimMat.Text = "Limpiar";
			this.btnLimMat.UseVisualStyleBackColor = true;
			this.btnLimMat.Click += new System.EventHandler(this.BtnLimMatClick);
			// 
			// btnAddMat
			// 
			this.btnAddMat.Location = new System.Drawing.Point(73, 149);
			this.btnAddMat.Name = "btnAddMat";
			this.btnAddMat.Size = new System.Drawing.Size(75, 23);
			this.btnAddMat.TabIndex = 5;
			this.btnAddMat.Text = "Agregar";
			this.btnAddMat.UseVisualStyleBackColor = true;
			this.btnAddMat.Click += new System.EventHandler(this.BtnAddMatClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(38, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(34, 23);
			this.label1.TabIndex = 9;
			this.label1.Text = "ID:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(38, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 23);
			this.label2.TabIndex = 10;
			this.label2.Text = "Titulo:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(38, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 23);
			this.label3.TabIndex = 11;
			this.label3.Text = "Autor:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(38, 115);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 23);
			this.label4.TabIndex = 12;
			this.label4.Text = "Existencia:";
			// 
			// textIDMat
			// 
			this.textIDMat.Location = new System.Drawing.Point(106, 31);
			this.textIDMat.Name = "textIDMat";
			this.textIDMat.Size = new System.Drawing.Size(164, 20);
			this.textIDMat.TabIndex = 13;
			// 
			// textTitMat
			// 
			this.textTitMat.Location = new System.Drawing.Point(106, 58);
			this.textTitMat.Name = "textTitMat";
			this.textTitMat.Size = new System.Drawing.Size(164, 20);
			this.textTitMat.TabIndex = 14;
			// 
			// textAutMat
			// 
			this.textAutMat.Location = new System.Drawing.Point(106, 85);
			this.textAutMat.Name = "textAutMat";
			this.textAutMat.Size = new System.Drawing.Size(164, 20);
			this.textAutMat.TabIndex = 15;
			// 
			// textExiMat
			// 
			this.textExiMat.Location = new System.Drawing.Point(106, 112);
			this.textExiMat.Name = "textExiMat";
			this.textExiMat.Size = new System.Drawing.Size(164, 20);
			this.textExiMat.TabIndex = 16;
			// 
			// AgregarMaterial
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(315, 225);
			this.Controls.Add(this.textExiMat);
			this.Controls.Add(this.textAutMat);
			this.Controls.Add(this.textTitMat);
			this.Controls.Add(this.textIDMat);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSalMat);
			this.Controls.Add(this.btnBusMat);
			this.Controls.Add(this.btnLimMat);
			this.Controls.Add(this.btnAddMat);
			this.Name = "AgregarMaterial";
			this.Text = "AgregarMaterial";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AgregarMaterialFormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox textExiMat;
		private System.Windows.Forms.TextBox textAutMat;
		private System.Windows.Forms.TextBox textTitMat;
		private System.Windows.Forms.TextBox textIDMat;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnAddMat;
		private System.Windows.Forms.Button btnLimMat;
		private System.Windows.Forms.Button btnBusMat;
		private System.Windows.Forms.Button btnSalMat;
	}
}
