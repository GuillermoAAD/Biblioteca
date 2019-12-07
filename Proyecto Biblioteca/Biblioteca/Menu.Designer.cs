/*
 * Created by SharpDevelop.
 * User: X-Zone
 * Date: 06/12/2019
 * Time: 12:45 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Biblioteca
{
	partial class Form1
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem materialToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem prestamoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.materialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.agregarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.mostrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.prestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.agregarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.mostrarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.usuarioToolStripMenuItem,
			this.materialToolStripMenuItem,
			this.prestamoToolStripMenuItem,
			this.salirToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(367, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// usuarioToolStripMenuItem
			// 
			this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.agregarToolStripMenuItem,
			this.mostrarToolStripMenuItem});
			this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
			this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
			this.usuarioToolStripMenuItem.Text = "Usuario";
			// 
			// agregarToolStripMenuItem
			// 
			this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
			this.agregarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.agregarToolStripMenuItem.Text = "Agregar";
			this.agregarToolStripMenuItem.Click += new System.EventHandler(this.AgregarToolStripMenuItemClick);
			// 
			// mostrarToolStripMenuItem
			// 
			this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
			this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.mostrarToolStripMenuItem.Text = "Mostrar";
			this.mostrarToolStripMenuItem.Click += new System.EventHandler(this.MostrarToolStripMenuItemClick);
			// 
			// materialToolStripMenuItem
			// 
			this.materialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.agregarToolStripMenuItem1,
			this.mostrarToolStripMenuItem1});
			this.materialToolStripMenuItem.Name = "materialToolStripMenuItem";
			this.materialToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
			this.materialToolStripMenuItem.Text = "Material";
			// 
			// agregarToolStripMenuItem1
			// 
			this.agregarToolStripMenuItem1.Name = "agregarToolStripMenuItem1";
			this.agregarToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
			this.agregarToolStripMenuItem1.Text = "Agregar";
			this.agregarToolStripMenuItem1.Click += new System.EventHandler(this.AgregarToolStripMenuItem1Click);
			// 
			// mostrarToolStripMenuItem1
			// 
			this.mostrarToolStripMenuItem1.Name = "mostrarToolStripMenuItem1";
			this.mostrarToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
			this.mostrarToolStripMenuItem1.Text = "Mostrar";
			this.mostrarToolStripMenuItem1.Click += new System.EventHandler(this.MostrarToolStripMenuItem1Click);
			// 
			// prestamoToolStripMenuItem
			// 
			this.prestamoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.agregarToolStripMenuItem2,
			this.mostrarToolStripMenuItem2});
			this.prestamoToolStripMenuItem.Name = "prestamoToolStripMenuItem";
			this.prestamoToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
			this.prestamoToolStripMenuItem.Text = "Prestamo";
			// 
			// agregarToolStripMenuItem2
			// 
			this.agregarToolStripMenuItem2.Name = "agregarToolStripMenuItem2";
			this.agregarToolStripMenuItem2.Size = new System.Drawing.Size(116, 22);
			this.agregarToolStripMenuItem2.Text = "Agregar";
			this.agregarToolStripMenuItem2.Click += new System.EventHandler(this.AgregarToolStripMenuItem2Click);
			// 
			// mostrarToolStripMenuItem2
			// 
			this.mostrarToolStripMenuItem2.Name = "mostrarToolStripMenuItem2";
			this.mostrarToolStripMenuItem2.Size = new System.Drawing.Size(116, 22);
			this.mostrarToolStripMenuItem2.Text = "Mostrar";
			this.mostrarToolStripMenuItem2.Click += new System.EventHandler(this.MostrarToolStripMenuItem2Click);
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
			this.salirToolStripMenuItem.Text = "Salir";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItemClick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(367, 261);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
