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
    public partial class ActualizarCliente : Form
    {
        public ActualizarCliente()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente auxCliente = new Cliente();
                NegocioCliente auxNegocio = new NegocioCliente();

                auxCliente.Correo = this.txtCorreoAC.Text;
                auxCliente.Clave = this.txtClaveAC.Text;
                auxCliente.Rut = this.txtRutAC.Text;
                auxCliente.Direccion = this.txtDireccionAC.Text;
                auxCliente.Telefono = Convert.ToInt32(this.txtTelefonoAC.Text);
                auxCliente.RazonSocial = this.txtRSocialAC.Text;
                auxCliente.Estado = this.txtEstadoAC.Text;

                auxNegocio.actualizarCliente(auxCliente);

                MessageBox.Show("Cliente actualizado con éxito. Recuerde hacer clic en 'Refrescar' para ver los cambios", "Sistema");
                this.Dispose();
                System.GC.Collect();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al actualizar. " + ex.Message, "Sistema");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }
    }
}
