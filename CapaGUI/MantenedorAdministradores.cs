using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaModelo;
using CapaNegocio;

namespace CapaGUI
{
    public partial class MantenedorAdministradores : Form
    {
        
        public MantenedorAdministradores()
        {
            InitializeComponent();
        }

        public static int Id_user { get; set; } = 0;
        public static int Id_admin { get; set; } = 0;

        private void MantenedorAdministradores_Load(object sender, EventArgs e)
        {

            //carga combobox con lista de regiones
            NegocioRegionComuna auxReg = new NegocioRegionComuna();
            this.comboBox2.DataSource = auxReg.consultaRegion().Tables[0];
            this.comboBox2.DisplayMember = "nombre";

            CapaNegocio.NegocioAdmin auxNeg = new CapaNegocio.NegocioAdmin();
            this.Usuario_Admin.DataSource = auxNeg.consultaAdministrador();
            this.Usuario_Admin.DataMember = "usuarios";
            this.Usuario_Admin.Enabled = true;

            Usuario_Admin.Columns[0].HeaderText = "Correo";
            Usuario_Admin.Columns[1].HeaderText = "Contraseña";
            Usuario_Admin.Columns[2].HeaderText = "Rut";
            Usuario_Admin.Columns[3].HeaderText = "Direccion";
            Usuario_Admin.Columns[4].HeaderText = "Telefono";
            Usuario_Admin.Columns[5].HeaderText = "Fecha";
            Usuario_Admin.Columns[6].HeaderText = "Nombre";
            Usuario_Admin.Columns[7].HeaderText = "Apellido Paterno";
            Usuario_Admin.Columns[8].HeaderText = "Apellido Materno";
            Usuario_Admin.Columns[9].HeaderText = "id comuna";
            Usuario_Admin.Columns[10].HeaderText = "user id";
            Usuario_Admin.Columns[11].HeaderText = "admin id";
            Usuario_Admin.Columns[1].Visible = false;
            Usuario_Admin.Columns[2].Visible = false;
            Usuario_Admin.Columns[3].Visible = false;
            Usuario_Admin.Columns[4].Visible = false;
            Usuario_Admin.Columns[5].Visible = false;
            Usuario_Admin.Columns[6].Visible = false;
            Usuario_Admin.Columns[7].Visible = false;
            Usuario_Admin.Columns[8].Visible = false;
            Usuario_Admin.Columns[9].Visible = false;
            Usuario_Admin.Columns[10].Visible = false;
            Usuario_Admin.Columns[11].Visible = false;
        }

