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
    public class NegocioServicio
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
            this.Conex.NombreTabla = "servicio";
            this.Conex.CadenaSQL = "SELECT * FROM prueba_portafolio.dbo.servicio";
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

        public int insertarServicio(Servicio servicio)
        {
            try
            {
                this.configurarConexion();
                this.Conex.NombreTabla = "servicio";
                //this.Conec.CadenaSQL = "DECLARE	@return_value int EXEC	@return_value = [dbo].[SP_INSERTAR_USUARIO] @correo = '" + usuario.Correo + "', @clave = '" + usuario.Clave + "', @rut = '" + usuario.Rut + "', @pasaporte = '" + usuario.Pasaporte + "', @direccion = '" + usuario.Direccion + "', @telefono ='" + usuario.Telefono + "', @fecha = '" + usuario.Fecha + "', @comuna_id = " + usuario.Id_comuna + "";
                this.Conex.CadenaSQL = "insert into servicio values ('" + servicio.Descripcion + "','" + servicio.Estado + "','" + servicio.Id_profesional + "','" + servicio.Id_contrato + "')";
                this.Conex.EsSelect = false;
                this.Conex.conectar();

                this.Conex.CadenaSQL = "select IDENT_CURRENT('servicio') as id";
                this.Conex.EsSelect = true;
                this.Conex.conectar();


                DataTable dt = new DataTable();
                dt = this.Conex.DbDataSet.Tables[0];
                if (dt.Rows.Count > 0)
                {
                    return Convert.ToInt32(dt.Rows[0]["id"]);
                }
                else
                {
                    return 0;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Datos No Guardados " + ex.Message, "Mensaje Sistema");
                Console.WriteLine("");
                return 0;
            }

        } //Fin insertar

    }
}
