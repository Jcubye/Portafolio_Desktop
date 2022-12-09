using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class Factura
    {
        private int id_factura_pago;
        private string fecha_emision;
        private string fecha_vencimiento;
        private string fecha_Pago;
        private string monto_Pagado;
        private int id_detalle;
        private string desc_detalle;
        private int monto_total_detalle;
        private int id_contrato;



        public int ID_factura_pago { get => id_factura_pago; set => id_factura_pago = value; }
        public string Fecha_emision { get => fecha_emision; set => fecha_emision = value; }
        public string Fecha_vencimiento { get => fecha_vencimiento; set => fecha_vencimiento = value; }
        public string Fecha_Pago { get => fecha_Pago; set => fecha_Pago = value; }
        public string Monto_Pagado { get => monto_Pagado; set => monto_Pagado = value; }
        public int Id_detalle { get => id_detalle; set => id_detalle = value; }
        public string Desc_detalle { get => desc_detalle; set => desc_detalle = value; }
        public int Monto_total_detalle { get => monto_total_detalle; set => monto_total_detalle = value; }
        public int Id_contrato { get => id_contrato; set => id_contrato = value; }
    }
}
