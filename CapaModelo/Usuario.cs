using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class Usuario
    {
        private int id;
        private String correo;
        private String clave;
        private String rut;
        private String pasaporte;
        private String direccion;
        private String telefono;
        private String fecha;
        private int id_comuna;

        public int Id { get => id; set => id = value; }
        public String Correo { get => correo; set => correo = value; }
        public String Clave { get => clave; set => clave = value; }
        public String Rut { get => rut; set => rut = value; }
        public String Pasaporte { get => pasaporte; set => pasaporte = value; }
        public String Direccion { get => direccion; set => direccion = value; }
        public String Telefono { get => telefono; set => telefono = value; }
        public String Fecha { get => fecha; set => fecha = value; }
        public int Id_comuna { get => id_comuna; set => id_comuna = value; }
    }
}
