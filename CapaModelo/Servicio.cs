using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class Servicio
    {
        private int id;
        private String descripcion;
        private String estado;
        private int id_profesional;
        private int id_contrato;

        public int Id { get => id; set => id = value; }
        public String Descripcion { get => descripcion; set => descripcion = value; }
        public String Estado { get => estado; set => estado = value; }
        public int Id_profesional { get => id_profesional; set => id_profesional = value; }
        public int Id_contrato { get => id_contrato; set => id_contrato = value; }
    }
}
