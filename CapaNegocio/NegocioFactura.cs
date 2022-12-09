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
    public class NegocioFactura
    {
        private Conexion conec;


        public Conexion Conec { get => conec; set => conec = value; }

        public void configurarConexion()
        {
            this.Conec = new Conexion();
            this.Conec.NombreBaseDeDatos = "prueba_portafolio";
            this.Conec.NombreTabla = "contrato";
            this.Conec.CadenaConexion = "Data Source = (local)\\SQLEXPRESS; Initial Catalog =prueba_portafolio; Integrated Security =True";
        }


        public int insertarFactura(Factura factura)
        {
            try
            {
                this.configurarConexion();
                //this.Conec.CadenaSQL = "DECLARE	@return_value int EXEC	@return_value = [dbo].[SP_INSERTAR_USUARIO] @correo = '" + usuario.Correo + "', @clave = '" + usuario.Clave + "', @rut = '" + usuario.Rut + "', @pasaporte = '" + usuario.Pasaporte + "', @direccion = '" + usuario.Direccion + "', @telefono ='" + usuario.Telefono + "', @fecha = '" + usuario.Fecha + "', @comuna_id = " + usuario.Id_comuna + "";
                this.Conec.CadenaSQL = "insert into factura (fecha_emision , fecha_vencimiento) values ('" + factura.Fecha_emision + "','" + factura.Fecha_vencimiento + "')";
                Console.WriteLine(Conec.CadenaSQL);
                this.Conec.EsSelect = false;
                this.Conec.conectar();

                this.Conec.CadenaSQL = "select IDENT_CURRENT('factura') as id";
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

        public int insertarFacturaDetalle(Factura factura)
        {
            try
            {
                this.configurarConexion();
                //this.Conec.CadenaSQL = "DECLARE	@return_value int EXEC	@return_value = [dbo].[SP_INSERTAR_USUARIO] @correo = '" + usuario.Correo + "', @clave = '" + usuario.Clave + "', @rut = '" + usuario.Rut + "', @pasaporte = '" + usuario.Pasaporte + "', @direccion = '" + usuario.Direccion + "', @telefono ='" + usuario.Telefono + "', @fecha = '" + usuario.Fecha + "', @comuna_id = " + usuario.Id_comuna + "";
                this.Conec.CadenaSQL = "insert into detalle_factura values ('" + factura.Desc_detalle + "','" + factura.Monto_total_detalle + "','" + factura.Id_contrato + "','" + factura.ID_factura_pago + "')";
                this.Conec.EsSelect = false;
                this.Conec.conectar();

                this.Conec.CadenaSQL = "select IDENT_CURRENT('detalle_factura') as id";
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
    }
}
