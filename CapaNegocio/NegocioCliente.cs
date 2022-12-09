using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaConexion;
using CapaModelo;


namespace CapaNegocio
{
    public class NegocioCliente
    {
        private Conexion conex;

        public Conexion Conex { get => conex; set => conex = value; }

        public void configurarConexion()
        {
            this.Conex = new Conexion();
            this.Conex.NombreBaseDeDatos = "prueba_portafolio";
            this.Conex.CadenaConexion = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=prueba_portafolio;Integrated Security=True";
        }

        public void insertarCliente(Cliente cliente)
        {
            string server = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=prueba_portafolio;Integrated Security=True";
            SqlConnection conectar = new SqlConnection();
            Conexion con = new Conexion();

            conectar.ConnectionString = server;
            conectar.Open();
            SqlCommand cmd = new SqlCommand("spInsertarCliente", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@correo", cliente.Correo);
            cmd.Parameters.AddWithValue("@clave", cliente.Clave);
            cmd.Parameters.AddWithValue("@rut", cliente.Rut);
            cmd.Parameters.AddWithValue("@direccion", cliente.Direccion);
            cmd.Parameters.AddWithValue("@telefono", cliente.Telefono);
            cmd.Parameters.AddWithValue("@fecha", cliente.FechaCreacion);
            cmd.Parameters.AddWithValue("@comuna_id", cliente.Comuna);
            cmd.Parameters.AddWithValue("@razon_social", cliente.RazonSocial);
            cmd.Parameters.AddWithValue("@estado", cliente.Estado);
            cmd.Parameters.AddWithValue("@rubro_id", cliente.Rubro);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            conectar.Close();
        }

        public void actualizarCliente(Cliente cliente)
        {
            string server = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=prueba_portafolio;Integrated Security=True";
            SqlConnection conectar = new SqlConnection();
            Conexion con = new Conexion();

            conectar.ConnectionString = server;
            conectar.Open();
            SqlCommand cmd = new SqlCommand("spActualizarCliente", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@correo", cliente.Correo);
            cmd.Parameters.AddWithValue("@clave", cliente.Clave);
            cmd.Parameters.AddWithValue("@rut", cliente.Rut);
            cmd.Parameters.AddWithValue("@direccion", cliente.Direccion);
            cmd.Parameters.AddWithValue("@telefono", cliente.Telefono);
            cmd.Parameters.AddWithValue("@razon_social", cliente.RazonSocial);
            cmd.Parameters.AddWithValue("@estado", cliente.Estado);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            conectar.Close();
        }

        public Cliente buscarCliente(String rut)
        {
            this.configurarConexion();
            this.Conex.NombreTabla = "cliente";
            this.Conex.CadenaSQL = "SELECT * FROM prueba_portafolio.dbo.usuarios WHERE rut ='" + rut + "';";
            this.Conex.EsSelect = true;
            this.Conex.conectar();
            DataTable dt = new DataTable();
            dt = this.Conex.DbDataSet.Tables[0];

            Cliente auxCliente = new Cliente();

            try
            {
                auxCliente.Rut = (String)dt.Rows[0]["rut"];
            }
            catch (Exception ex)
            {
                auxCliente.Rut = String.Empty;
            }

            return auxCliente;
        }

        public DataSet consultaCliente()
        {
            this.configurarConexion();
            this.Conex.NombreTabla = "usuarios";
            this.Conex.CadenaSQL = "SELECT correo, clave, rut, direccion, telefono, razon_social, estado " +
                "FROM prueba_portafolio.dbo.usuarios u  JOIN prueba_portafolio.dbo.cliente c ON u.id = c.usuarios_id";
            this.Conex.EsSelect = true;
            this.Conex.conectar();
            return this.Conex.DbDataSet;
        }

        public DataSet consultaClienteActivo()
        {
            this.configurarConexion();
            this.Conex.NombreTabla = "usuarios";
            this.Conex.CadenaSQL = "SELECT correo, clave, rut, direccion, telefono, razon_social, estado, r.nombre, r.descripcion, c.id " +
                "FROM prueba_portafolio.dbo.usuarios u  JOIN prueba_portafolio.dbo.cliente c ON u.id = c.usuarios_id join rubro r on c.rubro_id = r.id where c.estado = 'activo'";
            this.Conex.EsSelect = true;
            this.Conex.conectar();
            return this.Conex.DbDataSet;
        }

        public DataSet consultaClienteActivoFiltered(string rut)
        {
            this.configurarConexion();
            this.Conex.NombreTabla = "usuarios";
            this.Conex.CadenaSQL = "SELECT correo, clave, rut, direccion, telefono, razon_social, estado, r.nombre, r.descripcion, c.id " +
                "FROM prueba_portafolio.dbo.usuarios u  JOIN prueba_portafolio.dbo.cliente c ON u.id = c.usuarios_id join rubro r on c.rubro_id = r.id where c.estado = 'activo' AND u.rut like '" + rut+"%'";
            this.Conex.EsSelect = true;
            this.Conex.conectar();
            return this.Conex.DbDataSet;
        }

        public int obtenerIdComuna (String nombreComuna)
        {
            this.configurarConexion();
            this.Conex.NombreTabla = "comuna";
            this.Conex.CadenaSQL = "SELECT id FROM prueba_portafolio.dbo.comuna WHERE nombre = '" + nombreComuna + "'";
            this.Conex.EsSelect = true;
            this.Conex.conectar();
            DataTable dt = new DataTable();
            dt = this.Conex.DbDataSet.Tables[0];

            Comuna auxComuna = new Comuna();

            try
            {
                auxComuna.Id = (int)dt.Rows[0]["id"];
            }
            catch (Exception ex)
            {
                auxComuna.Id = 0;
            }

            return auxComuna.Id;
        }

        public int obtnerIdRubro(String nombreRubro)
        {
            this.configurarConexion();
            this.Conex.NombreTabla = "rubro";
            this.Conex.CadenaSQL = "SELECT id FROM prueba_portafolio.dbo.rubro WHERE nombre = '" + nombreRubro + "'";
            this.Conex.EsSelect = true;
            this.Conex.conectar();
            DataTable dt = new DataTable();
            dt = this.Conex.DbDataSet.Tables[0];

            Rubro auxRubro = new Rubro();

            try
            {
                auxRubro.Id = (int)dt.Rows[0]["id"];
            }
            catch (Exception ex)
            {
                auxRubro.Id = 0;
            }

            return auxRubro.Id;
        }

    }
}

