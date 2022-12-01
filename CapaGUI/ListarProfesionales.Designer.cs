namespace CapaGUI
{
    partial class ListarProfesionales
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
            this.btnListar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.prueba_portafolioDataSet = new CapaGUI.prueba_portafolioDataSet();
            this.profesionalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profesionalTableAdapter = new CapaGUI.prueba_portafolioDataSetTableAdapters.profesionalTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuariosidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prueba_portafolioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesionalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(84, 50);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 0;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(84, 226);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Volver";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(84, 135);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidopDataGridViewTextBoxColumn,
            this.apellidomDataGridViewTextBoxColumn,
            this.rolDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.usuariosidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.profesionalBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(199, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(930, 199);
            this.dataGridView1.TabIndex = 3;
            // 
            // prueba_portafolioDataSet
            // 
            this.prueba_portafolioDataSet.DataSetName = "prueba_portafolioDataSet";
            this.prueba_portafolioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // profesionalBindingSource
            // 
            this.profesionalBindingSource.DataMember = "profesional";
            this.profesionalBindingSource.DataSource = this.prueba_portafolioDataSet;
            // 
            // profesionalTableAdapter
            // 
            this.profesionalTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // apellidopDataGridViewTextBoxColumn
            // 
            this.apellidopDataGridViewTextBoxColumn.DataPropertyName = "apellido_p";
            this.apellidopDataGridViewTextBoxColumn.HeaderText = "apellido_p";
            this.apellidopDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apellidopDataGridViewTextBoxColumn.Name = "apellidopDataGridViewTextBoxColumn";
            this.apellidopDataGridViewTextBoxColumn.ReadOnly = true;
            this.apellidopDataGridViewTextBoxColumn.Width = 125;
            // 
            // apellidomDataGridViewTextBoxColumn
            // 
            this.apellidomDataGridViewTextBoxColumn.DataPropertyName = "apellido_m";
            this.apellidomDataGridViewTextBoxColumn.HeaderText = "apellido_m";
            this.apellidomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apellidomDataGridViewTextBoxColumn.Name = "apellidomDataGridViewTextBoxColumn";
            this.apellidomDataGridViewTextBoxColumn.ReadOnly = true;
            this.apellidomDataGridViewTextBoxColumn.Width = 125;
            // 
            // rolDataGridViewTextBoxColumn
            // 
            this.rolDataGridViewTextBoxColumn.DataPropertyName = "rol";
            this.rolDataGridViewTextBoxColumn.HeaderText = "rol";
            this.rolDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rolDataGridViewTextBoxColumn.Name = "rolDataGridViewTextBoxColumn";
            this.rolDataGridViewTextBoxColumn.ReadOnly = true;
            this.rolDataGridViewTextBoxColumn.Width = 125;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "estado";
            this.estadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoDataGridViewTextBoxColumn.Width = 125;
            // 
            // usuariosidDataGridViewTextBoxColumn
            // 
            this.usuariosidDataGridViewTextBoxColumn.DataPropertyName = "usuarios_id";
            this.usuariosidDataGridViewTextBoxColumn.HeaderText = "usuarios_id";
            this.usuariosidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usuariosidDataGridViewTextBoxColumn.Name = "usuariosidDataGridViewTextBoxColumn";
            this.usuariosidDataGridViewTextBoxColumn.ReadOnly = true;
            this.usuariosidDataGridViewTextBoxColumn.Width = 125;
            // 
            // ListarProfesionales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 335);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnListar);
            this.Name = "ListarProfesionales";
            this.Text = "ListarProfesionales";
            this.Load += new System.EventHandler(this.ListarProfesionales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prueba_portafolioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesionalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private prueba_portafolioDataSet prueba_portafolioDataSet;
        private System.Windows.Forms.BindingSource profesionalBindingSource;
        private prueba_portafolioDataSetTableAdapters.profesionalTableAdapter profesionalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuariosidDataGridViewTextBoxColumn;
    }
}