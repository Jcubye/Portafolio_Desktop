
namespace CapaGUI
{
    partial class PantallaFactura
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaFactura));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtRubro = new System.Windows.Forms.TextBox();
            this.txtRazon = new System.Windows.Forms.TextBox();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridCliente = new System.Windows.Forms.DataGridView();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridContrato = new System.Windows.Forms.DataGridView();
            this.txtIdContrato = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TimePickerFin = new System.Windows.Forms.DateTimePicker();
            this.TimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.txtCantidadUF = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtUFvalue = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnEmitir = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtDescDetalle = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContrato)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(907, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dateTimePicker2);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtIdContrato);
            this.tabPage1.Controls.Add(this.dataGridContrato);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtClientID);
            this.tabPage1.Controls.Add(this.txtDesc);
            this.tabPage1.Controls.Add(this.txtRubro);
            this.tabPage1.Controls.Add(this.txtRazon);
            this.tabPage1.Controls.Add(this.txtRut);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridCliente);
            this.tabPage1.Controls.Add(this.btnIngresar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(899, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cliente";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtDescDetalle);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.btnEmitir);
            this.tabPage2.Controls.Add(this.txtCantidadUF);
            this.tabPage2.Controls.Add(this.txtResultado);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.txtUFvalue);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.TimePickerFin);
            this.tabPage2.Controls.Add(this.TimePickerInicio);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(899, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Factura";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(116, 216);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ReadOnly = true;
            this.txtDesc.Size = new System.Drawing.Size(137, 83);
            this.txtDesc.TabIndex = 136;
            // 
            // txtRubro
            // 
            this.txtRubro.Location = new System.Drawing.Point(116, 165);
            this.txtRubro.Name = "txtRubro";
            this.txtRubro.ReadOnly = true;
            this.txtRubro.Size = new System.Drawing.Size(128, 20);
            this.txtRubro.TabIndex = 135;
            // 
            // txtRazon
            // 
            this.txtRazon.Location = new System.Drawing.Point(116, 116);
            this.txtRazon.Name = "txtRazon";
            this.txtRazon.ReadOnly = true;
            this.txtRazon.Size = new System.Drawing.Size(128, 20);
            this.txtRazon.TabIndex = 134;
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(116, 64);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(128, 20);
            this.txtRut.TabIndex = 133;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(140, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 141;
            this.label6.Text = "Seleccionar Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 140;
            this.label4.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 139;
            this.label3.Text = "Rubro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 138;
            this.label2.Text = "Razon Social :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 137;
            this.label1.Text = "Rut :";
            // 
            // dataGridCliente
            // 
            this.dataGridCliente.AllowUserToAddRows = false;
            this.dataGridCliente.AllowUserToDeleteRows = false;
            this.dataGridCliente.AllowUserToResizeColumns = false;
            this.dataGridCliente.AllowUserToResizeRows = false;
            this.dataGridCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCliente.GridColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridCliente.Location = new System.Drawing.Point(272, 64);
            this.dataGridCliente.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridCliente.Name = "dataGridCliente";
            this.dataGridCliente.ReadOnly = true;
            this.dataGridCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridCliente.RowHeadersVisible = false;
            this.dataGridCliente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridCliente.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridCliente.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridCliente.RowTemplate.DefaultCellStyle.NullValue = null;
            this.dataGridCliente.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCliente.RowTemplate.Height = 30;
            this.dataGridCliente.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCliente.Size = new System.Drawing.Size(139, 150);
            this.dataGridCliente.TabIndex = 132;
            this.dataGridCliente.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCliente_CellContentDoubleClick_1);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.Green;
            this.btnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnIngresar.Location = new System.Drawing.Point(396, 353);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(5);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(101, 39);
            this.btnIngresar.TabIndex = 131;
            this.btnIngresar.Text = "Siguiente";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(0, 386);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(12, 20);
            this.txtClientID.TabIndex = 142;
            this.txtClientID.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(368, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 13);
            this.label5.TabIndex = 142;
            this.label5.Text = "Ingresar datos de factura";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(576, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 13);
            this.label7.TabIndex = 143;
            this.label7.Text = "Seleccionar Contrato";
            // 
            // dataGridContrato
            // 
            this.dataGridContrato.AllowUserToAddRows = false;
            this.dataGridContrato.AllowUserToDeleteRows = false;
            this.dataGridContrato.AllowUserToResizeColumns = false;
            this.dataGridContrato.AllowUserToResizeRows = false;
            this.dataGridContrato.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridContrato.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridContrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridContrato.GridColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridContrato.Location = new System.Drawing.Point(661, 64);
            this.dataGridContrato.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridContrato.Name = "dataGridContrato";
            this.dataGridContrato.ReadOnly = true;
            this.dataGridContrato.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridContrato.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridContrato.RowHeadersVisible = false;
            this.dataGridContrato.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridContrato.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridContrato.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridContrato.RowTemplate.DefaultCellStyle.NullValue = null;
            this.dataGridContrato.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridContrato.RowTemplate.Height = 30;
            this.dataGridContrato.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridContrato.Size = new System.Drawing.Size(221, 150);
            this.dataGridContrato.TabIndex = 144;
            this.dataGridContrato.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridContrato_CellContentDoubleClick);
            // 
            // txtIdContrato
            // 
            this.txtIdContrato.Location = new System.Drawing.Point(503, 64);
            this.txtIdContrato.Name = "txtIdContrato";
            this.txtIdContrato.ReadOnly = true;
            this.txtIdContrato.Size = new System.Drawing.Size(128, 20);
            this.txtIdContrato.TabIndex = 145;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(429, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 146;
            this.label8.Text = "N° Contrato :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(185, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 13);
            this.label9.TabIndex = 146;
            this.label9.Text = "Ingrese fecha de emisión";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(454, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(198, 13);
            this.label11.TabIndex = 145;
            this.label11.Text = "Fecha de vencimiento de factura:";
            // 
            // TimePickerFin
            // 
            this.TimePickerFin.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.TimePickerFin.Location = new System.Drawing.Point(488, 111);
            this.TimePickerFin.Name = "TimePickerFin";
            this.TimePickerFin.Size = new System.Drawing.Size(200, 20);
            this.TimePickerFin.TabIndex = 144;
            this.TimePickerFin.Tag = "Restrinccion minima de termino de contrato 1 mes";
            // 
            // TimePickerInicio
            // 
            this.TimePickerInicio.Location = new System.Drawing.Point(220, 111);
            this.TimePickerInicio.Name = "TimePickerInicio";
            this.TimePickerInicio.Size = new System.Drawing.Size(200, 20);
            this.TimePickerInicio.TabIndex = 143;
            this.TimePickerInicio.ValueChanged += new System.EventHandler(this.TimePickerInicio_ValueChanged);
            // 
            // txtCantidadUF
            // 
            this.txtCantidadUF.Location = new System.Drawing.Point(490, 178);
            this.txtCantidadUF.Name = "txtCantidadUF";
            this.txtCantidadUF.ReadOnly = true;
            this.txtCantidadUF.Size = new System.Drawing.Size(200, 20);
            this.txtCantidadUF.TabIndex = 158;
            // 
            // txtResultado
            // 
            this.txtResultado.AutoSize = true;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.txtResultado.ForeColor = System.Drawing.Color.Black;
            this.txtResultado.Location = new System.Drawing.Point(454, 159);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(72, 13);
            this.txtResultado.TabIndex = 157;
            this.txtResultado.Text = "uf mensual:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(185, 159);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 13);
            this.label17.TabIndex = 156;
            this.label17.Text = "Valor de la UF:";
            // 
            // txtUFvalue
            // 
            this.txtUFvalue.Location = new System.Drawing.Point(220, 178);
            this.txtUFvalue.Name = "txtUFvalue";
            this.txtUFvalue.ReadOnly = true;
            this.txtUFvalue.Size = new System.Drawing.Size(200, 20);
            this.txtUFvalue.TabIndex = 155;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(444, 112);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 149;
            this.dateTimePicker1.Visible = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(444, 138);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 150;
            this.dateTimePicker2.Visible = false;
            // 
            // btnEmitir
            // 
            this.btnEmitir.BackColor = System.Drawing.Color.Green;
            this.btnEmitir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEmitir.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEmitir.FlatAppearance.BorderSize = 0;
            this.btnEmitir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmitir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmitir.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnEmitir.Location = new System.Drawing.Point(490, 322);
            this.btnEmitir.Margin = new System.Windows.Forms.Padding(5);
            this.btnEmitir.Name = "btnEmitir";
            this.btnEmitir.Size = new System.Drawing.Size(101, 39);
            this.btnEmitir.TabIndex = 159;
            this.btnEmitir.Text = "Emitir";
            this.btnEmitir.UseVisualStyleBackColor = true;
            this.btnEmitir.Click += new System.EventHandler(this.btnEmitir_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(319, 322);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 39);
            this.button2.TabIndex = 160;
            this.button2.Text = "Atras";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtDescDetalle
            // 
            this.txtDescDetalle.Location = new System.Drawing.Point(220, 241);
            this.txtDescDetalle.Multiline = true;
            this.txtDescDetalle.Name = "txtDescDetalle";
            this.txtDescDetalle.Size = new System.Drawing.Size(470, 57);
            this.txtDescDetalle.TabIndex = 162;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(185, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 13);
            this.label10.TabIndex = 163;
            this.label10.Text = "Detalle de Factura :";
            // 
            // PantallaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PantallaFactura";
            this.Text = "Creacion de Facturas";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContrato)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtRubro;
        private System.Windows.Forms.TextBox txtRazon;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridCliente;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridContrato;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdContrato;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker TimePickerFin;
        private System.Windows.Forms.DateTimePicker TimePickerInicio;
        private System.Windows.Forms.TextBox txtCantidadUF;
        private System.Windows.Forms.Label txtResultado;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtUFvalue;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEmitir;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDescDetalle;
    }
}