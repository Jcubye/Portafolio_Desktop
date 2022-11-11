using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class Cliente
    {
        private string rut, correo, clave, razonSocial, direccion, estado;
        private int telefono, comuna, rubro;
        private DateTime fechaCreacion;

        public string Rut { get => rut; set => rut = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Clave { get => clave; set => clave = value; }
        public string RazonSocial { get => razonSocial; set => razonSocial = value; }
        public int Comuna { get => comuna; set => comuna = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Rubro { get => rubro; set => rubro = value; }
        public string Estado { get => estado; set => estado = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
    }
}
