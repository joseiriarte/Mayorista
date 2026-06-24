using Mayorista.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayorista.Datos
{
    internal class MayoristaDao
    {
        AccesoDatos db;
        public MayoristaDao()
        {
            db = new AccesoDatos();
        }

        internal List<Cliente> RecuperarClientes(string filtro)
        {
            List<Cliente> listaClientes = new List<Cliente>();

            string consulta = @"select c.id_cliente, c.nombre, c.apellido from clientes c";
            if (!string.IsNullOrEmpty(filtro))
                consulta += " where c.nombre + ' ' + c.apellido like '%' + @filtro + '%'";


        }
    }
}