        public void Actualizar_data() {
            CapaNegocio.NegocioAdmin auxNeg = new CapaNegocio.NegocioAdmin();
            this.Usuario_Admin.DataSource = auxNeg.consultaAdministrador();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            try 
            {
                if (String.IsNullOrEmpty(this.txtCorreo.Text) || String.IsNullOrEmpty(this.txtContra.Text) || String.IsNullOrEmpty(this.txtRut.Text))
                {
                    MessageBox.Show("Rut, correo y clave son requeridos");
                }
                else
                {
                    CapaModelo.Usuario auxUser = new CapaModelo.Usuario();
                    auxUser.Correo = this.txtCorreo.Text;
                    auxUser.Clave = this.txtContra.Text;
                    auxUser.Rut = this.txtRut.Text;
                    auxUser.Pasaporte = this.txtPasaporte.Text;
                    auxUser.Direccion = this.txtDireccion.Text;
                    auxUser.Telefono = this.txtTelefono.Text;
                    auxUser.Id_comuna = Convert.ToInt32(this.comboBox1.SelectedValue);
                    DateTime thisDay = DateTime.Today;
                    auxUser.Fecha = thisDay.ToString("yyyy/MM/dd");


                    CapaNegocio.NegocioUsuario auxNegUser = new CapaNegocio.NegocioUsuario();
                    //validar rut 
                    if (ValidaRut(this.txtRut.Text) == false )
                    {
                        MessageBox.Show("Rut invalido", "Mensaje de sistema");
                        return;
                    }
                    if (validarEmail(this.txtCorreo.Text) == false) {
                        MessageBox.Show("Correo invalido", "Mensaje de sistema");
                        return;
                    }
                    int response = auxNegUser.insertarusuario(auxUser);

                    CapaModelo.Administrador auxAdmin = new CapaModelo.Administrador();

                    auxAdmin.Id_usuario = response;
                    auxAdmin.Nombre = this.txtName.Text;
                    auxAdmin.Apellidop = this.txtApeP.Text;
                    auxAdmin.Apellidom = this.txtApeM.Text;

                    CapaNegocio.NegocioAdmin auxNegAdmin = new CapaNegocio.NegocioAdmin();
                    int adminResponse = auxNegAdmin.insertaradmin(auxAdmin);
                    MessageBox.Show("Datos Guardados ", "Mensaje Sistema");
                    Console.WriteLine(" El ID DEL USUARIO ES " + response);
                    Console.WriteLine(" El ID DEL ADMIN ES " + adminResponse);
                    Actualizar_data();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Datos no guardados. " + ex.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            //int selectedIndex = cmb.SelectedIndex;
            //int selectedValue = (int)cmb.SelectedValue;
            //Console.WriteLine(" es " + selectedValue);
        }

        private void Usuario_Admin_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == 0)
                {
                    int j = 12;
                    for (int i = 0; i < j; i++)   
                    {
                        Console.WriteLine(" el i " + i);
                        String dato = this.Usuario_Admin[i, e.RowIndex].Value.ToString();
                        Console.WriteLine(" es " + dato);
                        if (i == 0) { txtCorreo.Text = dato; }
                        else if (i == 1) { txtContra.Text = dato; }
                        else if (i == 2) { txtRut.Text = dato; }
                        else if (i == 3) { txtDireccion.Text = dato; }
                        else if (i == 4) { txtTelefono.Text = dato; }
                        else if (i == 6) { txtName.Text = dato; }
                        else if (i == 7) { txtApeP.Text = dato; }
                        else if (i == 8) { txtApeM.Text = dato; }
                        else if (i == 9)
                        {

                            Console.WriteLine(" comuna " + this.comboBox1.SelectedIndex.ToString());
                            NegocioRegionComuna auxNeg = new NegocioRegionComuna();
                            List<String> lista = auxNeg.consultaComuna_region_by_id(Convert.ToInt32(dato));
                            comboBox2.SelectedIndex = comboBox2.FindStringExact(lista[0]);
                            comboBox1.SelectedIndex = comboBox1.FindStringExact(lista[1]);

                        }
                        else if (i == 10) { Id_user = Convert.ToInt32(dato); }
                        else if (i == 11) { Id_admin = Convert.ToInt32(dato); }
                    }

                }
                else if (e.ColumnIndex == 1)
                {
                    String Nombre = this.Usuario_Admin[e.ColumnIndex, e.RowIndex].Value.ToString();
                    Console.WriteLine(" es " + Nombre);

                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(" region " + this.comboBox2.SelectedIndex.ToString());
            Console.WriteLine(" region ITEM " + comboBox2.GetItemText(comboBox2.SelectedItem));//this.comboBox2.SelectedItem.ToString());
            // comboBox2.SelectedItem = "Región de Tarapacá";



            if (comboBox2.SelectedValue.ToString() != null)
            {
                //carga combobox con lista de comunas
                NegocioRegionComuna auxNeg = new NegocioRegionComuna();
                string id_region = this.comboBox2.Text;
                this.comboBox1.DataSource = auxNeg.consultaComuna(this.comboBox2.Text).Tables[0];
                this.comboBox1.DisplayMember = "nombre";
                this.comboBox1.ValueMember = "id";
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //comboBox2.SelectedItem = "Región de Tarapacá";
            Console.WriteLine(" comuna " + this.comboBox1.SelectedIndex.ToString());
            NegocioRegionComuna auxNeg = new NegocioRegionComuna();
            IList dt = auxNeg.consultaComuna_region_by_id(Convert.ToInt32(324));
            Console.WriteLine(" es " + dt[0]);
            //Console.WriteLine(comboBox2.FindStringExact("Región de Coquimbo"));

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(" El ID DEL USUARIO ES " + Id_user);
            //Console.WriteLine(" El ID DEL ADMIN ES " + Id_admin);
            try
            {
                if (String.IsNullOrEmpty(this.txtCorreo.Text) || String.IsNullOrEmpty(this.txtContra.Text) || String.IsNullOrEmpty(this.txtRut.Text))
                {
                    MessageBox.Show("Rut, correo y clave son requeridos");
                }
                else
                {
                    
                    //Console.WriteLine(" El ID DEL ADMIN ES " + Id_admin);
                    //Console.WriteLine(" El ID DEL ADMIN ES " + Id_admin);

                    CapaModelo.Usuario auxUser = new CapaModelo.Usuario();
                    auxUser.Correo = this.txtCorreo.Text;
                    auxUser.Clave = this.txtContra.Text;
                    auxUser.Direccion = this.txtDireccion.Text;
                    auxUser.Telefono = this.txtTelefono.Text;
                    auxUser.Id_comuna = Convert.ToInt32(this.comboBox1.SelectedValue);
                    auxUser.Id = Id_user;

                    CapaNegocio.NegocioUsuario auxNegUser = new CapaNegocio.NegocioUsuario();
                    //validar rut 
                    if (ValidaRut(this.txtRut.Text) == false)
                    {
                        MessageBox.Show("Rut invalido", "Mensaje de sistema");
                        return;
                    }
                    if (validarEmail(this.txtCorreo.Text) == false)
                    {
                        MessageBox.Show("Correo invalido", "Mensaje de sistema");
                        return;
                    }
                    auxNegUser.actualizarUsuario(auxUser);

                    CapaModelo.Administrador auxAdmin = new CapaModelo.Administrador();

                    auxAdmin.Nombre = this.txtName.Text;
                    auxAdmin.Apellidop = this.txtApeP.Text;
                    auxAdmin.Apellidom = this.txtApeM.Text;
                    auxAdmin.Id = Id_admin;
                    CapaNegocio.NegocioAdmin auxNegAdmin = new CapaNegocio.NegocioAdmin();
                    auxNegAdmin.actualizarAdmin(auxAdmin);
                    MessageBox.Show("Datos Guardados ", "Mensaje Sistema");
                    Actualizar_data();

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Datos no guardados. " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Envio_correo auxCorreo = new Envio_correo();
            //auxCorreo.Enviar_correo();
            txtCorreo.Text = String.Empty;
            txtContra.Text = String.Empty;
            txtRut.Text = String.Empty;
            txtPasaporte.Text = String.Empty;
            txtDireccion.Text = String.Empty;
            txtTelefono.Text = String.Empty;
            txtName.Text = String.Empty;
            txtApeP.Text = String.Empty;
            txtApeM.Text = String.Empty;
            this.comboBox2.SelectedIndex = 0;
            this.comboBox1.SelectedIndex = -1;
           
        }


        //metodo para validar rut
        public static bool ValidaRut(string rut)
        {
            rut = rut.Replace(".", "").ToUpper();
            //Regex expresion = new Regex("^([0-9]+-[0-9K])$");
            string dv = rut.Substring(rut.Length - 1, 1);
            //if (!expresion.IsMatch(rut))
            //{
            //    Console.WriteLine("No mach");
            //    return false;
            //}
            char[] charCorte = { '-' };
            string[] rutTemp = rut.Split(charCorte);
            Console.WriteLine(Digito(int.Parse(rutTemp[0])));
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

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    ComboBox cmb = (ComboBox)sender;
        //    int selectedIndex = cmb.SelectedIndex;
        //    int selectedValue = (int)cmb.SelectedValue;
        //    Console.WriteLine(" es " + selectedValue);

        //}


    }
}
