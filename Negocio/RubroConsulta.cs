using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayorista.Negocio
{
    internal class RubroConsulta
    {
        public string Rubro { get; internal set; }
        public int CantidadArticulosVendidos { get; internal set; }
        public decimal ImporteTotalFacturado { get; internal set; }
    }
}
