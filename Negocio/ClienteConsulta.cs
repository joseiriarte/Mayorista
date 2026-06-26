using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayorista.Negocio
{
    internal class ClienteConsulta
    {
        public string Nombre { get; internal set; }
        public string Apellido { get; internal set; }
        public decimal TotalCompras { get; internal set; }
        public decimal PromedioCompras { get; internal set; }
        public int CantidadCompras { get; internal set; }
        public string Barrio { get; internal set; }
    }
}
