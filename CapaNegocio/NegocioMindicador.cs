using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class NegocioMindicador
    {
        public double consultaMindicador()
        {
            try
            {
                string sURL;
                sURL = "https://mindicador.cl/api/uf/" + DateTime.Today.ToString("MM-dd-yyyy");//30-11-2022";
                //Console.WriteLine(sURL);
                WebRequest wrGETURL;
                wrGETURL = WebRequest.Create(sURL);
                WebProxy myProxy = new WebProxy("myproxy", 80);
                myProxy.BypassProxyOnLocal = true;
                wrGETURL.Proxy = WebProxy.GetDefaultProxy();
                Stream objStream;
                objStream = wrGETURL.GetResponse().GetResponseStream();
                StreamReader objReader = new StreamReader(objStream);
                string sLine = "";
                sLine = objReader.ReadLine();
                //Console.WriteLine(sLine);
                dynamic jsonObj = JsonConvert.DeserializeObject(sLine);
                //Console.WriteLine(jsonObj);
                var numero = jsonObj["serie"][0]["valor"];
                

                // Obtengo el directorio actual
                string path = Directory.GetCurrentDirectory();
                // Creo el fichero uf.txt y guardo mi variable
                using (StreamWriter outputFile = new StreamWriter(path + "\\uf.txt"))
                {
                    outputFile.WriteLine(numero);
                }
                return numero;
            }
            catch (Exception error)
            {
                double numero = 99999;//34863.92;
                string path = Directory.GetCurrentDirectory();
                foreach (string line in System.IO.File.ReadLines(path + "\\uf.txt"))
                {
                    numero = Convert.ToDouble(line);                
                }               
                MessageBox.Show("Error en la respuesta de la api mindicador, procediendo con el ultimo valor UF guardado " + numero, "Mensaje Sistema");
                return numero;

            }
        }
    }
}
