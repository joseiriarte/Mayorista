using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayorista.Negocio
{
    public class TipoDoc
    {
        public int IdTipoDocumento { get; set; }

        public string TipoDocumento { get; set; }

        public override string ToString()
        {
            return TipoDocumento;
        }
    }
}
