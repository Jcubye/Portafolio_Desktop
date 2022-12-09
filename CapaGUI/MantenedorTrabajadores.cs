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
    public partial class MantenedorTrabajadores : Form
    {
        public MantenedorTrabajadores()
        {
            InitializeComponent();
        }

        private void MantenedorTrabajadores_Load(object sender, EventArgs e)
        {
            //carga combobox con lista de proyectos
            NegocioProyecto auxNeg = new NegocioProyecto();
            this.cmbProyecto.DataSource = auxNeg.consultaProyecto().Tables[0];
            this.cmbProyecto.DisplayMember = "nombre";

            this.cmbProyecto.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtCorreo.Text) || String.IsNullOrEmpty(this.txtRut.Text))
                {
                    MessageBox.Show("Rut y correo son requeridos");
                }
                else
                {
                    NegocioTrabajadores auxNeg = new NegocioTrabajadores();
                    Trabajadores auxTrabajadores = new Trabajadores
                    {
                        Rut = this.txtRut.Text,
                        Nombre = this.txtNombre.Text,
                        Apellidop = this.txtApellidoP.Text,
                        Apellidom = this.txtApellidoM.Text,
                        Correo = this.txtCorreo.Text,
                        Capacitado = this.cmbCapacitado.Text,
                        Proyecto_id = auxNeg.obtenerIdProyecto(this.cmbProyecto.Text)
                    };

                    if (String.IsNullOrEmpty(auxNeg.buscarTrabajador(auxTrabajadores.Rut).Rut))
                    {
                        auxNeg.insertarTrabajador(auxTrabajadores);
                        MessageBox.Show("Datos guardados", "Mensaje de sistema");
                        this.limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Trabajador ya existe");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos no guardados. " + ex.Message);
            }
        }

        private void limpiar()
        {
            this.txtRut.Text="";
            this.txtNombre.Text = "";
            this.txtApellidoM.Text = "";
            this.txtApellidoP.Text = "";
            this.txtCorreo.Text = "";
            this.cmbCapacitado.Text = "";
        }
    }
}
