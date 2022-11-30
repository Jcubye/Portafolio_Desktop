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
                else
                {
                    dataGridView1.Columns[0].HeaderText = "Correo";
                    dataGridView1.Columns[1].HeaderText = "Clave";
                    dataGridView1.Columns[2].HeaderText = "Rut";
                    dataGridView1.Columns[3].HeaderText = "Direccion";
                    dataGridView1.Columns[4].HeaderText = "Telefono";
                    dataGridView1.Columns[5].HeaderText = "Razon social";
                    dataGridView1.Columns[6].HeaderText = "Estado";
                    //this.btnActualizar.Enabled = true;
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
    }
}
