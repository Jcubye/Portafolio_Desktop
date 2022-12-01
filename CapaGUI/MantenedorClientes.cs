using CapaModelo;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaGUI
{
    public partial class MantenedorClientes : Form
    {
        public MantenedorClientes()
        {
            InitializeComponent();
        }

        private NegocioCliente negocio;

        public NegocioCliente Negocio { get => negocio; set => negocio = value; }

        public void limpiar()
        {
            this.txtClave.Clear();
            this.txtCorreo.Clear();
            this.txtDireccion.Clear();
            this.txtFechaNac.ResetText();
            this.txtRSocial.Clear();
            //this.txtRubro.Clear();
            this.txtRut.Clear();
            this.txtTelefono.Clear();
            this.cmbComuna.SelectedIndex = 0;
            this.cmbRegion.SelectedIndex = 0;
            this.cmbRubro.SelectedIndex = 0;
            this.cmbEstado.SelectedIndex = 0;
        }   

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtCorreo.Text) || String.IsNullOrEmpty(this.txtClave.Text) || String.IsNullOrEmpty(this.txtRut.Text))
                {
                    MessageBox.Show("Rut, correo y clave son requeridos");
                }
                else
                {
                    NegocioCliente auxNegocio = new NegocioCliente();
                    Cliente auxCliente2 = new Cliente
                    {
                        Correo = this.txtCorreo.Text,
                        Clave = this.txtClave.Text,
                        Rut = this.txtRut.Text,
                        Direccion = this.txtDireccion.Text,
                        Telefono = Convert.ToInt32(this.txtTelefono.Text),
                        FechaCreacion = DateTime.Parse(this.txtFechaNac.Text),
                        Comuna = auxNegocio.obtenerIdComuna(this.cmbComuna.Text),//se necesita obtener id
                        RazonSocial = this.txtRSocial.Text,
                        Estado = this.cmbEstado.Text,
                        Rubro = auxNegocio.obtnerIdRubro(this.cmbRubro.Text)//se necesita obtener id
                    };

                    //validar rut 
                    if (ValidaRut(this.txtRut.Text) == false || validarEmail(this.txtCorreo.Text) == false)
                    {
                        MessageBox.Show("Rut o correo invalido", "Mensaje de sistema");
                    }
                    else
                    {
                        //validacion de si existe cliente en base de datos
                        if (String.IsNullOrEmpty(auxNegocio.buscarCliente(auxCliente2.Rut).Rut))
                        {
                            auxNegocio.insertarCliente(auxCliente2);
                            MessageBox.Show("Datos guardados", "Mensaje de sistema");
                            this.limpiar();
                        }
                        else
                        {
                            MessageBox.Show("Cliente ya existe");
                        }
                    }
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos no guardados. " + ex.Message);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ListarClientes cListado = new ListarClientes();
            cListado.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }

        private void MantenedorClientes_Load(object sender, EventArgs e)
        {
            //restriccion de fecha
            this.txtFechaNac.MaxDate = DateTime.Today;

            //carga combobox con lista de regiones
            NegocioRegionComuna auxNeg = new NegocioRegionComuna();
            this.cmbRegion.DataSource = auxNeg.consultaRegion().Tables[0];
            this.cmbRegion.DisplayMember = "nombre";

            //carga combobox con lista de rubros
            NegocioRubro auxNegR = new NegocioRubro();
            this.cmbRubro.DataSource = auxNegR.consultaRubro().Tables[0];
            this.cmbRubro.DisplayMember = "nombre";

            //texto fijo
            this.txtRubro.ReadOnly = true;
            this.cmbRegion.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbComuna.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbRubro.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cmbRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRegion.SelectedValue.ToString() != null)
            {
                //carga combobox con lista de comunas
                NegocioRegionComuna auxNeg = new NegocioRegionComuna();
                string id_region = this.cmbRegion.Text;
                this.cmbComuna.DataSource = auxNeg.consultaComuna(this.cmbRegion.Text).Tables[0];
                this.cmbComuna.DisplayMember = "nombre";
            }
        }

        private void cmbRubro_SelectedIndexChanged(object sender, EventArgs e)
        {
            NegocioRubro auxNegR = new NegocioRubro();
            this.txtRubro.Text = auxNegR.ObtenerDescRubro(this.cmbRubro.Text);
        }

        //metodo para simular placeholder
        private void txtRut_Enter(object sender, EventArgs e)
        {
            if (txtRut.Text == "Ej: 12.345.678-9")
            {
                txtRut.Text = "";
                txtRut.ForeColor = System.Drawing.Color.DarkGray;
            }
        }

        private void txtRut_Leave(object sender, EventArgs e)
        {
            if (txtRut.Text == "")
            {
                txtRut.Text = "Ej: 12.345.678-9";
                txtRut.ForeColor = System.Drawing.Color.DarkGray;
            }
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "Ej: ejemplo@correo.cl")
            {
                txtCorreo.Text = "";
                txtCorreo.ForeColor = System.Drawing.Color.DarkGray;
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "Ej: ejemplo@correo.cl";
                txtCorreo.ForeColor = System.Drawing.Color.DarkGray;
            }
        }

        //metodo para validar rut
        public static bool ValidaRut(string rut)
        {
            rut = rut.Replace(".", "").ToUpper();
            Regex expresion = new Regex("^([0-9]+-[0-9K])$");
            string dv = rut.Substring(rut.Length - 1, 1);
            if (!expresion.IsMatch(rut))
            {
                return false;
            }
            char[] charCorte = { '-' };
            string[] rutTemp = rut.Split(charCorte);
            if (dv != Digito(int.Parse(rutTemp[0])))
            {
                return false;
            }
            return true;
        }

        public static string Digito(int rut)
        {
            int suma = 0;
            int multiplicador = 1;
            while (rut != 0)
            {
                multiplicador++;
                if (multiplicador == 8)
                    multiplicador = 2;
                suma += (rut % 10) * multiplicador;
                rut = rut / 10;
            }
            suma = 11 - (suma % 11);
            if (suma == 11)
            {
                return "0";
            }
            else if (suma == 10)
            {
                return "K";
            }
            else
            {
                return suma.ToString();
            }
        }

        //metodo para validar correo
        static bool validarEmail(string email)
        {
            try
            {
                new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
