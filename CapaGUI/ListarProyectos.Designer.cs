namespace CapaGUI
{
    partial class ListarProyectos
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAux = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescProyecto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gridViewTrabajadores = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbProyec = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTrabajadores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(104, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 119;
            this.label1.Text = "Seleccione proyecto:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAux
            // 
            this.txtAux.Location = new System.Drawing.Point(12, 12);
            this.txtAux.Name = "txtAux";
            this.txtAux.ReadOnly = true;
            this.txtAux.Size = new System.Drawing.Size(100, 22);
            this.txtAux.TabIndex = 121;
            this.txtAux.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(98, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 17);
            this.label2.TabIndex = 122;
            this.label2.Text = "Descripción proyecto:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescProyecto
            // 
            this.txtDescProyecto.Location = new System.Drawing.Point(295, 115);
            this.txtDescProyecto.Multiline = true;
            this.txtDescProyecto.Name = "txtDescProyecto";
            this.txtDescProyecto.ReadOnly = true;
            this.txtDescProyecto.Size = new System.Drawing.Size(218, 95);
            this.txtDescProyecto.TabIndex = 123;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(75, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 17);
            this.label3.TabIndex = 124;
            this.label3.Text = "Trabajadores asignados:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gridViewTrabajadores
            // 
            this.gridViewTrabajadores.AllowUserToAddRows = false;
            this.gridViewTrabajadores.AllowUserToDeleteRows = false;
            this.gridViewTrabajadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewTrabajadores.Location = new System.Drawing.Point(295, 238);
            this.gridViewTrabajadores.Name = "gridViewTrabajadores";
            this.gridViewTrabajadores.ReadOnly = true;
            this.gridViewTrabajadores.RowTemplate.Height = 24;
            this.gridViewTrabajadores.Size = new System.Drawing.Size(402, 200);
            this.gridViewTrabajadores.TabIndex = 125;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSalir.Location = new System.Drawing.Point(346, 473);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(133, 36);
            this.btnSalir.TabIndex = 137;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(270, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(188, 25);
            this.label12.TabIndex = 138;
            this.label12.Text = "Lista de proyectos";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbProyec
            // 
            this.cmbProyec.FormattingEnabled = true;
            this.cmbProyec.Location = new System.Drawing.Point(295, 74);
            this.cmbProyec.Name = "cmbProyec";
            this.cmbProyec.Size = new System.Drawing.Size(218, 24);
            this.cmbProyec.TabIndex = 139;
            this.cmbProyec.SelectedIndexChanged += new System.EventHandler(this.cmbProyec_SelectedIndexChanged);
            // 
            // ListarProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(857, 544);
            this.Controls.Add(this.cmbProyec);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gridViewTrabajadores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescProyecto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAux);
            this.Controls.Add(this.label1);
            this.Name = "ListarProyectos";
            this.Text = "Proyectos";
            this.Load += new System.EventHandler(this.ListarProyectos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTrabajadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescProyecto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridViewTrabajadores;
        private System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.TextBox txtAux;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbProyec;
    }
}