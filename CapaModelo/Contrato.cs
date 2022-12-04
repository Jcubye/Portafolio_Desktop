using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class Contrato
    {
        private int id;
        private String detalle;
        private String fecha_inicio;
        private String fecha_termino;
        private int client_id;

        public int Id { get => id; set => id = value; }
        public String Detalle { get => detalle; set => detalle = value; }
        public String Fecha_inicio { get => fecha_inicio; set => fecha_inicio = value; }
        public String Fecha_termino { get => fecha_termino; set => fecha_termino = value; }
        public int Client_id { get => client_id; set => client_id = value; }
    }
}