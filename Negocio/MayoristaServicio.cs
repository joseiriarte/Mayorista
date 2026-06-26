using Mayorista.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayorista.Negocio
{
    internal class MayoristaServicio
    {
        MayoristaDao dao;
        public MayoristaServicio()
        {
            dao = new MayoristaDao();
        }

        internal List<Cliente> TraerClientes(string filtro)
        {
            return dao.RecuperarClientes(filtro);
        }

        internal List<DireccionCliente> TraerDomicilios(int id)
        {
            return dao.RecuperarDomicilios(id);
        }

        internal List<Cliente> TraerConsulta1()
        {
            return dao.RecuperarConsulta1();
        }

        internal object TraerTiposDoc()
        {
            return dao.RecuperarTiposDoc();
        }

        internal bool GuardarCliente(Cliente c)
        {
            return dao.CrearCliente(c);
        }
    }
}
