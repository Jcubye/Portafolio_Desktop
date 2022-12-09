using CapaConexion;
using CapaModelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class NegocioTrabajadores
    {
        private Conexion conex;

        public Conexion Conex { get => conex; set => conex = value; }

        public void configurarConexion()
        {
            this.Conex = new Conexion();
            this.Conex.NombreBaseDeDatos = "prueba_portafolio";
            this.Conex.CadenaConexion = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=prueba_portafolio;Integrated Security=True";
        }

        public int obtenerIdProyecto(String nombreProyecto)
        {
            this.configurarConexion();
            this.Conex.NombreTabla = "proyecto";
            this.Conex.CadenaSQL = "SELECT id FROM prueba_portafolio.dbo.proyecto WHERE nombre ='" + nombreProyecto + "';";
            this.Conex.EsSelect = true;
            this.Conex.conectar();
            DataTable dt = new DataTable();
            dt = this.Conex.DbDataSet.Tables[0];

            return (int)dt.Rows[0]["id"];
        }

        public Trabajadores buscarTrabajador(String rut)
        {
            this.configurarConexion();
            this.Conex.NombreTabla = "trabajadores";
            this.Conex.CadenaSQL = "SELECT * FROM prueba_portafolio.dbo.trabajadores WHERE rut ='" + rut + "';";
            this.Conex.EsSelect = true;
            this.Conex.conectar();
            DataTable dt = new DataTable();
            dt = this.Conex.DbDataSet.Tables[0];

            Trabajadores auxTrabajadores = new Trabajadores();

            try
            {
                auxTrabajadores.Rut = (String)dt.Rows[0]["rut"];
            }
            catch (Exception ex)
            {
                auxTrabajadores.Rut = String.Empty;
            }

            return auxTrabajadores;
        }

        public void insertarTrabajador(Trabajadores trabajador)
        {
            string server = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=prueba_portafolio;Integrated Security=True";
            SqlConnection conectar = new SqlConnection();
            Conexion con = new Conexion();

            conectar.ConnectionString = server;
            conectar.Open();
            SqlCommand cmd = new SqlCommand("spInsertarTrabajador", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@rut", trabajador.Rut);
            cmd.Parameters.AddWithValue("@nombre", trabajador.Nombre);
            cmd.Parameters.AddWithValue("@apellidop", trabajador.Apellidop);
            cmd.Parameters.AddWithValue("@apellidom", trabajador.Apellidom);
            cmd.Parameters.AddWithValue("@correo", trabajador.Correo);
            cmd.Parameters.AddWithValue("@capacitado", trabajador.Capacitado);
            cmd.Parameters.AddWithValue("@proyecto_id", trabajador.Proyecto_id);

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

        public DataSet consultaTrabajadores(String nombreP)
        {
            this.configurarConexion();
            this.Conex.NombreTabla = "trabajadores";
            this.Conex.CadenaSQL = "SELECT nombre, apellido_p, apellido_m FROM prueba_portafolio.dbo.trabajadores WHERE proyecto_id = (SELECT id FROM proyecto WHERE nombre ='"+ nombreP +"');";
            this.Conex.EsSelect = true;
            this.Conex.conectar();
            return this.Conex.DbDataSet;
        }
    }
}
