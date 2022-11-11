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

    }
}
