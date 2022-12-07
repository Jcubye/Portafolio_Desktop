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
    public class NegocioProfesional
    {

        private Conexion conec;

        public Conexion Conec { get => conec; set => conec = value; }





        public void configurarConexion()
        {
            this.Conec = new Conexion();
            this.Conec.NombreBaseDeDatos = "prueba_portafolio";
            this.Conec.NombreTabla = "profesional";
            this.Conec.CadenaConexion = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=prueba_portafolio;Integrated Security=True";
        }

        public DataSet retornaProfesional()
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "SELECT * FROM profesional";
            this.Conec.EsSelect = true;
            this.Conec.conectar();

            return this.Conec.DbDataSet;

        }

        public void IngresaProfesional(Profesional profesional)
        {

            this.configurarConexion();
            this.Conec.CadenaSQL = "SET IDENTITY_INSERT profesional ON insert into profesional (id, nombre, apellido_p, apellido_m, rol, estado, usuarios_id) VALUES('"
                + profesional.ID1 + "', '"
                + profesional.Nombre1 + "', '"
                + profesional.ApellidoPaterno1 + "', '"
                + profesional.ApellidoMaterno1 + "', '"
                + profesional.Rol1 + "', '"
                + profesional.Estado1 + "','"
                 + profesional.IdUsuario1 + "'); ";
            this.Conec.EsSelect = false;
            this.Conec.conectar();


        }



        public void EliminaProfesional(String id)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "DELETE FROM profesional "
                                   + "WHERE id = '" + id + "';";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        } //Fin Elimina cliente

        public void actualizaProfesional(Profesional profesional)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "UPDATE profesional "
                                   + "SET "
                                   + "nombre = '" + profesional.Nombre1
                                   + "' WHERE id = '" + profesional.ID1 + "';";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        } //Fin ingrasa cliente


        public Profesional retornaPosicion(int posicion)
        {
            Profesional auxProfesional = new Profesional();
            this.configurarConexion();
            this.Conec.CadenaSQL = "SELECT * FROM profesional";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec.DbDataSet.Tables[this.Conec.NombreTabla];

            try
            {
                auxProfesional.ID1 = (int)dt.Rows[posicion]["id"];
                auxProfesional.Nombre1 = (String)dt.Rows[posicion]["nombre"];
                auxProfesional.ApellidoPaterno1 = (String)dt.Rows[posicion]["apellido paterno"];
                auxProfesional.ApellidoMaterno1 = (String)dt.Rows[posicion]["apellido materno"];
                auxProfesional.Rol1 = (String)dt.Rows[posicion]["rol"];
                auxProfesional.Estado1 = (String)dt.Rows[posicion]["estado"];
                auxProfesional.IdUsuario1 = (string)dt.Rows[posicion]["usuario id"];

            }
            catch (Exception ex)
            {

                auxProfesional.Nombre1 = "";
            }

            return auxProfesional;

        }

        public Profesional buscaProfesional()
        {
            Profesional auxProfesional = new Profesional();
            this.configurarConexion();
            this.Conec.CadenaSQL = "SELECT * FROM profesional";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec.DbDataSet.Tables[this.Conec.NombreTabla];

            try
            {
                auxProfesional.Nombre1 = (String)dt.Rows[0]["nombre"];

            }
            catch (Exception ex)
            {
                auxProfesional.Nombre1 = "";
            }

            return auxProfesional;

        }

        public DataSet consultaProfesionalActivo()
        {
            this.configurarConexion();
            this.Conec.NombreTabla = "usuarios";
            this.Conec.CadenaSQL = "select * from profesional p join usuarios u on p.usuarios_id = u.id where p.estado = 'activo'";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            return this.Conec.DbDataSet;
        }

        public DataSet consultaProfesionalActivoFiltered(string rut)
        {
            this.configurarConexion();
            this.Conec.NombreTabla = "usuarios";
            this.Conec.CadenaSQL = "select * from profesional p join usuarios u on p.usuarios_id = u.id where p.estado = 'activo' AND u.rut like '" + rut + "%'";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            return this.Conec.DbDataSet;
        }



    }
}