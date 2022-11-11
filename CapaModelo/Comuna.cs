using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class Comuna
    {
        private string nombre;
        private int region_id, id;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Region_id { get => region_id; set => region_id = value; }
        public int Id { get => id; set => id = value; }
    }
}
