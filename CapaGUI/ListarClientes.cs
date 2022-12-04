using CapaModelo;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaGUI
{
    public partial class ListarClientes : Form
    {
        public ListarClientes()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            CapaNegocio.NegocioCliente auxNeg = new CapaNegocio.NegocioCliente();
            this.dataGridView1.DataSource = auxNeg.consultaCliente();
            this.dataGridView1.DataMember = "usuarios";

            if (this.dataGridView1.Rows.Count < 1)
            {
                MessageBox.Show("No hay clientes a listar","Ups!");
                this.btnActualizar.Enabled = false;
            }
            else
            {
                dataGridView1.Columns[0].HeaderText = "Correo";
                dataGridView1.Columns[1].HeaderText = "Clave";
                dataGridView1.Columns[2].HeaderText = "Rut";
                dataGridView1.Columns[3].HeaderText = "Direccion";
                dataGridView1.Columns[4].HeaderText = "Telefono";
                dataGridView1.Columns[5].HeaderText = "Razon social";
                dataGridView1.Columns[6].HeaderText = "Estado";
                this.btnActualizar.Enabled = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //rut no se puede editar
            this.dataGridView1.Columns["rut"].Visible = false;

            //cargar combobox en datagridview para estados
            //string[] estados = new string[] { "Activo", "Inactivo", "Suspendido" };
            //DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            //cmb.DataSource = estados;
            //this.dataGridView1.Columns.Add(cmb); //agrega una nueva columna, se debe reemplazar el textbox por combobox (preguntar a profe)

            try
            {
                if (this.btnActualizar.Text.Equals("Confirmar"))
                {
                    Cliente auxCliente = new Cliente();
                    NegocioCliente auxNegocio = new NegocioCliente();
                    

                    if ((MessageBox.Show("Esta seguro de actualizar?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        
                        DataGridViewRow row = this.dataGridView1.CurrentRow;
                        
                        auxCliente.Correo = (String)row.Cells[0].Value;
                        auxCliente.Clave = (String)row.Cells[1].Value;
                        auxCliente.Rut = (String)row.Cells[2].Value;
                        auxCliente.Direccion = (String)row.Cells[3].Value;
                        auxCliente.Telefono = (int)row.Cells[4].Value;
                        auxCliente.RazonSocial = (String)row.Cells[5].Value;
                        auxCliente.Estado = (String)row.Cells[6].Value;

                        auxNegocio.actualizarCliente(auxCliente);

                        MessageBox.Show("Cliente actualizado ", "Sistema");
                        this.dataGridView1.Columns["rut"].Visible = true;
                        this.dataGridView1.ReadOnly = true;
                        this.btnActualizar.Text = "Actualizar";
                        this.btnSalir.Text = "Salir";
                        this.btnListar.Enabled = true;
                    }
                    else
                    {
                        this.btnSalir_Click(sender, e);//arreglar evento de cancelar
                    }
                    this.btnActualizar.Text = "Actualizar";
                    this.btnSalir.Text = "Salir";
                }
                else
                {
                    this.dataGridView1.ReadOnly = false;
                    this.btnActualizar.Text = "Confirmar";
                    this.btnSalir.Text = "Cancelar";
                    this.btnListar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar. " + ex.Message, "Sistema");
            }
        }

        private void ListarClientes_Load(object sender, EventArgs e)
        {
            this.btnActualizar.Enabled = false;
            
        }
    }
}
