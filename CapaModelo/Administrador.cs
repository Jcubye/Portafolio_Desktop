using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class Administrador
    {
        private int id;
        private int id_usuario;
        private String nombre;
        private String apellidop;
        private String apellidom;


        public int Id { get => id; set => id = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public String Nombre { get => nombre; set => nombre = value; }
        public String Apellidop { get => apellidop; set => apellidop = value; }
        public String Apellidom { get => apellidom; set => apellidom = value; }

    }
}
