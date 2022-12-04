
namespace CapaGUI
{
    partial class ProfesionalesDataView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.prueba_portafolio_profesionalDataSet = new CapaGUI.prueba_portafolio_profesionalDataSet();
            this.profesionalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profesionalTableAdapter = new CapaGUI.prueba_portafolio_profesionalDataSetTableAdapters.profesionalTableAdapter();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prueba_portafolio_profesionalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesionalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.id,
            this.apellidopDataGridViewTextBoxColumn,
            this.apellidomDataGridViewTextBoxColumn,
            this.rolDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.Acciones});
            this.dataGridView1.DataSource = this.profesionalBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(644, 234);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // prueba_portafolio_profesionalDataSet
            // 
            this.prueba_portafolio_profesionalDataSet.DataSetName = "prueba_portafolio_profesionalDataSet";
            this.prueba_portafolio_profesionalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // profesionalBindingSource
            // 
            this.profesionalBindingSource.DataMember = "profesional";
            this.profesionalBindingSource.DataSource = this.prueba_portafolio_profesionalDataSet;
            // 
            // profesionalTableAdapter
            // 
            this.profesionalTableAdapter.ClearBeforeFill = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // apellidopDataGridViewTextBoxColumn
            // 
            this.apellidopDataGridViewTextBoxColumn.DataPropertyName = "apellido_p";
            this.apellidopDataGridViewTextBoxColumn.HeaderText = "apellido_p";
            this.apellidopDataGridViewTextBoxColumn.Name = "apellidopDataGridViewTextBoxColumn";
            this.apellidopDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidomDataGridViewTextBoxColumn
            // 
            this.apellidomDataGridViewTextBoxColumn.DataPropertyName = "apellido_m";
            this.apellidomDataGridViewTextBoxColumn.HeaderText = "apellido_m";
            this.apellidomDataGridViewTextBoxColumn.Name = "apellidomDataGridViewTextBoxColumn";
            this.apellidomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rolDataGridViewTextBoxColumn
            // 
            this.rolDataGridViewTextBoxColumn.DataPropertyName = "rol";
            this.rolDataGridViewTextBoxColumn.HeaderText = "rol";
            this.rolDataGridViewTextBoxColumn.Name = "rolDataGridViewTextBoxColumn";
            this.rolDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Acciones
            // 
            this.Acciones.DataPropertyName = "id";
            this.Acciones.HeaderText = "Acciones_column";
            this.Acciones.Name = "Acciones";
            this.Acciones.ReadOnly = true;
            // 
            // ProfesionalesDataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ProfesionalesDataView";
            this.Text = "ProfesionalesDataView";
            this.Load += new System.EventHandler(this.ProfesionalesDataView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prueba_portafolio_profesionalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesionalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private prueba_portafolio_profesionalDataSet prueba_portafolio_profesionalDataSet;
        private System.Windows.Forms.BindingSource profesionalBindingSource;
        private prueba_portafolio_profesionalDataSetTableAdapters.profesionalTableAdapter profesionalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Acciones;
    }
}