using CapaConexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NegocioRegionComuna
    {
        private Conexion conex;

        public Conexion Conex { get => conex; set => conex = value; }

        public void configurarConexion()
        {
            this.Conex = new Conexion();
            this.Conex.NombreBaseDeDatos = "prueba_portafolio";
            this.Conex.CadenaConexion = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=prueba_portafolio;Integrated Security=True";
        }

        public DataSet consultaRegion()
        {
            this.configurarConexion();
            this.Conex.NombreTabla = "region";
            this.Conex.CadenaSQL = "SELECT * FROM prueba_portafolio.dbo.region";
            this.Conex.EsSelect = true;
            this.Conex.conectar();
            return this.Conex.DbDataSet;
        }

        public DataSet consultaComuna(String region)
        {
            this.configurarConexion();
            this.Conex.NombreTabla = "comuna";
            this.Conex.CadenaSQL = "SELECT * FROM prueba_portafolio.dbo.comuna WHERE region_id = (SELECT id from region where nombre = '" + region + "');";
            this.Conex.EsSelect = true;
            this.Conex.conectar();
            return this.Conex.DbDataSet;
        }

    }
}
