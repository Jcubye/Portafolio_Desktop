using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System;
using Newtonsoft.Json;
using CapaNegocio;

namespace CapaGUI
{
    public partial class PantallaContrato : Form
    {
        public static double ValorUF { get; set; } = 0;

        public PantallaContrato()
        {
            InitializeComponent();
            CapaNegocio.NegocioCliente auxNeg = new CapaNegocio.NegocioCliente();
            this.dataGridCliente.DataSource = auxNeg.consultaClienteActivo();
            this.dataGridCliente.DataMember = "usuarios";
            //restriccion de fecha

            CapaNegocio.NegocioProfesional auxProf = new CapaNegocio.NegocioProfesional();
            this.dataGridProf.DataSource = auxProf.consultaProfesionalActivo();
            this.dataGridProf.DataMember = "usuarios";
            //dataGridProf

            this.TimePickerFin.MinDate = this.TimePickerInicio.Value.AddMonths(1);//DateTime.Now.AddMonths(1);

            if (this.dataGridCliente.Rows.Count < 1)
            {
                MessageBox.Show("No hay clientes a listar", "Ups!");
                //this.btnActualizar.Enabled = false;
            }
            else if (this.dataGridProf.Rows.Count < 1) {
                MessageBox.Show("No hay Profesionales activos para seleccionar", "Error");
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

                // Grid Profesional
                dataGridProf.Columns[10].HeaderText = "Rut";
                int k = dataGridProf.Columns.Count;
                for (int i = 0; i < k; i++)
                {
                    dataGridProf.Columns[i].Visible = false;
                }
                dataGridProf.Columns[10].Visible = true;

            }

            try
            {
                string sURL;
                sURL = "https://mindicador.cl/api/uf/" + DateTime.Today.ToString("MM-dd-yyyy");//30-11-2022";
                //Console.WriteLine(sURL);
                WebRequest wrGETURL;
                wrGETURL = WebRequest.Create(sURL);
                WebProxy myProxy = new WebProxy("myproxy", 80);
                myProxy.BypassProxyOnLocal = true;
                wrGETURL.Proxy = WebProxy.GetDefaultProxy();
                Stream objStream;
                objStream = wrGETURL.GetResponse().GetResponseStream();
                StreamReader objReader = new StreamReader(objStream);
                string sLine = "";
                sLine = objReader.ReadLine();
                //Console.WriteLine(sLine);
                dynamic jsonObj = JsonConvert.DeserializeObject(sLine);
                //Console.WriteLine(jsonObj);
                var numero = jsonObj["serie"][0]["valor"];
                ValorUF = numero;
                
                // Obtengo el directorio actual
                string path = Directory.GetCurrentDirectory();
                // Creo el fichero uf.txt y guardo mi variable
                using (StreamWriter outputFile = new StreamWriter(path + "\\uf.txt")) {
                    outputFile.WriteLine(ValorUF);
                }
            }
            catch (Exception error)
            {
                string path = Directory.GetCurrentDirectory();
                foreach (string line in System.IO.File.ReadLines(path + "\\uf.txt"))
                {
                    // System.Console.WriteLine(line + " kkk");
                    ValorUF = Convert.ToDouble(line);
                }
                MessageBox.Show("Error en la respuesta de la api mindicador, procediendo con el ultimo valor UF guardado " + ValorUF , "Mensaje Sistema");
                Console.WriteLine(error);
     
            }
            radioButton1.Checked = true;
            txtUFvalue.Text = "$ " + ValorUF;
            //TimeSpan difFechas = TimePickerFin.Value - TimePickerInicio.Value;
            //double result_calculo = ((difFechas.Days / 30) * ValorUF);
            //int producto;
            //if (radioButton1.Checked)
            //{
            //    producto = 5;
            //}
            //else
            //{
            //    producto = 6;
            //}
            //if (difFechas.Days / 30 <= 1)
            //{
            //    txtResultado.Text = difFechas.Days / 30 + " Mes de servicio por " + result_calculo * producto;
            //}
            //else
            //{
            //    txtResultado.Text = difFechas.Days / 30 + " Meses de servicio por " + result_calculo * producto;
            //}
            calculate_string();
        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = this.tabPage2;
        }

