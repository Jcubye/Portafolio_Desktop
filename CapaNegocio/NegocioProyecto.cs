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
    public class NegocioProyecto
    {
        private Conexion conex;

        public Conexion Conex { get => conex; set => conex = value; }

        public void configurarConexion()
        {
            this.Conex = new Conexion();
            this.Conex.NombreBaseDeDatos = "prueba_portafolio";
            this.Conex.CadenaConexion = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=prueba_portafolio;Integrated Security=True";
        }

        public void insertarProyecto(Proyecto proyecto)
        {
            string server = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=prueba_portafolio;Integrated Security=True";
            SqlConnection conectar = new SqlConnection();
            Conexion con = new Conexion();

            conectar.ConnectionString = server;
            conectar.Open();
            SqlCommand cmd = new SqlCommand("spInsertarProyecto", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@nombre", proyecto.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", proyecto.Descripcion);
            cmd.Parameters.AddWithValue("@rubro_id", proyecto.Rubro_id);
            cmd.Parameters.AddWithValue("@cliente_id", proyecto.Cliente_id);

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

        public DataSet consultaProyecto()
        {
            this.configurarConexion();
            this.Conex.NombreTabla = "proyecto";
            this.Conex.CadenaSQL = "SELECT nombre FROM prueba_portafolio.dbo.proyecto";
            this.Conex.EsSelect = true;
            this.Conex.conectar();
            return this.Conex.DbDataSet;
        }

        public String obtenerDescProyecto(String nombreProyecto)
        {
            this.configurarConexion();
            this.Conex.NombreTabla = "proyecto";
            this.Conex.CadenaSQL = "SELECT descripcion FROM prueba_portafolio.dbo.proyecto WHERE nombre = '" + nombreProyecto + "'";
            this.Conex.EsSelect = true;
            this.Conex.conectar();
            DataTable dt = new DataTable();
            dt = this.Conex.DbDataSet.Tables[0];

            return (String)dt.Rows[0]["descripcion"];
        }
    }
}
