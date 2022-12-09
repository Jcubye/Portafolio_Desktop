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
    public partial class PantallaAdminDashboard : Form
    {
        public PantallaAdminDashboard()
        {
            InitializeComponent();

            CapaNegocio.NegocioCliente auxNeg = new CapaNegocio.NegocioCliente();
            this.dataGridView1.DataSource = auxNeg.consultaCliente();
            this.dataGridView1.DataMember = "usuarios";

            dataGridView1.Columns[0].HeaderText = "Correo";
            dataGridView1.Columns[1].HeaderText = "Clave";
            dataGridView1.Columns[2].HeaderText = "Rut";
            dataGridView1.Columns[3].HeaderText = "Direccion";
            dataGridView1.Columns[4].HeaderText = "Telefono";
            dataGridView1.Columns[5].HeaderText = "Razon social";
            dataGridView1.Columns[6].HeaderText = "Estado";

            dataGridView1.Columns.Add(new DataGridViewButtonColumn() { HeaderText = "", Text = "Modificar", UseColumnTextForButtonValue = true });
            dataGridView1.Columns.Add(new DataGridViewButtonColumn() { HeaderText = "Acciones", Text = "Suspender", UseColumnTextForButtonValue = true });
            dataGridView1.Columns.Add(new DataGridViewButtonColumn() { HeaderText = "", Text = "Activar", UseColumnTextForButtonValue = true });

            

            CapaNegocio.NegocioContrato auxContrato = new CapaNegocio.NegocioContrato();
            this.dataGridContratos.DataSource = auxContrato.consultaContrato();
            this.dataGridContratos.DataMember = "contrato";


            dataGridContratos.Columns[0].HeaderText = "id";
            dataGridContratos.Columns[1].HeaderText = "Detalle";
            dataGridContratos.Columns[2].HeaderText = "Fecha Inicio";
            dataGridContratos.Columns[3].HeaderText = "Fecha Termino";
            dataGridContratos.Columns[4].HeaderText = "Cliente ID";
            dataGridContratos.Columns[5].HeaderText = "Razon social";
            dataGridContratos.Columns[6].HeaderText = "Estado";
            dataGridContratos.Columns[7].HeaderText = "Usuario id";
            dataGridContratos.Columns[8].HeaderText = "Rubro id";
            dataGridContratos.Columns[0].Visible = false;
            dataGridContratos.Columns[4].Visible = false;
            dataGridContratos.Columns[7].Visible = false;
            dataGridContratos.Columns[8].Visible = false;

            dataGridContratos.Columns.Add(new DataGridViewButtonColumn() { HeaderText = "Acciones", Text = "Suspender", UseColumnTextForButtonValue = true });
            dataGridContratos.Columns.Add(new DataGridViewButtonColumn() { HeaderText = "", Text = "Activar", UseColumnTextForButtonValue = true });

            NegocioReporteria negRep = new NegocioReporteria();
            this.dataGridFacturas.DataSource = negRep.consultaFacturas();
            this.dataGridFacturas.DataMember = "detalle_factura";
            dataGridFacturas.Columns[0].HeaderText = "Razon Social";
            dataGridFacturas.Columns[1].HeaderText = "Estado";
            dataGridFacturas.Columns[2].HeaderText = "Monto a pagar";
            dataGridFacturas.Columns[3].HeaderText = "Fecha emision";
            dataGridFacturas.Columns[4].HeaderText = "Fecha vencimiento";
            dataGridFacturas.Columns[5].HeaderText = "Descripcion";
            dataGridFacturas.Columns[6].HeaderText = "Monto pagado";
        }

        private void salirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect(); 
        }

        private void PantallaAdminDashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MantenedorClientes mc = new MantenedorClientes();
            mc.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedIndex == 1) {
                CapaNegocio.NegocioCliente auxNeg = new CapaNegocio.NegocioCliente();
                this.dataGridView1.DataSource = auxNeg.consultaCliente();
                this.dataGridView1.DataMember = "usuarios";

                if (this.dataGridView1.Rows.Count < 1)
                {
                    MessageBox.Show("No hay clientes a listar", "Ups!");
                    //this.btnActualizar.Enabled = false;
                }
               
            }
            if (tabControl1.SelectedIndex == 3)
            {
                CapaNegocio.NegocioContrato auxContrato = new CapaNegocio.NegocioContrato();
                this.dataGridContratos.DataSource = auxContrato.consultaContrato();
                this.dataGridContratos.DataMember = "contrato";

                if (this.dataGridContratos.Rows.Count < 1)
                {
                    MessageBox.Show("No hay contratos a listar", "Ups!");
                    //this.btnActualizar.Enabled = false;
                }
                
            }

            if (tabControl1.SelectedIndex == 5)
            {
                NegocioReporteria negRep = new NegocioReporteria();
                this.dataGridFacturas.DataSource = negRep.consultaFacturas();
                this.dataGridFacturas.DataMember = "detalle_factura";

                if (this.dataGridFacturas.Rows.Count < 1)
                {
                    MessageBox.Show("No hay contratos a listar", "Ups!");
                    //this.btnActualizar.Enabled = false;
                }

            }

            if (tabControl1.SelectedIndex == 8)
            {
                if ((MessageBox.Show("¿Esta seguro de Salir?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    this.Dispose();
                    System.GC.Collect();
                }   
            }
            if (tabControl1.SelectedIndex == 9)
            {
                MantenedorAdministradores ma = new MantenedorAdministradores();
                ma.ShowDialog();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            PantallaContrato mc = new PantallaContrato();
            mc.ShowDialog();
        }

        private void btnDeudores_Click(object sender, EventArgs e)
        {
            NegocioReporteria negRep = new NegocioReporteria();
            DataSet mydata = negRep.consultaFacturasPendientes();
            negRep.GenerarReporte(mydata,"DEUDORES");
        }

        private void btnReportClient_Click(object sender, EventArgs e)
        {
            CapaNegocio.NegocioCliente auxNeg = new CapaNegocio.NegocioCliente();
            DataSet mydata = auxNeg.consultaCliente();

            NegocioReporteria negRep = new NegocioReporteria();
            negRep.GenerarReporte(mydata,"CLIENTES");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CapaNegocio.NegocioCliente auxNeg = new CapaNegocio.NegocioCliente();
            DataSet mydata = auxNeg.consultaCliente();

            NegocioReporteria negRep = new NegocioReporteria();
            negRep.GenerarReporte(mydata, "CLIENTES ACTIVOS");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CapaNegocio.NegocioRubro auxNeg = new CapaNegocio.NegocioRubro();
            DataSet mydata = auxNeg.consultaRubro();

            NegocioReporteria negRep = new NegocioReporteria();
            negRep.GenerarReporte(mydata, "RUBROS");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            PantallaFactura ma = new PantallaFactura();
            ma.ShowDialog();
        }
    }
}
