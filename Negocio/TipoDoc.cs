using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayorista.Negocio
{
    public class TipoDoc
    {
        public int Id_tipo_documento { get; set; }

        public string Tipo_documento { get; set; }

        public override string ToString()
        {
            return Tipo_documento;
        }
    }
}
