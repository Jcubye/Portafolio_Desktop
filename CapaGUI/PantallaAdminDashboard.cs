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
        }

        private void salirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect(); 
        }

        private void PantallaAdminDashboard_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'prueba_portafolioDataSet1.profesional' Puede moverla o quitarla según sea necesario.
            // descomentar al entregar this.profesionalTableAdapter1.Fill(this.prueba_portafolioDataSet1.profesional);


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
            if (tabControl1.SelectedIndex == 8)
            {
                if ((MessageBox.Show("¿Esta seguro de Salir?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    this.Dispose();
                    System.GC.Collect();
                }   
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            PantallaContrato mc = new PantallaContrato();
            mc.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            MantenedorProfesional mp = new MantenedorProfesional();
            mp.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.CurrentRow;
            if (e.ColumnIndex == 1)
            {
                if((String)row.Cells[9].Value == "Activo")
                {
                    String rut = (String)row.Cells[5].Value;
                    NegocioCliente nc = new NegocioCliente();
                    nc.suspenderCliente(rut);
                    MessageBox.Show("Cliente suspendido");
                    btnRefresh.PerformClick();
                }
                else
                {
                    MessageBox.Show("Cliente ya se encuentra suspendido");
                }
            }
            if (e.ColumnIndex == 0)
            {
                //MessageBox.Show("Modificar");
                ActualizarCliente ac = new ActualizarCliente();

                ac.txtCorreoAC.Text = (String)row.Cells[3].Value;
                ac.txtClaveAC.Text = (String)row.Cells[4].Value;
                ac.txtRutAC.Text = (String)row.Cells[5].Value;
                ac.txtDireccionAC.Text = (String)row.Cells[6].Value;
                ac.txtTelefonoAC.Text = Convert.ToString((int)row.Cells[7].Value);
                ac.txtRSocialAC.Text = (String)row.Cells[8].Value;
                ac.txtEstadoAC.Text = (String)row.Cells[9].Value;

                ac.Show();
            }
            if (e.ColumnIndex == 2)
            {
                if ((String)row.Cells[9].Value == "Suspendido")
                {
                    String rut = (String)row.Cells[5].Value;
                    NegocioCliente nc = new NegocioCliente();
                    nc.activarCliente(rut);
                    MessageBox.Show("Cliente activo");
                    btnRefresh.PerformClick();
                }
                else
                {
                    MessageBox.Show("Cliente ya se encuentra activo");
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            CapaNegocio.NegocioCliente auxNeg = new CapaNegocio.NegocioCliente();
            this.dataGridView1.DataSource = auxNeg.consultaCliente();
            this.dataGridView1.DataMember = "usuarios";
        }
    }
}
