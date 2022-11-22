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
    public partial class PantallaAdminDashboard : Form
    {
        public PantallaAdminDashboard()
        {
            InitializeComponent();
        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect(); 
        }

        private void PantallaAdminDashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void mantenedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenedorClientes mc = new MantenedorClientes();
            mc.ShowDialog();
        }

        private void mantenedorProgesionalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenedorProfesionales pmantenedorP = new MantenedorProfesionales();
            pmantenedorP.ShowDialog();
        }
    }
}
