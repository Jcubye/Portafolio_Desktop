
namespace CapaGUI
{
    partial class PantallaAdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesionalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenedorProgesionalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contratosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finanzasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeProfesionalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perfilToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.profesionalesToolStripMenuItem,
            this.contratosToolStripMenuItem,
            this.finanzasToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.salirToolStripMenuItem1,
            this.salirToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(781, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notificacionesToolStripMenuItem});
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.perfilToolStripMenuItem.Text = "Dashboard";
            this.perfilToolStripMenuItem.Click += new System.EventHandler(this.perfilToolStripMenuItem_Click);
            // 
            // notificacionesToolStripMenuItem
            // 
            this.notificacionesToolStripMenuItem.Name = "notificacionesToolStripMenuItem";
            this.notificacionesToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.notificacionesToolStripMenuItem.Text = "Notificaciones";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenedorToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // mantenedorToolStripMenuItem
            // 
            this.mantenedorToolStripMenuItem.Name = "mantenedorToolStripMenuItem";
            this.mantenedorToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.mantenedorToolStripMenuItem.Text = "Mantenedor";
            this.mantenedorToolStripMenuItem.Click += new System.EventHandler(this.mantenedorToolStripMenuItem_Click);
            // 
            // profesionalesToolStripMenuItem
            // 
            this.profesionalesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenedorProgesionalesToolStripMenuItem,
            this.listadoDeProfesionalesToolStripMenuItem});
            this.profesionalesToolStripMenuItem.Name = "profesionalesToolStripMenuItem";
            this.profesionalesToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.profesionalesToolStripMenuItem.Text = "Profesionales";
            // 
            // mantenedorProgesionalesToolStripMenuItem
            // 
            this.mantenedorProgesionalesToolStripMenuItem.Name = "mantenedorProgesionalesToolStripMenuItem";
            this.mantenedorProgesionalesToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.mantenedorProgesionalesToolStripMenuItem.Text = "Mantenedor Profesionales";
            this.mantenedorProgesionalesToolStripMenuItem.Click += new System.EventHandler(this.mantenedorProgesionalesToolStripMenuItem_Click);
            // 
            // contratosToolStripMenuItem
            // 
            this.contratosToolStripMenuItem.Name = "contratosToolStripMenuItem";
            this.contratosToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.contratosToolStripMenuItem.Text = "Contratos";
            // 
            // finanzasToolStripMenuItem
            // 
            this.finanzasToolStripMenuItem.Name = "finanzasToolStripMenuItem";
            this.finanzasToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.finanzasToolStripMenuItem.Text = "Servicios";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.salirToolStripMenuItem.Text = "Finanzas";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(82, 24);
            this.salirToolStripMenuItem1.Text = "Reportes";
            // 
            // salirToolStripMenuItem2
            // 
            this.salirToolStripMenuItem2.Name = "salirToolStripMenuItem2";
            this.salirToolStripMenuItem2.Size = new System.Drawing.Size(52, 24);
            this.salirToolStripMenuItem2.Text = "Salir";
            this.salirToolStripMenuItem2.Click += new System.EventHandler(this.salirToolStripMenuItem2_Click);
            // 
            // listadoDeProfesionalesToolStripMenuItem
            // 
            this.listadoDeProfesionalesToolStripMenuItem.Name = "listadoDeProfesionalesToolStripMenuItem";
            this.listadoDeProfesionalesToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.listadoDeProfesionalesToolStripMenuItem.Text = "Listado de Profesionales";
            this.listadoDeProfesionalesToolStripMenuItem.Click += new System.EventHandler(this.listadoDeProfesionalesToolStripMenuItem_Click);
            // 
            // PantallaAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 553);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PantallaAdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel de Administrador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PantallaAdminDashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesionalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contratosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finanzasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notificacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mantenedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenedorProgesionalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeProfesionalesToolStripMenuItem;
    }
}