        private void dataGridCliente_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
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
                }
                else if (e.ColumnIndex == 1)
                {
                    String Nombre = this.dataGridCliente[e.ColumnIndex, e.RowIndex].Value.ToString();
                    Console.WriteLine(" es " + Nombre);

                }
            }
        }


        private void txtRut_KeyDown(object sender, KeyEventArgs e)
        {
            string text = txtRut.Text;
            CapaNegocio.NegocioCliente auxNeg = new CapaNegocio.NegocioCliente();
            this.dataGridCliente.DataSource = auxNeg.consultaClienteActivoFiltered(text);
            this.dataGridCliente.DataMember = "usuarios";

            txtRazon.Text = "";
            txtRubro.Text = "";
            txtDesc.Text = "";
        }

        private void TimePickerInicio_ValueChanged(object sender, EventArgs e)
        {
            this.TimePickerFin.MinDate = this.TimePickerInicio.Value.AddMonths(1);//DateTime.Now.AddMonths(1);
            //TimeSpan difFechas = TimePickerFin.Value - TimePickerInicio.Value;
            //double result_calculo = ((difFechas.Days / 30) * ValorUF);
            //int producto;
            //if (radioButton1.Checked)
            //{
            //    producto = 5;
            //}
            //else
            //{
            //    producto = 6;
            //}
            //if (difFechas.Days / 30 <= 1)
            //{
            //    txtResultado.Text = difFechas.Days / 30 + " Mes de servicio por " + result_calculo * producto;
            //}
            //else
            //{
            //    txtResultado.Text = difFechas.Days / 30 + " Meses de servicio por " + result_calculo * producto;
            //}
            calculate_string();
            //txtResultado.Text = "" + ((difFechas.Days / 30) * ValorUF);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = this.tabPage1;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = this.tabPage3;
            //Console.WriteLine(ValorUF);
            //Console.WriteLine();


        }

        private void dataGridProf_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == 10)
                {
                    txtIdProf.Text = this.dataGridProf[0, e.RowIndex].Value.ToString();
                    txtRutProf.Text = this.dataGridProf[10, e.RowIndex].Value.ToString();
                    txtNameProf.Text = this.dataGridProf[1, e.RowIndex].Value.ToString() + " " + this.dataGridProf[2, e.RowIndex].Value.ToString() + " " + this.dataGridProf[3, e.RowIndex].Value.ToString();
                    txtRol.Text = this.dataGridProf[4, e.RowIndex].Value.ToString();
     

                    NegocioRegionComuna auxNeg = new NegocioRegionComuna();
                    List<String> lista = auxNeg.consultaComuna_region_by_id(Convert.ToInt32(this.dataGridProf[15, e.RowIndex].Value.ToString()));
                    txtRegion.Text = lista[0];
                    txtComuna.Text = lista[1];
                    //comboBox2.SelectedIndex = comboBox2.FindStringExact(lista[0]);
                    //comboBox1.SelectedIndex = comboBox1.FindStringExact(lista[1]);
                }
                else if (e.ColumnIndex == 1)
                {
                    String Nombre = this.dataGridProf[e.ColumnIndex, e.RowIndex].Value.ToString();
                    Console.WriteLine(" es " + Nombre);

                }
            }
        }

        private void txtRutProf_KeyDown(object sender, KeyEventArgs e)
        {
            string text = txtRutProf.Text;
            CapaNegocio.NegocioProfesional auxProf = new CapaNegocio.NegocioProfesional();
            this.dataGridProf.DataSource = auxProf.consultaProfesionalActivoFiltered(text);
            this.dataGridProf.DataMember = "usuarios";

            txtNameProf.Text = "";
            txtRol.Text = "";
            txtRegion.Text = "";
            txtComuna.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //TimePickerFin.Value.ToString("yyyy/MM/dd");

            //Console.WriteLine(" es " + TimePickerInicio.Value.ToString("yyyy/MM/dd"));
            //Console.WriteLine(" es " + TimePickerFin.Value.ToString("yyyy/MM/dd"));
            //Console.WriteLine(" es " + txtClientID.Text);
            //this.dataGridCliente[9, e.RowIndex].Value.ToString();
            CapaModelo.Contrato auxCont = new CapaModelo.Contrato();
            auxCont.Detalle = this.txtContDesc.Text;
            auxCont.Fecha_inicio = TimePickerInicio.Value.ToString("yyyy/MM/dd");
            auxCont.Fecha_termino = TimePickerFin.Value.ToString("yyyy/MM/dd");
            auxCont.Client_id = Convert.ToInt32(txtClientID.Text);
            NegocioContrato auxNegCont = new NegocioContrato();
            int id_contrato = auxNegCont.insertarContrato(auxCont);

            CapaModelo.Servicio auxServ = new CapaModelo.Servicio();
            if (radioButton1.Checked)
            {
                //Aqui asigno el valor de la descripcion del servicio, basico con valor de 5 uf
                auxServ.Descripcion = "Servicio basico con valor de 5 uf";
            }
            else {
                //Aqui asigno el valor de la descripcion del servicio, 24/7 con valor de 7 uf
                auxServ.Descripcion = "Servicio basico con atencion a llamadas 24/7 valor de 7 uf";
            }
            auxServ.Estado = "Activo";
            auxServ.Id_profesional = Convert.ToInt32(txtIdProf.Text);
            auxServ.Id_contrato = id_contrato;

            NegocioServicio auxNegServ = new NegocioServicio();

            int id_servicio = auxNegServ.insertarServicio(auxServ);

            Console.WriteLine(" id contrato es " + id_contrato);
            Console.WriteLine(" id servicio es " + id_servicio);
            MessageBox.Show("Contrato y servicio ingresado correctamente", "Mensaje de Sistema");
            //insertarContrato
        }

        private void TimePickerFin_ValueChanged(object sender, EventArgs e)
        {
            //txtResultado.Text = "" + Math.Abs((TimePickerFin.Value.Month - TimePickerInicio.Value.Month) + 12 * (TimePickerFin.Value.Year - TimePickerInicio.Value.Year));
            //TimeSpan difFechas = TimePickerFin.Value - TimePickerInicio.Value;
            //double result_calculo = ((difFechas.Days / 30) * ValorUF);
            //int producto;
            //if (radioButton1.Checked)
            //{
            //    producto = 5;
            //}
            //else {
            //    producto = 6;
            //}
            //if (difFechas.Days / 30 <= 1)
            //{
            //    txtResultado.Text = difFechas.Days / 30 + " Mes de servicio por " + result_calculo * producto;
            //}
            //else
            //{
            //    txtResultado.Text = difFechas.Days / 30 + " Meses de servicio por " + result_calculo * producto;
            //}
            calculate_string();
        }

        public void calculate_string() {

            TimeSpan difFechas = TimePickerFin.Value - TimePickerInicio.Value;
            double meses = (difFechas.Days / 30);
            
            int producto;
            if (radioButton1.Checked)
            {
                producto = 5;
            }
            else
            {
                producto = 7;
            }
            int uf_mes = 10;
            
            if (meses <= 1)
            {
                double result_calculo = (ValorUF * (uf_mes + producto));
                txtResultado.Text = meses + " Mes de servicio por " + (uf_mes + producto) + " UF.";
                txtCantidadUF.Text = (uf_mes + producto) + " UF = $" + result_calculo;
            }
            else if (meses > 1 && meses < 6)
            {
                double result_calculo = (ValorUF * (uf_mes + producto));
                txtResultado.Text = meses + " Meses de servicio por " + (uf_mes + producto) + " UF mensuales.";
                txtCantidadUF.Text = (uf_mes + producto) + " UF = $" + result_calculo;
            }

            else if (meses > 5 && meses < 12) {
                uf_mes = 6;
                double result_calculo = (ValorUF * (uf_mes + producto));
                txtResultado.Text = meses + " Meses de servicio por " + (uf_mes + producto) + " UF mensuales.";
                txtCantidadUF.Text = (uf_mes + producto) + " UF = $" + result_calculo;
            }

            else if (meses > 11)
            {
                uf_mes = 4;
                double result_calculo = (ValorUF * (uf_mes + producto));
                txtResultado.Text = meses + " Meses de servicio por " + (uf_mes + producto) + " UF mensuales.";
                txtCantidadUF.Text = (uf_mes + producto) + " UF = $" + result_calculo;
            }
            else
            {
                MessageBox.Show("Error al realizar al calculo, meses indicados no son validos.", "Mensaje de Sistema");
                //txtResultado.Text = difFechas.Days / 30 + " Meses de servicio por " + result_calculo * producto;
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            calculate_string();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = this.tabPage2;
        }
    }
}
