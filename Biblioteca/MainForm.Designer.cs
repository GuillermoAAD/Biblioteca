/*
 * Created by SharpDevelop.
 * User: TOSHIBA
 * Date: 09/05/2017
 * Time: 07:29 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Biblioteca
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.materialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.usuarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.materialToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.prestamoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salirToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.agregarToolStripMenuItem,
			this.salirToolStripMenuItem,
			this.salirToolStripMenuItem1,
			this.salirToolStripMenuItem2});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(416, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// agregarToolStripMenuItem
			// 
			this.agregarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.usuarioToolStripMenuItem,
			this.materialToolStripMenuItem});
			this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
			this.agregarToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
			this.agregarToolStripMenuItem.Text = "Usuario";
			// 
			// usuarioToolStripMenuItem
			// 
			this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
			this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.usuarioToolStripMenuItem.Text = "Agregar";
			this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.UsuarioToolStripMenuItemClick);
			// 
			// materialToolStripMenuItem
			// 
			this.materialToolStripMenuItem.Name = "materialToolStripMenuItem";
			this.materialToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.materialToolStripMenuItem.Text = "Mostrar";
			this.materialToolStripMenuItem.Click += new System.EventHandler(this.MaterialToolStripMenuItemClick);
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.usuarioToolStripMenuItem1,
			this.materialToolStripMenuItem1});
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
			this.salirToolStripMenuItem.Text = "Material";
			// 
			// usuarioToolStripMenuItem1
			// 
			this.usuarioToolStripMenuItem1.Name = "usuarioToolStripMenuItem1";
			this.usuarioToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
			this.usuarioToolStripMenuItem1.Text = "Agregar";
			this.usuarioToolStripMenuItem1.Click += new System.EventHandler(this.UsuarioToolStripMenuItem1Click);
			// 
			// materialToolStripMenuItem1
			// 
			this.materialToolStripMenuItem1.Name = "materialToolStripMenuItem1";
			this.materialToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
			this.materialToolStripMenuItem1.Text = "Mostrar";
			this.materialToolStripMenuItem1.Click += new System.EventHandler(this.MaterialToolStripMenuItem1Click);
			// 
			// salirToolStripMenuItem1
			// 
			this.salirToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.prestamoToolStripMenuItem2,
			this.buscarToolStripMenuItem});
			this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
			this.salirToolStripMenuItem1.Size = new System.Drawing.Size(69, 20);
			this.salirToolStripMenuItem1.Text = "Prestamo";
			// 
			// prestamoToolStripMenuItem2
			// 
			this.prestamoToolStripMenuItem2.Name = "prestamoToolStripMenuItem2";
			this.prestamoToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
			this.prestamoToolStripMenuItem2.Text = "Agregar";
			this.prestamoToolStripMenuItem2.Click += new System.EventHandler(this.PrestamoToolStripMenuItem2Click);
			// 
			// buscarToolStripMenuItem
			// 
			this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
			this.buscarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.buscarToolStripMenuItem.Text = "Buscar";
			this.buscarToolStripMenuItem.Click += new System.EventHandler(this.BuscarToolStripMenuItemClick);
			// 
			// salirToolStripMenuItem2
			// 
			this.salirToolStripMenuItem2.Name = "salirToolStripMenuItem2";
			this.salirToolStripMenuItem2.Size = new System.Drawing.Size(41, 20);
			this.salirToolStripMenuItem2.Text = "Salir";
			this.salirToolStripMenuItem2.Click += new System.EventHandler(this.SalirToolStripMenuItem2Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(142, 160);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(240, 20);
			this.textBox1.TabIndex = 1;
			this.textBox1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(142, 115);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(240, 20);
			this.textBox2.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(36, 112);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Usuario";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.Control;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(36, 158);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Contraseña";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(416, 270);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Biblioteca";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem prestamoToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem materialToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem materialToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}
