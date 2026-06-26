using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayorista.Negocio
{
    public class Barrio
    {
        public int Id_barrio { get; set; }

        public int Id_localidad { get; set; }

        public string Nombre_barrio { get; set; }

        public override string ToString()
        {
            return Nombre_barrio;
        }
    }
}
