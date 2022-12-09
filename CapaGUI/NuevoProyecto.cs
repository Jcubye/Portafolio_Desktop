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
    public partial class NuevoProyecto : Form
    {
        public NuevoProyecto()
        {
            InitializeComponent();
        }

        private void NuevoProyecto_Load(object sender, EventArgs e)
        {
            //carga combobox con lista de rubros
            NegocioRubro auxNegR = new NegocioRubro();
            this.cmbRubro.DataSource = auxNegR.consultaRubro().Tables[0];
            this.cmbRubro.DisplayMember = "nombre";

            this.cmbRubro.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cmbRubro_SelectedIndexChanged(object sender, EventArgs e)
        {
            NegocioRubro auxNegR = new NegocioRubro();
            this.txtDescRubro.Text = auxNegR.ObtenerDescRubro(this.cmbRubro.Text);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtNombreP.Text) || String.IsNullOrEmpty(this.txtDescP.Text))
                {
                    MessageBox.Show("Nombre y descripcion de proyecto son requeridos");
                }
                else
                {
                    //obtener id rubro e id cliente
                    NegocioRubro auxNegR = new NegocioRubro();
                    int id_r;
                    id_r = auxNegR.ObtenerIdRubro(this.cmbRubro.Text);

                    NegocioCliente auxNegC = new NegocioCliente();
                    int id_c;
                    id_c = auxNegC.obtnerIdCliente(this.txtRespaldoIdcliente.Text);

                    NegocioProyecto auxNeg = new NegocioProyecto();
                    Proyecto auxProy = new Proyecto {
                        Nombre = this.txtNombreP.Text,
                        Descripcion = this.txtDescP.Text,
                        Rubro_id = id_r,
                        Cliente_id = id_c
                    };

                    auxNeg.insertarProyecto(auxProy);
                    MessageBox.Show("Proyecto añadido", "Mensaje de sistema");
                    this.limpiar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos no guardados. " + ex.Message);
            }
        }

        private void limpiar()
        {
            this.txtNombreP.Text = "";
            this.txtDescP.Text = "";
        }
    }
}
