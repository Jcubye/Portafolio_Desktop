using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class Trabajadores
    {
        private string rut, nombre, apellidop, apellidom, correo, capacitado;
        private int proyecto_id;

        public string Rut { get => rut; set => rut = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidop { get => apellidop; set => apellidop = value; }
        public string Apellidom { get => apellidom; set => apellidom = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Capacitado { get => capacitado; set => capacitado = value; }
        public int Proyecto_id { get => proyecto_id; set => proyecto_id = value; }
    }
}
