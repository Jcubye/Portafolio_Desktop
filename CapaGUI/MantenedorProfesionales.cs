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

                    auxProfesional.ID1 = Convert.ToInt32(this.txtIdProfesional.Text);
                    auxProfesional.Nombre1 = this.txtNombreProfesional.Text;
                    auxProfesional.ApellidoPaterno1 = this.txtApellidoPaterno.Text;
                    auxProfesional.ApellidoMaterno1 = this.txtApellidoMaterno.Text;
                    auxProfesional.Rol1 = this.txtRolProfesional.Text;
                    auxProfesional.Estado1 = this.txtEstado.Text;
                    auxProfesional.IdUsuario1 = this.txtIdUsuario.Text;


                    auxNprofesional.IngresaProfesional(auxProfesional);
                    MessageBox.Show("Datos Guardados ", "Mensaje Sistema");
                    this.limpiar();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos No Guardados " + ex.Message, "Mensaje Sistema");
            }

        }


        public void limpiar()
        {
            this.txtIdProfesional.Text = String.Empty;
            this.txtNombreProfesional.Text = String.Empty;
            this.txtApellidoPaterno.Text = String.Empty;
            this.txtApellidoMaterno.Text = String.Empty;
            this.txtRolProfesional.Text = String.Empty;
            this.txtEstado.Text = String.Empty;
            this.txtIdUsuario.Text = String.Empty;
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }

        private void MantenedorProfesionales_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'prueba_portafolioDataSet.profesional' Puede moverla o quitarla según sea necesario.
            this.profesionalTableAdapter.Fill(this.prueba_portafolioDataSet.profesional);

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiar();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ListarProfesionales plistarProfesional = new ListarProfesionales();
            plistarProfesional.ShowDialog();
        }
    }
}
