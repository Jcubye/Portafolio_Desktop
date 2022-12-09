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
    public partial class ListarProyectos : Form
    {
        public ListarProyectos()
        {
            InitializeComponent();
        }

        private void ListarProyectos_Load(object sender, EventArgs e)
        {
            NegocioProyecto auxNegocio = new NegocioProyecto();
            this.cmbProyecto.DataSource = auxNegocio.consultaProyecto().Tables[0];
            this.cmbProyecto.DisplayMember = "nombre";
            this.cmbProyecto.DropDownStyle = ComboBoxStyle.DropDownList;

            this.txtDescProyecto.Text = auxNegocio.obtenerDescProyecto(this.cmbProyecto.Text);

            NegocioTrabajadores auxNeg = new NegocioTrabajadores();
            this.gridViewTrabajadores.DataSource = auxNeg.consultaTrabajadores(this.cmbProyecto.Text);
            this.gridViewTrabajadores.DataMember = "Trabajadores";
            this.gridViewTrabajadores.Columns[0].HeaderText = "Nombre";
            this.gridViewTrabajadores.Columns[1].HeaderText = "Apellido paterno";
            this.gridViewTrabajadores.Columns[2].HeaderText = "Apellido materno";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }
    }
}
