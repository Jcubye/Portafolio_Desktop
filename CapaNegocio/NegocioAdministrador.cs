using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo;
using CapaConexion;
using System.Data.SqlClient;
using System.Data;

namespace CapaNegocio
{
    public class NegocioAdmin
    {
        private Conexion conec;


        public Conexion Conec { get => conec; set => conec = value; }

        public void configurarConexion()
        {
            this.Conec = new Conexion();
            this.Conec.NombreBaseDeDatos = "prueba_portafolio";
            this.Conec.NombreTabla = "administrador";
            this.Conec.CadenaConexion = "Data Source = (local)\\SQLEXPRESS; Initial Catalog =prueba_portafolio; Integrated Security =True";
        }
        public int insertaradmin(Administrador admin)
        {
            try
            {
                this.configurarConexion();
                this.Conec.CadenaSQL = "DECLARE	@return_value int EXEC	@return_value = [dbo].[SP_INSERTAR_administrador] @nombre = '" + admin.Nombre + "', @apellido_p = '" + admin.Apellidop + "', @apellido_m = '" + admin.Apellidom+ "', @usuarios_id = '" + admin.Id_usuario + "' ";
                this.Conec.EsSelect = false;
                this.Conec.conectar();

                this.Conec.CadenaSQL = "select IDENT_CURRENT('administrador') as id";
                this.Conec.EsSelect = true;
                this.Conec.conectar();


                DataTable dt = new DataTable();
                dt = this.Conec.DbDataSet.Tables[0];
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

        public DataSet consultaAdministrador()
        {
            this.configurarConexion();
            this.Conec.NombreTabla = "usuarios";
            this.Conec.CadenaSQL = "SELECT u.correo, u.clave, u.rut, u.direccion, u.telefono, u.fecha, adm.nombre, adm.apellido_p, adm.apellido_m, u.comuna_id, u.id as user_id, adm.id as adm_id " +
                "FROM usuarios u  JOIN administrador adm ON u.id = adm.usuarios_id";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            return this.Conec.DbDataSet;
        } //Fin consultar

        public void actualizarAdmin(Administrador admin)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "UPDATE administrador SET nombre = '"
                                   + admin.Nombre +
                                   "', apellido_p = '" + admin.Apellidop +
                                   "', apellido_m = '" + admin.Apellidom +
                                   "' WHERE id = '" + admin.Id + "';";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        } //Fin Actualizar
    }
}
