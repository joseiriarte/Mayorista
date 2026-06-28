using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayorista.Negocio
{
    public class Barrio
    {
        public int IdBarrio { get; set; }

        public int IdLocalidad { get; set; }

        public string NombreBarrio { get; set; }

        public override string ToString()
        {
            return NombreBarrio;
        }
    }
}
