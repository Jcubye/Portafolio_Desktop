using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo;
using CapaNegocio;
using System.Windows.Forms;

namespace CapaGUI
{
    public partial class ListarProfesionales : Form
    {
        public ListarProfesionales()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CapaNegocio.NegocioProfesional auxNProf = new CapaNegocio.NegocioProfesional();
            this.dataGridView1.DataSource = auxNProf.buscaProfesional();
            this.dataGridView1.DataMember = "Profesional";

            if (this.dataGridView1.Rows.Count < 1)
            {
                MessageBox.Show("No hay profesionales para mostrar");
                this.btnActualizar.Enabled = false;
            }
            else
            {
                dataGridView1.Columns[0].HeaderText = "id";
                dataGridView1.Columns[1].HeaderText = "nombre";
                dataGridView1.Columns[2].HeaderText = "Apellido Paterno";
                dataGridView1.Columns[3].HeaderText = "Apellido Materno";
                dataGridView1.Columns[4].HeaderText = "Rol profesional";
                dataGridView1.Columns[5].HeaderText = "Id Usuario";
                dataGridView1.Columns[6].HeaderText = "Estado";
                this.btnActualizar.Enabled = true;
            }
        }

        private void ListarProfesionales_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'prueba_portafolioDataSet.profesional' Puede moverla o quitarla según sea necesario.
            this.profesionalTableAdapter.Fill(this.prueba_portafolioDataSet.profesional);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos Actualizados");
        }
    }
}
