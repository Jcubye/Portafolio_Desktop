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
    public partial class ProfesionalesDataView : Form
    {
        public ProfesionalesDataView()
        {
            InitializeComponent();
        }

        private void ProfesionalesDataView_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'prueba_portafolio_profesionalDataSet.profesional' Puede moverla o quitarla según sea necesario.
            this.profesionalTableAdapter.Fill(this.prueba_portafolio_profesionalDataSet.profesional);

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == 0)
                {
                    int j = 5;
                    //String dato = this.dataGridView1[4, e.RowIndex].Value.ToString();
                    //Console.WriteLine(" es " + dato);
                    for (int i = 0; i < j; i++){
                        Console.WriteLine(" el i " + i);
                        String dato = this.dataGridView1[i, e.RowIndex].Value.ToString();
                        Console.WriteLine(" es " + dato);
                        if (i == 0) { Console.WriteLine("Dato culiao del id papito " + dato);};
                    }

                    //else if (i == 1) { txtContra.Text = dato; }
                    //else if (i == 2) { txtRut.Text = dato; }
                    //else if (i == 3) { txtDireccion.Text = dato; }
                    //else if (i == 4) { txtTelefono.Text = dato; }
                    //else if (i == 6) { txtName.Text = dato; }
                    //else if (i == 7) { txtApeP.Text = dato; }
                    //else if (i == 8) { txtApeM.Text = dato; }
                    //else if (i == 9)
                    //{

                    //    Console.WriteLine(" comuna " + this.comboBox1.SelectedIndex.ToString());
                    //    NegocioRegionComuna auxNeg = new NegocioRegionComuna();
                    //    List<String> lista = auxNeg.consultaComuna_region_by_id(Convert.ToInt32(dato));
                    //    comboBox2.SelectedIndex = comboBox2.FindStringExact(lista[0]);
                    //    comboBox1.SelectedIndex = comboBox1.FindStringExact(lista[1]);

                    //}
                    //else if (i == 10) { Id_user = Convert.ToInt32(dato); }
                    //else if (i == 11) { Id_admin = Convert.ToInt32(dato); }
                    //}

                }
                else if (e.ColumnIndex == 1)
                {
                    String Nombre = this.dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
                    Console.WriteLine(" es " + Nombre);

                }
            }
        }
    }
}
