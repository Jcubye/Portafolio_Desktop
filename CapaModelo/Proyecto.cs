using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class Proyecto
    {
        private string nombre, descripcion;
        private int rubro_id, cliente_id;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Rubro_id { get => rubro_id; set => rubro_id = value; }
        public int Cliente_id { get => cliente_id; set => cliente_id = value; }
    }
}
