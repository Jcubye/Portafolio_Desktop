using CapaConexion;
using CapaModelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NegocioRubro
    {
        private Conexion conex;

        public Conexion Conex { get => conex; set => conex = value; }

        public void configurarConexion()
        {
            this.Conex = new Conexion();
            this.Conex.NombreBaseDeDatos = "prueba_portafolio";
            this.Conex.CadenaConexion = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=prueba_portafolio;Integrated Security=True";
        }

        public DataSet consultaRubro()
        {
            this.configurarConexion();
            this.Conex.NombreTabla = "rubro";
            this.Conex.CadenaSQL = "SELECT * FROM prueba_portafolio.dbo.rubro";
            this.Conex.EsSelect = true;
            this.Conex.conectar();
            return this.Conex.DbDataSet;
        }

        public String ObtenerDescRubro(String nombreRubro)//preba
        {
            this.configurarConexion();
            this.Conex.NombreTabla = "rubro";
            this.Conex.CadenaSQL = "SELECT descripcion FROM prueba_portafolio.dbo.rubro WHERE nombre ='" + nombreRubro + "';";
            this.Conex.EsSelect = true;
            this.Conex.conectar();
            DataTable dt = new DataTable();
            dt = this.Conex.DbDataSet.Tables[0];

            Rubro auxRubro = new Rubro();

            try
            {
                auxRubro.Descripcion = (String)dt.Rows[0]["descripcion"];
            }
            catch (Exception ex)
            {
                auxRubro.Descripcion = "";
            }

            return auxRubro.Descripcion;
        }

        public int ObtenerIdRubro(String nombreRubro)//preba
        {
            this.configurarConexion();
            this.Conex.NombreTabla = "rubro";
            this.Conex.CadenaSQL = "SELECT id FROM prueba_portafolio.dbo.rubro WHERE nombre ='" + nombreRubro + "';";
            this.Conex.EsSelect = true;
            this.Conex.conectar();
            DataTable dt = new DataTable();
            dt = this.Conex.DbDataSet.Tables[0];
            
            return (int)dt.Rows[0]["id"];
        }
    }
}
