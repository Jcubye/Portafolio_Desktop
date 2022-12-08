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
    public partial class PantallaProfesionalDashboard : Form
    {
        public PantallaProfesionalDashboard()
        {
            InitializeComponent();


            CapaNegocio.NegocioCliente auxCliente = new CapaNegocio.NegocioCliente();
            //this.dataGridView4.DataSource = auxCliente.consultaClienteActivoCamilo();
            this.dataGridView4.DataMember = "usuarios";


            dataGridView4.Columns[0].HeaderText = "c.id";
            dataGridView4.Columns[1].HeaderText = "Detalle";
            dataGridView4.Columns[2].HeaderText = "Fecha Inicio";
            dataGridView4.Columns[3].HeaderText = "Fecha Termino";
            dataGridView4.Columns[4].HeaderText = "Cliente ID";
            dataGridView4.Columns[5].HeaderText = "Razon social";
            dataGridView4.Columns[6].HeaderText = "Estado";
            dataGridView4.Columns[7].HeaderText = "Usuario id";
            dataGridView4.Columns[7].HeaderText = "Rubro id";


        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }

        private void Tabcontrol1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Tabcontrol1.SelectedIndex == 6)
            {
                if ((MessageBox.Show("¿Esta seguro de Salir?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    this.Dispose();
                    System.GC.Collect();
                }
            }
        }

        private void PantallaProfesionalDashboard_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'prueba_portafolioDataSet.fiscalizacion' Puede moverla o quitarla según sea necesario.
            this.fiscalizacionTableAdapter.Fill(this.prueba_portafolioDataSet.fiscalizacion);
            // TODO: esta línea de código carga datos en la tabla 'prueba_portafolioDataSet.solicitud' Puede moverla o quitarla según sea necesario.
            this.solicitudTableAdapter.Fill(this.prueba_portafolioDataSet.solicitud);
            // TODO: esta línea de código carga datos en la tabla 'prueba_portafolioDataSet.servicio' Puede moverla o quitarla según sea necesario.
            this.servicioTableAdapter.Fill(this.prueba_portafolioDataSet.servicio);
            // TODO: esta línea de código carga datos en la tabla 'prueba_portafolio_profesionalDataSet.profesional' Puede moverla o quitarla según sea necesario.
           // this.profesionalTableAdapter.Fill(this.prueba_portafolio_profesionalDataSet.profesional);

        }

        private void button13_Click(object sender, EventArgs e)
        {

            this.Dispose();
            System.GC.Collect();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
