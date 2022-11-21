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
    public class NegocioUsuario
    {
        private Conexion conec;


        public Conexion Conec { get => conec; set => conec = value; }

        public void configurarConexion()
        {
            this.Conec = new Conexion();
            this.Conec.NombreBaseDeDatos = "prueba_portafolio";
            this.Conec.NombreTabla = "usuarios";
            this.Conec.CadenaConexion = "Data Source = (local)\\SQLEXPRESS; Initial Catalog =prueba_portafolio; Integrated Security =True";
        }
        

        public int insertarusuario(Usuario usuario)
        {
            try
            {
                this.configurarConexion();
                this.Conec.CadenaSQL = "DECLARE	@return_value int EXEC	@return_value = [dbo].[SP_INSERTAR_USUARIO] @correo = '" + usuario.Correo + "', @clave = '" +usuario.Clave + "', @rut = '"+ usuario.Rut+ "', @pasaporte = '" + usuario.Pasaporte + "', @direccion = '" + usuario.Direccion + "', @telefono ='" + usuario.Telefono + "', @fecha = '" + usuario.Fecha + "', @comuna_id = " + usuario.Id_comuna + "";
                this.Conec.EsSelect = false;
                this.Conec.conectar();

                this.Conec.CadenaSQL = "select IDENT_CURRENT('usuarios') as id";
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

        public void actualizarUsuario(Usuario user)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "UPDATE usuarios SET correo = '"
                                   + user.Correo +
                                   "', clave = '" + user.Clave +
                                   "', direccion = '" + user.Direccion +
                                   "', telefono = '" + user.Telefono +
                                   "', comuna_id = '" + user.Id_comuna +
                                   "' WHERE id = '" + user.Id + "';";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        
        } //Fin Actualizar

        public int authUsuario(Usuario user)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "SELECT * from usuarios WHERE correo = '" + user.Correo + "' and clave = '" + user.Clave + "';";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            int result;
            DataTable dt = new DataTable();
            dt = this.Conec.DbDataSet.Tables[0];

            if (dt.Rows.Count > 0) {result = 1;}
            else { result = 0; }

            return result;

        } //Fin consultar
    }
}
