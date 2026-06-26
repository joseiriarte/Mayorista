using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayorista.Negocio
{
    internal class FacturaConsulta
    {
        public int NroFactura { get; internal set; }
        public string FechaFactura { get; internal set; }
        public decimal Importe { get; internal set; }
        public string FormaPago { get; internal set; }
    }
}
