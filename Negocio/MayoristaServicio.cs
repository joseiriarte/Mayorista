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

        internal Cliente TraerClientePorId(int id)
        {
            return dao.RecuperarClientePorId(id);
        }

        internal List<DireccionCliente> TraerDomicilios(int id)
        {
            return dao.RecuperarDomicilios(id);
        }

        internal List<ClienteConsulta> TraerConsulta1()
        {
            return dao.RecuperarConsulta1();
        }

        internal List<FacturaConsulta> TraerConsulta2()
        {
            return dao.RecuperarConsulta2();
        }

        internal List<RubroConsulta> TraerConsulta3()
        {
            return dao.RecuperarConsulta3();
        }

        internal List<ClienteConsulta> TraerConsulta4()
        {
            return dao.RecuperarConsulta4();
        }
        internal object TraerTiposDoc()
        {
            return dao.RecuperarTiposDoc();
        }

        internal bool GuardarCliente(Cliente c)
        {
            return dao.CrearCliente(c);
        }

        internal object TraerBarrios()
        {
            return dao.RecuperarBarrios();
        }

        internal bool GuardarDomicilio(DireccionCliente d)
        {
            return dao.CrearDomicilio(d);
        }
    }
}
