﻿namespace CapaGUI
{
    partial class MantenedorProfesionales
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
            this.components = new System.ComponentModel.Container();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.txtNombreProfesional = new System.Windows.Forms.TextBox();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.txtRolProfesional = new System.Windows.Forms.TextBox();
            this.txtIdProfesional = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.profesionalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prueba_portafolioDataSet = new CapaGUI.prueba_portafolioDataSet();
            this.profesionalTableAdapter = new CapaGUI.prueba_portafolioDataSetTableAdapters.profesionalTableAdapter();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profesionalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prueba_portafolioDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(718, 306);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 28);
            this.btnVolver.TabIndex = 36;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(529, 306);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(100, 28);
            this.btnListar.TabIndex = 35;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(100, 306);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 28);
            this.btnAgregar.TabIndex = 33;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(587, 173);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(215, 22);
            this.txtEstado.TabIndex = 32;
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(587, 109);
            this.txtIdUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(215, 22);
            this.txtIdUsuario.TabIndex = 31;
            // 
            // txtNombreProfesional
            // 
            this.txtNombreProfesional.Location = new System.Drawing.Point(194, 92);
            this.txtNombreProfesional.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreProfesional.Name = "txtNombreProfesional";
            this.txtNombreProfesional.Size = new System.Drawing.Size(215, 22);
            this.txtNombreProfesional.TabIndex = 30;
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Location = new System.Drawing.Point(194, 216);
            this.txtApellidoMaterno.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(215, 22);
            this.txtApellidoMaterno.TabIndex = 29;
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Location = new System.Drawing.Point(194, 150);
            this.txtApellidoPaterno.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(215, 22);
            this.txtApellidoPaterno.TabIndex = 28;
            // 
            // txtRolProfesional
            // 
            this.txtRolProfesional.Location = new System.Drawing.Point(587, 51);
            this.txtRolProfesional.Margin = new System.Windows.Forms.Padding(4);
            this.txtRolProfesional.Name = "txtRolProfesional";
            this.txtRolProfesional.Size = new System.Drawing.Size(215, 22);
            this.txtRolProfesional.TabIndex = 27;
            // 
            // txtIdProfesional
            // 
            this.txtIdProfesional.Location = new System.Drawing.Point(194, 47);
            this.txtIdProfesional.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdProfesional.Name = "txtIdProfesional";
            this.txtIdProfesional.Size = new System.Drawing.Size(215, 22);
            this.txtIdProfesional.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Id Usuario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 96);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Nombre del Profesional";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 154);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Apellido Paterno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 216);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Apellido Materno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(475, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Rol Profesional";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(526, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Id Profesional";
            // 
            // profesionalBindingSource
            // 
            this.profesionalBindingSource.DataMember = "profesional";
            this.profesionalBindingSource.DataSource = this.prueba_portafolioDataSet;
            // 
            // prueba_portafolioDataSet
            // 
            this.prueba_portafolioDataSet.DataSetName = "prueba_portafolioDataSet";
            this.prueba_portafolioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // profesionalTableAdapter
            // 
            this.profesionalTableAdapter.ClearBeforeFill = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(331, 306);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpiar.TabIndex = 38;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // MantenedorProfesionales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 396);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtIdUsuario);
            this.Controls.Add(this.txtNombreProfesional);
            this.Controls.Add(this.txtApellidoMaterno);
            this.Controls.Add(this.txtApellidoPaterno);
            this.Controls.Add(this.txtRolProfesional);
            this.Controls.Add(this.txtIdProfesional);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "MantenedorProfesionales";
            this.Text = "MantenedorProfesionales";
            this.Load += new System.EventHandler(this.MantenedorProfesionales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profesionalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prueba_portafolioDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.TextBox txtNombreProfesional;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.TextBox txtRolProfesional;
        private System.Windows.Forms.TextBox txtIdProfesional;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private prueba_portafolioDataSet prueba_portafolioDataSet;
        private System.Windows.Forms.BindingSource profesionalBindingSource;
        private prueba_portafolioDataSetTableAdapters.profesionalTableAdapter profesionalTableAdapter;
        private System.Windows.Forms.Button btnLimpiar;
    }
}