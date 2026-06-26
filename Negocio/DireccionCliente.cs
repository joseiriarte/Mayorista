using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayorista.Negocio
{
    public class DireccionCliente
    {
        private int id_direccion_cliente;
        private int id_cliente;
        private Barrio id_barrio;
        private string direccion;
        private string codigo_postal;

        public int Id_direccion_cliente { get; set; }
        public int Id_cliente { get; set; }

        public Barrio Id_barrio { get; set; }

        public string Direccion { get; set; }

        public string Codigo_postal { get; set; }
    }
}