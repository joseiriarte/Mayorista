using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayorista.Negocio
{
    public class DireccionCliente
    {
        private int idDireccionCliente;
        private int idCliente;
        private Barrio barrio;
        private string direccion;
        private string codigoPostal;

        public int IdDireccionCliente { get; set; }
        public int IdCliente { get; set; }

        public Barrio Barrio { get; set; }

        public string Direccion { get; set; }

        public string CodigoPostal { get; set; }
    }
}