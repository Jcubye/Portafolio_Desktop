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
    public partial class MantenedorProfesionales : Form
    {
        public MantenedorProfesionales()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                if (String.IsNullOrEmpty(this.txtIdProfesional.Text))
                {
                    MessageBox.Show("Por Favor ingrese un dato valido para el ID ", "Mensaje Sistema");
                    return;
                }
                else if (String.IsNullOrEmpty(this.txtNombreProfesional.Text))
                {
                    MessageBox.Show("Por Favor ingrese un dato valido para el nombre del Profesional ", "Mensaje Sistema");
                    return;
                }
                else if (String.IsNullOrEmpty(this.txtApellidoPaterno.Text))
                {
                    MessageBox.Show("Por Favor ingrese un dato valido para el Apellido ", "Mensaje Sistema");
                    return;
                }
                else if (String.IsNullOrEmpty(this.txtApellidoMaterno.Text))
                {
                    MessageBox.Show("Por Favor ingrese un dato valido para el Apellido ", "Mensaje Sistema");
                    return;
                }

                else if (String.IsNullOrEmpty(this.txtRolProfesional.Text))
                {
                    MessageBox.Show("Por Favor ingrese un dato valido para el Rol de profesional ", "Mensaje Sistema");
                    return;
                }

                else if (String.IsNullOrEmpty(this.txtIdUsuario.Text))
                {
                    MessageBox.Show("Por Favor ingrese un dato valido para el Id del usuario ", "Mensaje Sistema");
                    return;
                }

                else if (String.IsNullOrEmpty(this.txtEstado.Text))
                {
                    MessageBox.Show("Por Favor ingrese un dato valido para el Estado ", "Mensaje Sistema");
                    return;
                }

                {

        

                    NegocioProfesional auxNprofesional = new NegocioProfesional();
                    Profesional auxProfesional = new Profesional();

                    auxProfesional.Nombre1 = this.txtNombreProfesional.Text;
                    auxProfesional.ApellidoPaterno1 = this.txtApellidoPaterno.Text;
                    auxProfesional.ApellidoMaterno1 = this.txtApellidoMaterno.Text;
                    auxProfesional.Rol1 = this.txtRolProfesional.Text;
                    auxProfesional.Estado1 = this.txtEstado.Text;

                    auxNprofesional.IngresaProfesional(auxProfesional);
                    MessageBox.Show("Datos Guardados ", "Mensaje Sistema");


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos No Guardados " + ex.Message, "Mensaje Sistema");
            }




        }
    }
}
