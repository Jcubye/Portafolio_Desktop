using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo;
using CapaConexion;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using Microsoft.Win32;
using System.Windows.Forms;

using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Pdf.Canvas.Draw;

namespace CapaNegocio
{
    public class NegocioReporteria
    {
        private Conexion conex;

        public Conexion Conex { get => conex; set => conex = value; }

        public void configurarConexion()
        {
            this.Conex = new Conexion();
            this.Conex.NombreBaseDeDatos = "prueba_portafolio";
            this.Conex.CadenaConexion = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=prueba_portafolio;Integrated Security=True";
        }

        public DataSet consultaFacturasPendientes()
        {
            this.configurarConexion();
            this.Conex.NombreTabla = "detalle_factura";
            this.Conex.CadenaSQL = "select razon_social as 'Razon Social', estado,monto_total as 'Monto a pagar', fecha_emision as 'Fecha emision', fecha_vencimiento as 'Fecha vencimiento', descripcion, monto as 'Monto a pagado' from detalle_factura df join factura f on df.id = f.id join contrato c on df.contrato_id = c.id join cliente on c.cliente_id = cliente.id where f.fecha_pago IS NULL";
            this.Conex.EsSelect = true;
            this.Conex.conectar();
            return this.Conex.DbDataSet;
        }

        public void GenerarReporte(DataSet data, string tittle)
        {
            
            SaveFileDialog saveDialog = new SaveFileDialog();

            // Set the filter for the file extension
            saveDialog.Filter = "PDF files (*.pdf)|*.pdf";

            // Show the file selection dialog
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                
                var  writer = new PdfWriter(saveDialog.FileName);
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);
                Paragraph header = new Paragraph(tittle)
                   .SetTextAlignment(TextAlignment.CENTER)
                   .SetFontSize(20);
                //############
                var table = new Table(data.Tables[0].Columns.Count);

                foreach (DataColumn column in data.Tables[0].Columns)
                {
                    table.AddCell(new Cell().Add(new Paragraph(column.ColumnName))).SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
                }
                foreach (DataRow row in data.Tables[0].Rows)
                {
                    foreach (DataColumn column in data.Tables[0].Columns)
                    {
                        table.AddCell(new Cell().Add(new Paragraph(row[column].ToString()))).SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
                    }
                }
                document.Add(header);
                // Line separator
                var currentDate = DateTime.Now;
                
                Paragraph subheader = new Paragraph("Fecha :" + currentDate.ToString("dd-MM-yyyy"))
                   .SetTextAlignment(TextAlignment.RIGHT)
                   .SetFontSize(10);

                Paragraph subheader2 = new Paragraph(" ")
                    .SetFontSize(10);

                document.Add(subheader);
                LineSeparator ls = new LineSeparator(new SolidLine());
                document.Add(ls);

                document.Add(subheader2);  

                document.Add(table);
                //############

                document.Close();
            }
        }
    }
}
