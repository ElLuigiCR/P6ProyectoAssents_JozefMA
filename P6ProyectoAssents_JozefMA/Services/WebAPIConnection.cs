using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6ProyectoAssents_JozefMA.Services
{
    internal class WebAPIConnection
    {

        public static string ProductionURLPrefix = "https://192.168.0.2:45456/swagger/index.html";

        public static string TestingURLPrefix = "https://192.168.0.2:45456/swagger/index.html";

        //además de la raíz de URL acá vamos a indicar cuál es la API Key que deberíamos 
        //usar para consumir los endpoints 
        public static string ApiKeyName = "P6ApiKey";
        public static string ApiKeyValue = "JozefMP6Apik123454321abc";

        public static string MimeType = "application/json";
        public static string ContentType = "Content-Type";

    }
}
