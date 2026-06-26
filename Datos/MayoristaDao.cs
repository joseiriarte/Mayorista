using Mayorista.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mayorista.Datos
{
    internal class MayoristaDao
    {
        AccesoDatos db;
        public MayoristaDao()
        {
            db = new AccesoDatos();
        }

        internal bool CrearCliente(Cliente c)
        {
            string consulta = "insert into clientes (id_tipo_documento, nro_documento, nombre, apellido, email, telefono) values (@idTipoDocumento, @nroDocumento, @nombre, @apellido, @email, @telefono)";
            List<Parametro> lista = new List<Parametro>();
            lista.Add(new Parametro("@idTipoDocumento", c.Id_tipo_documento.Id_tipo_documento));
            lista.Add(new Parametro("@nroDocumento", c.Nro_documento));
            lista.Add(new Parametro("@nombre", c.Nombre));
            lista.Add(new Parametro("@apellido", c.Apellido));
            lista.Add(new Parametro("@email", c.Email));
            lista.Add(new Parametro("@telefono", c.Telefono));

            return db.ActualizarBD(consulta, lista) > 0;
        }

        internal bool CrearDomicilio(DireccionCliente d)
        {
            string consulta = "insert into direcciones_clientes (id_cliente, id_barrio, direccion, codigo_postal) values (@idCliente, @idBarrio, @direccion, @codigoPostal)";
            List<Parametro> lista = new List<Parametro>();
            lista.Add(new Parametro("@idCliente", d.Id_cliente));
            lista.Add(new Parametro("@idBarrio", d.Id_barrio.Id_barrio));
            lista.Add(new Parametro("@direccion", d.Direccion));
            lista.Add(new Parametro("@codigoPostal", d.Codigo_postal));

            return db.ActualizarBD(consulta, lista) > 0;
        }

        internal object RecuperarBarrios()
        {
            List<Barrio> listaBarrios = new List<Barrio>();

            DataTable dt = db.ConsultarTabla("barrios");
            foreach (DataRow dr in dt.Rows)
            {
                Barrio b = new Barrio();
                b.Id_barrio = (int)dr[0];
                b.Id_localidad = (int)dr[1];
                b.Nombre_barrio = (string)dr[2];

                listaBarrios.Add(b);
            }
            return listaBarrios;
        }

        internal List<Cliente> RecuperarClientes(string filtro)
        {
            List<Cliente> listaClientes = new List<Cliente>();
            
            string consultaSQL = "select * from clientes c";

            if (!string.IsNullOrEmpty(filtro))
            {
                consultaSQL += " where c.nombre + ' ' + c.apellido like '%" + filtro + "%'";
            }
            DataTable tabla = db.ConsultarBD(consultaSQL);
            foreach (DataRow fila in tabla.Rows)
            {
                Cliente c = new Cliente();
                c.Id_cliente = (int)fila[0];
                c.Id_tipo_documento = new TipoDoc();
                c.Id_tipo_documento.Id_tipo_documento = (int)fila[1];
                c.Nro_documento = (string)fila[2];
                c.Nombre = (string)fila[3];
                c.Apellido = (string)fila[4];
                c.Email = (string)fila[5];
                c.Telefono = (string)fila[6];
                listaClientes.Add(c);
            }
            return listaClientes;
        }

        internal Cliente RecuperarClientePorId(int id)
        {
            Cliente c = null;

            string consultaSQL = "select * from clientes c where c.id_cliente = " + id;

            DataTable dt = db.ConsultarBD(consultaSQL);

            if(dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];

                c = new Cliente();
                c.Id_cliente = (int)dr[0];
                c.Id_tipo_documento = new TipoDoc();
                c.Id_tipo_documento.Id_tipo_documento = (int)dr[1];
                c.Nro_documento = (string)dr[2];
                c.Nombre = (string)dr[3];
                c.Apellido = (string)dr[4];
                c.Email = (string)dr[5];
                c.Telefono = (string)dr[6];
                
            }
            return c;
        }

        internal List<Cliente> RecuperarConsulta1()
        {
            List <Cliente> listaCliente1 = new List<Cliente>();
            string consultaSQL = "select nombre from clientes c join facturas f on c.id_cliente= f.id_cliente join detalles_facturas d on d.nro_factura = f.nro_factura where apellido like '%ez' or nombre like '[d-m]%' group by c.id_cliente, apellido, nombre order by apellido, nombre";
            DataTable tabla = db.ConsultarTabla(consultaSQL);
            foreach(DataRow fila in tabla.Rows)
            {
                Cliente oCliente1 = new Cliente();
                oCliente1.Nombre = (string)fila[0];
                listaCliente1.Add(oCliente1);
            }
            return listaCliente1;
        }

        internal List<DireccionCliente> RecuperarDomicilios(int id)
        {
            List<DireccionCliente> listaDomicilios = new List<DireccionCliente>();
            string consultaSQL = "select * from direcciones_clientes where id_cliente = " + id;
            
            DataTable tabla = db.ConsultarBD(consultaSQL);
            foreach (DataRow fila in tabla.Rows)
            {
                DireccionCliente oDomicilio = new DireccionCliente();
                oDomicilio.Id_direccion_cliente = (int)fila[0];
                oDomicilio.Id_cliente = (int)fila[1];
                oDomicilio.Id_barrio = new Barrio();
                oDomicilio.Id_barrio.Id_barrio = (int)fila[2];
                oDomicilio.Direccion = (string)fila[3];
                oDomicilio.Codigo_postal = (string)fila[4];
                listaDomicilios.Add(oDomicilio);
            }
            return listaDomicilios;
        }

        internal object RecuperarTiposDoc()
        {
            List<TipoDoc> listaTiposDoc = new List<TipoDoc>();

            DataTable dt = db.ConsultarTabla("tipos_documentos");
            foreach (DataRow dr in dt.Rows)
            {
                TipoDoc t = new TipoDoc();
                t.Id_tipo_documento = (int)dr[0];
                t.Tipo_documento = (string)dr[1];

                listaTiposDoc.Add(t);
            }
            return listaTiposDoc;
        }
    }
}
