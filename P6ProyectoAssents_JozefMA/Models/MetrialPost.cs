using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6ProyectoAssents_JozefMA.Models
{
    public class MetrialPost
    {

        public int CodigoMateria { get; set; }

        public string NombreMateria { get; set; } = null!;

        public string Descripcion { get; set; } = null!;

        public string? Nota { get; set; }

    }
}
