using Mayorista.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
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
            
            string consultaSQL = "select c.id_cliente, c.nombre, c.apellido, c.telefono from clientes c";
            if (!string.IsNullOrEmpty(filtro))
            {
                consultaSQL += " where c.nombre + ' ' + c.apellido like '%" + filtro + "%'";
            }
            DataTable tabla = db.ConsultarTabla(consultaSQL);
            foreach (DataRow fila in tabla.Rows)
            {
                Cliente oCliente = new Cliente();
                oCliente.Id_cliente = (int)fila[0];
                oCliente.Id_tipo_documento = (int)fila[1];
                oCliente.Nro_documento = (string)fila[2];
                oCliente.Nombre = (string)fila[3];
                oCliente.Apellido = (string)fila[4];
                oCliente.Email = (string)fila[5];
                oCliente.Telefono = (string)fila[6];
                listaClientes.Add(oCliente);
            }
            return listaClientes;
        }

        internal List<DireccionCliente> RecuperarDomicilios(string filtro)
        {
            List<DireccionCliente> listaDomicilios = new List<DireccionCliente>();
            string consultaSQL = "select d.* from direcciones_clientes d";
            if (!string.IsNullOrEmpty(filtro))
            {
                consultaSQL += "from domicilios d join clientes c on d.id_cliente = c.id_cliente where c.nombre + ' ' + c.apellido like '%" + filtro + "%'";
            }
            DataTable tabla = db.ConsultarTabla(consultaSQL);
            foreach (DataRow fila in tabla.Rows)
            {
                DireccionCliente oDomicilio = new DireccionCliente();
                oDomicilio.Id_direccion_cliente = (int)fila[0];
                oDomicilio.Id_cliente = (int)fila[1];
                oDomicilio.Id_barrio = (int)fila[2];
                oDomicilio.Direccion = (string)fila[3];
                oDomicilio.Codigo_postal = (string)fila[4];
                listaDomicilios.Add(oDomicilio);
            }
            return listaDomicilios;
        }
    }
}
