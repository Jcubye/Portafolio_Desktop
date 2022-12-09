using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaGUI
{
    public partial class PantallaLogin : Form
    {
        public PantallaLogin()
        {
            InitializeComponent();
            //Inicia al centro de la pantalla @Johnna
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdministradores_Click(object sender, EventArgs e)
        {
            PantallaAdminDashboard pAdminDashboard = new PantallaAdminDashboard();
            pAdminDashboard.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProfesionales_Click(object sender, EventArgs e)
        {
            PantallaProfesionalDashboard pProfesionalDashboard = new PantallaProfesionalDashboard();
            pProfesionalDashboard.ShowDialog();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            CapaModelo.Usuario auxUser = new CapaModelo.Usuario();
            auxUser.Clave = txtClave.Text;
            auxUser.Correo = txtCorreo.Text;

            NegocioUsuario auxNeg = new NegocioUsuario();
            int val = auxNeg.authUsuario(auxUser);

            if (val == 1)
            {
                this.Hide();
                PantallaAdminDashboard pAdminDash = new PantallaAdminDashboard();
                pAdminDash.ShowDialog();
            }
            else {
                MessageBox.Show("El usuario y contraseña no coinciden. reintenlo o comuniquese con el administrador para mas info ", "Mensaje Sistema");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (txtClave.PasswordChar == '*')
                {
                    txtClave.PasswordChar = '\0';
                }
            }
            else {
                txtClave.PasswordChar = '*';
            }
        }
    }
}
