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
    public partial class PantallaFactura : Form
    {
        public static double ValorUF { get; set; } = 0;
        public static double CantidadUF { get; set; } = 0;

        public PantallaFactura()
        {
            InitializeComponent();
   
            CapaNegocio.NegocioCliente auxNeg = new CapaNegocio.NegocioCliente();
            this.dataGridCliente.DataSource = auxNeg.consultaClienteActivo();
            this.dataGridCliente.DataMember = "usuarios";

            // Grid Contrato
            CapaNegocio.NegocioContrato auxCon = new CapaNegocio.NegocioContrato();
            this.dataGridContrato.DataSource = auxCon.consultaContratoFiltrado(0);
            this.dataGridContrato.DataMember = "contrato";

            dataGridContrato.Columns[0].Visible = false;

            if (this.dataGridCliente.Rows.Count < 1)
            {
                MessageBox.Show("No hay clientes a listar", "Ups!");
                //this.btnActualizar.Enabled = false;
            }
            else
            {
                // Grid Cliente
                dataGridCliente.Columns[2].HeaderText = "Rut";
                int j = dataGridCliente.Columns.Count;
                for (int i = 0; i < j; i++)
                {
                    dataGridCliente.Columns[i].Visible = false;
                }
                dataGridCliente.Columns[2].Visible = true;

            }
            this.TimePickerFin.Enabled = false;

            NegocioMindicador auxMin = new NegocioMindicador();
            ValorUF = auxMin.consultaMindicador();
            txtUFvalue.Text = "$ " + ValorUF;
        }

        private void txtRut_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void dataGridCliente_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridCliente_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == 2)
                {
                    txtRazon.Text = this.dataGridCliente[5, e.RowIndex].Value.ToString();
                    txtRubro.Text = this.dataGridCliente[7, e.RowIndex].Value.ToString();
                    txtDesc.Text = this.dataGridCliente[8, e.RowIndex].Value.ToString();
                    txtRut.Text = this.dataGridCliente[2, e.RowIndex].Value.ToString();
                    txtClientID.Text = this.dataGridCliente[9, e.RowIndex].Value.ToString();
                    CapaNegocio.NegocioContrato auxCon = new CapaNegocio.NegocioContrato();
                    this.dataGridContrato.DataSource = auxCon.consultaContratoFiltrado(Convert.ToInt32(txtClientID.Text));
                    this.dataGridContrato.DataMember = "contrato";
                }
                else if (e.ColumnIndex == 1)
                {
                    String Nombre = this.dataGridCliente[e.ColumnIndex, e.RowIndex].Value.ToString();
                    Console.WriteLine(" es " + Nombre);

                }
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = this.tabPage2;
        }

        private void dataGridContrato_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == 1)
                {
                    txtIdContrato.Text = this.dataGridContrato[0, e.RowIndex].Value.ToString();
                    dateTimePicker1.Value = DateTime.Parse(this.dataGridContrato[2, e.RowIndex].Value.ToString());
                    dateTimePicker2.Value = DateTime.Parse(this.dataGridContrato[3, e.RowIndex].Value.ToString());
                    calculate_string();
                }
                else if (e.ColumnIndex == 1)
                {
                    String Nombre = this.dataGridContrato[e.ColumnIndex, e.RowIndex].Value.ToString();
                    Console.WriteLine(" es " + Nombre);
                }
            }
        }

        private void TimePickerInicio_ValueChanged(object sender, EventArgs e)
        {
            this.TimePickerFin.Value = this.TimePickerInicio.Value.AddDays(10);
        }

        public void calculate_string()
        {

            TimeSpan difFechas = dateTimePicker2.Value - dateTimePicker1.Value;
            double meses = (difFechas.Days / 30);

            int producto = 6;
            
            int uf_mes = 10;

            if (meses <= 1)
            {
                double result_calculo = (ValorUF * (uf_mes + producto));
                txtResultado.Text = meses + " Mes de servicio por " + (uf_mes + producto) + " UF.";
                txtCantidadUF.Text = (uf_mes + producto) + " UF = $" + result_calculo;
                CantidadUF = (uf_mes + producto);
            }
            else if (meses > 1 && meses < 6)
            {
                double result_calculo = (ValorUF * (uf_mes + producto));
                txtResultado.Text = meses + " Meses de servicio por " + (uf_mes + producto) + " UF mensuales.";
                txtCantidadUF.Text = (uf_mes + producto) + " UF = $" + result_calculo;
                CantidadUF = (uf_mes + producto);
            }

            else if (meses > 5 && meses < 12)
            {
                uf_mes = 6;
                double result_calculo = (ValorUF * (uf_mes + producto));
                txtResultado.Text = meses + " Meses de servicio por " + (uf_mes + producto) + " UF mensuales.";
                txtCantidadUF.Text = (uf_mes + producto) + " UF = $" + result_calculo;
                CantidadUF = (uf_mes + producto);
            }

            else if (meses > 11)
            {
                uf_mes = 4;
                double result_calculo = (ValorUF * (uf_mes + producto));
                txtResultado.Text = meses + " Meses de servicio por " + (uf_mes + producto) + " UF mensuales.";
                txtCantidadUF.Text = (uf_mes + producto) + " UF = $" + result_calculo;
                CantidadUF = (uf_mes + producto);
            }
            else
            {
                MessageBox.Show("Error al realizar al calculo, meses indicados no son validos.", "Mensaje de Sistema");
                //txtResultado.Text = difFechas.Days / 30 + " Meses de servicio por " + result_calculo * producto;
            }

        }

        private void btnEmitir_Click(object sender, EventArgs e)
        {
            Factura auxFact = new Factura();
            auxFact.Fecha_emision = TimePickerInicio.Value.ToString("yyyy/MM/dd");
            auxFact.Fecha_vencimiento = TimePickerFin.Value.ToString("yyyy/MM/dd");

            NegocioFactura auxNeg = new NegocioFactura();
            auxFact.ID_factura_pago = auxNeg.insertarFactura(auxFact);
            auxFact.Desc_detalle = txtDescDetalle.Text;
            auxFact.Monto_total_detalle = Convert.ToInt32(CantidadUF);
            auxFact.Id_contrato = Convert.ToInt32(txtIdContrato.Text);
            auxNeg.insertarFacturaDetalle(auxFact);
            MessageBox.Show("Factura emitida correctamente", "Mensaje de Sistema");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = this.tabPage1;
        }
    }
}
